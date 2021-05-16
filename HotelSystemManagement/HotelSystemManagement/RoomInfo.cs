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
    public partial class RoomInfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-DABF71C;Initial Catalog=hotel_db;Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string sql = "SELECT * FROM Room_tab";
            SqlDataAdapter getData = new SqlDataAdapter(sql,Con);
            SqlCommandBuilder getRows = new SqlCommandBuilder(getData);
            var getSpace = new DataSet();
            getData.Fill(getSpace);
            RoomGridView.DataSource = getSpace.Tables[0];
            Con.Close();
            ResetTextBoxes();
        }
        public RoomInfo()
        {
            InitializeComponent();
        }
        private void RoomGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RoomNumber.Text = this.RoomGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            RoomPhone.Text = this.RoomGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            if(this.RoomGridView.Rows[e.RowIndex].Cells[2].Value.ToString() == "free")
            {
                NoRadio.Checked = true;
            }
            else
            {
                YesRadio.Checked = true;
            }
        }
        private void RoomInfo_Load(object sender, EventArgs e)
        {
            populate();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            int w2 = checkExistsRoomID(RoomNumber.Text, RoomPhone.Text);
            
            if ((RoomNumber.Text == "") || (RoomPhone.Text == ""))
            {
                MessageBox.Show("All input data must be filled");
            }
            else if(w2 == 0)
            {
                MessageBox.Show("Input data cannot be duplicated");
            }
            else
            {
                string isfree;
                if (YesRadio.Checked == true) isfree = "free";
                else isfree = "occupied";
                Con.Open();
                SqlCommand sql = new SqlCommand($"INSERT INTO Room_tab VALUES({RoomNumber.Text},'{RoomPhone.Text}','{isfree}')", Con);
                sql.ExecuteNonQuery();
                Con.Close();
                populate();
                MessageBox.Show("Room added successfully");
            }
        }  
        private int checkExistsRoomID(string roomNum, string roomPho)
        { 
            Con.Open();
            SqlCommand sql = new SqlCommand("SELECT RoomID,RoomPhone FROM Room_tab", Con);
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                if ((Convert.ToString(reader[0]) == roomNum)||(Convert.ToString(reader[1]) == roomPho))
                {
                    Con.Close();
                    return 0;
                }
            }
            Con.Close();
            return 1;
        }
        private void ResetTextBoxes()
        {
            RoomNumber.Text = RoomPhone.Text = "";
            NoRadio.Checked = true;
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string isfree = "free";
            if (YesRadio.Checked == true) isfree = "occupated";
            SqlCommand sql = new SqlCommand($"UPDATE Room_tab SET RoomID = {RoomNumber.Text}, RoomPhone = '{RoomPhone.Text}', RoomFree = '{isfree}'", Con);
            sql.ExecuteNonQuery();
            Con.Close();
            populate();
            MessageBox.Show("Room data updated successfully");
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if((RoomNumber.Text == "")||(RoomPhone.Text == ""))
            {
                MessageBox.Show("First, select row to be deleted");
            }
            else
            {
                Con.Open();
                SqlCommand sql = new SqlCommand($"DELETE FROM Room_tab WHERE RoomID = {RoomNumber.Text}", Con);
                sql.ExecuteNonQuery();
                Con.Close();
                populate();
                MessageBox.Show("Room data deleted successfully");
            }
            
        }
    }
}
