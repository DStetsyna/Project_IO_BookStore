namespace BookStore
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            panel1 = new Panel();
            LoginBtn = new Button();
            UPass = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            CancelAdm = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(CancelAdm);
            panel1.Controls.Add(LoginBtn);
            panel1.Controls.Add(UPass);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(601, 315);
            panel1.TabIndex = 0;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.White;
            LoginBtn.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            LoginBtn.Location = new Point(203, 205);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(201, 31);
            LoginBtn.TabIndex = 10;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // UPass
            // 
            UPass.Location = new Point(273, 135);
            UPass.Name = "UPass";
            UPass.PasswordChar = '*';
            UPass.Size = new Size(175, 27);
            UPass.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(154, 136);
            label3.Name = "label3";
            label3.Size = new Size(118, 26);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(273, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(233, 21);
            label1.Name = "label1";
            label1.Size = new Size(147, 26);
            label1.TabIndex = 3;
            label1.Text = "AdminLogin";
            // 
            // CancelAdm
            // 
            CancelAdm.AutoSize = true;
            CancelAdm.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Underline, GraphicsUnit.Point);
            CancelAdm.ForeColor = SystemColors.GrayText;
            CancelAdm.Location = new Point(256, 278);
            CancelAdm.Name = "CancelAdm";
            CancelAdm.Size = new Size(88, 26);
            CancelAdm.TabIndex = 11;
            CancelAdm.Text = "Cancel";
            CancelAdm.Click += CancelAdm_Click;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(625, 339);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button LoginBtn;
        private TextBox UPass;
        private Label label3;
        private Label CancelAdm;
    }
}