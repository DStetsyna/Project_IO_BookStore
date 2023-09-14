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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=Django;Initial Catalog=BookShopDb;Integrated Security=True");
        private void populate()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Users", Con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            UsersGV.DataSource = dt;
            Con.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (Uname.Text == "" || Uphone.Text == "" || Uadress.Text == "" || Upassword.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT Users(UName,UPhone,UAdd,UPass) VALUES (@Uname, @Uphone, @Uadress, @Upassword)", Con);
                    cmd.Parameters.AddWithValue("@Uname", Uname.Text);
                    cmd.Parameters.AddWithValue("@Uphone", Uphone.Text);
                    cmd.Parameters.AddWithValue("@Uadress", Uadress.Text);
                    cmd.Parameters.AddWithValue("@Upassword", Upassword.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User added to list");
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
        private void Reset()
        {
            Uname.Text = "";
            Uphone.Text = "";
            Uadress.Text = "";
            Upassword.Text = "";
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
        int key = 0;
        private void DeleteBtn_Click(object sender, EventArgs e)
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
                    string query = "delete from Users where UId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User deleted successfully");
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

        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Uname.Text = UsersGV.SelectedRows[0].Cells[1].Value.ToString();
            Uphone.Text = UsersGV.SelectedRows[0].Cells[2].Value.ToString();
            Uadress.Text = UsersGV.SelectedRows[0].Cells[3].Value.ToString();
            Upassword.Text = UsersGV.SelectedRows[0].Cells[4].Value.ToString();
            if (Uname.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(UsersGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (Uname.Text == "" || Uphone.Text == "" || Uadress.Text == "" || Upassword.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update Users set UName='" + Uname.Text + "',UPhone='" + Uphone.Text + "',UAdd='" + Uadress.Text + "',UPass='" + Upassword.Text + "' where UId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User updated successfully");
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

        private void BooksLbl_Click(object sender, EventArgs e)
        {
            Books Obj = new Books();
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
