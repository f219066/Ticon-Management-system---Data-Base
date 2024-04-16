namespace Db_project
{
    partial class adminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminLogin));
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            SigninButton = new Button();
            SignUpButton = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            button4 = new Button();
            menuButton = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(245, 303);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(191, 27);
            textBox2.TabIndex = 59;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Violet;
            label1.Location = new Point(283, 114);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 19);
            label1.TabIndex = 54;
            label1.Text = "Ready to Login";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(243, 175);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 18);
            label2.TabIndex = 55;
            label2.Text = "Admin ID";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(320, 335);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 17);
            label4.TabIndex = 57;
            label4.Text = "Forget Password";
            label4.Click += label4_Click;
            // 
            // SigninButton
            // 
            SigninButton.AutoSize = true;
            SigninButton.BackColor = SystemColors.Control;
            SigninButton.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            SigninButton.ForeColor = SystemColors.ControlText;
            SigninButton.Location = new Point(307, 394);
            SigninButton.Margin = new Padding(4, 5, 4, 5);
            SigninButton.Name = "SigninButton";
            SigninButton.Padding = new Padding(3, 2, 1, 2);
            SigninButton.Size = new Size(88, 48);
            SigninButton.TabIndex = 60;
            SigninButton.Text = "Sign In";
            SigninButton.UseVisualStyleBackColor = false;
            SigninButton.Click += button2_Click;
            // 
            // SignUpButton
            // 
            SignUpButton.BackColor = Color.Black;
            SignUpButton.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            SignUpButton.ForeColor = SystemColors.AppWorkspace;
            SignUpButton.Location = new Point(408, 446);
            SignUpButton.Margin = new Padding(4, 5, 4, 5);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Padding = new Padding(3, 2, 1, 2);
            SignUpButton.Size = new Size(84, 45);
            SignUpButton.TabIndex = 61;
            SignUpButton.Text = "Sign Up";
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(243, 255);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 18);
            label3.TabIndex = 56;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(245, 223);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 27);
            textBox1.TabIndex = 58;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(SignUpButton);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(SigninButton);
            panel1.Location = new Point(216, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(715, 625);
            panel1.TabIndex = 62;
            panel1.Paint += panel1_Paint;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.Cursor = Cursors.PanWest;
            button4.FlatAppearance.BorderColor = Color.Indigo;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Transparent;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(924, 718);
            button4.Name = "button4";
            button4.Padding = new Padding(25, 0, 0, 0);
            button4.Size = new Size(275, 105);
            button4.TabIndex = 63;
            button4.Text = "            ";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // menuButton
            // 
            menuButton.BackColor = Color.Transparent;
            menuButton.Cursor = Cursors.Hand;
            menuButton.Image = (Image)resources.GetObject("menuButton.Image");
            menuButton.Location = new Point(1117, 12);
            menuButton.Margin = new Padding(2, 3, 2, 3);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(34, 37);
            menuButton.SizeMode = PictureBoxSizeMode.StretchImage;
            menuButton.TabIndex = 62;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // adminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1181, 852);
            Controls.Add(menuButton);
            Controls.Add(button4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminLogin";
            Text = "adminLogin";
            Load += adminLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SigninButton;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private PictureBox menuButton;
    }
}