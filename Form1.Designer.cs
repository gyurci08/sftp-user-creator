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
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            la_host = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            bt_generate = new Button();
            bt_editDefaults = new Button();
            label6 = new Label();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 28);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 10);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 6;
            label2.Text = "Group";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(118, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
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
            // textBox3
            // 
            textBox3.Location = new Point(237, 28);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(222, 23);
            textBox3.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 180);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 10;
            label3.Text = "Public-key";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 198);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(447, 23);
            textBox4.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 64);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 12;
            label4.Text = "Home";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 82);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(447, 23);
            textBox5.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 113);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 14;
            label5.Text = "Directories";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 131);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(206, 23);
            textBox6.TabIndex = 13;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 242);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 17;
            label6.Text = "By: György Jandzsó";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 446);
            Controls.Add(label6);
            Controls.Add(bt_editDefaults);
            Controls.Add(bt_generate);
            Controls.Add(label5);
            Controls.Add(textBox6);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(la_host);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(textBox2);
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
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label la_host;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Button bt_generate;
        private Button bt_editDefaults;
        private Label label6;
    }
}
