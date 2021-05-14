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
            ClientCountry.Text = "POLAND";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand sql1 = new SqlCommand($"INSERT INTO Client_tab(ClientName,ClientPhone,ClientCountry) VALUES('{ClientName.Text}','{ClientPhone.Text}','{ClientCountry.SelectedItem.ToString()}')", Con);
            sql1.ExecuteNonQuery();
            MessageBox.Show("Client Successfully Added");
            ClientName.Text = ClientPhone.Text = ""; ClientCountry.Text = "POLAND";
            Con.Close();
            populate();
        }

        private void ClientGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClientID.Text = ClientGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            ClientName.Text    = ClientGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            ClientPhone.Text   = ClientGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            ClientCountry.Text = ClientGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "UPDATE Client_tab SET ClientName = '" + ClientName.Text + "', ClientPhone = '" + ClientPhone.Text + "',ClientCountry = '" + ClientCountry.SelectedItem.ToString() + "' WHERE ClientID = " + ClientID.Text;
            SqlCommand sql = new SqlCommand(query,Con);
            sql.ExecuteNonQuery();
            Con.Close();
            ClientName.Text = ClientPhone.Text = ""; ClientCountry.Text = "POLAND";
            populate();
            MessageBox.Show("Client Successfully Edited");
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "DELETE FROM Client_tab where ClientID = " + ClientID.Text;
            SqlCommand sql = new SqlCommand(query, Con);
            sql.ExecuteNonQuery();
            Con.Close();
            ClientName.Text = ClientPhone.Text = ""; ClientCountry.Text = "Chose country";
            populate();
            MessageBox.Show("Client Successfully Deleted");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            string sql = "SELECT * FROM Client_tab WHERE ClientName LIKE '%" + ClientSearch.Text + "%'";
            SqlDataAdapter getData = new SqlDataAdapter(sql, Con);
            SqlCommandBuilder getRows = new SqlCommandBuilder(getData);
            var getSpace = new DataSet();
            getData.Fill(getSpace);
            ClientGridView.DataSource = getSpace.Tables[0];
            Con.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            populate();
            ClientSearch.Text = "";
        }

        private void ClientSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
