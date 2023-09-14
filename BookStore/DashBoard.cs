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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
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

        private void UsersLbl_Click(object sender, EventArgs e)
        {
            Users Obj = new Users();
            Obj.Show();
            this.Hide();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=Django;Initial Catalog=BookShopDb;Integrated Security=True");
        private void DashBoard_Load(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda0 = new SqlDataAdapter("select sum(Amount) from Books", Con);
            DataTable dt0 = new DataTable();
            sda0.Fill(dt0);
            BookStockLbl.Text = dt0.Rows[0][0].ToString();
            SqlDataAdapter sda1 = new SqlDataAdapter("select sum(Amount) from Bill", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            AmountLbl.Text = dt1.Rows[0][0].ToString();
            SqlDataAdapter sda2 = new SqlDataAdapter("select Count(*) from Users", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            UserLbl.Text = dt2.Rows[0][0].ToString();
            Con.Close();
        }

        private void ExitLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
