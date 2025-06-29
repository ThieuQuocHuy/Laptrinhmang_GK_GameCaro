using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Media;
namespace Game_Caro
{
    public partial class Form1 : Form
    {
        #region Properties
        ChessBoardManager ChessBoard;
        string PlayerName;
        SocketManager socket;
        #endregion
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

            ChessBoard = new ChessBoardManager(pnlChessBeard, txbPlayerName, pctbMark);
            ChessBoard.EndedGame += ChessBoard_EndedGame;
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;

            prcbCoolDown.Step = Constant.COOL_DOWN_STEP;
            prcbCoolDown.Maximum = Constant.COOL_DOWN_TIME;
            prcbCoolDown.Value = 0;
            tmCoolDown.Interval = Constant.COOL_DOWN_INTERVAL;

            socket = new SocketManager();

            txt_Chat.Text = "";

            NewGame();
        }

        #region
        void EndGame()
        {
            tmCoolDown.Stop();
            pnlChessBeard.Enabled = false;
            undoToolStripMenuItem.Enabled = false;
        }
        void ChessBoard_PlayerMarked(object? sender, ButtonClickEvent e)
        {
            tmCoolDown.Stop();
            pnlChessBeard.Enabled = false;
            prcbCoolDown.Value = 0;

            socket.Send(new SocketData((int)SocketComand.SEND_POINT, "", e.ClickedPoint));
            undoToolStripMenuItem.Enabled = false;
            Listen();
        }

