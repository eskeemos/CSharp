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
    public partial class ReservationsInfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-DABF71C;Initial Catalog=hotel_db;Integrated Security=True");
        DateTime today;
        public ReservationsInfo()
        {
            InitializeComponent();
        }
        private void ShowRefreshData()
        {
            Con.Open();
            SqlDataAdapter getData = new SqlDataAdapter("SELECT * FROM Reservation_tab",Con);
            var getSpace = new DataSet();
            getData.Fill(getSpace);
            ReservationGridView.DataSource = getSpace.Tables[0];
            Con.Close();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            DateHms.Text = DateTime.Now.ToLongTimeString();
        }
        private void ReservationsInfo_Load(object sender, EventArgs e)
        {
            DateHms.Text = DateTime.Now.ToLongTimeString();
            ShowRefreshData();
            timer.Start();
            today = DateIn.Value;
            FillNameCombo();
            FillRoomCombo();
        }
        private void ReservationGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ReservationID.Text = ReservationGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                ClientName.Text    = ReservationGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                RoomNumber.Text    = ReservationGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                DateIn.Text        = ReservationGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                DateOut.Text       = ReservationGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }
        private void FillNameCombo()
        {
            Con.Open();
            SqlCommand sql = new SqlCommand("SELECT DISTINCT ClientName FROM Client_tab;", Con);
            SqlDataReader getReader = sql.ExecuteReader();
            DataTable getPlace = new DataTable();
            getPlace.Columns.Add("ClientName", typeof(string));
            getPlace.Load(getReader);
            ClientName.ValueMember = "ClientName";
            ClientName.DataSource = getPlace;
            Con.Close();
        }
        private void FillRoomCombo()
        {
            Con.Open();
            SqlCommand sql = new SqlCommand($"SELECT RoomID FROM Room_tab WHERE RoomFree = 'free'", Con);
            SqlDataReader getReader = sql.ExecuteReader();
            DataTable getPlace = new DataTable();
            getPlace.Columns.Add("RoomID", typeof(string));
            getPlace.Load(getReader);
            RoomNumber.ValueMember = "RoomID";
            RoomNumber.DataSource = getPlace;
            Con.Close();
        }
        private void UpdateRoomState()
        {
            Con.Open();
            SqlCommand sql = new SqlCommand($"UPDATE Room_tab SET RoomFree = 'occupied' WHERE RoomID = {Convert.ToInt32(RoomNumber.SelectedValue.ToString())}", Con);
            sql.ExecuteNonQuery();
            Con.Close();
            FillRoomCombo();
        }
        private void UpdateRoomStateOnDelete()
        {
            Con.Open();
            SqlCommand sql = new SqlCommand($"UPDATE Room_tab SET RoomFree = 'free' WHERE RoomID = {Convert.ToInt32(RoomNumber.SelectedValue.ToString()) - 1}", Con);
            sql.ExecuteNonQuery();
            Con.Close();
            FillRoomCombo();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if((DateTime.Compare(DateIn.Value, today) < 0) || (DateTime.Compare(DateOut.Value, DateIn.Value) < 0))
            {
                MessageBox.Show("Enter correct Date data");
            }
            else
            {
                Con.Open();
                string query = $"INSERT INTO Reservation_tab VALUES('{ClientName.SelectedValue.ToString()}',{RoomNumber.SelectedValue.ToString()},'{DateIn.Value.ToShortDateString()}','{DateOut.Value.ToShortDateString()}')";
                SqlCommand sql = new SqlCommand(query, Con);
                sql.ExecuteNonQuery();
                Con.Close();
                ShowRefreshData();
                MessageBox.Show("Reservation Added successfully.");
                UpdateRoomState();
            }
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand sql = new SqlCommand($"DELETE FROM Reservation_tab WHERE ResID = {ReservationID.Text}",Con);
            sql.ExecuteNonQuery();
            Con.Close();
            ShowRefreshData();
            MessageBox.Show("Reservation deleted successfully.");
            UpdateRoomStateOnDelete();
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            ShowRefreshData();
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand sql = new SqlCommand($"UPDATE Reservation_tab SET Client = '{ClientName.Text}', Room = {RoomNumber.Text}, DateIn = '{DateIn.Value.ToShortDateString()}', DateOut = '{DateOut.Value.ToShortDateString()}' WHERE ResID = {ReservationID.Text}", Con);
            sql.ExecuteNonQuery();
            Con.Close();
            ShowRefreshData();
            MessageBox.Show("Reservation updated successfully.");
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter getData = new SqlDataAdapter($"SELECT * FROM Reservation_tab WHERE ResID = {ReservationSearch.Text}",Con);
            var getSpace = new DataSet();
            getData.Fill(getSpace);
            ReservationGridView.DataSource = getSpace.Tables[0];
            Con.Close();
            ReservationSearch.Text = "";
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.Show();
        }
    }
}
