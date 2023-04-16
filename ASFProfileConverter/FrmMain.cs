using System;
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

            Dictionary<string, string> botDict = new();
            HashSet<string> convertedBotNames = new();

            StringBuilder sb = new();

            var lines = botAccounts.Split('\n');
            foreach (var line in lines)
            {
                var texts = line.Trim().Split(new char[] { ',', '��', ' ', '\t' });

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

                string login = texts[0];
                string passwd = texts[1];
                botDict.Add(login, passwd);
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
                                //��������
                                string maPath = Path.Combine(asfFolder, accountName + ".maFile");
                                File.Copy(filePath, maPath);

                                //���������ļ�
                                string configPath = Path.Combine(asfFolder, accountName + ".json");
                                using var asfStream = File.Open(configPath, FileMode.OpenOrCreate, FileAccess.Write);
                                var configJson = new ASFConfigData {
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
                if (MessageBox.Show(string.Format("���� {0} ��û��ƥ�����ƵĻ������˺�δת��, �Ƿ��������\r\nȷ�� - ��������, ȡ�� - ��ֹ����", notConvertedCount), "����", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    var lastBots = botDict.Where(x => !convertedBotNames.Contains(x.Key));
                    foreach (var (accountName, accountPasswd) in lastBots)
                    {
                        //���������ļ�
                        string configPath = Path.Combine(asfFolder, accountName + ".json");
                        using var asfStream = File.Open(configPath, FileMode.OpenOrCreate, FileAccess.Write);
                        var configJson = new ASFConfigData {
                            SteamLogin = accountName,
                            SteamPassword = accountPasswd,
                        };
                        JsonSerializer.Serialize(asfStream, configJson);
                        convertedBotNames.Add(accountName);
                    }
                }
            }

            MessageBox.Show(string.Format("�������, ��ת���� {0} ������������", convertedBotNames.Count), "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
