namespace Project_Simulator_OOP
{
    partial class login_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_page));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            name_login = new Label();
            pictureBox1 = new PictureBox();
            user_name = new Label();
            txt_username = new Guna.UI2.WinForms.Guna2TextBox();
            txtpass = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // name_login
            // 
            name_login.AutoSize = true;
            name_login.BackColor = Color.Blue;
            name_login.Font = new Font("Century Gothic", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            name_login.ForeColor = Color.White;
            name_login.Location = new Point(147, 25);
            name_login.Name = "name_login";
            name_login.Size = new Size(176, 34);
            name_login.TabIndex = 0;
            name_login.Text = "USER LOGIN";
            name_login.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(382, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(448, 335);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // user_name
            // 
            user_name.AutoSize = true;
            user_name.BackColor = Color.Blue;
            user_name.ForeColor = Color.White;
            user_name.Location = new Point(0, 132);
            user_name.Name = "user_name";
            user_name.Size = new Size(115, 28);
            user_name.TabIndex = 2;
            user_name.Text = "USERNAME";
            // 
            // txt_username
            // 
            txt_username.CustomizableEdges = customizableEdges1;
            txt_username.DefaultText = "";
            txt_username.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_username.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_username.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_username.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_username.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_username.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_username.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_username.Location = new Point(147, 132);
            txt_username.Name = "txt_username";
            txt_username.PasswordChar = '\0';
            txt_username.PlaceholderText = "";
            txt_username.SelectedText = "";
            txt_username.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txt_username.Size = new Size(166, 33);
            txt_username.TabIndex = 4;
            // 
            // txtpass
            // 
            txtpass.CustomizableEdges = customizableEdges3;
            txtpass.DefaultText = "";
            txtpass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtpass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtpass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtpass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtpass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtpass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpass.Location = new Point(147, 188);
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '●';
            txtpass.PlaceholderText = "";
            txtpass.SelectedText = "";
            txtpass.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtpass.Size = new Size(166, 33);
            txtpass.TabIndex = 5;
            txtpass.UseSystemPasswordChar = true;
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = Color.Blue;
            guna2Button1.CustomizableEdges = customizableEdges5;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Empty;
            guna2Button1.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(147, 255);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button1.Size = new Size(143, 44);
            guna2Button1.TabIndex = 6;
            guna2Button1.Text = "LOGIN";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Blue;
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 188);
            label1.Name = "label1";
            label1.Size = new Size(117, 28);
            label1.TabIndex = 7;
            label1.Text = "PASSWORD";
            // 
            // login_page
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 330);
            Controls.Add(label1);
            Controls.Add(guna2Button1);
            Controls.Add(txtpass);
            Controls.Add(txt_username);
            Controls.Add(user_name);
            Controls.Add(pictureBox1);
            Controls.Add(name_login);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login_page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "s";
            Load += login_page_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name_login;
        private PictureBox pictureBox1;
        private Label user_name;
        private Guna.UI2.WinForms.Guna2TextBox txt_username;
        private Guna.UI2.WinForms.Guna2TextBox txtpass;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Label label1;
    }
}