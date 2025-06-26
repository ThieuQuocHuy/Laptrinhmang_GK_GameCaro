using System.Net.NetworkInformation;
using System.Windows.Forms;
// //
namespace Game_Caro
{
    public partial class Form1 : Form
    {
        #region Properties
        ChessBoardManager ChessBoard;
        string PlayerName;
        #endregion
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

            ChessBoard = new ChessBoardManager(pnlChessBeard, txbPlayerName, pctbMark);
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;

            prcbCoolDown.Step = Constant.COOL_DOWN_STEP;
            prcbCoolDown.Maximum = Constant.COOL_DOWN_TIME;
            prcbCoolDown.Value = 0;
            tmCoolDown.Interval = Constant.COOL_DOWN_INTERVAL;

            // //
            txt_Chat.Text = "";

            NewGame();
        }

        #region
        void EndGame()
        {
            pnlChessBeard.Enabled = false;
            undoToolStripMenuItem.Enabled = false;
        }
        void ChessBoard_PlayerMarked(object? sender, ButtonClickEvent e)
        {
            pnlChessBeard.Enabled = false;
            prcbCoolDown.Value = 0;

            // //
            undoToolStripMenuItem.Enabled = false;
            // //
        }

        

        // //

        void NewGame()
        {
            
            undoToolStripMenuItem.Enabled = true;
            ChessBoard.DrawChessBoard();

        }

        // //

        

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
            lbRole.Enabled = false;
            lbRole.Text = "Host";
            lbNameXO.Text = "You are ";
            pctbXO.Image = Image.FromFile(Application.StartupPath + "\\Resources\\X_caro.jpg");
            pctbXO.BackgroundImageLayout = ImageLayout.Stretch;
            pnlChessBeard.Enabled = true;

        }

        // //

        // //

        private void Form1_FormClosed(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("B?n có ch?c mu?n thoát game không?", "Notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
            else
            {
                try
                {
                    //socket.Send(new SocketData((int)SocketComand.QUIT, "", new Point()));//
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        // //

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbIP.Text))
            {
                //txbIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }
        }

        void Listen()
        {

            Thread listenThread = new Thread(() =>
            {
                try
                {
                    //SocketData data = (SocketData)socket.Receive();
                    //ProcessData(data);
                }
                catch (Exception)
                {

                    throw;
                }
            });
            listenThread.IsBackground = true;
            listenThread.Start();


        }

        // //


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
            //PlayerName = ChessBoard.Players[socket.isServer ? 0 : 1].Name;
            txt_Chat.Text += "- " + PlayerName + ": " + txt_Message.Text + "\r\n";

            //socket.Send(new SocketData((int)SocketComand.SEND_MESSAGE, txt_Chat.Text, new Point()));
            Listen();
        }

        private void txt_Message_TextChanged(object sender, EventArgs e)
        {

        }
        // //
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            // //
        }
    }
}