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
        public void ShowRefreshData()
        {
            Con.Open();
            string sql = "SELECT * FROM Staff_tab";
            SqlDataAdapter getData = new SqlDataAdapter(sql, Con);
            var getSpace = new DataSet();
            getData.Fill(getSpace);
            StaffGridView.DataSource = getSpace.Tables[0];
            Con.Close();
            ResetTextBox();
        }
        public StaffInfo()
        {
            InitializeComponent();
        }
        private void StaffInfo_Load(object sender, EventArgs e)
        {
            ShowRefreshData();
            DateHms.Text = DateTime.Now.ToLongTimeString();
            timer.Start();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if ((StaffName.Text == "") || (StaffPhone.Text == "") || (StaffGender.Text == "Chose gender") || (StaffPassword.Text == ""))
            {
                MessageBox.Show("All input data must be filled and validated!");
            }
            else
            {
                Con.Open();
                SqlCommand sql = new SqlCommand($"INSERT INTO Staff_tab(StaffName, StaffPhone, StaffGender, StaffPassword) VALUES ('{StaffName.Text}','{StaffPhone.Text}','{StaffGender.SelectedItem.ToString()}','{StaffPassword.Text}')", Con);
                sql.ExecuteNonQuery();
                Con.Close();
                ShowRefreshData();
                MessageBox.Show("Staff added successfully");
            }
        }
        private void StaffGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                StaffID.Text       = this.StaffGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                StaffName.Text     = this.StaffGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                StaffPhone.Text    = this.StaffGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                StaffGender.Text   = this.StaffGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                StaffPassword.Text = this.StaffGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }  
        private void EditBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand sql = new SqlCommand($"UPDATE Staff_tab SET StaffName = '{StaffName.Text}', StaffPhone = '{StaffPhone.Text}', StaffPassword = '{StaffPassword.Text}', StaffGender = '{StaffGender.SelectedItem.ToString()}' WHERE StaffID = {StaffID.Text}", Con);
            sql.ExecuteNonQuery();
            Con.Close();
            ShowRefreshData();
            MessageBox.Show("Staff edited successfully");
        }
        private void ResetTextBox()
        {
            StaffName.Text = StaffPhone.Text = StaffPassword.Text = StaffSearch.Text = ""; ;
            StaffGender.Text = "Chose gender";
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand sql = new SqlCommand($"DELETE FROM Staff_tab WHERE StaffID = ${StaffID.Text}",Con);
            sql.ExecuteNonQuery();
            Con.Close();
            ShowRefreshData();
            MessageBox.Show("Staff deleted successfully");
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {        
            Con.Open();
            string sql = $"SELECT * FROM Staff_tab WHERE StaffName LIKE '%{StaffSearch.Text}%'";
            SqlDataAdapter getData = new SqlDataAdapter(sql, Con);
            var getSpace = new DataSet();
            getData.Fill(getSpace);
            StaffGridView.DataSource = getSpace.Tables[0];
            Con.Close();
            ResetText();
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            ShowRefreshData();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            DateHms.Text = DateTime.Now.ToLongTimeString();
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.Show();
        }
    }
}
