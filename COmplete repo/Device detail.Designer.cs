namespace Project_Simulator_OOP
{
    partial class Device_Input
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
            Device_Name_Label = new Label();
            Device_Ip_Label = new Label();
            device_type_label = new Label();
            input_ok_button = new Button();
            TB_Device_Name = new TextBox();
            TB_Device_IP = new TextBox();
            TB_Device_Type = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Device_Name_Label
            // 
            Device_Name_Label.AutoSize = true;
            Device_Name_Label.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Device_Name_Label.Location = new Point(59, 93);
            Device_Name_Label.Margin = new Padding(4, 0, 4, 0);
            Device_Name_Label.Name = "Device_Name_Label";
            Device_Name_Label.Size = new Size(147, 23);
            Device_Name_Label.TabIndex = 3;
            Device_Name_Label.Text = "Device Name";
            // 
            // Device_Ip_Label
            // 
            Device_Ip_Label.AutoSize = true;
            Device_Ip_Label.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Device_Ip_Label.Location = new Point(59, 175);
            Device_Ip_Label.Margin = new Padding(4, 0, 4, 0);
            Device_Ip_Label.Name = "Device_Ip_Label";
            Device_Ip_Label.Size = new Size(94, 21);
            Device_Ip_Label.TabIndex = 4;
            Device_Ip_Label.Text = "Device IP";
            // 
            // device_type_label
            // 
            device_type_label.AutoSize = true;
            device_type_label.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            device_type_label.Location = new Point(59, 240);
            device_type_label.Margin = new Padding(4, 0, 4, 0);
            device_type_label.Name = "device_type_label";
            device_type_label.Size = new Size(59, 23);
            device_type_label.TabIndex = 5;
            device_type_label.Text = "PORT";
            // 
            // input_ok_button
            // 
            input_ok_button.Location = new Point(59, 360);
            input_ok_button.Margin = new Padding(4, 5, 4, 5);
            input_ok_button.Name = "input_ok_button";
            input_ok_button.Size = new Size(107, 38);
            input_ok_button.TabIndex = 6;
            input_ok_button.Text = "Ok";
            input_ok_button.Click += input_ok_button_Click;
            // 
            // TB_Device_Name
            // 
            TB_Device_Name.Location = new Point(269, 88);
            TB_Device_Name.Margin = new Padding(4, 5, 4, 5);
            TB_Device_Name.Name = "TB_Device_Name";
            TB_Device_Name.Size = new Size(141, 31);
            TB_Device_Name.TabIndex = 7;
            // 
            // TB_Device_IP
            // 
            TB_Device_IP.Location = new Point(269, 170);
            TB_Device_IP.Margin = new Padding(4, 5, 4, 5);
            TB_Device_IP.Name = "TB_Device_IP";
            TB_Device_IP.Size = new Size(141, 31);
            TB_Device_IP.TabIndex = 8;
            // 
            // TB_Device_Type
            // 
            TB_Device_Type.Location = new Point(269, 240);
            TB_Device_Type.Margin = new Padding(4, 5, 4, 5);
            TB_Device_Type.Name = "TB_Device_Type";
            TB_Device_Type.Size = new Size(141, 31);
            TB_Device_Type.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(161, 9);
            label1.Name = "label1";
            label1.Size = new Size(196, 23);
            label1.TabIndex = 10;
            label1.Text = "Device Information";
            label1.Click += label1_Click;
            // 
            // Device_Input
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 438);
            Controls.Add(label1);
            Controls.Add(TB_Device_Type);
            Controls.Add(TB_Device_IP);
            Controls.Add(TB_Device_Name);
            Controls.Add(input_ok_button);
            Controls.Add(device_type_label);
            Controls.Add(Device_Ip_Label);
            Controls.Add(Device_Name_Label);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Device_Input";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Details";
            Load += Device_Input_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label Device_Name_Label;
        private Label Device_Ip_Label;
        private Label device_type_label;
        private Button input_ok_button;
        private TextBox TB_Device_Name;
        private TextBox TB_Device_IP;
        private TextBox TB_Device_Type;
        private Label label1;
    }
}