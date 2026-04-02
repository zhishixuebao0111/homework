using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string filePath1;
        private string filePath2;
        public Form1()
        {
            InitializeComponent(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "选择第二个文本文件";
                ofd.Filter = "文本文件|*.txt|所有文件|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filePath2 = ofd.FileName;
                    textBox2.Text = filePath2;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "选择第一个文本文件";
                ofd.Filter = "文本文件|*.txt|所有文件|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filePath1 = ofd.FileName;
                    textBox1.Text = filePath1;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath1) || string.IsNullOrEmpty(filePath2))
            {
                MessageBox.Show("请先选择两个文本文件。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 读取两个文件的所有内容
                string content1 = File.ReadAllText(filePath1);
                string content2 = File.ReadAllText(filePath2);

                // 合并内容（可根据需要添加分隔符，如换行）
                string mergedContent = content1 + Environment.NewLine + content2;

                // 获取可执行程序所在目录，并创建 Data 子目录（如果不存在）
                string exeDir = AppDomain.CurrentDomain.BaseDirectory;
                string dataDir = Path.Combine(exeDir, "Data");
                if (!Directory.Exists(dataDir))
                {
                    Directory.CreateDirectory(dataDir);
                }

                // 生成新文件名
                string newFileName = $"合并结果_{DateTime.Now:yyyyMMddHHmmss}.txt";
                string outputPath = Path.Combine(dataDir, newFileName);
                // 写入合并后的内容
                File.WriteAllText(outputPath, mergedContent);

                MessageBox.Show($"合并成功！\n文件保存至：{outputPath}", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"发生错误：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
