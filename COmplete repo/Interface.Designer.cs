namespace Project_Simulator_OOP
{
    partial class Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            Add_Button = new Button();
            Run_Button = new Button();
            dev_not_found = new Label();
            Manager = new PictureBox();
            combo = new ComboBox();
            menuStrip1 = new MenuStrip();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)Manager).BeginInit();
            SuspendLayout();
            // 
            // Add_Button
            // 
            Add_Button.BackColor = Color.Blue;
            Add_Button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Add_Button.ForeColor = SystemColors.ButtonHighlight;
            Add_Button.Location = new Point(396, 166);
            Add_Button.Margin = new Padding(5, 4, 5, 4);
            Add_Button.Name = "Add_Button";
            Add_Button.Size = new Size(116, 43);
            Add_Button.TabIndex = 0;
            Add_Button.Text = "Add";
            Add_Button.UseVisualStyleBackColor = false;
            Add_Button.Click += Add_Button_Click;
            // 
            // Run_Button
            // 
            Run_Button.BackColor = Color.Blue;
            Run_Button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Run_Button.ForeColor = Color.White;
            Run_Button.Location = new Point(547, 166);
            Run_Button.Margin = new Padding(5, 4, 5, 4);
            Run_Button.Name = "Run_Button";
            Run_Button.Size = new Size(102, 43);
            Run_Button.TabIndex = 2;
            Run_Button.Text = "start";
            Run_Button.UseVisualStyleBackColor = false;
            Run_Button.Click += Run_Button_Click;
            // 
            // dev_not_found
            // 
            dev_not_found.AutoSize = true;
            dev_not_found.Location = new Point(364, 32);
            dev_not_found.Margin = new Padding(5, 0, 5, 0);
            dev_not_found.Name = "dev_not_found";
            dev_not_found.Size = new Size(0, 22);
            dev_not_found.TabIndex = 3;
            // 
            // Manager
            // 
            Manager.Image = (Image)resources.GetObject("Manager.Image");
            Manager.Location = new Point(1128, 0);
            Manager.Margin = new Padding(5, 4, 5, 4);
            Manager.Name = "Manager";
            Manager.Size = new Size(193, 192);
            Manager.SizeMode = PictureBoxSizeMode.Zoom;
            Manager.TabIndex = 8;
            Manager.TabStop = false;
            Manager.Click += Manager_Click;
            // 
            // combo
            // 
            combo.FormattingEnabled = true;
            combo.Items.AddRange(new object[] { "router", "pc", "switch", "work", "firewall" });
            combo.Location = new Point(396, 92);
            combo.Margin = new Padding(5, 4, 5, 4);
            combo.Name = "combo";
            combo.Size = new Size(232, 30);
            combo.TabIndex = 10;
            combo.Text = "devices";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 3, 0, 3);
            menuStrip1.Size = new Size(1321, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(210, 92);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(152, 22);
            guna2HtmlLabel1.TabIndex = 12;
            guna2HtmlLabel1.Text = "Device Name";
            guna2HtmlLabel1.Click += guna2HtmlLabel1_Click;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Blue;
            guna2HtmlLabel2.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel2.ForeColor = Color.White;
            guna2HtmlLabel2.Location = new Point(988, 29);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(132, 25);
            guna2HtmlLabel2.TabIndex = 13;
            guna2HtmlLabel2.Text = " MAIN SERVER";
            // 
            // Interface
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1321, 711);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(combo);
            Controls.Add(Manager);
            Controls.Add(dev_not_found);
            Controls.Add(Run_Button);
            Controls.Add(Add_Button);
            Controls.Add(menuStrip1);
            Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Interface";
            Text = "Device Monitoring System";
            Load += Interface_Load;
            ((System.ComponentModel.ISupportInitialize)Manager).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Add_Button;
        private Button Run_Button;
        private Label dev_not_found;
        private PictureBox Manager;
        //        private Label Timer_Label;
        private ComboBox combo;
        private MenuStrip menuStrip1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}