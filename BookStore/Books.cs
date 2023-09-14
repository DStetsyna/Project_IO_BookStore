using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookStore
{
    public partial class Books : Form
    {
        public Books()
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
        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (Btitle.Text == "" || Bauthor.Text == "" || Bamount.Text == "" || Bprice.Text == "" || Bcategory.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT Books(Title,Author,Category,Amount,Price) VALUES (@Btitle, @Bauthor, @Bcategory, @Bamount, @Bprice)", Con);
                    cmd.Parameters.AddWithValue("@Btitle", Btitle.Text);
                    cmd.Parameters.AddWithValue("@Bauthor", Bauthor.Text);
                    cmd.Parameters.AddWithValue("@Bcategory", Bcategory.SelectedItem);
                    cmd.Parameters.AddWithValue("@Bamount", int.Parse(Bamount.Text));
                    cmd.Parameters.AddWithValue("@Bprice", int.Parse(Bprice.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book added to list");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            populate();
            Bcategory.SelectedIndex = -1;
        }
        private void Reset()
        {
            Btitle.Text = "";
            Bauthor.Text = "";
            Bcategory.SelectedIndex = -1;
            Bamount.Text = "";
            Bprice.Text = "";
        }
        private void Resetbtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
        int key = 0;
        private void BookGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Btitle.Text = BookGV.SelectedRows[0].Cells[1].Value.ToString();
            Bauthor.Text = BookGV.SelectedRows[0].Cells[2].Value.ToString();
            Bcategory.SelectedItem = BookGV.SelectedRows[0].Cells[3].Value.ToString();
            Bamount.Text = BookGV.SelectedRows[0].Cells[4].Value.ToString();
            Bprice.Text = BookGV.SelectedRows[0].Cells[5].Value.ToString();
            if (Btitle.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(BookGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from Books where BId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book deleted successfully");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (Btitle.Text == "" || Bauthor.Text == "" || Bamount.Text == "" || Bprice.Text == "" || Bcategory.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update Books set Title='" + Btitle.Text + "',Author='" + Bauthor.Text + "',Category'" + Bcategory.SelectedItem.ToString() + "',Amount='" + Bamount.Text + "',Price='" + Bprice.Text + "where BId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book updated successfully");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void LogoutLbl_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void UsersLbl_Click(object sender, EventArgs e)
        {
            Users Obj = new Users();
            Obj.Show();
            this.Hide();
        }

        private void DashboardLbl_Click(object sender, EventArgs e)
        {
            DashBoard Obj = new DashBoard();
            Obj.Show();
            this.Hide();
        }

        private void ExitLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
