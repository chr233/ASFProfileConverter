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
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            sS.SuspendLayout();
            groupBox4.SuspendLayout();
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
            btnConvert.Location = new Point(534, 83);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(148, 48);
            btnConvert.TabIndex = 2;
            btnConvert.Text = "生成机器人配置";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(txtBotAccoutns);
            groupBox2.Location = new Point(12, 137);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(670, 303);
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
            txtBotAccoutns.Size = new Size(655, 275);
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
            btnToForm.Size = new Size(148, 46);
            btnToForm.TabIndex = 2;
            btnToForm.Text = "生成账密表格";
            btnToForm.UseVisualStyleBackColor = true;
            btnToForm.Click += btnToForm_Click;
            // 
            // sS
            // 
            sS.Items.AddRange(new ToolStripItem[] { tsAuthor, tsGithub, tsVersion });
            sS.Location = new Point(0, 610);
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
            groupBox4.Location = new Point(12, 446);
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
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 632);
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
    }
}
