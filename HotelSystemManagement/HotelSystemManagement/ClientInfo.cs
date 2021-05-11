using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelSystemManagement
{
    public partial class ClientInfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-DABF71C;Initial Catalog=hotel_db;Integrated Security=True");
        public ClientInfo()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datetxt.Text = DateTime.Now.ToLongTimeString();
        }

        private void ClientInfo_Load(object sender, EventArgs e)
        {
            Datetxt.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand sqlCom = new SqlCommand("INSERT INTO Client_tab values()",Con);
            Con.Close();
        }
    }
}
