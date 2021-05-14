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
    public partial class StaffInfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-DABF71C;Initial Catalog=hotel_db;Integrated Security=True");
        public void populate()
        {
            Con.Open();
            string sql = "SELECT * FROM Staff_tab";
            SqlDataAdapter getData = new SqlDataAdapter(sql, Con);
            SqlCommandBuilder getRows = new SqlCommandBuilder(getData);
            var getSpace = new DataSet();
            getData.Fill(getSpace);
            ClientGridView.DataSource = getSpace.Tables[0];
            Con.Close();
        }
        public StaffInfo()
        {
            InitializeComponent();
        }

        private void StaffInfo_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            
            if((StaffName.Text == "")||(StaffPhone.Text == "")||(StaffGender.SelectedItem.ToString() == "")||(StaffPassword.Text == ""))
            {
                MessageBox.Show("None of the input can be empty!");
            }
            else
            {
                Con.Open();
                SqlCommand sql = new SqlCommand($"INSERT INTO Staff_tab(StaffName, StaffPhone, StaffGender, StaffPassword) VALUES ('{StaffName.Text}','{StaffPhone.Text}','{StaffGender.SelectedItem.ToString()}','{StaffPassword.Text}')", Con);
                sql.ExecuteNonQuery();
                Con.Close();
                populate();
                MessageBox.Show("Staff added successfully");
            }  
        }

        private void ClientGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StaffID.Text = this.ClientGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            StaffName.Text = this.ClientGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            StaffPhone.Text = this.ClientGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            StaffGender.Text = this.ClientGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            StaffPassword.Text = this.ClientGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
