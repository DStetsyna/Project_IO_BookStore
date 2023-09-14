namespace BookStore
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            AdminMode = new Label();
            LoginBtn = new Button();
            UPass = new TextBox();
            ULogin = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(9, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 378);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(32, 245);
            label7.Name = "label7";
            label7.Size = new Size(132, 26);
            label7.TabIndex = 6;
            label7.Text = "Good price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(32, 163);
            label6.Name = "label6";
            label6.Size = new Size(132, 26);
            label6.TabIndex = 5;
            label6.Text = "New books";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(32, 86);
            label5.Name = "label5";
            label5.Size = new Size(162, 26);
            label5.TabIndex = 4;
            label5.Text = "Big collection";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(AdminMode);
            panel2.Controls.Add(LoginBtn);
            panel2.Controls.Add(UPass);
            panel2.Controls.Add(ULogin);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(233, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(341, 378);
            panel2.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.GrayText;
            label8.Location = new Point(312, 0);
            label8.Name = "label8";
            label8.Size = new Size(29, 26);
            label8.TabIndex = 9;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // AdminMode
            // 
            AdminMode.AutoSize = true;
            AdminMode.Font = new Font("Bookman Old Style", 12F, FontStyle.Underline, GraphicsUnit.Point);
            AdminMode.ForeColor = SystemColors.GrayText;
            AdminMode.Location = new Point(147, 348);
            AdminMode.Name = "AdminMode";
            AdminMode.Size = new Size(73, 23);
            AdminMode.TabIndex = 8;
            AdminMode.Text = "Admin";
            AdminMode.Click += AdminMode_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.White;
            LoginBtn.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            LoginBtn.Location = new Point(77, 314);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(201, 31);
            LoginBtn.TabIndex = 7;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // UPass
            // 
            UPass.Location = new Point(147, 244);
            UPass.Name = "UPass";
            UPass.PasswordChar = '*';
            UPass.Size = new Size(175, 27);
            UPass.TabIndex = 6;
            // 
            // ULogin
            // 
            ULogin.Location = new Point(147, 187);
            ULogin.Name = "ULogin";
            ULogin.Size = new Size(175, 27);
            ULogin.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(28, 245);
            label3.Name = "label3";
            label3.Size = new Size(118, 26);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(20, 185);
            label2.Name = "label2";
            label2.Size = new Size(126, 26);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(147, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(107, 35);
            label1.Name = "label1";
            label1.Size = new Size(135, 26);
            label1.TabIndex = 1;
            label1.Text = "Book Store";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(586, 388);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button LoginBtn;
        private TextBox UPass;
        private TextBox ULogin;
        private Label label3;
        private Label label2;
        private Label AdminMode;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
    }
}