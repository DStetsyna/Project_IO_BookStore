namespace BookStore
{
    partial class Billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            label4 = new Label();
            BookGV = new DataGridView();
            Resetbtn = new Button();
            Bprice = new TextBox();
            ClientName = new TextBox();
            label12 = new Label();
            label13 = new Label();
            ExitLbl = new Label();
            Bamount = new TextBox();
            Btitle = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            LogoutLbl = new Label();
            pictureBox6 = new PictureBox();
            panel = new Panel();
            panel2 = new Panel();
            label7 = new Label();
            UserNameLbl = new Label();
            Totallbl = new Label();
            PrintBtn = new Button();
            AddBtn = new Button();
            label6 = new Label();
            BillGV = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)BookGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BillGV).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(213, 377);
            label4.Name = "label4";
            label4.Size = new Size(160, 33);
            label4.TabIndex = 20;
            label4.Text = "Books List";
            // 
            // BookGV
            // 
            BookGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BookGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookGV.Location = new Point(14, 413);
            BookGV.Name = "BookGV";
            BookGV.RowHeadersWidth = 51;
            BookGV.RowTemplate.Height = 29;
            BookGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BookGV.Size = new Size(576, 291);
            BookGV.TabIndex = 19;
            BookGV.CellContentClick += BookGV_CellContentClick;
            // 
            // Resetbtn
            // 
            Resetbtn.BackColor = Color.White;
            Resetbtn.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Resetbtn.Location = new Point(200, 245);
            Resetbtn.Name = "Resetbtn";
            Resetbtn.Size = new Size(142, 31);
            Resetbtn.TabIndex = 18;
            Resetbtn.Text = "Reset";
            Resetbtn.UseVisualStyleBackColor = false;
            Resetbtn.Click += Resetbtn_Click;
            // 
            // Bprice
            // 
            Bprice.Enabled = false;
            Bprice.Location = new Point(200, 201);
            Bprice.Name = "Bprice";
            Bprice.Size = new Size(142, 27);
            Bprice.TabIndex = 15;
            // 
            // ClientName
            // 
            ClientName.Location = new Point(14, 201);
            ClientName.Name = "ClientName";
            ClientName.Size = new Size(170, 27);
            ClientName.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.GrayText;
            label12.Location = new Point(200, 172);
            label12.Name = "label12";
            label12.Size = new Size(67, 26);
            label12.TabIndex = 13;
            label12.Text = "Price";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.GrayText;
            label13.Location = new Point(14, 172);
            label13.Name = "label13";
            label13.Size = new Size(150, 26);
            label13.TabIndex = 12;
            label13.Text = "Client Name";
            // 
            // ExitLbl
            // 
            ExitLbl.AutoSize = true;
            ExitLbl.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ExitLbl.ForeColor = SystemColors.GrayText;
            ExitLbl.Location = new Point(1162, 0);
            ExitLbl.Name = "ExitLbl";
            ExitLbl.Size = new Size(29, 26);
            ExitLbl.TabIndex = 9;
            ExitLbl.Text = "X";
            ExitLbl.Click += ExitLbl_Click;
            // 
            // Bamount
            // 
            Bamount.Location = new Point(200, 132);
            Bamount.Name = "Bamount";
            Bamount.Size = new Size(142, 27);
            Bamount.TabIndex = 6;
            // 
            // Btitle
            // 
            Btitle.Enabled = false;
            Btitle.Location = new Point(14, 133);
            Btitle.Name = "Btitle";
            Btitle.Size = new Size(170, 27);
            Btitle.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(200, 104);
            label3.Name = "label3";
            label3.Size = new Size(111, 26);
            label3.TabIndex = 4;
            label3.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(14, 104);
            label2.Name = "label2";
            label2.Size = new Size(125, 26);
            label2.TabIndex = 3;
            label2.Text = "Book Title";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(592, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(530, 10);
            label1.Name = "label1";
            label1.Size = new Size(165, 33);
            label1.TabIndex = 1;
            label1.Text = "Book Store";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(68, 19);
            label5.Name = "label5";
            label5.Size = new Size(135, 26);
            label5.TabIndex = 2;
            label5.Text = "Book Store";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // LogoutLbl
            // 
            LogoutLbl.AutoSize = true;
            LogoutLbl.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LogoutLbl.ForeColor = SystemColors.Control;
            LogoutLbl.Location = new Point(65, 14);
            LogoutLbl.Name = "LogoutLbl";
            LogoutLbl.Size = new Size(89, 26);
            LogoutLbl.TabIndex = 5;
            LogoutLbl.Text = "Logout";
            LogoutLbl.Click += LogoutLbl_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(3, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(56, 51);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 4;
            pictureBox6.TabStop = false;
            // 
            // panel
            // 
            panel.BackColor = Color.Transparent;
            panel.Controls.Add(LogoutLbl);
            panel.Controls.Add(pictureBox6);
            panel.Location = new Point(12, 621);
            panel.Name = "panel";
            panel.Size = new Size(204, 57);
            panel.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(UserNameLbl);
            panel2.Controls.Add(Totallbl);
            panel2.Controls.Add(PrintBtn);
            panel2.Controls.Add(AddBtn);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(BillGV);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(BookGV);
            panel2.Controls.Add(Resetbtn);
            panel2.Controls.Add(Bprice);
            panel2.Controls.Add(ClientName);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(ExitLbl);
            panel2.Controls.Add(Bamount);
            panel2.Controls.Add(Btitle);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(243, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1191, 726);
            panel2.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.GrayText;
            label7.Location = new Point(3, 10);
            label7.Name = "label7";
            label7.Size = new Size(71, 26);
            label7.TabIndex = 29;
            label7.Text = "User:";
            // 
            // UserNameLbl
            // 
            UserNameLbl.AutoSize = true;
            UserNameLbl.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            UserNameLbl.ForeColor = SystemColors.GrayText;
            UserNameLbl.Location = new Point(67, 10);
            UserNameLbl.Name = "UserNameLbl";
            UserNameLbl.Size = new Size(135, 26);
            UserNameLbl.TabIndex = 28;
            UserNameLbl.Text = "User Name";
            // 
            // Totallbl
            // 
            Totallbl.AutoSize = true;
            Totallbl.Font = new Font("Bookman Old Style", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Totallbl.ForeColor = SystemColors.GrayText;
            Totallbl.Location = new Point(864, 496);
            Totallbl.Name = "Totallbl";
            Totallbl.Size = new Size(84, 33);
            Totallbl.TabIndex = 27;
            Totallbl.Text = "Total";
            // 
            // PrintBtn
            // 
            PrintBtn.BackColor = Color.White;
            PrintBtn.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PrintBtn.Location = new Point(851, 532);
            PrintBtn.Name = "PrintBtn";
            PrintBtn.Size = new Size(106, 31);
            PrintBtn.TabIndex = 26;
            PrintBtn.Text = "Print";
            PrintBtn.UseVisualStyleBackColor = false;
            PrintBtn.Click += button2_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.White;
            AddBtn.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.Location = new Point(14, 245);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(170, 31);
            AddBtn.TabIndex = 25;
            AddBtn.Text = "Add to Bill";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bookman Old Style", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.GrayText;
            label6.Location = new Point(864, 97);
            label6.Name = "label6";
            label6.Size = new Size(60, 33);
            label6.TabIndex = 24;
            label6.Text = "Bill";
            // 
            // BillGV
            // 
            BillGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BillGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BillGV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            BillGV.Location = new Point(547, 133);
            BillGV.Name = "BillGV";
            BillGV.RowHeadersWidth = 51;
            BillGV.RowTemplate.Height = 29;
            BillGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BillGV.Size = new Size(641, 262);
            BillGV.TabIndex = 23;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Books";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Quantity";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Price";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Total";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(panel);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 726);
            panel1.TabIndex = 8;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Billing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(1446, 750);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Billing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing";
            Load += Billing_Load;
            ((System.ComponentModel.ISupportInitialize)BookGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BillGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private DataGridView BookGV;
        private Button Resetbtn;
        private TextBox Bprice;
        private TextBox ClientName;
        private Label label12;
        private Label label13;
        private Label ExitLbl;
        private TextBox Bamount;
        private TextBox Btitle;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label5;
        private PictureBox pictureBox2;
        private Label LogoutLbl;
        private PictureBox pictureBox6;
        private Panel panel;
        private Panel panel2;
        private Panel panel1;
        private Label label6;
        private DataGridView BillGV;
        private Button PrintBtn;
        private Button AddBtn;
        private Label Totallbl;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Label UserNameLbl;
        private Label label7;
    }
}