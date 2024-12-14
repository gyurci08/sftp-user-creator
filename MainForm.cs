using sftp_user_creator.config;
using sftp_user_creator.utils;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace sftp_user_creator
{
    public partial class MainForm : Form
    {
        private readonly IConfigurationService _configService;
        private IDictionary<string, string> _config;
        private static readonly string dataDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");
        private static readonly string hostsFilePath = Path.Combine(dataDirectory, "hosts.txt");

        public MainForm(IConfigurationService configService)
        {
            _configService = configService ?? throw new ArgumentNullException(nameof(configService));
            InitializeComponent();
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            await LoadConfigurationAsync();
        }

        private async Task LoadConfigurationAsync()
        {
            try
            {
                _config = await _configService.LoadConfigurationAsync();
                ApplyConfiguration();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading configuration: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyConfiguration()
        {
            if (_config.TryGetValue("group", out var group))
            {
                tb_group.Text = group;
            }
            if (_config.TryGetValue("home", out var home))
            {
                tb_home.Text = home;
            }
            if (_config.TryGetValue("public_keys_dir", out var publicKeysDir))
            {
                tb_publicKeyPath.Text = publicKeysDir;
            }
        }

        private async Task SaveConfigurationAsync()
        {
            _config["group"] = tb_group.Text;
            _config["home"] = tb_home.Text;
            _config["public_keys_dir"] = tb_publicKeyPath.Text;
            await _configService.SaveConfigurationAsync(_config);
        }








        bool isHostFound = false;
        private string host;



        private async void tb_hostname_TextChanged(object sender, EventArgs e)
        {
            string hostname = tb_hostname.Text.Trim();
            if (!string.IsNullOrEmpty(hostname))
            {
                string result = await SearchHostsFileAsync(hostname);
                DisplaySearchResult(result);
            }
        }


        private async Task<string> SearchHostsFileAsync(string hostname)
        {
            if (!File.Exists(hostsFilePath))
            {
                string defaultContent = "127.0.0.1 localhost\n";
                File.WriteAllText(hostsFilePath, defaultContent);
                isHostFound = false;
                return "Hosts created";
            }

            try
            {
                using (StreamReader reader = new StreamReader(hostsFilePath))
                {
                    string line;
                    while ((line = await reader.ReadLineAsync()) != null)
                    {
                        if (line.Contains(hostname, StringComparison.OrdinalIgnoreCase))
                        {
                            isHostFound = true;
                            return line.Split(" ")[0];
                        }
                    }
                }
                isHostFound = false;
                return "Hostname not found in hosts file.";
            }
            catch (Exception ex)
            {
                isHostFound = false;
                return $"Error reading hosts file: {ex.Message}";
            }
        }

        private void DisplaySearchResult(string result)
        {
            host = tb_foundHost.Text = result;
        }


        private void bt_openSettings_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", dataDirectory);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening data directory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }







   



        private void bt_generate_Click(object sender, EventArgs e)
        {
            if(!(string.IsNullOrWhiteSpace(tb_username.Text) | string.IsNullOrWhiteSpace(tb_group.Text)| string.IsNullOrWhiteSpace(tb_home.Text)| string.IsNullOrWhiteSpace(tb_hostname.Text)))
            {
                var passwordGenerator = new PasswordGenerator();
                var sftpUserGenerator = new SftpUserGenerator();
                string commands = sftpUserGenerator.GenerateCommands(
                    username: tb_username.Text,
                    group: tb_group.Text,
                    password: passwordGenerator.Generate(15, 2),
                    homePath: tb_home.Text,
                    subdirectories: tb_directories.Text.Replace(';',',').Split(","),
                    sshKey: tb_publicKey.Text,
                    sshKeyPath: tb_publicKeyPath.Text
                );

                if (!isHostFound) {
                    host = tb_hostname.Text;
                }


                string header = $"""
                ######################################
                # System: {host}
                """;

                rtb_commands.Clear();
                rtb_commands.AppendText(header + "\n");
                rtb_commands.AppendText(string.Join("\n", commands));

            }
            else
                MessageBox.Show($"Fill all the needed boxes: username, group, user's path, hostname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);




        }


    }
}
