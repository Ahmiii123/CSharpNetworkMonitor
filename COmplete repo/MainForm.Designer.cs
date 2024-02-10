namespace Project_Simulator_OOP
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            MyProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            timer2 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(39, 12);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(614, 51);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "NETWORK MONITORING SYSTEM";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel2.ForeColor = Color.White;
            guna2HtmlLabel2.Location = new Point(531, 58);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(188, 45);
            guna2HtmlLabel2.TabIndex = 1;
            guna2HtmlLabel2.Text = "Version 2.0";
            // 
            // MyProgressBar
            // 
            MyProgressBar.FillColor = Color.FromArgb(200, 213, 218, 223);
            MyProgressBar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MyProgressBar.ForeColor = Color.White;
            MyProgressBar.Location = new Point(265, 102);
            MyProgressBar.Minimum = 0;
            MyProgressBar.Name = "MyProgressBar";
            MyProgressBar.ShadowDecoration.CustomizableEdges = customizableEdges1;
            MyProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            MyProgressBar.Size = new Size(209, 209);
            MyProgressBar.TabIndex = 2;
            MyProgressBar.Text = "MyProgressbar";
            MyProgressBar.ValueChanged += MyProgressBar_ValueChanged;
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel3.ForeColor = Color.White;
            guna2HtmlLabel3.Location = new Point(210, 348);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(329, 45);
            guna2HtmlLabel3.TabIndex = 3;
            guna2HtmlLabel3.Text = "PoweredByAhmad";
            // 
            // timer2
            // 
            timer2.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(728, 395);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(MyProgressBar);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2CircleProgressBar MyProgressBar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private System.Windows.Forms.Timer timer2;
    }
}