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
namespace HotelSystemManagement
{
    public partial class Start : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-DABF71C;Initial Catalog=hotel_db;Integrated Security=True");
        public Start()
        {
            InitializeComponent();
        }
        private void Login(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Staff_tab " + "WHERE " +"StaffName = '"+ username.Text +"' AND StaffPassword = '" + password.Text + "'",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString() == "1")
            {
                SplashForm sf = new SplashForm();
                sf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password. Try Again.");
            }
            Con.Close();
        }
        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
