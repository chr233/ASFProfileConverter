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
            groupBox1 = new GroupBox();
            btnMaFolder = new Button();
            btnConvert = new Button();
            groupBox2 = new GroupBox();
            txtBotAccoutns = new TextBox();
            groupBox3 = new GroupBox();
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
            groupBox5 = new GroupBox();
            picDonate = new PictureBox();
            groupBox6 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            sS.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDonate).BeginInit();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // txtMaFolder
            // 
            txtMaFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMaFolder.Location = new Point(6, 22);
            txtMaFolder.Name = "txtMaFolder";
            txtMaFolder.PlaceholderText = "包含maFile文件的目录";
            txtMaFolder.Size = new Size(416, 23);
            txtMaFolder.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnMaFolder);
            groupBox1.Controls.Add(txtMaFolder);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(509, 55);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "令牌文件目录";
            // 
            // btnMaFolder
            // 
            btnMaFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaFolder.Location = new Point(428, 22);
            btnMaFolder.Name = "btnMaFolder";
            btnMaFolder.Size = new Size(75, 23);
            btnMaFolder.TabIndex = 1;
            btnMaFolder.Text = "…";
            btnMaFolder.UseVisualStyleBackColor = true;
            btnMaFolder.Click += btnMaFolder_Click;
            // 
            // btnConvert
            // 
            btnConvert.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConvert.Location = new Point(534, 159);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(148, 34);
            btnConvert.TabIndex = 2;
            btnConvert.Text = "生成机器人配置";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(txtBotAccoutns);
            groupBox2.Location = new Point(12, 198);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(670, 309);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "机器人账号密码信息，一行一个，支持中英文逗号或者空格分隔";
            // 
            // txtBotAccoutns
            // 
            txtBotAccoutns.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBotAccoutns.Location = new Point(6, 22);
            txtBotAccoutns.Multiline = true;
            txtBotAccoutns.Name = "txtBotAccoutns";
            txtBotAccoutns.PlaceholderText = "登录名 , 密码";
            txtBotAccoutns.ScrollBars = ScrollBars.Vertical;
            txtBotAccoutns.Size = new Size(655, 281);
            txtBotAccoutns.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(btnASFFolder);
            groupBox3.Controls.Add(txtASFFolder);
            groupBox3.Location = new Point(12, 73);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(509, 58);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "输出文件目录";
            // 
            // btnASFFolder
            // 
            btnASFFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnASFFolder.Location = new Point(428, 22);
            btnASFFolder.Name = "btnASFFolder";
            btnASFFolder.Size = new Size(75, 23);
            btnASFFolder.TabIndex = 1;
            btnASFFolder.Text = "…";
            btnASFFolder.UseVisualStyleBackColor = true;
            btnASFFolder.Click += btnASFFolder_Click;
            // 
            // txtASFFolder
            // 
            txtASFFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtASFFolder.Location = new Point(6, 22);
            txtASFFolder.Name = "txtASFFolder";
            txtASFFolder.PlaceholderText = "保存ASF机器人配置文件或者表格文件的目录";
            txtASFFolder.Size = new Size(416, 23);
            txtASFFolder.TabIndex = 0;
            // 
            // btnToForm
            // 
            btnToForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnToForm.Location = new Point(534, 21);
            btnToForm.Name = "btnToForm";
            btnToForm.Size = new Size(148, 36);
            btnToForm.TabIndex = 2;
            btnToForm.Text = "生成账密表格";
            btnToForm.UseVisualStyleBackColor = true;
            btnToForm.Click += btnToForm_Click;
            // 
            // sS
            // 
            sS.Items.AddRange(new ToolStripItem[] { tsAuthor, tsGithub, tsVersion });
            sS.Location = new Point(0, 677);
            sS.Name = "sS";
            sS.Size = new Size(694, 22);
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
            tsGithub.Size = new Size(583, 17);
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
            groupBox4.Location = new Point(12, 513);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(670, 161);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "ASF机器人配置模板 ($$LOGIN$$ 和 $$PASSWD$$ 将会被自动替换成账号和密码)";
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Right;
            btnReset.Location = new Point(544, 0);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(120, 23);
            btnReset.TabIndex = 1;
            btnReset.Text = "重设为默认模板";
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
            txtBotModel.Size = new Size(658, 133);
            txtBotModel.TabIndex = 0;
            // 
            // rbLower
            // 
            rbLower.AutoSize = true;
            rbLower.Location = new Point(6, 22);
            rbLower.Name = "rbLower";
            rbLower.Size = new Size(86, 21);
            rbLower.TabIndex = 7;
            rbLower.Text = "转换成小写";
            rbLower.UseVisualStyleBackColor = true;
            // 
            // rbUpper
            // 
            rbUpper.AutoSize = true;
            rbUpper.Location = new Point(98, 22);
            rbUpper.Name = "rbUpper";
            rbUpper.Size = new Size(86, 21);
            rbUpper.TabIndex = 8;
            rbUpper.Text = "转换成大写";
            rbUpper.UseVisualStyleBackColor = true;
            // 
            // rbAccount
            // 
            rbAccount.AutoSize = true;
            rbAccount.Checked = true;
            rbAccount.Location = new Point(190, 22);
            rbAccount.Name = "rbAccount";
            rbAccount.Size = new Size(134, 21);
            rbAccount.TabIndex = 9;
            rbAccount.TabStop = true;
            rbAccount.Text = "遵循输入的账号格式";
            rbAccount.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox5.Controls.Add(rbAccount);
            groupBox5.Controls.Add(rbLower);
            groupBox5.Controls.Add(rbUpper);
            groupBox5.Location = new Point(12, 137);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(509, 55);
            groupBox5.TabIndex = 10;
            groupBox5.TabStop = false;
            groupBox5.Text = "ASF机器人命名格式";
            // 
            // picDonate
            // 
            picDonate.Cursor = Cursors.Hand;
            picDonate.Dock = DockStyle.Fill;
            picDonate.Image = Properties.Resources.donate;
            picDonate.Location = new Point(3, 19);
            picDonate.Name = "picDonate";
            picDonate.Size = new Size(142, 68);
            picDonate.SizeMode = PictureBoxSizeMode.Zoom;
            picDonate.TabIndex = 11;
            picDonate.TabStop = false;
            picDonate.Click += picDonate_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(picDonate);
            groupBox6.Location = new Point(534, 63);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(148, 90);
            groupBox6.TabIndex = 12;
            groupBox6.TabStop = false;
            groupBox6.Text = "赞助";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 699);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(sS);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnToForm);
            Controls.Add(btnConvert);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            Text = "SDA令牌ASF配置文件批量转换 - By Chr_ 2023";
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            sS.ResumeLayout(false);
            sS.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picDonate).EndInit();
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaFolder;
        private GroupBox groupBox1;
        private Button btnMaFolder;
        private Button btnConvert;
        private GroupBox groupBox2;
        private TextBox txtBotAccoutns;
        private GroupBox groupBox3;
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
        private GroupBox groupBox5;
        private PictureBox picDonate;
        private GroupBox groupBox6;
    }
}
