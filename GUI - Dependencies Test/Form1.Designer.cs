namespace GUI___Dependencies_Test
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
            panel_LateralMenu = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            panel_Body = new Panel();
            panel_UpMenu = new Panel();
            button_Close = new Button();
            panel_LateralMenu.SuspendLayout();
            panel_Body.SuspendLayout();
            panel_UpMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel_LateralMenu
            // 
            panel_LateralMenu.BackColor = SystemColors.ControlDark;
            panel_LateralMenu.Controls.Add(panel3);
            panel_LateralMenu.Controls.Add(button1);
            panel_LateralMenu.Dock = DockStyle.Left;
            panel_LateralMenu.Location = new Point(0, 0);
            panel_LateralMenu.Name = "panel_LateralMenu";
            panel_LateralMenu.Size = new Size(246, 781);
            panel_LateralMenu.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Location = new Point(3, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(18, 42);
            panel3.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(27, 12);
            button1.Name = "button1";
            button1.Size = new Size(213, 42);
            button1.TabIndex = 0;
            button1.Text = "Video";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel_Body
            // 
            panel_Body.BackColor = SystemColors.ControlDarkDark;
            panel_Body.Controls.Add(panel_UpMenu);
            panel_Body.Dock = DockStyle.Fill;
            panel_Body.Location = new Point(246, 0);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(1107, 781);
            panel_Body.TabIndex = 1;
            // 
            // panel_UpMenu
            // 
            panel_UpMenu.Controls.Add(button_Close);
            panel_UpMenu.Dock = DockStyle.Top;
            panel_UpMenu.Location = new Point(0, 0);
            panel_UpMenu.Name = "panel_UpMenu";
            panel_UpMenu.Size = new Size(1107, 54);
            panel_UpMenu.TabIndex = 0;
            // 
            // button_Close
            // 
            button_Close.FlatAppearance.BorderSize = 0;
            button_Close.FlatStyle = FlatStyle.Flat;
            button_Close.Location = new Point(1039, 3);
            button_Close.Name = "button_Close";
            button_Close.Size = new Size(65, 48);
            button_Close.TabIndex = 0;
            button_Close.Text = "X";
            button_Close.UseVisualStyleBackColor = true;
            button_Close.Click += button_Close_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 781);
            Controls.Add(panel_Body);
            Controls.Add(panel_LateralMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel_LateralMenu.ResumeLayout(false);
            panel_Body.ResumeLayout(false);
            panel_UpMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_LateralMenu;
        private Panel panel_Body;
        private Panel panel3;
        private Button button1;
        private Panel panel_UpMenu;
        private Button button_Close;
    }
}
