using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnFetch_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text.Trim();
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("请输入URL地址", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 确保URL格式正确
                if (!url.StartsWith("http://") && !url.StartsWith("https://"))
                {
                    url = "https://" + url;
                }

                // 获取网页内容
                using HttpClient client = new HttpClient();
                client.Timeout = TimeSpan.FromSeconds(10);
                string html = await client.GetStringAsync(url);

                // 正则表达式匹配手机号码（中国大陆手机号）
                string phonePattern = @"1[3-9]\d{9}";
                MatchCollection phoneMatches = Regex.Matches(html, phonePattern);
                var phones = new System.Collections.Generic.HashSet<string>();
                foreach (Match match in phoneMatches)
                {
                    phones.Add(match.Value);
                }
                string emailPattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";
                MatchCollection emailMatches = Regex.Matches(html, emailPattern);
                var emails = new System.Collections.Generic.HashSet<string>();
                foreach (Match match in emailMatches)
                {
                    emails.Add(match.Value);
                }
                txtPhones.Text = string.Join(Environment.NewLine, phones);
                txtEmails.Text = string.Join(Environment.NewLine, emails);

                if (phones.Count == 0 && emails.Count == 0)
                {
                    MessageBox.Show("未找到任何手机号码和邮箱地址", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"找到 {phones.Count} 个手机号码，{emails.Count} 个邮箱地址", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"获取内容出错: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
