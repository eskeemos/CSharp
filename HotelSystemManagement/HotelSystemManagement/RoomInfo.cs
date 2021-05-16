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
        public RoomInfo()
        {
            InitializeComponent();
        }
        private void ResetTextBoxes()
        {
            RoomNumber.Text = RoomPhone.Text = RoomSearch.Text = "";
            NoRadio.Checked = true;
        }
        private void ShowRefreshData()
        {
            Con.Open();
            SqlDataAdapter getData = new SqlDataAdapter("SELECT * FROM Room_tab", Con);
            var getSpace = new DataSet();
            getData.Fill(getSpace);
            RoomGridView.DataSource = getSpace.Tables[0];
            Con.Close();
            ResetTextBoxes();
        }
        private void RoomGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RoomNumber.Text = this.RoomGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            RoomPhone.Text = this.RoomGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (this.RoomGridView.Rows[e.RowIndex].Cells[2].Value.ToString() == "occupied")
            {
                YesRadio.Checked = true;
            }
            else
            {
                NoRadio.Checked = true;
            }
        }
        private void RoomInfo_Load(object sender, EventArgs e)
        {
            ShowRefreshData();
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if ((RoomNumber.Text == "") || (RoomPhone.Text == ""))
            {
                MessageBox.Show("First, select row to be deleted");
            }
            else
            {
                Con.Open();
                SqlCommand sql = new SqlCommand($"DELETE FROM Room_tab WHERE RoomID = {RoomNumber.Text} ", Con);
                sql.ExecuteNonQuery();
                Con.Close();
                ShowRefreshData();
                MessageBox.Show("Room data deleted successfully");
            }
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if ((RoomNumber.Text == "") || (RoomPhone.Text == ""))
            {
                MessageBox.Show("All input data must be filled");
            }
            else
            {
                string isfree;
                if (YesRadio.Checked == true)
                {
                    isfree = "free";
                }
                else
                {
                    isfree = "occupied";
                }
                Con.Open();
                SqlCommand sql = new SqlCommand($"INSERT INTO Room_tab VALUES('0{RoomNumber.Text.PadLeft(4, '0')}','{RoomPhone.Text}','{isfree}')", Con);
                sql.ExecuteNonQuery();
                Con.Close();
                ShowRefreshData();
                MessageBox.Show("Room added successfully");
            }
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            string isfree;
            if (YesRadio.Checked == true)
            {
                isfree = "occupated";
            }
            else
            {
                isfree = "free";
            }
            Con.Open();
            SqlCommand sql = new SqlCommand($"UPDATE Room_tab SET RoomID = {RoomNumber.Text}, RoomPhone = '{RoomPhone.Text}', RoomFree = '{isfree}'", Con);
            sql.ExecuteNonQuery();
            Con.Close();
            ShowRefreshData();
            MessageBox.Show("Room data updated successfully");
        }
    }
}
