
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmQuanLy : Form
    {

        public frmQuanLy()
        {
            InitializeComponent();
        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            dtpCheckInQLKH.Format = DateTimePickerFormat.Custom;
            dtpCheckInQLKH.CustomFormat = "dd/MM/yyyy";
            dtpCheckOutQLKH.Format = DateTimePickerFormat.Custom;
            dtpCheckOutQLKH.CustomFormat = "dd/MM/yyyy";
            LoadDataToComboBoxMaPhong();
            LoadDataToComboBoxLoaiPhong();
            LoadData1();

        }

        //Hiện cbbMaPhong
        private void LoadDataToComboBoxMaPhong()
        {
            try
            {
                using (SqlConnection connection = connectionClass.GetConnection())
                {
                    connection.Open();
                    string query = @"SELECT PhongID FROM [dbo].[Phong]";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            int roomId = Convert.ToInt32(reader["PhongID"]);
                            cbbMaPhongQLP.Items.Add(roomId);
                        }
                        reader.Close();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        //Hiện cbbLoaiPhong
        private void LoadDataToComboBoxLoaiPhong()
        {
            try
            {
                using (SqlConnection connection = connectionClass.GetConnection())
                {
                    connection.Open();
                    string query = @" SELECT TenLoai FROM LoaiPhong ";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        cbbLoaiPhong.Items.Clear();
                        while (reader.Read())
                        {
                            cbbLoaiPhong.Items.Add(reader[0].ToString());
                        }
                        reader.Close();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        //Load datagridview ds Phòng
        private void LoadData1()
        {
            try
            {
                using (SqlConnection connection = connectionClass.GetConnection())
                {
                    connection.Open();
                    string query = @"SELECT P.PhongID, LP.TenLoai, P.GiaPhong FROM[dbo].[Phong] P JOIN[dbo].[LoaiPhong] LP ON p.LoaiPhongID = LP.LoaiPhongID";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dtgvLoaiPhong.DataSource = dataTable;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        
        
                // Cập nhật IDLoaiPhong và Giá phòng của bảng Phong
                private void UpdateRoomTypeAndPrice(int maPhong, string tenLoaiPhong)
        {
            try
            {
                using (SqlConnection connection = connectionClass.GetConnection())
                {
                    connection.Open();

                    // Lấy IDLoaiPhong và GiaLoaiPhong từ bảng LoaiPhong dựa trên tên loại phòng
                    string query = @"SELECT LoaiPhongID, GiaLoaiPhong FROM LoaiPhong WHERE TenLoai = @TenLoaiPhong";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TenLoaiPhong", tenLoaiPhong);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            int idLoaiPhong = reader.GetInt32(0);
                            int giaLoaiPhong = reader.GetInt32(1);
                            reader.Close();

                            // Cập nhật IDLoaiPhong và Giá của bảng Phong dựa trên mã phòng
                            query = @"UPDATE Phong SET LoaiPhongID = @IDLoaiPhong, GiaPhong = @Gia WHERE PhongID = @MaPhong";
                            using (SqlCommand updateCommand = new SqlCommand(query, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@IDLoaiPhong", idLoaiPhong);
                                updateCommand.Parameters.AddWithValue("@Gia", giaLoaiPhong);
                                updateCommand.Parameters.AddWithValue("@MaPhong", maPhong);

                                int rowsAffected = updateCommand.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Cập nhật loại phòng và giá thành công.");
                                }
                                else
                                {
                                    MessageBox.Show("Cập nhật loại phòng và giá thất bại.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy loại phòng.");
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

       
        private void btnThoatQuanLy_Click(object sender, EventArgs e)
        {
            frmManHinhChinh TB = new frmManHinhChinh();   
            this.Hide();
            TB.ShowDialog();
        }

 
     
        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void atpCoutQLKH_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome h = new frmHome();
            h.ShowDialog();

        }

        private void btnCapNhatLoaiPhong_Click(object sender, EventArgs e)
        {
            int maphong = Convert.ToInt32(cbbMaPhongQLP.SelectedItem);
            string tenLoaiPhong = cbbLoaiPhong.SelectedItem.ToString();

            UpdateRoomTypeAndPrice(maphong, tenLoaiPhong);
            LoadData1();
        }

        private void cbbMaPhongQLP_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedRoomId = Convert.ToInt32(cbbMaPhongQLP.SelectedItem);
        }

        private void cbbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLoaiPhong = cbbLoaiPhong.SelectedItem.ToString();
        }

        private void dtgvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvLoaiPhong.Rows[e.RowIndex];

                // Lấy giá trị của các ô trong dòng được chọn
                string value1 = row.Cells["PhongID"].Value.ToString();
                string value2 = row.Cells["TenLoai"].Value.ToString();
                // ...

                // Hiển thị thông tin trong TextBox
                cbbMaPhongQLP.Text = value1;
                cbbLoaiPhong.Text = value2;
                // ...
            }
        }

        private void TimThongtinkhachhang()
        {
                try
                {
                    using (SqlConnection connection = connectionClass.GetConnection())
                    {
                        connection.Open();
                    string query = @"SELECT KH.*, HD.PhongID, HD.dateCheckIn, HD.dateCheckOut FROM[dbo].[HoaDon] AS HD
                    JOIN[dbo].[KhachHang] AS KH ON HD.KhachHangID = KH.KhachHangID
                    WHERE KH.TenKH LIKE N'%"+txbtimkiemKH.Text+"%';";

                        SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dtgvKhachhangQLKH.DataSource = dataTable;
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            
        }

        private void dtgvKhachhangQLKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvKhachhangQLKH.Rows[e.RowIndex];

                // Lấy giá trị của các ô trong dòng được chọn
                DateTime checkInDate = Convert.ToDateTime(row.Cells["dateCheckIn"].Value);
                DateTime checkOutDate = Convert.ToDateTime(row.Cells["dateCheckOut"].Value);

                dtpCheckInQLKH.Value = checkInDate;
                dtpCheckOutQLKH.Value = checkOutDate;
            }
        }

        private void btnTimKiemQLKH_Click(object sender, EventArgs e)
        {
            TimThongtinkhachhang();
        }
    }
}
