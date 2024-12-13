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
            tb_host = new TextBox();
            la_publicKey = new Label();
            tb_publicKey = new TextBox();
            la_home = new Label();
            tb_home = new TextBox();
            la_directories = new Label();
            tb_directories = new TextBox();
            bt_generate = new Button();
            bt_editDefaults = new Button();
            la_author = new Label();
            bt_editHosts = new Button();
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
            // tb_host
            // 
            resources.ApplyResources(tb_host, "tb_host");
            tb_host.Name = "tb_host";
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
            // bt_editDefaults
            // 
            resources.ApplyResources(bt_editDefaults, "bt_editDefaults");
            bt_editDefaults.Name = "bt_editDefaults";
            bt_editDefaults.UseVisualStyleBackColor = true;
            // 
            // la_author
            // 
            resources.ApplyResources(la_author, "la_author");
            la_author.Name = "la_author";
            // 
            // bt_editHosts
            // 
            resources.ApplyResources(bt_editHosts, "bt_editHosts");
            bt_editHosts.Name = "bt_editHosts";
            bt_editHosts.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bt_editHosts);
            Controls.Add(la_author);
            Controls.Add(bt_editDefaults);
            Controls.Add(bt_generate);
            Controls.Add(la_directories);
            Controls.Add(tb_directories);
            Controls.Add(la_home);
            Controls.Add(tb_home);
            Controls.Add(la_publicKey);
            Controls.Add(tb_publicKey);
            Controls.Add(la_host);
            Controls.Add(tb_host);
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
        private TextBox tb_host;
        private Label la_publicKey;
        private TextBox tb_publicKey;
        private Label la_home;
        private TextBox tb_home;
        private Label la_directories;
        private TextBox tb_directories;
        private Button bt_generate;
        private Button bt_editDefaults;
        private Label la_author;
        private Button bt_editHosts;
    }
}