        void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
            socket.Send(new SocketData((int)SocketComand.END_GAME_LOSS, "", new Point()));

        }

        private void tmCoolDown_Tick(object sender, EventArgs e)
        {
            prcbCoolDown.PerformStep();
            if (prcbCoolDown.Value >= prcbCoolDown.Maximum)
            {
                EndGame();
                socket.Send(new SocketData((int)SocketComand.END_GAME_WIN, "", new Point()));
                CustomMessageBox message = new CustomMessageBox("Bạn đã thua!", Color.Green);
                message.ShowDialog();
            }
        }

        void NewGame()
        {
            tmCoolDown.Stop();
            prcbCoolDown.Value = 0;
            undoToolStripMenuItem.Enabled = true;
            ChessBoard.DrawChessBoard();

        }

        void Quit()
        {
            Application.Exit();
        }

        void Undo()
        {
            prcbCoolDown.Value = 0;
            ChessBoard.Undo();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
            lbRole.Enabled = false;
            lbRole.Text = "Host";
            lbNameXO.Text = "You are ";
            pctbXO.Image = Image.FromFile(Application.StartupPath + "\\Resources\\X_caro.jpg");
            pctbXO.BackgroundImageLayout = ImageLayout.Stretch;
            pnlChessBeard.Enabled = true;

            socket.Send(new SocketData((int)SocketComand.NEW_GAME, "", new Point()));
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
            socket.Send(new SocketData((int)SocketComand.UNDO, "", new Point()));
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void Form1_FormClosed(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát game không?", "Notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
            else
            {
                try
                {
                    socket.Send(new SocketData((int)SocketComand.QUIT, "", new Point()));
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void btnLan_Click(object sender, EventArgs e)
        {
            socket.IP = txbIP.Text;
            if (!socket.ConnectServer())
            {
                //prcbCoolDown.Maximum = Constant.COOL_DOWN_TIME1MINUTE;
                //tmCoolDown.Start();
                //lbLoading.Text = "Đang chờ đối thủ";
                socket.isServer = true;
                pnlChessBeard.Enabled = true;
                socket.CreateServer();
                lbRole.Enabled = false;
                lbRole.Text = "Host";
                lbNameXO.Text = "You are ";
                pctbXO.Image = Image.FromFile(Application.StartupPath + "\\Resources\\X_caro.jpg");
                pctbXO.BackgroundImageLayout = ImageLayout.Stretch;
                pnlChessBeard.Enabled = true;

            }
            else
            {
                tmCoolDown.Stop();
                prcbCoolDown.Value = 0;
                socket.isServer = false;
                pnlChessBeard.Enabled = false;
                lbRole.Enabled = false;
                lbRole.Text = "Guest";
                lbNameXO.Text = "You are ";
                pctbXO.Image = Image.FromFile(Application.StartupPath + "\\Resources\\O_caro.jpg");
                pctbXO.BackgroundImageLayout = ImageLayout.Stretch;
                //  socket.Send(new SocketData((int)SocketComand.CONNECT_SUCCESS, "", new Point()));
                Listen();
            }

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            txbIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);
            if (string.IsNullOrEmpty(txbIP.Text))
            {
                txbIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }
        }

        void Listen()
        {

            Thread listenThread = new Thread(() =>
            {
                try
                {
                    SocketData data = (SocketData)socket.Receive();
                    ProcessData(data);
                }
                catch (Exception)
                {

                    throw;
                }
            });
            listenThread.IsBackground = true;
            listenThread.Start();


        }

        private void ProcessData(SocketData data)
        {
            switch (data.Command)
            {
                case (int)SocketComand.NOTIFY:
                    MessageBox.Show(data.Message);
                    break;
                case (int)SocketComand.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NewGame();
                        pnlChessBeard.Enabled = false;
                        lbRole.Enabled = false;
                        lbRole.Text = "Guest";
                        lbNameXO.Text = "You are ";
                        pctbXO.Image = Image.FromFile(Application.StartupPath + "\\Resources\\O_caro.jpg");
                        pctbXO.BackgroundImageLayout = ImageLayout.Stretch;
                    }));
                    break;
                case (int)SocketComand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        prcbCoolDown.Value = 0;
                        pnlChessBeard.Enabled = true;
                        tmCoolDown.Start();
                        undoToolStripMenuItem.Enabled = true;
                        ChessBoard.OtherPlayerMark(data.Point);
                    }));
                    break;
                case (int)SocketComand.UNDO:
                    Undo();
                    prcbCoolDown.Value = 0;
                    break;
                case (int)SocketComand.END_GAME_WIN:
                    prcbCoolDown.Value = 0;
                    if (!socket.isServer) // Chỉ hiện thông báo chiến thắng cho người không phải host
                    {
                        CustomMessageBox message = new CustomMessageBox("Bạn đã trở thành đom đóm!", Color.Blue);
                        message.ShowDialog();
                    }
                    
                    break;
                case (int)SocketComand.END_GAME_LOSS:
                    prcbCoolDown.Value = 0;
                    if (socket.isServer) // Thông báo thắng cho Host
                    {
                        CustomMessageBox message = new CustomMessageBox("Bạn đã trở thành đom đóm!", Color.Blue);
                        message.ShowDialog();
                    }

                    break;
                case (int)SocketComand.TIME_OUT:
                    MessageBox.Show("Hết giờ");
                    break;
                case (int)SocketComand.QUIT:
                    tmCoolDown.Stop();
                    MessageBox.Show("Đối thủ đã thoát");
                    break;
                case (int)SocketComand.SEND_MESSAGE:
                    txt_Chat.Text = data.Message;
                    break;
                case (int)SocketComand.CONNECT_SUCCESS:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        tmCoolDown.Stop();
                        prcbCoolDown.Value = 0;
                        lbLoading.Text = "Kết nối thành công";
                    }));
                    break;

            }
            Listen();
        }
        #endregion


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pctbAvatar_Click(object sender, EventArgs e)
        {

        }

        private void pctbMark_Click(object sender, EventArgs e)
        {

        }

        private void prcbCoolDown_Click(object sender, EventArgs e)
        {

        }

        private void txbPlayerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Define the path to the "images" folder in your project
            string imagesPath = Path.Combine(Application.StartupPath, "images");
            // Open a file dialog that starts in the "images" folder
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = imagesPath;
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select Background Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Set the selected image as the background
                    this.BackgroundImage = Image.FromFile(openFileDialog.FileName);
                    this.BackgroundImageLayout = ImageLayout.Stretch; // Adjust layout as needed
                    pnlChessBeard.BackgroundImage = Image.FromFile(openFileDialog.FileName);
                    pnlChessBeard.BackgroundImageLayout = ImageLayout.Stretch;

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_Chat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            PlayerName = ChessBoard.Players[socket.isServer ? 0 : 1].Name;
            txt_Chat.Text += "- " + PlayerName + ": " + txt_Message.Text + "\r\n";

            socket.Send(new SocketData((int)SocketComand.SEND_MESSAGE, txt_Chat.Text, new Point()));
            Listen();
        }

        private void txt_Message_TextChanged(object sender, EventArgs e)
        {

        }
        private void nhacnen(object sender, EventArgs e)
        {
            // Đường dẫn tới thư mục "amthanh" trong thư mục gốc của ứng dụng
            string musicFolderPath = Path.Combine(Application.StartupPath, "amthanh");

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = musicFolderPath;
                // Sửa filter để hỗ trợ cả wav và mp3
                openFileDialog.Filter = "Audio Files|*.wav;*.mp3";
                openFileDialog.Title = "Select Background Music";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    AudioManager.PlayBackground(openFileDialog.FileName);
                }
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            AudioManager.Dispose();
        }
    }
}