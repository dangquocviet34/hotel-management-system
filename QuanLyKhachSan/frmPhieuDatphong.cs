using QuanLyKhachSan.DAO;
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

    public partial class frmPhieuDatphong : Form
    {
       
        private Dictionary<int, List<int>> phongLoaiPhongDictionary;
        public frmPhieuDatphong()
        {
           
            InitializeComponent();           
            LoadDataToComboBox();
            LoadBookingNames();
            dtpCheckin.Format = DateTimePickerFormat.Custom;
            dtpCheckin.CustomFormat = "dd/MM/yyyy";
            dtpCheckout.Format = DateTimePickerFormat.Custom;
            dtpCheckout.CustomFormat = "dd/MM/yyyy";
        }
        

        private void btnthoatCTP_Click(object sender, EventArgs e)
        {
            frmManHinhChinh ThoatDatPhong = new frmManHinhChinh();
            this.Hide();
            ThoatDatPhong.ShowDialog();
            this.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmManHinhChinh TB = new frmManHinhChinh();
            this.Hide();
            TB.ShowDialog();
        }

        private void txbMadondatphong_TextChanged(object sender, EventArgs e)
        {
            
        }
        private string TaoMaAuto()
        {
            DateTime now = DateTime.Now;

            string year = now.Year.ToString();
            string month = now.Month.ToString().PadLeft(2, '0');
            string day = now.Day.ToString().PadLeft(2, '0');
            string hour = now.Hour.ToString().PadLeft(2, '0');
            string minute = now.Minute.ToString().PadLeft(2, '0');

            string invoiceCode = $"{year}{month}{day}{hour}{minute}";

            return invoiceCode;
        }

        private void btnThem1_Click(object sender, EventArgs e)
        {
            txbMadondatphong.Text = string.Empty;
            txbtenkhach.Text = string.Empty;
            txbEmail.Text = string.Empty;
            txbCMTCCCD.Text = string.Empty;
            txbSDT.Text = string.Empty;

            //lblGiaPhong.Text = string.Empty;
            
            cbbTenbooking.Text = string.Empty;
            cbbSoLuongKhach.SelectedIndex = -1;
            cbbMaPhong.SelectedIndex = -1;
            cbbLoaiPhong.SelectedIndex = -1;
            cbbTenbooking.SelectedIndex = -1;
            lbGiaPhong.Text = string.Empty;
            dtpCheckin.Value = DateTime.Now;
            dtpCheckout.Value = DateTime.Now;


        }
        private void Luukh()
        {
                txbMadondatphong.Enabled = false;

          
                using (SqlConnection connection = connectionClass.GetConnection())
                {
                    connection.Open();

                    string query = @"insert into KhachHang( TenKH, SDT, CCCD, Email ) 
                            VALUES      (@tenKH, @sdt, @CCCD, @email)";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@tenKH", txbtenkhach.Text);
                        command.Parameters.AddWithValue("@sdt", txbSDT.Text);
                        command.Parameters.AddWithValue("@CCCD", txbCMTCCCD.Text);
                        command.Parameters.AddWithValue("@email", txbEmail.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Insert thành công
                            MessageBox.Show("Đơn đặt phòng đã được lưu vào cơ sở dữ liệu.");
                        }
                        else
                        {
                            // Không có dòng nào bị ảnh hưởng
                            MessageBox.Show("Không thể chèn đơn đặt phòng vào cơ sở dữ liệu.");
                        }
                    }
                    connection.Close();
                }
        }

        private void LuuHD()
        {
            // Kiểm tra thời gian check-in và check-out
            DateTime checkInTime = dtpCheckin.Value;
            DateTime checkOutTime = dtpCheckout.Value;

            if (checkOutTime <= checkInTime)
            {
                MessageBox.Show("Thời gian check-out phải lớn hơn thời gian check-in.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string formattedCheckIn = checkInTime.ToString("yyyy-MM-dd");
                string formattedCheckOut = checkOutTime.ToString("yyyy-MM-dd");
                txbMadondatphong.Enabled = false;
                Luukh();

                using (SqlConnection connection = connectionClass.GetConnection())
                {
                    connection.Open();
                    string queryKH = @"SELECT KhachHangID FROM KhachHang WHERE TenKH LIKE N'" + txbtenkhach.Text + "' AND SDT LIKE N'" + txbSDT.Text + "'" +
                        " AND CCCD LIKE N'" + txbCMTCCCD.Text + "' AND Email LIKE N'" + txbEmail.Text + "'";
                    SqlCommand command1 = new SqlCommand(queryKH, connection);

                    int MaKH = (int)command1.ExecuteScalar();

                    string queryHD = @"INSERT INTO HoaDon ( [KhachHangID],[PhongID], [SoKhach],   [TenBooking], [dateCheckIn], [dateCheckOut])
            VALUES      (@KhachHangID, @PhongID, @Sokhach,   @TenBooking, @dateCheckIn, @dateCheckOut)";

                    int SoKhach = Convert.ToInt32(cbbSoLuongKhach.SelectedItem);
                    TimeSpan ngay = checkOutTime - checkInTime;
                    int sodem = ngay.Days;
                    using (SqlCommand command = new SqlCommand(queryHD, connection))
                    {
                        command.Parameters.AddWithValue("@KhachHangID", MaKH);
                        command.Parameters.AddWithValue("@PhongID", cbbMaPhong.Text);
                        command.Parameters.AddWithValue("@Sokhach", cbbSoLuongKhach.Text);        
                        command.Parameters.AddWithValue("@TenBooking", cbbTenbooking.Text);
                        command.Parameters.AddWithValue("@dateCheckIn", formattedCheckIn);
                        command.Parameters.AddWithValue("@dateCheckOut", formattedCheckOut);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Insert thành công
                            MessageBox.Show("Đơn đặt phòng đã được lưu vào cơ sở dữ liệu.");
                        }
                        else
                        {
                            // Không có dòng nào bị ảnh hưởng
                            MessageBox.Show("Không thể chèn đơn đặt phòng vào cơ sở dữ liệu.");
                        }
                    }


                    connection.Close();

                }
            }
        }
       
       
        private void txtLuu_Click(object sender, EventArgs e)
        {
            LuuHD();
        }

        private void btnthoatCTP_Click_1(object sender, EventArgs e)
        {
            frmHome f = new frmHome();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void cbbMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaPhong.SelectedItem != null)
            {
                
                int maPhong = (int)cbbMaPhong.SelectedItem;

                // Tìm mã loại phòng tương ứng với mã phòng trong từ điển
                int maLoaiPhong = 0;

                foreach (var kvp in phongLoaiPhongDictionary)
                {
                    if (kvp.Value.Contains(maPhong))
                    {
                        maLoaiPhong = kvp.Key;
                        break;
                    }
                }

                // Tìm và chọn loại phòng tương ứng trong ComboBox Loai phòng
                foreach (LoaiPhong item in cbbLoaiPhong.Items)
                {
                    if (item.MaLoaiPhong == maLoaiPhong)
                    {
                        cbbLoaiPhong.SelectedItem = item;
                        break;
                    }
                }

                // hiển thị giá phòng
                using (SqlConnection connection = connectionClass.GetConnection())
                {
                    connection.Open();

                    string query = @"SELECT GiaPhong FROM Phong WHERE PhongID = @MaPhong";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaPhong", maPhong);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int giaPhong = reader.GetInt32(0);
                                lbGiaPhong.Text = giaPhong.ToString(); // Hiển thị giá phòng trong Label
                            }
                            else
                            {
                                lbGiaPhong.Text = "N/A"; // Nếu không tìm thấy giá phòng, hiển thị "N/A"
                            }
                        }
                    }
                }
            }
        }

        private void LoadDataToComboBoxLoaiPhong()
        {
            // Load dữ liệu từ bảng LoaiPhong vào ComboBox LoaiPhong
            string queryLoaiPhong = @"SELECT LoaiPhongID, TenLoai FROM LoaiPhong";

            using (SqlConnection connection = connectionClass.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(queryLoaiPhong, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int maLoaiPhong = reader.GetInt32(0);
                            string tenLoaiPhong = reader.GetString(1);

                            cbbLoaiPhong.Items.Add(new LoaiPhong(maLoaiPhong, tenLoaiPhong));

                            // Tạo danh sách phòng trống cho mỗi loại phòng
                            phongLoaiPhongDictionary.Add(maLoaiPhong, new List<int>());
                        }
                    }
                }
            }
        }

       

        private void LoadDataToComboBox()
        {
            string queryLoaiPhong = @"SELECT LoaiPhongID, TenLoai FROM LoaiPhong"; 

            using (SqlConnection connection = connectionClass.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(queryLoaiPhong, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int maLoaiPhong = reader.GetInt32(0);
                            string tenLoaiPhong = reader.GetString(1);

                            cbbLoaiPhong.Items.Add(new LoaiPhong(maLoaiPhong, tenLoaiPhong));
                        }
                    }
                }
            }

            // Load dữ liệu từ bảng Phong vào ComboBox Phong và xây dựng từ điển phòng-loại phòng
            string queryPhong = @"SELECT PhongID, LoaiPhongID FROM Phong";

            using (SqlConnection connection = connectionClass.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(queryPhong, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        phongLoaiPhongDictionary = new Dictionary<int, List<int>>();

                        while (reader.Read())
                        {
                            int maPhong = reader.GetInt32(0);
                            int maLoaiPhong = reader.GetInt32(1);

                            cbbMaPhong.Items.Add(maPhong);

                            if (phongLoaiPhongDictionary.ContainsKey(maLoaiPhong))
                            {
                                phongLoaiPhongDictionary[maLoaiPhong].Add(maPhong);
                            }
                            else
                            {
                                phongLoaiPhongDictionary.Add(maLoaiPhong, new List<int> { maPhong });
                            }
                        }
                    }
                }
            }
            
        }


        private void cbbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiPhong.SelectedItem != null)
            {
                int maLoaiPhong = ((LoaiPhong)cbbLoaiPhong.SelectedItem).MaLoaiPhong;

                // Xóa tất cả các phòng hiện tại trong ComboBox Phong
                cbbMaPhong.Items.Clear();

                // Thêm các phòng tương ứng với loại phòng vào ComboBox Phong
                if (phongLoaiPhongDictionary.ContainsKey(maLoaiPhong))
                {
                    List<int> phongs = phongLoaiPhongDictionary[maLoaiPhong];
                    // cbbMaPhong.Items.AddRange(phongs.ToArray());
                    foreach (int phong in phongs)
                    {
                        cbbMaPhong.Items.Add(phong);
                    }
                }
            }
            

        }
        private void LoadBookingNames()
        {
            

            string query = @"SELECT TenBooking FROM Booking";

            using (SqlConnection connection = connectionClass.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string bookingName = reader.GetString(0);

                    // Add each booking name to the ComboBox
                    cbbTenbooking.Items.Add(bookingName);
                }

                reader.Close();
            }
        }
    }
    }

