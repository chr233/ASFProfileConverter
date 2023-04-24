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
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // txtMaFolder
            // 
            txtMaFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMaFolder.Location = new Point(6, 22);
            txtMaFolder.Name = "txtMaFolder";
            txtMaFolder.PlaceholderText = "包含maFile文件的目录";
            txtMaFolder.Size = new Size(296, 23);
            txtMaFolder.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnMaFolder);
            groupBox1.Controls.Add(txtMaFolder);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(389, 55);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "令牌文件目录";
            // 
            // btnMaFolder
            // 
            btnMaFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaFolder.Location = new Point(308, 22);
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
            btnConvert.Location = new Point(414, 83);
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
            groupBox2.Size = new Size(550, 433);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "机器人账号 密码 一行一个";
            // 
            // txtBotAccoutns
            // 
            txtBotAccoutns.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBotAccoutns.Location = new Point(6, 22);
            txtBotAccoutns.Multiline = true;
            txtBotAccoutns.Name = "txtBotAccoutns";
            txtBotAccoutns.ScrollBars = ScrollBars.Vertical;
            txtBotAccoutns.Size = new Size(535, 405);
            txtBotAccoutns.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(btnASFFolder);
            groupBox3.Controls.Add(txtASFFolder);
            groupBox3.Location = new Point(12, 73);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(389, 58);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "输出文件目录";
            // 
            // btnASFFolder
            // 
            btnASFFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnASFFolder.Location = new Point(308, 22);
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
            txtASFFolder.Size = new Size(296, 23);
            txtASFFolder.TabIndex = 0;
            // 
            // btnToForm
            // 
            btnToForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnToForm.Location = new Point(414, 21);
            btnToForm.Name = "btnToForm";
            btnToForm.Size = new Size(148, 46);
            btnToForm.TabIndex = 2;
            btnToForm.Text = "生成账密表格";
            btnToForm.UseVisualStyleBackColor = true;
            btnToForm.Click += btnToForm_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 582);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnToForm);
            Controls.Add(btnConvert);
            Controls.Add(groupBox1);
            Name = "FrmMain";
            Text = "ASF配置文件批量生成 - By Chr_ 2023";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
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
    }
}
