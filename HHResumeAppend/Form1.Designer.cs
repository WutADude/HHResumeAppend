namespace HHResumeAppend
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.AppendsCountLabel = new System.Windows.Forms.Label();
            this.GitLinkLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TokenGB = new System.Windows.Forms.GroupBox();
            this.TokenPasteLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClosestAppendLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ResumeCountLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MainButton = new System.Windows.Forms.Button();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TokenGB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.HeaderPanel.Controls.Add(this.AppendsCountLabel);
            this.HeaderPanel.Controls.Add(this.GitLinkLabel);
            this.HeaderPanel.Controls.Add(this.pictureBox1);
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(423, 100);
            this.HeaderPanel.TabIndex = 1;
            // 
            // AppendsCountLabel
            // 
            this.AppendsCountLabel.Cursor = System.Windows.Forms.Cursors.Help;
            this.AppendsCountLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AppendsCountLabel.ForeColor = System.Drawing.Color.White;
            this.AppendsCountLabel.Location = new System.Drawing.Point(232, 38);
            this.AppendsCountLabel.Name = "AppendsCountLabel";
            this.AppendsCountLabel.Size = new System.Drawing.Size(177, 47);
            this.AppendsCountLabel.TabIndex = 5;
            this.AppendsCountLabel.Text = "...";
            this.AppendsCountLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GitLinkLabel
            // 
            this.GitLinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GitLinkLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.GitLinkLabel.ForeColor = System.Drawing.Color.White;
            this.GitLinkLabel.Location = new System.Drawing.Point(127, 38);
            this.GitLinkLabel.Name = "GitLinkLabel";
            this.GitLinkLabel.Size = new System.Drawing.Size(99, 20);
            this.GitLinkLabel.TabIndex = 4;
            this.GitLinkLabel.Text = "Мой GitHub";
            this.GitLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GitLinkLabel.Click += new System.EventHandler(this.GitLinkLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HHResumeAppend.Properties.Resources.HHLOGO;
            this.pictureBox1.Location = new System.Drawing.Point(16, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bearer token:";
            // 
            // TokenGB
            // 
            this.TokenGB.Controls.Add(this.TokenPasteLabel);
            this.TokenGB.Controls.Add(this.label1);
            this.TokenGB.Location = new System.Drawing.Point(12, 101);
            this.TokenGB.Name = "TokenGB";
            this.TokenGB.Size = new System.Drawing.Size(397, 53);
            this.TokenGB.TabIndex = 3;
            this.TokenGB.TabStop = false;
            // 
            // TokenPasteLabel
            // 
            this.TokenPasteLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TokenPasteLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TokenPasteLabel.Location = new System.Drawing.Point(104, 20);
            this.TokenPasteLabel.Name = "TokenPasteLabel";
            this.TokenPasteLabel.Size = new System.Drawing.Size(283, 20);
            this.TokenPasteLabel.TabIndex = 3;
            this.TokenPasteLabel.Text = "-> скопируйте токен и нажмите ЛКМ<-";
            this.TokenPasteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TokenPasteLabel.Click += new System.EventHandler(this.TokenPasteLabel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClosestAppendLabel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ResumeCountLabel);
            this.groupBox1.Controls.Add(this.lastNameLabel);
            this.groupBox1.Controls.Add(this.FirstNameLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 145);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // ClosestAppendLabel
            // 
            this.ClosestAppendLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClosestAppendLabel.Location = new System.Drawing.Point(155, 116);
            this.ClosestAppendLabel.Name = "ClosestAppendLabel";
            this.ClosestAppendLabel.Size = new System.Drawing.Size(236, 20);
            this.ClosestAppendLabel.TabIndex = 11;
            this.ClosestAppendLabel.Text = "...";
            this.ClosestAppendLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ближайшее поднятие:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ResumeCountLabel
            // 
            this.ResumeCountLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResumeCountLabel.Location = new System.Drawing.Point(114, 92);
            this.ResumeCountLabel.Name = "ResumeCountLabel";
            this.ResumeCountLabel.Size = new System.Drawing.Size(277, 20);
            this.ResumeCountLabel.TabIndex = 9;
            this.ResumeCountLabel.Text = "...";
            this.ResumeCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameLabel.Location = new System.Drawing.Point(75, 68);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(316, 20);
            this.lastNameLabel.TabIndex = 8;
            this.lastNameLabel.Text = "...";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstNameLabel.Location = new System.Drawing.Point(43, 44);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(348, 20);
            this.FirstNameLabel.TabIndex = 7;
            this.FirstNameLabel.Text = "...";
            this.FirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Кол-во резюме:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Фамилия:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Имя:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Информация о пользователе токена";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainButton
            // 
            this.MainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.MainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainButton.Enabled = false;
            this.MainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButton.ForeColor = System.Drawing.Color.Black;
            this.MainButton.Location = new System.Drawing.Point(12, 305);
            this.MainButton.Name = "MainButton";
            this.MainButton.Size = new System.Drawing.Size(397, 41);
            this.MainButton.TabIndex = 5;
            this.MainButton.TabStop = false;
            this.MainButton.Text = "Запустить";
            this.MainButton.UseVisualStyleBackColor = false;
            this.MainButton.Click += new System.EventHandler(this.MainButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(423, 353);
            this.Controls.Add(this.MainButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TokenGB);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "HeadHunter resume appender by wDude";
            this.HeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TokenGB.ResumeLayout(false);
            this.TokenGB.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel HeaderPanel;
        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox TokenGB;
        private Label TokenPasteLabel;
        private GroupBox groupBox1;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label ResumeCountLabel;
        private Label lastNameLabel;
        private Label FirstNameLabel;
        private Button MainButton;
        private Label GitLinkLabel;
        internal Label AppendsCountLabel;
        private Label label7;
        internal Label ClosestAppendLabel;
    }
}