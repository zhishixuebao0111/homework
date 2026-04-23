using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        private readonly HttpClient _baiduClient;
        private readonly HttpClient _bingClient;

        public Form1()
        {
            InitializeComponent();

            var handler = new HttpClientHandler
            {
                UseCookies = true,
                CookieContainer = new System.Net.CookieContainer(),
                AutomaticDecompression = System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate
            };

            _baiduClient = new HttpClient(handler);
            _baiduClient.DefaultRequestHeaders.Add("User-Agent",
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/131.0.0.0 Safari/537.36");
            _baiduClient.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7");
            _baiduClient.DefaultRequestHeaders.Add("Accept-Language", "zh-CN,zh;q=0.9,en;q=0.8");
            _baiduClient.DefaultRequestHeaders.Add("Cache-Control", "max-age=0");
            _baiduClient.DefaultRequestHeaders.Add("Connection", "keep-alive");
            _baiduClient.DefaultRequestHeaders.Add("Sec-Fetch-Dest", "document");
            _baiduClient.DefaultRequestHeaders.Add("Sec-Fetch-Mode", "navigate");
            _baiduClient.DefaultRequestHeaders.Add("Sec-Fetch-Site", "none");
            _baiduClient.DefaultRequestHeaders.Add("Sec-Fetch-User", "?1");
            _baiduClient.DefaultRequestHeaders.Add("Upgrade-Insecure-Requests", "1");

            _bingClient = new HttpClient();
            _bingClient.DefaultRequestHeaders.Add("User-Agent",
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36");

            btnSearch.MouseEnter += (s, e) => btnSearch.BackColor = Color.FromArgb(0, 100, 180);
            btnSearch.MouseLeave += (s, e) => btnSearch.BackColor = Color.FromArgb(0, 120, 215);
            txtKeyword.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    btnSearch.PerformClick();
            };
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtKeyword.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("请输入搜索关键字！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnSearch.Enabled = false;
            txtBaidu.Text = "正在搜索百度...";
            txtBing.Text = "正在搜索Bing...";

            try
            {
                var baiduTask = SearchBaiduAsync(keyword);
                var bingTask = SearchBingAsync(keyword);

                await Task.WhenAll(baiduTask, bingTask);

                txtBaidu.Text = baiduTask.Result;
                txtBing.Text = bingTask.Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"搜索出错：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSearch.Enabled = true;
            }
        }

        private async Task<string> SearchBaiduAsync(string keyword)
        {
            try
            {
                string url = $"https://www.baidu.com/s?wd={Uri.EscapeDataString(keyword)}";
                using var request = new HttpRequestMessage(HttpMethod.Get, url);
                request.Headers.Referrer = new Uri("https://www.baidu.com/");

                var response = await _baiduClient.SendAsync(request);
                string html = await response.Content.ReadAsStringAsync();

                if (html.Contains("安全验证") || html.Contains("网络不给力") || html.Contains("verify.baidu.com"))
                {
                    return "百度触发了安全验证（反爬虫保护）。\n\n这是正常现象，百度对程序访问限制较严格。\n\n可以使用右侧的Bing搜索，限制较少。";
                }

                string text = ExtractBaiduText(html);
                return text.Length > 0 ? text : "未提取到搜索结果内容。";
            }
            catch (Exception ex)
            {
                return $"百度搜索失败：{ex.Message}";
            }
        }

        private async Task<string> SearchBingAsync(string keyword)
        {
            try
            {
                string url = $"https://www.bing.com/search?q={Uri.EscapeDataString(keyword)}";
                string html = await _bingClient.GetStringAsync(url);
                string text = ExtractBingText(html);
                return text.Length > 0 ? text : "未提取到搜索结果内容。";
            }
            catch (Exception ex)
            {
                return $"Bing搜索失败：{ex.Message}";
            }
        }

        private string ExtractBaiduText(string html)
        {
            StringBuilder result = new StringBuilder();

            int contentStart = html.IndexOf("id=\"content_left\"", StringComparison.OrdinalIgnoreCase);
            if (contentStart > 0)
            {
                int contentEnd = html.IndexOf("id=\"content_right\"", contentStart, StringComparison.OrdinalIgnoreCase);
                if (contentEnd > contentStart)
                {
                    string contentLeft = html.Substring(contentStart, contentEnd - contentStart);

                    var abstracts = Regex.Matches(contentLeft, @"<span[^>]*class=""c-abstract""[^>]*>(.*?)</span>", RegexOptions.IgnoreCase | RegexOptions.Singleline);
                    foreach (Match match in abstracts)
                    {
                        string text = CleanText(match.Groups[1].Value);
                        text = FilterBaiduNoise(text);
                        if (text.Length > 30)
                        {
                            result.AppendLine("• " + text);
                            result.AppendLine();
                        }
                    }
                }
            }

            if (result.Length == 0)
            {
                var abstracts = Regex.Matches(html, @"<div[^>]*class=""c-span-last""[^>]*>(.*?)</div>", RegexOptions.IgnoreCase | RegexOptions.Singleline);
                foreach (Match match in abstracts)
                {
                    string text = CleanText(match.Groups[1].Value);
                    text = FilterBaiduNoise(text);
                    if (text.Length > 30)
                    {
                        result.AppendLine("• " + text);
                        result.AppendLine();
                    }
                }
            }

            string final = result.ToString().Trim();

            if (final.Length < 50)
            {
                return ExtractGeneralText(html, 1500);
            }

            return final.Length > 600 ? final.Substring(0, 600) + "..." : final;
        }

        private string FilterBaiduNoise(string text)
        {
            text = Regex.Replace(text, @"-->.*?<!--", " ", RegexOptions.Singleline);
            text = Regex.Replace(text, @"""\w+""\s*:", " ");
            text = Regex.Replace(text, @"百度快照|查看图|找相关|发布时间|.*秒前.*", "");
            text = Regex.Replace(text, @"^\d+月\d+日|^\d+天前|^\d+小时前", "");
            text = Regex.Replace(text, @"[•·●]\s*", "");
            text = Regex.Replace(text, @"_\w+", " ");
            text = Regex.Replace(text, @"\s+", " ");
            return text.Trim();
        }

        private string ExtractBingText(string html)
        {
            StringBuilder result = new StringBuilder();

            var captions = Regex.Matches(html, @"class=""b_caption"">(.*?)</div>", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            foreach (Match match in captions)
            {
                string text = CleanText(match.Groups[1].Value);
                if (text.Length > 10)
                {
                    result.AppendLine(text);
                    result.AppendLine();
                }
            }

            if (result.Length == 0)
            {
                var paragraphs = Regex.Matches(html, @"<p>(.*?)</p>", RegexOptions.IgnoreCase | RegexOptions.Singleline);
                foreach (Match match in paragraphs)
                {
                    string text = CleanText(match.Groups[1].Value);
                    if (text.Length > 10)
                    {
                        result.AppendLine(text);
                        result.AppendLine();
                    }
                }
            }

            if (result.Length == 0)
            {
                return ExtractGeneralText(html, 400);
            }

            string final = result.ToString().Trim();
            return final.Length > 500 ? final.Substring(0, 500) + "..." : final;
        }

        private string CleanText(string text)
        {
            text = Regex.Replace(text, "<[^>]+>", " ");
            text = Regex.Replace(text, @"\s+", " ");
            text = System.Net.WebUtility.HtmlDecode(text);
            return text.Trim();
        }

        private string ExtractGeneralText(string html, int skipLength)
        {
            string cleaned = Regex.Replace(html, "<script[^>]*>.*?</script>", "", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            cleaned = Regex.Replace(cleaned, "<style[^>]*>.*?</style>", "", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            cleaned = Regex.Replace(cleaned, "<!--.*?-->", "", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            cleaned = Regex.Replace(cleaned, @"""\w+(-\w+)*""\s*:\s*""[^""]*""", " ");
            cleaned = Regex.Replace(cleaned, @"\{[^}]{0,200}\}", " ");
            cleaned = Regex.Replace(cleaned, "<[^>]+>", " ");
            cleaned = Regex.Replace(cleaned, @"_\w+", " ");
            cleaned = Regex.Replace(cleaned, @"\s+", " ");
            cleaned = System.Net.WebUtility.HtmlDecode(cleaned);
            cleaned = cleaned.Trim();

            if (cleaned.Length > skipLength)
            {
                cleaned = cleaned.Substring(skipLength);
            }

            return cleaned.Length > 500 ? cleaned.Substring(0, 500) + "..." : cleaned;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
