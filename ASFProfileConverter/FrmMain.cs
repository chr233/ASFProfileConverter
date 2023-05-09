using System;
using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ASFProfileConverter
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            tsAuthor.Text = "作者: Chr_";
            var version = Assembly.GetExecutingAssembly().GetName().Version ?? new Version("0.0.0.0");
            tsVersion.Text = $"版本: {version}";
            tsGithub.Text = "获取源码";
        }

        private void btnMaFolder_Click(object sender, EventArgs e)
        {
            using var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    txtMaFolder.Text = dialog.SelectedPath;
                }
            }
        }

        private void btnASFFolder_Click(object sender, EventArgs e)
        {
            using var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    txtASFFolder.Text = dialog.SelectedPath;
                }
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string maFolder = txtMaFolder.Text;
            string asfFolder = txtASFFolder.Text;
            string botAccounts = txtBotAccoutns.Text;

            if (!Path.Exists(maFolder))
            {
                MessageBox.Show("令牌文件夹路径不存在", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaFolder.Focus();
                return;
            }
            if (!Path.Exists(asfFolder))
            {
                MessageBox.Show("ASF机器人配置文件夹路径不存在", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtASFFolder.Focus();
                return;
            }

            if (string.IsNullOrEmpty(botAccounts))
            {
                MessageBox.Show("请输入要转换的机器人账号", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBotAccoutns.Focus();
                return;
            }

            Dictionary<string, string> botDict = new();
            HashSet<string> convertedBotNames = new();

            StringBuilder sb = new();

            var lines = botAccounts.Split('\n');
            foreach (var line in lines)
            {
                var texts = line.Trim().Split(new char[] { ',', '，', ' ', '\t' });

                if (texts.Length < 2)
                {
                    if (MessageBox.Show(string.Format("{0} 参数错误\r\n确认 - 继续运行, 取消 - 终止操作", line), "错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    {
                        return;
                    }
                    else
                    {
                        continue;
                    }
                }

                string login = texts[0];
                string passwd = texts[1];
                botDict.Add(login, passwd);
            }

            var filePaths = Directory.EnumerateFiles(maFolder, "*.maFile");
            if (!filePaths.Any())
            {
                if (MessageBox.Show("令牌文件夹下未找到可用令牌 (需要以 .maFile 结尾)\r\n确认 - 继续运行, 取消 - 终止操作", "错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    return;
                }
            }
            else
            {
                foreach (var filePath in filePaths)
                {
                    try
                    {
                        using var maStream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
                        var maJson = JsonSerializer.Deserialize<MaFileData>(maStream);
                        if (maJson?.AccountName != null)
                        {
                            var accountName = maJson.AccountName;
                            if (botDict.TryGetValue(accountName, out string? accountPasswd))
                            {
                                //复制令牌
                                string maPath = Path.Combine(asfFolder, accountName + ".maFile");
                                File.Copy(filePath, maPath);

                                //创建配置文件
                                string configPath = Path.Combine(asfFolder, accountName + ".json");
                                using var asfStream = File.Open(configPath, FileMode.OpenOrCreate, FileAccess.Write);
                                var configJson = new ASFConfigData
                                {
                                    SteamLogin = accountName,
                                    SteamPassword = accountPasswd,
                                };
                                JsonSerializer.Serialize(asfStream, configJson);

                                convertedBotNames.Add(accountName);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "text");
                    }
                }
            }

            int notConvertedCount = botDict.Keys.Count - convertedBotNames.Count;
            if (notConvertedCount > 0)
            {
                if (MessageBox.Show(string.Format("还有 {0} 个没有匹配令牌的机器人账号未转换, 是否继续导入\r\n确认 - 继续运行, 取消 - 终止操作", notConvertedCount), "错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    var lastBots = botDict.Where(x => !convertedBotNames.Contains(x.Key));
                    foreach (var (accountName, accountPasswd) in lastBots)
                    {
                        //创建配置文件
                        string configPath = Path.Combine(asfFolder, accountName + ".json");
                        using var asfStream = File.Open(configPath, FileMode.OpenOrCreate, FileAccess.Write);
                        var configJson = new ASFConfigData
                        {
                            SteamLogin = accountName,
                            SteamPassword = accountPasswd,
                        };
                        JsonSerializer.Serialize(asfStream, configJson);
                        convertedBotNames.Add(accountName);
                    }
                }
            }

            MessageBox.Show(string.Format("操作完成, 共转换了 {0} 个机器人配置", convertedBotNames.Count), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnToForm_Click(object sender, EventArgs e)
        {
            string maFolder = txtMaFolder.Text;
            string asfFolder = txtASFFolder.Text;
            string botAccounts = txtBotAccoutns.Text;

            if (!Path.Exists(maFolder))
            {
                MessageBox.Show("令牌文件夹路径不存在", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaFolder.Focus();
                return;
            }
            if (!Path.Exists(asfFolder))
            {
                MessageBox.Show("输出文件夹路径不存在", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtASFFolder.Focus();
                return;
            }

            if (string.IsNullOrEmpty(botAccounts))
            {
                MessageBox.Show("请输入要转换的机器人账号", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBotAccoutns.Focus();
                return;
            }

            Dictionary<string, string> botDict = new();
            HashSet<string> convertedBotNames = new();


            var lines = botAccounts.Split('\n');
            foreach (var line in lines)
            {
                var texts = line.Trim().Split(new char[] { ',', '，', ' ', '\t' });

                if (texts.Length < 2)
                {
                    if (MessageBox.Show(string.Format("{0} 参数错误\r\n确认 - 继续运行, 取消 - 终止操作", line), "错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    {
                        return;
                    }
                    else
                    {
                        continue;
                    }
                }

                string login = texts[0];
                string passwd = texts[1];
                botDict.Add(login, passwd);
            }

            StringBuilder sb = new();
            sb.AppendLine("账号,密码,密钥");

            var filePaths = Directory.EnumerateFiles(maFolder, "*.maFile");
            if (!filePaths.Any())
            {
                if (MessageBox.Show("令牌文件夹下未找到可用令牌 (需要以 .maFile 结尾)\r\n确认 - 继续运行, 取消 - 终止操作", "错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    return;
                }
            }
            else
            {
                foreach (var filePath in filePaths)
                {
                    try
                    {
                        using var maStream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
                        var maJson = JsonSerializer.Deserialize<MaFileData>(maStream);
                        if (maJson?.AccountName != null)
                        {
                            var accountName = maJson.AccountName;
                            if (botDict.TryGetValue(accountName, out string? accountPasswd))
                            {
                                sb.AppendLine(string.Format("{0},{1},{2}", accountName, accountPasswd, maJson.SharedSecret));
                                convertedBotNames.Add(accountName);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "text");
                    }
                }
            }

            int notConvertedCount = botDict.Keys.Count - convertedBotNames.Count;
            if (notConvertedCount > 0)
            {
                if (MessageBox.Show(string.Format("还有 {0} 个没有匹配令牌的机器人账号未转换, 是否继续导入\r\n确认 - 继续运行, 取消 - 终止操作", notConvertedCount), "错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    var lastBots = botDict.Where(x => !convertedBotNames.Contains(x.Key));
                    foreach (var (accountName, accountPasswd) in lastBots)
                    {
                        sb.AppendLine(string.Format("{0},{1},", accountName, accountPasswd));
                        convertedBotNames.Add(accountName);
                    }
                }
            }

            var savePath = Path.Combine(asfFolder, "export.csv");
            using var file = File.Open(savePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            using var sw = new StreamWriter(file);
            await sw.WriteAsync(sb);

            MessageBox.Show(string.Format("操作完成, 共转换了 {0} 个机器人, 文件保存在 {1}", convertedBotNames.Count, savePath), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private static void OpenLink(string uri)
        {
            Process.Start(new ProcessStartInfo(uri) { UseShellExecute = true });
        }

        private void tsAuthor_Click(object sender, EventArgs e)
        {
            const string target = "https://github.com/chr233/";
            OpenLink(target);
        }

        private void tsGithub_Click(object sender, EventArgs e)
        {
            const string target = "https://github.com/chr233/ASFProfileConverter";
            OpenLink(target);
        }

        private void tsVersion_Click(object sender, EventArgs e)
        {
            const string target = "https://github.com/chr233/ASFProfileConverter/releases";
            OpenLink(target);
        }

    }
}
