namespace Db_project
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            menuButton = new PictureBox();
            panel2 = new Panel();
            HomeButton = new Button();
            panel3 = new Panel();
            button2 = new Button();
            panel4 = new Panel();
            Help_button = new Button();
            panel5 = new Panel();
            button4 = new Button();
            button1 = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.Indigo;
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(button1);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(2, 3, 2, 3);
            sidebar.MaximumSize = new Size(245, 852);
            sidebar.MinimumSize = new Size(106, 852);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(245, 852);
            sidebar.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menuButton);
            panel1.Location = new Point(2, 3);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(238, 119);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(103, 52);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 24);
            label1.TabIndex = 1;
            label1.Text = " Menu";
            label1.Click += label1_Click;
            // 
            // menuButton
            // 
            menuButton.Cursor = Cursors.Hand;
            menuButton.Image = (Image)resources.GetObject("menuButton.Image");
            menuButton.Location = new Point(33, 37);
            menuButton.Margin = new Padding(2, 3, 2, 3);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(54, 63);
            menuButton.SizeMode = PictureBoxSizeMode.StretchImage;
            menuButton.TabIndex = 0;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(HomeButton);
            panel2.Location = new Point(2, 128);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(238, 76);
            panel2.TabIndex = 1;
            // 
            // HomeButton
            // 
            HomeButton.BackColor = Color.Indigo;
            HomeButton.FlatStyle = FlatStyle.Flat;
            HomeButton.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HomeButton.ForeColor = Color.Transparent;
            HomeButton.Image = (Image)resources.GetObject("HomeButton.Image");
            HomeButton.ImageAlign = ContentAlignment.MiddleLeft;
            HomeButton.Location = new Point(-2, -19);
            HomeButton.Margin = new Padding(2, 3, 2, 3);
            HomeButton.Name = "HomeButton";
            HomeButton.Padding = new Padding(25, 0, 0, 0);
            HomeButton.Size = new Size(266, 103);
            HomeButton.TabIndex = 2;
            HomeButton.Text = "                 Home\r\n";
            HomeButton.TextAlign = ContentAlignment.MiddleLeft;
            HomeButton.UseVisualStyleBackColor = false;
            HomeButton.Click += HomeButton_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Location = new Point(2, 210);
            panel3.Margin = new Padding(2, 3, 2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(238, 97);
            panel3.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.Indigo;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Transparent;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-10, 0);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Padding = new Padding(25, 0, 0, 0);
            button2.Size = new Size(274, 104);
            button2.TabIndex = 3;
            button2.Text = "                   Scheduling";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(Help_button);
            panel4.Location = new Point(2, 313);
            panel4.Margin = new Padding(2, 3, 2, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(238, 96);
            panel4.TabIndex = 6;
            // 
            // Help_button
            // 
            Help_button.BackColor = Color.Indigo;
            Help_button.FlatStyle = FlatStyle.Flat;
            Help_button.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Help_button.ForeColor = Color.Transparent;
            Help_button.Image = (Image)resources.GetObject("Help_button.Image");
            Help_button.ImageAlign = ContentAlignment.MiddleLeft;
            Help_button.Location = new Point(-2, 0);
            Help_button.Margin = new Padding(2, 3, 2, 3);
            Help_button.Name = "Help_button";
            Help_button.Padding = new Padding(25, 0, 0, 0);
            Help_button.Size = new Size(254, 96);
            Help_button.TabIndex = 4;
            Help_button.Text = "                 Help\r\n";
            Help_button.TextAlign = ContentAlignment.MiddleLeft;
            Help_button.UseVisualStyleBackColor = false;
            Help_button.Click += button3_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(button4);
            panel5.Location = new Point(2, 415);
            panel5.Margin = new Padding(2, 3, 2, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(238, 97);
            panel5.TabIndex = 7;
            // 
            // button4
            // 
            button4.BackColor = Color.Indigo;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Transparent;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-2, -24);
            button4.Margin = new Padding(2, 3, 2, 3);
            button4.Name = "button4";
            button4.Padding = new Padding(25, 0, 0, 0);
            button4.Size = new Size(258, 121);
            button4.TabIndex = 5;
            button4.Text = "                 About\r\n";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.PanWest;
            button1.Dock = DockStyle.Bottom;
            button1.FlatAppearance.BorderColor = Color.Indigo;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Transparent;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(2, 518);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Padding = new Padding(25, 0, 0, 0);
            button1.Size = new Size(274, 83);
            button1.TabIndex = 64;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1107, 831);
            ControlBox = false;
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            Name = "Mainform";
            Load += Form1_Load;
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Help_button;
        private System.Windows.Forms.Button button1;
        private PictureBox menuButton;
    }
}

