namespace WinFormsApp1
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
            lblTitle = new Label();
            lblUrl = new Label();
            txtUrl = new TextBox();
            btnFetch = new Button();
            panelPhone = new Panel();
            lblPhones = new Label();
            txtPhones = new TextBox();
            panelEmail = new Panel();
            lblEmails = new Label();
            txtEmails = new TextBox();
            panelPhone.SuspendLayout();
            panelEmail.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微软雅黑", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(33, 33, 33);
            lblTitle.Location = new Point(12, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(189, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "网页信息提取工具";
            // 
            // lblUrl
            // 
            lblUrl.AutoSize = true;
            lblUrl.Font = new Font("微软雅黑", 10F);
            lblUrl.Location = new Point(12, 60);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(66, 20);
            lblUrl.TabIndex = 1;
            lblUrl.Text = "网页URL:";
            // 
            // txtUrl
            // 
            txtUrl.Font = new Font("微软雅黑", 10F);
            txtUrl.Location = new Point(92, 58);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(580, 25);
            txtUrl.TabIndex = 2;
            // 
            // btnFetch
            // 
            btnFetch.BackColor = Color.FromArgb(66, 133, 244);
            btnFetch.FlatStyle = FlatStyle.Flat;
            btnFetch.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            btnFetch.ForeColor = Color.White;
            btnFetch.Location = new Point(688, 56);
            btnFetch.Name = "btnFetch";
            btnFetch.Size = new Size(80, 30);
            btnFetch.TabIndex = 3;
            btnFetch.Text = "开始提取";
            btnFetch.UseVisualStyleBackColor = false;
            btnFetch.Click += btnFetch_Click;
            // 
            // panelPhone
            // 
            panelPhone.BackColor = Color.FromArgb(248, 248, 248);
            panelPhone.Controls.Add(lblPhones);
            panelPhone.Controls.Add(txtPhones);
            panelPhone.Location = new Point(12, 100);
            panelPhone.Name = "panelPhone";
            panelPhone.Size = new Size(370, 360);
            panelPhone.TabIndex = 4;
            // 
            // lblPhones
            // 
            lblPhones.AutoSize = true;
            lblPhones.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            lblPhones.ForeColor = Color.FromArgb(33, 33, 33);
            lblPhones.Location = new Point(8, 8);
            lblPhones.Name = "lblPhones";
            lblPhones.Size = new Size(69, 19);
            lblPhones.TabIndex = 0;
            lblPhones.Text = "手机号码";
            // 
            // txtPhones
            // 
            txtPhones.BackColor = Color.White;
            txtPhones.BorderStyle = BorderStyle.FixedSingle;
            txtPhones.Font = new Font("Consolas", 10F);
            txtPhones.Location = new Point(8, 35);
            txtPhones.Multiline = true;
            txtPhones.Name = "txtPhones";
            txtPhones.ScrollBars = ScrollBars.Vertical;
            txtPhones.Size = new Size(350, 310);
            txtPhones.TabIndex = 1;
            // 
            // panelEmail
            // 
            panelEmail.BackColor = Color.FromArgb(248, 248, 248);
            panelEmail.Controls.Add(lblEmails);
            panelEmail.Controls.Add(txtEmails);
            panelEmail.Location = new Point(398, 100);
            panelEmail.Name = "panelEmail";
            panelEmail.Size = new Size(370, 360);
            panelEmail.TabIndex = 5;
            // 
            // lblEmails
            // 
            lblEmails.AutoSize = true;
            lblEmails.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            lblEmails.ForeColor = Color.FromArgb(33, 33, 33);
            lblEmails.Location = new Point(8, 8);
            lblEmails.Name = "lblEmails";
            lblEmails.Size = new Size(69, 19);
            lblEmails.TabIndex = 0;
            lblEmails.Text = "邮箱地址";
            // 
            // txtEmails
            // 
            txtEmails.BackColor = Color.White;
            txtEmails.BorderStyle = BorderStyle.FixedSingle;
            txtEmails.Font = new Font("Consolas", 10F);
            txtEmails.Location = new Point(8, 35);
            txtEmails.Multiline = true;
            txtEmails.Name = "txtEmails";
            txtEmails.ScrollBars = ScrollBars.Vertical;
            txtEmails.Size = new Size(350, 310);
            txtEmails.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(784, 476);
            Controls.Add(panelEmail);
            Controls.Add(panelPhone);
            Controls.Add(btnFetch);
            Controls.Add(txtUrl);
            Controls.Add(lblUrl);
            Controls.Add(lblTitle);
            Font = new Font("微软雅黑", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "网页信息提取工具";
            panelPhone.ResumeLayout(false);
            panelPhone.PerformLayout();
            panelEmail.ResumeLayout(false);
            panelEmail.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUrl;
        private TextBox txtUrl;
        private Button btnFetch;
        private Panel panelPhone;
        private Label lblPhones;
        private TextBox txtPhones;
        private Panel panelEmail;
        private Label lblEmails;
        private TextBox txtEmails;
    }
}
