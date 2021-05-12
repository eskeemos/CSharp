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
        public void populate()
        {
            Con.Open();
            string myQuery = "SELECT * FROM Client_tab";
            SqlDataAdapter prepareSql = new SqlDataAdapter(myQuery, Con);
            SqlCommandBuilder sql2 = new SqlCommandBuilder(prepareSql);
            var res = new DataSet();
            prepareSql.Fill(res);
            ClientGridView.DataSource = res.Tables[0];
            Con.Close();
        }
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
            populate();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand sql1 = new SqlCommand($"INSERT INTO Client_tab(ClientName,ClientPhone,ClientCountry) VALUES('{ClientName.Text}','{ClientPhone.Text}','{ClientCountry.SelectedItem.ToString()}')", Con);
            sql1.ExecuteNonQuery();
            MessageBox.Show("Client Successfully Added");
            ClientName.Text = ClientPhone.Text = ""; ClientCountry.Text = "Chose country";
            Con.Close();
            populate();
        }

        private void ClientGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClientName.Text    = ClientGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            ClientPhone.Text   = ClientGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            ClientCountry.Text = ClientGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
