namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        private void InitializeComponent()
        {
            lblTitle = new Label();
            txtKeyword = new TextBox();
            btnSearch = new Button();
            lblBaidu = new Label();
            lblBing = new Label();
            txtBaidu = new TextBox();
            txtBing = new TextBox();
            pnlSearch = new Panel();
            pnlResults = new Panel();
            pnlSearch.SuspendLayout();
            pnlResults.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(50, 50, 50);
            lblTitle.Location = new Point(226, 13);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(182, 51);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "搜索引擎";
            lblTitle.Click += lblTitle_Click;
            // 
            // txtKeyword
            // 
            txtKeyword.BorderStyle = BorderStyle.None;
            txtKeyword.Font = new Font("Segoe UI", 14F);
            txtKeyword.Location = new Point(11, 14);
            txtKeyword.Margin = new Padding(2, 3, 2, 3);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.PlaceholderText = "请输入搜索关键字...";
            txtKeyword.Size = new Size(428, 25);
            txtKeyword.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 120, 215);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(451, 8);
            btnSearch.Margin = new Padding(2, 3, 2, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(93, 38);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "🔍 搜索";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblBaidu
            // 
            lblBaidu.AutoSize = true;
            lblBaidu.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBaidu.ForeColor = Color.FromArgb(30, 30, 30);
            lblBaidu.Location = new Point(12, 13);
            lblBaidu.Margin = new Padding(2, 0, 2, 0);
            lblBaidu.Name = "lblBaidu";
            lblBaidu.Size = new Size(54, 25);
            lblBaidu.TabIndex = 4;
            lblBaidu.Text = "百度";
            // 
            // lblBing
            // 
            lblBing.AutoSize = true;
            lblBing.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBing.ForeColor = Color.FromArgb(30, 30, 30);
            lblBing.Location = new Point(342, 13);
            lblBing.Margin = new Padding(2, 0, 2, 0);
            lblBing.Name = "lblBing";
            lblBing.Size = new Size(53, 25);
            lblBing.TabIndex = 5;
            lblBing.Text = "Bing";
            // 
            // txtBaidu
            // 
            txtBaidu.BackColor = Color.White;
            txtBaidu.BorderStyle = BorderStyle.None;
            txtBaidu.Font = new Font("Segoe UI", 11F);
            txtBaidu.ForeColor = Color.FromArgb(60, 60, 60);
            txtBaidu.Location = new Point(12, 47);
            txtBaidu.Margin = new Padding(2, 3, 2, 3);
            txtBaidu.Multiline = true;
            txtBaidu.Name = "txtBaidu";
            txtBaidu.ReadOnly = true;
            txtBaidu.ScrollBars = ScrollBars.Vertical;
            txtBaidu.Size = new Size(318, 296);
            txtBaidu.TabIndex = 6;
            // 
            // txtBing
            // 
            txtBing.BackColor = Color.White;
            txtBing.BorderStyle = BorderStyle.None;
            txtBing.Font = new Font("Segoe UI", 11F);
            txtBing.ForeColor = Color.FromArgb(60, 60, 60);
            txtBing.Location = new Point(342, 47);
            txtBing.Margin = new Padding(2, 3, 2, 3);
            txtBing.Multiline = true;
            txtBing.Name = "txtBing";
            txtBing.ReadOnly = true;
            txtBing.ScrollBars = ScrollBars.Vertical;
            txtBing.Size = new Size(334, 296);
            txtBing.TabIndex = 7;
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = Color.White;
            pnlSearch.BorderStyle = BorderStyle.FixedSingle;
            pnlSearch.Controls.Add(btnSearch);
            pnlSearch.Controls.Add(txtKeyword);
            pnlSearch.Location = new Point(78, 76);
            pnlSearch.Margin = new Padding(2, 3, 2, 3);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(553, 56);
            pnlSearch.TabIndex = 3;
            // 
            // pnlResults
            // 
            pnlResults.BackColor = Color.White;
            pnlResults.Controls.Add(txtBing);
            pnlResults.Controls.Add(txtBaidu);
            pnlResults.Controls.Add(lblBing);
            pnlResults.Controls.Add(lblBaidu);
            pnlResults.Location = new Point(78, 144);
            pnlResults.Margin = new Padding(2, 3, 2, 3);
            pnlResults.Name = "pnlResults";
            pnlResults.Size = new Size(689, 355);
            pnlResults.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 248, 248);
            ClientSize = new Size(877, 531);
            Controls.Add(pnlResults);
            Controls.Add(pnlSearch);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "搜索引擎";
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            pnlResults.ResumeLayout(false);
            pnlResults.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtKeyword;
        private Button btnSearch;
        private Label lblBaidu;
        private Label lblBing;
        private TextBox txtBaidu;
        private TextBox txtBing;
        private Panel pnlSearch;
        private Panel pnlResults;
    }
}
