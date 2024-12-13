namespace sftp_user_creator
{
    partial class Form1
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
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(465, 28);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(772, 399);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // la_user
            // 
            la_user.AutoSize = true;
            la_user.Location = new Point(12, 10);
            la_user.Name = "la_user";
            la_user.Size = new Size(60, 15);
            la_user.TabIndex = 4;
            la_user.Text = "Username";
            // 
            // tb_username
            // 
            tb_username.Location = new Point(12, 28);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(100, 23);
            tb_username.TabIndex = 3;
            // 
            // la_group
            // 
            la_group.AutoSize = true;
            la_group.Location = new Point(118, 10);
            la_group.Name = "la_group";
            la_group.Size = new Size(40, 15);
            la_group.TabIndex = 6;
            la_group.Text = "Group";
            // 
            // tb_group
            // 
            tb_group.Location = new Point(118, 28);
            tb_group.Name = "tb_group";
            tb_group.Size = new Size(100, 23);
            tb_group.TabIndex = 5;
            // 
            // la_host
            // 
            la_host.AutoSize = true;
            la_host.Location = new Point(237, 10);
            la_host.Name = "la_host";
            la_host.Size = new Size(32, 15);
            la_host.TabIndex = 8;
            la_host.Text = "Host";
            // 
            // tb_host
            // 
            tb_host.Location = new Point(237, 28);
            tb_host.Name = "tb_host";
            tb_host.Size = new Size(222, 23);
            tb_host.TabIndex = 7;
            // 
            // la_publicKey
            // 
            la_publicKey.AutoSize = true;
            la_publicKey.Location = new Point(12, 180);
            la_publicKey.Name = "la_publicKey";
            la_publicKey.Size = new Size(63, 15);
            la_publicKey.TabIndex = 10;
            la_publicKey.Text = "Public-key";
            // 
            // tb_publicKey
            // 
            tb_publicKey.Location = new Point(12, 198);
            tb_publicKey.Name = "tb_publicKey";
            tb_publicKey.Size = new Size(447, 23);
            tb_publicKey.TabIndex = 9;
            // 
            // la_home
            // 
            la_home.AutoSize = true;
            la_home.Location = new Point(12, 64);
            la_home.Name = "la_home";
            la_home.Size = new Size(40, 15);
            la_home.TabIndex = 12;
            la_home.Text = "Home";
            // 
            // tb_home
            // 
            tb_home.Location = new Point(12, 82);
            tb_home.Name = "tb_home";
            tb_home.Size = new Size(447, 23);
            tb_home.TabIndex = 11;
            // 
            // la_directories
            // 
            la_directories.AutoSize = true;
            la_directories.Location = new Point(12, 113);
            la_directories.Name = "la_directories";
            la_directories.Size = new Size(63, 15);
            la_directories.TabIndex = 14;
            la_directories.Text = "Directories";
            // 
            // tb_directories
            // 
            tb_directories.Location = new Point(12, 131);
            tb_directories.Name = "tb_directories";
            tb_directories.Size = new Size(206, 23);
            tb_directories.TabIndex = 13;
            // 
            // bt_generate
            // 
            bt_generate.Location = new Point(274, 242);
            bt_generate.Name = "bt_generate";
            bt_generate.Size = new Size(135, 62);
            bt_generate.TabIndex = 15;
            bt_generate.Text = "Generate";
            bt_generate.UseVisualStyleBackColor = true;
            // 
            // bt_editDefaults
            // 
            bt_editDefaults.Location = new Point(285, 310);
            bt_editDefaults.Name = "bt_editDefaults";
            bt_editDefaults.Size = new Size(112, 33);
            bt_editDefaults.TabIndex = 16;
            bt_editDefaults.Text = "Edit defaults";
            bt_editDefaults.UseVisualStyleBackColor = true;
            // 
            // la_author
            // 
            la_author.AutoSize = true;
            la_author.Location = new Point(12, 242);
            la_author.Name = "la_author";
            la_author.Size = new Size(108, 15);
            la_author.TabIndex = 17;
            la_author.Text = "By: György Jandzsó";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 446);
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
            Name = "Form1";
            Text = "Form1";
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
    }
}
