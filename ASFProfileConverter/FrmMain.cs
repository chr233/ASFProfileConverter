using ASFProfileConverter.Properties;

using System.Diagnostics;
using System.Text;
using System.Text.Json;

namespace ASFProfileConverter
{
    public partial class FrmMain : Form
    {
        private readonly JsonSerializerOptions _jsonOption;
        public FrmMain()
        {
            InitializeComponent();
            _jsonOption = new JsonSerializerOptions { WriteIndented = true };
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            tsAuthor.Text = "����: Chr_";
            tsVersion.Text = $"�汾: {Program.Version}";
            tsGithub.Text = "��ȡԴ��";

            Text += $"- {Program.Version} - {Program.FrameworkName}";

            var botModel = GlobalConfig.Default.BotModel;
            if (string.IsNullOrEmpty(botModel))
            {
                var configJson = new ASFConfigData {
                    SteamLogin = "$$LOGIN$$",
                    SteamPassword = "$$PASSWD$$",
                };
                botModel = JsonSerializer.Serialize(configJson, _jsonOption);
            }
            txtBotModel.Text = botModel;

            txtMaFolder.Text = GlobalConfig.Default.MaFolder;
            txtASFFolder.Text = GlobalConfig.Default.ASFFolder;
            txtBotAccoutns.Text = GlobalConfig.Default.BotAccounts;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalConfig.Default.MaFolder = txtMaFolder.Text;
            GlobalConfig.Default.ASFFolder = txtASFFolder.Text;
            GlobalConfig.Default.BotAccounts = txtBotAccoutns.Text;
            GlobalConfig.Default.BotModel = txtBotModel.Text;
            GlobalConfig.Default.Save();
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

        private async void btnConvert_Click(object sender, EventArgs e)
        {
            string maFolder = txtMaFolder.Text;
            string asfFolder = txtASFFolder.Text;
            string botAccounts = txtBotAccoutns.Text;

            if (!Path.Exists(maFolder))
            {
                MessageBox.Show("�����ļ���·��������", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaFolder.Focus();
                return;
            }
            if (!Path.Exists(asfFolder))
            {
                MessageBox.Show("ASF�����������ļ���·��������", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtASFFolder.Focus();
                return;
            }

            if (string.IsNullOrEmpty(botAccounts))
            {
                MessageBox.Show("������Ҫת���Ļ������˺�", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBotAccoutns.Focus();
                return;
            }

            var botModel = txtBotModel.Text;

            try
            {
                var _ = JsonSerializer.Deserialize<ASFConfigData>(botModel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("ASF������ģ����Ч\r\n��������: {0}", ex.Message), "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBotModel.Focus();
                return;
            }


            var botDict = new Dictionary<string, string>();
            var convertedBotNames = new HashSet<string>();

            var sb = new StringBuilder();

            var lines = botAccounts.Split('\n');
            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                var texts = line.Trim().Split(new char[] { ',', '��', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                if (texts.Length < 2)
                {
                    if (MessageBox.Show(string.Format("{0} ��������\r\nȷ�� - ��������, ȡ�� - ��ֹ����", line), "����", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    {
                        return;
                    }
                    else
                    {
                        continue;
                    }
                }

                string login = texts[0].Trim().ToLower();
                string passwd = texts[1].Trim();
                botDict.TryAdd(login, passwd);
            }

            var filePaths = Directory.EnumerateFiles(maFolder, "*.maFile", SearchOption.AllDirectories);
            if (!filePaths.Any())
            {
                if (MessageBox.Show("�����ļ�����δ�ҵ��������� (��Ҫ�� .maFile ��β)\r\nȷ�� - ��������, ȡ�� - ��ֹ����", "����", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
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
                            if (botDict.TryGetValue(accountName.ToLower(), out string? accountPasswd) && !convertedBotNames.Contains(accountName))
                            {
                                //��������
                                string maPath = Path.Combine(asfFolder, accountName + ".maFile");
                                if (maPath != filePath)
                                {
                                    File.Copy(filePath, maPath, true);
                                }

                                //���������ļ�
                                string configPath = Path.Combine(asfFolder, accountName + ".json");
                                bool exist = File.Exists(configPath);
                                using var asfStream = File.Open(configPath, exist ? FileMode.Truncate : FileMode.CreateNew, FileAccess.Write);
                                var configJson = botModel.Replace(Resources.Login, accountName).Replace(Resources.Passwd, accountPasswd);
                                await asfStream.WriteAsync(Encoding.UTF8.GetBytes(configJson));
                                await asfStream.FlushAsync();
                                convertedBotNames.Add(accountName);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(string.Format("д��������˺ų���\r\n������Ϣ: {0}", ex.Message), "����");
                    }
                }
            }

            int notConvertedCount = botDict.Keys.Count - convertedBotNames.Count;
            if (notConvertedCount > 0)
            {
                if (MessageBox.Show(string.Format("���� {0} ��û��ƥ�����ƵĻ������˺�δת��, �Ƿ��������\r\nȷ�� - ��������, ȡ�� - ��ֹ����", notConvertedCount), "����", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    var lastBots = botDict.Where(x => !convertedBotNames.Contains(x.Key));
                    foreach (var (accountName, accountPasswd) in lastBots)
                    {
                        //���������ļ�
                        string configPath = Path.Combine(asfFolder, accountName + ".json");
                        bool exist = File.Exists(configPath);
                        using var asfStream = File.Open(configPath, exist ? FileMode.Truncate : FileMode.CreateNew, FileAccess.Write);
                        var configJson = botModel.Replace(Resources.Login, accountName).Replace(Resources.Passwd, accountPasswd);
                        await asfStream.WriteAsync(Encoding.UTF8.GetBytes(configJson));
                        await asfStream.FlushAsync();
                        convertedBotNames.Add(accountName);
                    }
                }
            }

            MessageBox.Show(string.Format("�������, ��ת���� {0} ������������", convertedBotNames.Count), "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnToForm_Click(object sender, EventArgs e)
        {
            string maFolder = txtMaFolder.Text;
            string asfFolder = txtASFFolder.Text;
            string botAccounts = txtBotAccoutns.Text;

            if (!Path.Exists(maFolder))
            {
                MessageBox.Show("�����ļ���·��������", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaFolder.Focus();
                return;
            }
            if (!Path.Exists(asfFolder))
            {
                MessageBox.Show("����ļ���·��������", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtASFFolder.Focus();
                return;
            }

            if (string.IsNullOrEmpty(botAccounts))
            {
                MessageBox.Show("������Ҫת���Ļ������˺�", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBotAccoutns.Focus();
                return;
            }

            Dictionary<string, string> botDict = new();
            HashSet<string> convertedBotNames = new();


            var lines = botAccounts.Split('\n');
            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                var texts = line.Trim().Split(new char[] { ',', '��', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                if (texts.Length < 2)
                {
                    if (MessageBox.Show(string.Format("{0} ��������\r\nȷ�� - ��������, ȡ�� - ��ֹ����", line), "����", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    {
                        return;
                    }
                    else
                    {
                        continue;
                    }
                }

                string login = texts[0].Trim().ToLower();
                string passwd = texts[1].Trim();
                botDict.TryAdd(login, passwd);
            }

            StringBuilder sb = new();
            sb.AppendLine("�˺�,����,��Կ");

            var filePaths = Directory.EnumerateFiles(maFolder, "*.maFile");
            if (!filePaths.Any())
            {
                if (MessageBox.Show("�����ļ�����δ�ҵ��������� (��Ҫ�� .maFile ��β)\r\nȷ�� - ��������, ȡ�� - ��ֹ����", "����", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
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
                            if (botDict.TryGetValue(accountName.ToLower(), out string? accountPasswd))
                            {
                                sb.AppendLine(string.Format("{0},{1},{2}", accountName, accountPasswd, maJson.SharedSecret));
                                convertedBotNames.Add(accountName);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"��ȡ���Ƴ���: {ex.Message}", "����");
                    }
                }
            }

            int notConvertedCount = botDict.Keys.Count - convertedBotNames.Count;
            if (notConvertedCount > 0)
            {
                if (MessageBox.Show(string.Format("���� {0} ��û��ƥ�����ƵĻ������˺�δת��, �Ƿ��������\r\nȷ�� - ��������, ȡ�� - ��ֹ����", notConvertedCount), "����", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
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
            using var file = File.Open(savePath, FileMode.Truncate, FileAccess.Write, FileShare.None);
            using var sw = new StreamWriter(file);
            await sw.WriteAsync(sb);

            MessageBox.Show(string.Format("�������, ��ת���� {0} ��������, �ļ������� {1}", convertedBotNames.Count, savePath), "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private static void OpenLink(string uri)
        {
            Process.Start(new ProcessStartInfo(uri) { UseShellExecute = true });
        }

        private void tsAuthor_Click(object sender, EventArgs e)
        {
            const string target = "https://steamcommunity.com/id/Chr_/";
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("���Ḳ�ǵ�ǰ��ģ��, ȷ����?", "ȷ��", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                var configJson = new ASFConfigData {
                    SteamLogin = "$$LOGIN$$",
                    SteamPassword = "$$PASSWD$$",
                };
                txtBotModel.Text = JsonSerializer.Serialize(configJson, _jsonOption);
            }
        }

        private void picDonate_Click(object sender, EventArgs e)
        {
            const string target = "https://afdian.com/@chr233";
            OpenLink(target);
        }

        private async void btnFixMaFile_Click(object sender, EventArgs e)
        {
            string maFolder = txtMaFolder.Text;
            string asfFolder = txtASFFolder.Text;

            if (!Path.Exists(maFolder))
            {
                MessageBox.Show("�����ļ���·��������", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaFolder.Focus();
                return;
            }
            if (!Path.Exists(asfFolder))
            {
                MessageBox.Show("����ļ���·��������", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtASFFolder.Focus();
                return;
            }

            var filePaths = Directory.EnumerateFiles(maFolder, "*.maFile");
            if (!filePaths.Any())
            {
                if (MessageBox.Show("�����ļ�����δ�ҵ��������� (��Ҫ�� .maFile ��β)\r\nȷ�� - ��������, ȡ�� - ��ֹ����", "����", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    return;
                }
            }
            else
            {
                int success = 0;
                int error = 0;
                foreach (var filePath in filePaths)
                {
                    try
                    {
                        using var maStream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
                        var maJson = JsonSerializer.Deserialize<MaFileData>(maStream);

                        if (!string.IsNullOrEmpty(maJson?.SharedSecret))
                        {
                            if (string.IsNullOrEmpty(maJson.IdentitySecret))
                            {
                                maJson.IdentitySecret = "fake";
                            }

                            var newPath = Path.Combine(asfFolder, Path.GetFileName(filePath));
                            if (File.Exists(newPath))
                            {
                                File.Delete(newPath);
                            }

                            using var newStream = File.Open(newPath, FileMode.Create, FileAccess.Write);
                            await JsonSerializer.SerializeAsync(newStream, maJson);

                            success++;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"��ȡ���Ƴ���: {ex.Message}", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        error++;
                    }
                }

                MessageBox.Show($"�޲����, �ɹ� {success} , ʧ�� {error}", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void common_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private async void common_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                if (e.Data.GetData(DataFormats.FileDrop) is string[] files && files.Length > 0)
                {
                    if (sender is TextBox txtBox)
                    {
                        if (txtBox.Name != txtBotAccoutns.Name)
                        {
                            var path = files[0];
                            if (!Directory.Exists(path) && File.Exists(path))
                            {
                                path = Path.GetDirectoryName(path);
                            }
                            txtBox.Text = path;
                        }
                        else
                        {
                            foreach (var file in files)
                            {
                                if (Directory.Exists(file) && !File.Exists(file))
                                {
                                    continue;
                                }

                                if (txtBox.Text.Length > 0)
                                {
                                    txtBox.Text += "\r\n\r\n";
                                }

                                try
                                {
                                    var text = await File.ReadAllTextAsync(file);
                                    txtBox.Text += text;
                                }
                                catch (Exception ex)
                                {
                                    txtBox.Text += $"��ȡ�ļ�{file}����:{ex.Message}";
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
