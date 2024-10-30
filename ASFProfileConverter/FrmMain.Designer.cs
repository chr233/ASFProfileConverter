namespace ASFProfileConverter
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            txtMaFolder = new TextBox();
            btnMaFolder = new Button();
            btnConvert = new Button();
            groupBox2 = new GroupBox();
            txtBotAccoutns = new TextBox();
            btnASFFolder = new Button();
            txtASFFolder = new TextBox();
            btnToForm = new Button();
            sS = new StatusStrip();
            tsAuthor = new ToolStripStatusLabel();
            tsGithub = new ToolStripStatusLabel();
            tsVersion = new ToolStripStatusLabel();
            groupBox4 = new GroupBox();
            btnReset = new Button();
            txtBotModel = new TextBox();
            rbLower = new RadioButton();
            rbUpper = new RadioButton();
            rbAccount = new RadioButton();
            picDonate = new PictureBox();
            groupBox6 = new GroupBox();
            btnFixMaFile = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            groupBox2.SuspendLayout();
            sS.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDonate).BeginInit();
            groupBox6.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtMaFolder
            // 
            txtMaFolder.AllowDrop = true;
            txtMaFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMaFolder.Location = new Point(148, 12);
            txtMaFolder.Name = "txtMaFolder";
            txtMaFolder.PlaceholderText = "包含maFile文件的目录";
            txtMaFolder.Size = new Size(407, 23);
            txtMaFolder.TabIndex = 0;
            txtMaFolder.DragDrop += common_DragDrop;
            txtMaFolder.DragEnter += common_DragEnter;
            // 
            // btnMaFolder
            // 
            btnMaFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaFolder.Location = new Point(561, 12);
            btnMaFolder.Name = "btnMaFolder";
            btnMaFolder.Size = new Size(48, 23);
            btnMaFolder.TabIndex = 1;
            btnMaFolder.Text = "…";
            btnMaFolder.UseVisualStyleBackColor = true;
            btnMaFolder.Click += btnMaFolder_Click;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(12, 101);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(148, 36);
            btnConvert.TabIndex = 7;
            btnConvert.Text = "&G. 生成机器人配置";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(txtBotAccoutns);
            groupBox2.Location = new Point(12, 143);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(751, 178);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "&4. 机器人账号密码信息，一行一个，支持中英文逗号或者空格分隔";
            // 
            // txtBotAccoutns
            // 
            txtBotAccoutns.AllowDrop = true;
            txtBotAccoutns.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBotAccoutns.Location = new Point(6, 22);
            txtBotAccoutns.Multiline = true;
            txtBotAccoutns.Name = "txtBotAccoutns";
            txtBotAccoutns.PlaceholderText = "登录名 , 密码";
            txtBotAccoutns.ScrollBars = ScrollBars.Vertical;
            txtBotAccoutns.Size = new Size(736, 150);
            txtBotAccoutns.TabIndex = 10;
            txtBotAccoutns.DragDrop += common_DragDrop;
            txtBotAccoutns.DragEnter += common_DragEnter;
            // 
            // btnASFFolder
            // 
            btnASFFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnASFFolder.Location = new Point(561, 41);
            btnASFFolder.Name = "btnASFFolder";
            btnASFFolder.Size = new Size(48, 23);
            btnASFFolder.TabIndex = 3;
            btnASFFolder.Text = "…";
            btnASFFolder.UseVisualStyleBackColor = true;
            btnASFFolder.Click += btnASFFolder_Click;
            // 
            // txtASFFolder
            // 
            txtASFFolder.AllowDrop = true;
            txtASFFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtASFFolder.Location = new Point(148, 41);
            txtASFFolder.Name = "txtASFFolder";
            txtASFFolder.PlaceholderText = "保存ASF机器人配置文件或者表格文件的目录";
            txtASFFolder.Size = new Size(407, 23);
            txtASFFolder.TabIndex = 2;
            txtASFFolder.DragDrop += common_DragDrop;
            txtASFFolder.DragEnter += common_DragEnter;
            // 
            // btnToForm
            // 
            btnToForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnToForm.Location = new Point(461, 101);
            btnToForm.Name = "btnToForm";
            btnToForm.Size = new Size(148, 36);
            btnToForm.TabIndex = 9;
            btnToForm.Text = "&T. 生成账密表格";
            btnToForm.UseVisualStyleBackColor = true;
            btnToForm.Click += btnToForm_Click;
            // 
            // sS
            // 
            sS.Items.AddRange(new ToolStripItem[] { tsAuthor, tsGithub, tsVersion });
            sS.Location = new Point(0, 491);
            sS.Name = "sS";
            sS.Size = new Size(775, 22);
            sS.TabIndex = 5;
            sS.Text = "statusStrip1";
            // 
            // tsAuthor
            // 
            tsAuthor.IsLink = true;
            tsAuthor.LinkBehavior = LinkBehavior.HoverUnderline;
            tsAuthor.LinkColor = Color.Black;
            tsAuthor.Name = "tsAuthor";
            tsAuthor.Size = new Size(64, 17);
            tsAuthor.Text = "作者: Chr_";
            tsAuthor.VisitedLinkColor = Color.Black;
            tsAuthor.Click += tsAuthor_Click;
            // 
            // tsGithub
            // 
            tsGithub.IsLink = true;
            tsGithub.LinkBehavior = LinkBehavior.HoverUnderline;
            tsGithub.LinkColor = Color.Black;
            tsGithub.Name = "tsGithub";
            tsGithub.Size = new Size(664, 17);
            tsGithub.Spring = true;
            tsGithub.Text = "获取源码";
            tsGithub.VisitedLinkColor = Color.Black;
            tsGithub.Click += tsGithub_Click;
            // 
            // tsVersion
            // 
            tsVersion.IsLink = true;
            tsVersion.LinkBehavior = LinkBehavior.HoverUnderline;
            tsVersion.LinkColor = Color.Black;
            tsVersion.Name = "tsVersion";
            tsVersion.Size = new Size(32, 17);
            tsVersion.Text = "版本";
            tsVersion.VisitedLinkColor = Color.Black;
            tsVersion.Click += tsVersion_Click;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(btnReset);
            groupBox4.Controls.Add(txtBotModel);
            groupBox4.Location = new Point(12, 327);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(751, 161);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "&5. ASF机器人配置模板 ($$LOGIN$$ 和 $$PASSWD$$ 将会被自动替换成账号和密码)";
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Right;
            btnReset.Location = new Point(596, 0);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(149, 23);
            btnReset.TabIndex = 12;
            btnReset.Text = "&R. 重设为默认模板";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // txtBotModel
            // 
            txtBotModel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBotModel.Location = new Point(6, 22);
            txtBotModel.Multiline = true;
            txtBotModel.Name = "txtBotModel";
            txtBotModel.PlaceholderText = "{ }";
            txtBotModel.ScrollBars = ScrollBars.Vertical;
            txtBotModel.Size = new Size(739, 133);
            txtBotModel.TabIndex = 11;
            // 
            // rbLower
            // 
            rbLower.AutoSize = true;
            rbLower.Location = new Point(0, 0);
            rbLower.Name = "rbLower";
            rbLower.Size = new Size(86, 21);
            rbLower.TabIndex = 4;
            rbLower.TabStop = true;
            rbLower.Text = "转换成小写";
            rbLower.UseVisualStyleBackColor = true;
            // 
            // rbUpper
            // 
            rbUpper.AutoSize = true;
            rbUpper.Location = new Point(92, 0);
            rbUpper.Name = "rbUpper";
            rbUpper.Size = new Size(86, 21);
            rbUpper.TabIndex = 5;
            rbUpper.TabStop = true;
            rbUpper.Text = "转换成大写";
            rbUpper.UseVisualStyleBackColor = true;
            // 
            // rbAccount
            // 
            rbAccount.AutoSize = true;
            rbAccount.Checked = true;
            rbAccount.Location = new Point(184, 0);
            rbAccount.Name = "rbAccount";
            rbAccount.Size = new Size(134, 21);
            rbAccount.TabIndex = 6;
            rbAccount.TabStop = true;
            rbAccount.Text = "遵循输入的账号格式";
            rbAccount.UseVisualStyleBackColor = true;
            // 
            // picDonate
            // 
            picDonate.Cursor = Cursors.Hand;
            picDonate.Dock = DockStyle.Fill;
            picDonate.Image = Properties.Resources.donate;
            picDonate.Location = new Point(3, 19);
            picDonate.Name = "picDonate";
            picDonate.Size = new Size(142, 103);
            picDonate.SizeMode = PictureBoxSizeMode.Zoom;
            picDonate.TabIndex = 11;
            picDonate.TabStop = false;
            picDonate.Click += picDonate_Click;
            // 
            // groupBox6
            // 
            groupBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox6.Controls.Add(picDonate);
            groupBox6.Location = new Point(615, 12);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(148, 125);
            groupBox6.TabIndex = 12;
            groupBox6.TabStop = false;
            groupBox6.Text = "赞助 爱发电 @chr233";
            // 
            // btnFixMaFile
            // 
            btnFixMaFile.Location = new Point(166, 101);
            btnFixMaFile.Name = "btnFixMaFile";
            btnFixMaFile.Size = new Size(148, 36);
            btnFixMaFile.TabIndex = 8;
            btnFixMaFile.Text = "&F. 修补令牌";
            btnFixMaFile.UseVisualStyleBackColor = true;
            btnFixMaFile.Click += btnFixMaFile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(130, 17);
            label1.TabIndex = 0;
            label1.Text = "&1. 令牌文件目录 (可选)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(94, 17);
            label2.TabIndex = 2;
            label2.Text = "&2. 输出文件目录";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 74);
            label3.Name = "label3";
            label3.Size = new Size(127, 17);
            label3.TabIndex = 4;
            label3.Text = "&3. ASF机器人命名格式";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(rbAccount);
            panel1.Controls.Add(rbLower);
            panel1.Controls.Add(rbUpper);
            panel1.Location = new Point(148, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(461, 25);
            panel1.TabIndex = 14;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 513);
            Controls.Add(panel1);
            Controls.Add(btnMaFolder);
            Controls.Add(btnASFFolder);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtASFFolder);
            Controls.Add(label1);
            Controls.Add(txtMaFolder);
            Controls.Add(btnFixMaFile);
            Controls.Add(groupBox6);
            Controls.Add(groupBox4);
            Controls.Add(sS);
            Controls.Add(groupBox2);
            Controls.Add(btnToForm);
            Controls.Add(btnConvert);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            Text = "SDA令牌ASF配置文件批量转换 - By Chr_";
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            sS.ResumeLayout(false);
            sS.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picDonate).EndInit();
            groupBox6.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaFolder;
        private Button btnMaFolder;
        private Button btnConvert;
        private GroupBox groupBox2;
        private TextBox txtBotAccoutns;
        private Button btnASFFolder;
        private TextBox txtASFFolder;
        private Button btnToForm;
        private StatusStrip sS;
        private ToolStripStatusLabel tsAuthor;
        private ToolStripStatusLabel tsVersion;
        private ToolStripStatusLabel tsGithub;
        private GroupBox groupBox4;
        private Button btnReset;
        private TextBox txtBotModel;
        private RadioButton rbLower;
        private RadioButton rbUpper;
        private RadioButton rbAccount;
        private PictureBox picDonate;
        private GroupBox groupBox6;
        private Button btnFixMaFile;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
    }
}
