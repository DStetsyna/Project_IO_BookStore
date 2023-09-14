using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=Django;Initial Catalog=BookShopDb;Integrated Security=True");
        private void populate()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Books", Con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            BookGV.DataSource = dt;
            Con.Close();
        }
        private void UpdateBook()
        {
            int newAmount = stock - Convert.ToInt32(Bamount.Text);
            try
            {
                Con.Open();
                string query = "update Books set Amount=" + newAmount + " where BId=" + key + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                // MessageBox.Show("Book updated successfully");
                Con.Close();
                populate();
                //Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int n = 0, Grdtotal = 0;
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (Bamount.Text == "" || Convert.ToInt32(Bamount.Text) > stock)
            {
                MessageBox.Show("Not Enough Stock");
            }
            else
            {
                int total = Convert.ToInt32(Bamount.Text) * Convert.ToInt32(Bprice.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = Btitle.Text;
                newRow.Cells[2].Value = Bamount.Text;
                newRow.Cells[3].Value = Bprice.Text;
                newRow.Cells[4].Value = total;
                BillGV.Rows.Add(newRow);
                n++;
                UpdateBook();
                Grdtotal = Grdtotal + total;
                Totallbl.Text = "Rs" + Grdtotal;
            }
        }
        int key = 0, stock = 0;
        private void BookGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Btitle.Text = BookGV.SelectedRows[0].Cells[1].Value.ToString();
            Bamount.Text = BookGV.SelectedRows[0].Cells[4].Value.ToString();
            Bprice.Text = BookGV.SelectedRows[0].Cells[5].Value.ToString();
            if (Btitle.Text == "")
            {
                key = 0;
                stock = 0;
            }
            else
            {
                key = Convert.ToInt32(BookGV.SelectedRows[0].Cells[0].Value.ToString());
                stock = Convert.ToInt32(BookGV.SelectedRows[0].Cells[4].Value.ToString());
            }
        }
        private void Reset()
        {
            Btitle.Text = "";
            Bamount.Text = "";
            ClientName.Text = "";
            Bprice.Text = "";
        }
        private void Resetbtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
        int prodid, prodqty, prodprice, tottal, pos = 60;
        string prodname;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Book Shop", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80));
            e.Graphics.DrawString("Id  product  quantity  price   total", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(26, 40));
            foreach (DataGridViewRow row in BillGV.Rows)
            {
                prodid = Convert.ToInt32(row.Cells["Column1"].Value);
                prodname = "" + row.Cells["Column2"].Value;
                prodprice = Convert.ToInt32(row.Cells["Column3"].Value);
                prodqty = Convert.ToInt32(row.Cells["Column4"].Value);
                tottal = Convert.ToInt32(row.Cells["Column5"].Value);
                e.Graphics.DrawString("" + prodid, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(26, pos));
                e.Graphics.DrawString("" + prodname, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(35, pos));
                e.Graphics.DrawString("" + prodprice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(120, pos));
                e.Graphics.DrawString("" + prodqty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(170, pos));
                e.Graphics.DrawString("" + tottal, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(235, pos));
                pos += 20;
            }
            e.Graphics.DrawString("Grand Total : " + Grdtotal + " PLN", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(26, pos + 50));
            e.Graphics.DrawString("***********Book Store***********", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Crimson, new Point(40, pos + 85));
            BillGV.Rows.Clear();
            BillGV.Refresh();
            pos = 100;
            Grdtotal = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ClientName.Text == "" || Btitle.Text == "")
            {
                MessageBox.Show("Select Client Name");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT Bill(UName,ClientName,Amount) VALUES (@UserNameLbl, @ClientName, @Amount)", Con);
                    cmd.Parameters.AddWithValue("@UserNameLbl", UserNameLbl.Text);
                    cmd.Parameters.AddWithValue("@ClientName", ClientName.Text);
                    cmd.Parameters.AddWithValue("@Amount", Grdtotal);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill saved successfully");
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            UserNameLbl.Text = Login.UserName;
        }

        private void LogoutLbl_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void ExitLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
