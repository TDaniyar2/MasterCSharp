namespace edapp
{
    partial class MasterCSharp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterCSharp));
            panelcenter = new Panel();
            buttonifreg = new Label();
            buttonLogin = new Button();
            pictureBox2 = new PictureBox();
            password = new TextBox();
            loginbox = new TextBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelcenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelcenter
            // 
            panelcenter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelcenter.BackColor = Color.Purple;
            panelcenter.BackgroundImageLayout = ImageLayout.None;
            panelcenter.Controls.Add(buttonifreg);
            panelcenter.Controls.Add(buttonLogin);
            panelcenter.Controls.Add(pictureBox2);
            panelcenter.Controls.Add(password);
            panelcenter.Controls.Add(loginbox);
            panelcenter.Controls.Add(label2);
            panelcenter.Controls.Add(pictureBox3);
            panelcenter.Controls.Add(pictureBox1);
            panelcenter.Controls.Add(label1);
            panelcenter.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            panelcenter.Location = new Point(0, 0);
            panelcenter.Name = "panelcenter";
            panelcenter.Size = new Size(1110, 607);
            panelcenter.TabIndex = 0;
            panelcenter.Paint += panelcenter_Paint;
            // 
            // buttonifreg
            // 
            buttonifreg.AutoSize = true;
            buttonifreg.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonifreg.Location = new Point(500, 353);
            buttonifreg.Name = "buttonifreg";
            buttonifreg.Size = new Size(89, 18);
            buttonifreg.TabIndex = 10;
            buttonifreg.Text = "Регистрация";
            buttonifreg.Click += label3_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.AutoSize = true;
            buttonLogin.BackgroundImageLayout = ImageLayout.None;
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Location = new Point(500, 391);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(78, 34);
            buttonLogin.TabIndex = 9;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(45, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // password
            // 
            password.Anchor = AnchorStyles.Left;
            password.BackColor = SystemColors.ScrollBar;
            password.Location = new Point(423, 304);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(233, 26);
            password.TabIndex = 6;
            password.UseSystemPasswordChar = true;
            password.TextChanged += textBox2_TextChanged;
            // 
            // loginbox
            // 
            loginbox.Anchor = AnchorStyles.Left;
            loginbox.BackColor = SystemColors.ScrollBar;
            loginbox.Location = new Point(423, 209);
            loginbox.Multiline = true;
            loginbox.Name = "loginbox";
            loginbox.Size = new Size(233, 40);
            loginbox.TabIndex = 5;
            loginbox.TextChanged += textBox1_TextChanged;
            loginbox.Enter += loginbox_Enter;
            loginbox.Leave += loginbox_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(493, 140);
            label2.Name = "label2";
            label2.Size = new Size(85, 37);
            label2.TabIndex = 4;
            label2.Text = "Вход";
            label2.Click += label2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(392, 306);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(392, 216);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Purple;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(151, 44);
            label1.Name = "label1";
            label1.Size = new Size(166, 29);
            label1.TabIndex = 0;
            label1.Text = "MasterCSharp\r\n";
            label1.Click += label1_Click;
            // 
            // MasterCSharp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(1111, 603);
            Controls.Add(panelcenter);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MasterCSharp";
            Text = "MasterCSharp";
            Load += LoginForm_Load;
            panelcenter.ResumeLayout(false);
            panelcenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelcenter;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox3;
        private TextBox loginbox;
        private TextBox password;
        private PictureBox pictureBox2;
        private Button buttonLogin;
        private Label buttonifreg;
    }
}