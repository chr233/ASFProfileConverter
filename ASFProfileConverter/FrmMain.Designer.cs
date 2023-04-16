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
            this.txtMaFolder = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMaFolder = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBotAccoutns = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnASFFolder = new System.Windows.Forms.Button();
            this.txtASFFolder = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMaFolder
            // 
            this.txtMaFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaFolder.Location = new System.Drawing.Point(6, 22);
            this.txtMaFolder.Name = "txtMaFolder";
            this.txtMaFolder.Size = new System.Drawing.Size(296, 23);
            this.txtMaFolder.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnMaFolder);
            this.groupBox1.Controls.Add(this.txtMaFolder);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 55);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "令牌文件夹";
            // 
            // btnMaFolder
            // 
            this.btnMaFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaFolder.Location = new System.Drawing.Point(308, 22);
            this.btnMaFolder.Name = "btnMaFolder";
            this.btnMaFolder.Size = new System.Drawing.Size(75, 23);
            this.btnMaFolder.TabIndex = 1;
            this.btnMaFolder.Text = "…";
            this.btnMaFolder.UseVisualStyleBackColor = true;
            this.btnMaFolder.Click += new System.EventHandler(this.btnMaFolder_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvert.Location = new System.Drawing.Point(414, 34);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(139, 84);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "生成机器人配置";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtBotAccoutns);
            this.groupBox2.Location = new System.Drawing.Point(12, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 433);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "机器人账号 密码 一行一个";
            // 
            // txtBotAccoutns
            // 
            this.txtBotAccoutns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBotAccoutns.Location = new System.Drawing.Point(6, 22);
            this.txtBotAccoutns.Multiline = true;
            this.txtBotAccoutns.Name = "txtBotAccoutns";
            this.txtBotAccoutns.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBotAccoutns.Size = new System.Drawing.Size(535, 405);
            this.txtBotAccoutns.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnASFFolder);
            this.groupBox3.Controls.Add(this.txtASFFolder);
            this.groupBox3.Location = new System.Drawing.Point(12, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 58);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "输出文件夹";
            // 
            // btnASFFolder
            // 
            this.btnASFFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnASFFolder.Location = new System.Drawing.Point(308, 22);
            this.btnASFFolder.Name = "btnASFFolder";
            this.btnASFFolder.Size = new System.Drawing.Size(75, 23);
            this.btnASFFolder.TabIndex = 1;
            this.btnASFFolder.Text = "…";
            this.btnASFFolder.UseVisualStyleBackColor = true;
            this.btnASFFolder.Click += new System.EventHandler(this.btnASFFolder_Click);
            // 
            // txtASFFolder
            // 
            this.txtASFFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtASFFolder.Location = new System.Drawing.Point(6, 22);
            this.txtASFFolder.Name = "txtASFFolder";
            this.txtASFFolder.Size = new System.Drawing.Size(296, 23);
            this.txtASFFolder.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 582);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMain";
            this.Text = "ASF配置文件批量生成 - By Chr_ 2023";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

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
    }
}
