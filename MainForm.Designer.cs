namespace sftp_user_creator
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
            richTextBox1 = new RichTextBox();
            la_user = new Label();
            tb_username = new TextBox();
            la_group = new Label();
            tb_group = new TextBox();
            la_host = new Label();
            tb_hostname = new TextBox();
            la_publicKey = new Label();
            tb_publicKey = new TextBox();
            la_home = new Label();
            tb_home = new TextBox();
            la_directories = new Label();
            tb_directories = new TextBox();
            bt_generate = new Button();
            la_author = new Label();
            bt_openSettings = new Button();
            la_publicKeyPath = new Label();
            tb_publicKeyPath = new TextBox();
            tb_foundHost = new TextBox();
            la_hostFound = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            resources.ApplyResources(richTextBox1, "richTextBox1");
            richTextBox1.Name = "richTextBox1";
            // 
            // la_user
            // 
            resources.ApplyResources(la_user, "la_user");
            la_user.Name = "la_user";
            // 
            // tb_username
            // 
            resources.ApplyResources(tb_username, "tb_username");
            tb_username.Name = "tb_username";
            // 
            // la_group
            // 
            resources.ApplyResources(la_group, "la_group");
            la_group.Name = "la_group";
            // 
            // tb_group
            // 
            resources.ApplyResources(tb_group, "tb_group");
            tb_group.Name = "tb_group";
            // 
            // la_host
            // 
            resources.ApplyResources(la_host, "la_host");
            la_host.Name = "la_host";
            // 
            // tb_hostname
            // 
            resources.ApplyResources(tb_hostname, "tb_hostname");
            tb_hostname.Name = "tb_hostname";
            tb_hostname.TextChanged += tb_hostname_TextChanged;
            // 
            // la_publicKey
            // 
            resources.ApplyResources(la_publicKey, "la_publicKey");
            la_publicKey.Name = "la_publicKey";
            // 
            // tb_publicKey
            // 
            resources.ApplyResources(tb_publicKey, "tb_publicKey");
            tb_publicKey.Name = "tb_publicKey";
            // 
            // la_home
            // 
            resources.ApplyResources(la_home, "la_home");
            la_home.Name = "la_home";
            // 
            // tb_home
            // 
            resources.ApplyResources(tb_home, "tb_home");
            tb_home.Name = "tb_home";
            // 
            // la_directories
            // 
            resources.ApplyResources(la_directories, "la_directories");
            la_directories.Name = "la_directories";
            // 
            // tb_directories
            // 
            resources.ApplyResources(tb_directories, "tb_directories");
            tb_directories.Name = "tb_directories";
            // 
            // bt_generate
            // 
            resources.ApplyResources(bt_generate, "bt_generate");
            bt_generate.Name = "bt_generate";
            bt_generate.UseVisualStyleBackColor = true;
            bt_generate.Click += bt_generate_Click;
            // 
            // la_author
            // 
            resources.ApplyResources(la_author, "la_author");
            la_author.Name = "la_author";
            // 
            // bt_openSettings
            // 
            resources.ApplyResources(bt_openSettings, "bt_openSettings");
            bt_openSettings.Name = "bt_openSettings";
            bt_openSettings.UseVisualStyleBackColor = true;
            bt_openSettings.Click += bt_openSettings_Click;
            // 
            // la_publicKeyPath
            // 
            resources.ApplyResources(la_publicKeyPath, "la_publicKeyPath");
            la_publicKeyPath.Name = "la_publicKeyPath";
            // 
            // tb_publicKeyPath
            // 
            resources.ApplyResources(tb_publicKeyPath, "tb_publicKeyPath");
            tb_publicKeyPath.Name = "tb_publicKeyPath";
            // 
            // tb_foundHost
            // 
            resources.ApplyResources(tb_foundHost, "tb_foundHost");
            tb_foundHost.Name = "tb_foundHost";
            tb_foundHost.ReadOnly = true;
            // 
            // la_hostFound
            // 
            resources.ApplyResources(la_hostFound, "la_hostFound");
            la_hostFound.Name = "la_hostFound";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(la_hostFound);
            Controls.Add(tb_foundHost);
            Controls.Add(la_publicKeyPath);
            Controls.Add(tb_publicKeyPath);
            Controls.Add(bt_openSettings);
            Controls.Add(la_author);
            Controls.Add(bt_generate);
            Controls.Add(la_directories);
            Controls.Add(tb_directories);
            Controls.Add(la_home);
            Controls.Add(tb_home);
            Controls.Add(la_publicKey);
            Controls.Add(tb_publicKey);
            Controls.Add(la_host);
            Controls.Add(tb_hostname);
            Controls.Add(la_group);
            Controls.Add(tb_group);
            Controls.Add(la_user);
            Controls.Add(tb_username);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label la_user;
        private TextBox tb_username;
        private Label la_group;
        private TextBox tb_group;
        private Label la_host;
        private TextBox tb_hostname;
        private Label la_publicKey;
        private TextBox tb_publicKey;
        private Label la_home;
        private TextBox tb_home;
        private Label la_directories;
        private TextBox tb_directories;
        private Button bt_generate;
        private Label la_author;
        private Button bt_openSettings;
        private Label la_publicKeyPath;
        private TextBox tb_publicKeyPath;
        private TextBox tb_foundHost;
        private Label la_hostFound;
    }
}
