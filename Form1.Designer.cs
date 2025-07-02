namespace Game_Caro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlChessBeard = new Panel();
            panel2 = new Panel();
            pctbAvatar = new PictureBox();
            pctbXO = new PictureBox();
            lbNameXO = new Label();
            lbRole = new Label();
            pctbMark = new PictureBox();
            tmCoolDown = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            thayToolStripMenuItem = new ToolStripMenuItem();
            thayĐổiNhạcNềnToolStripMenuItem = new ToolStripMenuItem();
            txbPlayerName = new TextBox();
            txbIP = new TextBox();
            prcbCoolDown = new ProgressBar();
            btnLan = new Button();
            lbLoading = new Label();
            panel3 = new Panel();
            txt_Chat = new TextBox();
            txt_Message = new TextBox();
            btn_Send = new Button();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctbAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctbXO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctbMark).BeginInit();
            menuStrip1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pnlChessBeard
            // 
            pnlChessBeard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlChessBeard.BackColor = SystemColors.Control;
            pnlChessBeard.Location = new Point(11, 31);
            pnlChessBeard.Name = "pnlChessBeard";
            pnlChessBeard.Size = new Size(743, 541);
            pnlChessBeard.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(pctbAvatar);
            panel2.Controls.Add(pctbXO);
            panel2.Controls.Add(lbNameXO);
            panel2.Controls.Add(lbRole);
            panel2.Location = new Point(869, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(113, 87);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // pctbAvatar
            // 
            pctbAvatar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pctbAvatar.BackgroundImage = (Image)resources.GetObject("pctbAvatar.BackgroundImage");
            pctbAvatar.BackgroundImageLayout = ImageLayout.Stretch;
            pctbAvatar.Location = new Point(-1, 1);
            pctbAvatar.Name = "pctbAvatar";
            pctbAvatar.Size = new Size(113, 87);
            pctbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbAvatar.TabIndex = 0;
            pctbAvatar.TabStop = false;
            pctbAvatar.Click += pctbAvatar_Click;
            // 
            // pctbXO
            // 
            pctbXO.BackColor = SystemColors.ButtonHighlight;
            pctbXO.Location = new Point(65, 89);
            pctbXO.Name = "pctbXO";
            pctbXO.Size = new Size(25, 25);
            pctbXO.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbXO.TabIndex = 4;
            pctbXO.TabStop = false;
            // 
            // lbNameXO
            // 
            lbNameXO.AutoSize = true;
            lbNameXO.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbNameXO.Location = new Point(7, 89);
            lbNameXO.Name = "lbNameXO";
            lbNameXO.Size = new Size(0, 18);
            lbNameXO.TabIndex = 4;
            // 
            // lbRole
            // 
            lbRole.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbRole.AutoSize = true;
            lbRole.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbRole.ForeColor = Color.Crimson;
            lbRole.Location = new Point(21, 1);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(0, 25);
            lbRole.TabIndex = 4;
            // 
            // pctbMark
            // 
            pctbMark.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pctbMark.Location = new Point(777, 29);
            pctbMark.Name = "pctbMark";
            pctbMark.Size = new Size(83, 85);
            pctbMark.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbMark.TabIndex = 2;
            pctbMark.TabStop = false;
            pctbMark.Click += pctbMark_Click;
            // 
            // tmCoolDown
            // 
            tmCoolDown.Tick += tmCoolDown_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, toolStripMenuItem1, thayToolStripMenuItem, thayĐổiNhạcNềnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 1, 0, 1);
            menuStrip1.Size = new Size(986, 26);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, undoToolStripMenuItem, quitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newGameToolStripMenuItem.Size = new Size(224, 26);
            newGameToolStripMenuItem.Text = "New Game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(224, 26);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.E;
            quitToolStripMenuItem.Size = new Size(224, 26);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(14, 24);
            // 
            // thayToolStripMenuItem
            // 
            thayToolStripMenuItem.Name = "thayToolStripMenuItem";
            thayToolStripMenuItem.Size = new Size(140, 24);
            thayToolStripMenuItem.Text = "Thay đổi hình nền";
            thayToolStripMenuItem.Click += thayToolStripMenuItem_Click;
            // 
            // thayĐổiNhạcNềnToolStripMenuItem
            // 
            thayĐổiNhạcNềnToolStripMenuItem.Name = "thayĐổiNhạcNềnToolStripMenuItem";
            thayĐổiNhạcNềnToolStripMenuItem.Size = new Size(120, 24);
            thayĐổiNhạcNềnToolStripMenuItem.Text = "Chọn nhạc nền";
            thayĐổiNhạcNềnToolStripMenuItem.Click += nhacnen;
            // 
            // txbPlayerName
            // 
            txbPlayerName.Location = new Point(11, 3);
            txbPlayerName.Name = "txbPlayerName";
            txbPlayerName.ReadOnly = true;
            txbPlayerName.Size = new Size(185, 27);
            txbPlayerName.TabIndex = 0;
            txbPlayerName.TextChanged += txbPlayerName_TextChanged;
            // 
            // txbIP
            // 
            txbIP.Location = new Point(11, 49);
            txbIP.Name = "txbIP";
            txbIP.Size = new Size(185, 27);
            txbIP.TabIndex = 0;
            txbIP.Text = "127.0.0.1";
            txbIP.TextAlign = HorizontalAlignment.Center;
            // 
            // prcbCoolDown
            // 
            prcbCoolDown.Location = new Point(11, 35);
            prcbCoolDown.Name = "prcbCoolDown";
            prcbCoolDown.Size = new Size(184, 9);
            prcbCoolDown.TabIndex = 1;
            prcbCoolDown.Click += prcbCoolDown_Click;
            // 
            // btnLan
            // 
            btnLan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLan.BackColor = Color.LightSalmon;
            btnLan.FlatStyle = FlatStyle.Popup;
            btnLan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLan.ForeColor = Color.Green;
            btnLan.Location = new Point(14, 81);
            btnLan.Name = "btnLan";
            btnLan.Size = new Size(182, 29);
            btnLan.TabIndex = 3;
            btnLan.Text = "Chơi trực tuyến";
            btnLan.UseVisualStyleBackColor = false;
            btnLan.Click += btnLan_Click;
            // 
            // lbLoading
            // 
            lbLoading.AutoSize = true;
            lbLoading.Location = new Point(355, 49);
            lbLoading.Name = "lbLoading";
            lbLoading.Size = new Size(0, 20);
            lbLoading.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(lbLoading);
            panel3.Controls.Add(btnLan);
            panel3.Controls.Add(prcbCoolDown);
            panel3.Controls.Add(txbIP);
            panel3.Controls.Add(txbPlayerName);
            panel3.Location = new Point(781, 123);
            panel3.Name = "panel3";
            panel3.Size = new Size(203, 125);
            panel3.TabIndex = 0;
            // 
            // txt_Chat
            // 
            txt_Chat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_Chat.BackColor = Color.FromArgb(192, 255, 255);
            txt_Chat.Cursor = Cursors.IBeam;
            txt_Chat.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Chat.Location = new Point(781, 269);
            txt_Chat.Margin = new Padding(2, 3, 2, 3);
            txt_Chat.Multiline = true;
            txt_Chat.Name = "txt_Chat";
            txt_Chat.ReadOnly = true;
            txt_Chat.ScrollBars = ScrollBars.Vertical;
            txt_Chat.Size = new Size(202, 240);
            txt_Chat.TabIndex = 5;
            txt_Chat.Text = "Người A: Hi";
            txt_Chat.TextChanged += txt_Chat_TextChanged;
            // 
            // txt_Message
            // 
            txt_Message.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_Message.Location = new Point(781, 524);
            txt_Message.Margin = new Padding(2, 3, 2, 3);
            txt_Message.Name = "txt_Message";
            txt_Message.Size = new Size(121, 27);
            txt_Message.TabIndex = 4;
            txt_Message.TextChanged += txt_Message_TextChanged;
            // 
            // btn_Send
            // 
            btn_Send.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Send.BackColor = SystemColors.ActiveCaption;
            btn_Send.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Send.Location = new Point(917, 524);
            btn_Send.Margin = new Padding(2, 3, 2, 3);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(70, 27);
            btn_Send.TabIndex = 6;
            btn_Send.Text = "SEND";
            btn_Send.UseVisualStyleBackColor = false;
            btn_Send.Click += btn_Send_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(176, 575);
            label1.Name = "label1";
            label1.Size = new Size(183, 20);
            label1.TabIndex = 7;
            label1.Text = "Đi đủ 5 điểm sẽ thắng nhé\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 599);
            Controls.Add(label1);
            Controls.Add(btn_Send);
            Controls.Add(txt_Message);
            Controls.Add(txt_Chat);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pctbMark);
            Controls.Add(pnlChessBeard);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Game Caro Fun ( Line up 5 )";
            FormClosing += Form1_FormClosed;
            Shown += Form1_Shown;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctbAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctbXO).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctbMark).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlChessBeard;
        private Panel panel2;
        private PictureBox pctbAvatar;
        private PictureBox pctbMark;
        private TextBox textBox2;
        private PictureBox pictureBox2;
        private Label lbRole;
        private System.Windows.Forms.Timer tmCoolDown;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private Label lbNameXO;
        private PictureBox pctbXO;
        private ToolStripMenuItem thayToolStripMenuItem;
        private TextBox txbPlayerName;
        private Button btnLan;
        private ProgressBar prcbCoolDown;
        private TextBox txbIP;
        private Label lbLoading;
        private Panel panel3;
        private TextBox txt_Chat;
        private TextBox txt_Message;
        private Button btn_Send;
        private ToolStripMenuItem thayĐổiNhạcNềnToolStripMenuItem;
        private Label label1;
    }
}