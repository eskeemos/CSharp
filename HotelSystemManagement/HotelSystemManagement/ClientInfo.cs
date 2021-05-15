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
            string sql = "SELECT * FROM Client_tab";
            SqlDataAdapter getData = new SqlDataAdapter(sql, Con);
            SqlCommandBuilder getRows = new SqlCommandBuilder(getData);
            var getSpace = new DataSet();
            getData.Fill(getSpace);
            ClientGridView.DataSource = getSpace.Tables[0];
            Con.Close();
            ResetTextBox();
        }
        private void ResetTextBox()
        {
            ClientName.Text = ClientPhone.Text = ClientSearch.Text = ""; ;
            ClientCountry.Text = "Chose Country";
        }
        public ClientInfo()
        {
            InitializeComponent();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            Datetxt.Text = DateTime.Now.ToLongTimeString();
        }
        private void ClientInfo_Load(object sender, EventArgs e)
        {
            Datetxt.Text = DateTime.Now.ToLongTimeString();
            timer.Start();
            populate();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if ((ClientName.Text == "") ||(ClientPhone.Text == "") || (ClientCountry.SelectedItem.ToString() == "Chose Country"))
            {
                MessageBox.Show("All input data must be filled and validated!");
            }
            else
            {
                Con.Open();
                SqlCommand sql1 = new SqlCommand($"INSERT INTO Client_tab(ClientName,ClientPhone,ClientCountry) VALUES('{ClientName.Text}','{ClientPhone.Text}','{ClientCountry.SelectedItem.ToString()}')", Con);
                sql1.ExecuteNonQuery();
                Con.Close();
                populate();
                MessageBox.Show("Client Successfully Added");
            }
        }
        private void ClientGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClientID.Text      = ClientGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
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
            populate();
            MessageBox.Show("Client Successfully Edited");
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = $"DELETE FROM Client_tab where ClientID = {ClientID.Text}";
            SqlCommand sql = new SqlCommand(query, Con);
            sql.ExecuteNonQuery();
            Con.Close();
            populate();
            MessageBox.Show("Client deleted successfully");
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
        }    
    }
}
