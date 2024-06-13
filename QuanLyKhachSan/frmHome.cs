using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyKhachSan
{
    public partial class frmHome : Form
    {
        
        SqlConnection connection ;
        SqlCommand command;
       
        
        public frmHome()
        {
            InitializeComponent();
            
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinCaNhan TTCN = new frmThongTinCaNhan();
            this.Hide();
            TTCN.ShowDialog();
            this.Show();
        }

        private void btnExitHome_Click(object sender, EventArgs e)
        {
            frmManHinhChinh MHC = new frmManHinhChinh();
            this.Hide();
            MHC.ShowDialog();
            this.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLy QL = new frmQuanLy();
            this.Hide();
            QL.ShowDialog();
        }

        private void btnChiTiet1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            LoadHienThiphong1(1);
            LoadHienThiphong2(2);
            LoadHienThiphong3(3);
            LoadHienThiphong4(4);
            LoadHienThiphong5(5);
            LoadHienThiphong6(6);
            LoadHienThiphong7(7);
            LoadHienThiphong8(8);
        }

        private void cbbPhongH1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            string trangThai = cbbPhongH1.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Ở":
                    pn_Phong1.BackColor = Color.OrangeRed;
                    break;
                case "Phòng Trả":
                    pn_Phong1.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    pn_Phong1.BackColor = Color.SpringGreen;
                    break;
                case "Phòng Đang Dọn":
                    pn_Phong1.BackColor = Color.LightSteelBlue;
                    break;
            }
        }
        private void btnChiTiet1_Click_1(object sender, EventArgs e)
        {
            frmPhieuDatphong PDP = new frmPhieuDatphong();
            this.Hide();
            PDP.ShowDialog();
            this.Show();
        }
        private void btnChiTiet2_Click(object sender, EventArgs e)
        {
            frmPhieuDatphong PDP = new frmPhieuDatphong();
            this.Hide();
            PDP.ShowDialog();
            this.Show();
        }

        private void btnChiTiet3_Click(object sender, EventArgs e)
        {
            frmPhieuDatphong PDP = new frmPhieuDatphong();
            this.Hide();
            PDP.ShowDialog();
            this.Show();
        }

        private void btnChiTiet4_Click(object sender, EventArgs e)
        {
            frmPhieuDatphong PDP = new frmPhieuDatphong();
            this.Hide();
            PDP.ShowDialog();
            this.Show();
        }

        private void btnChiTiet5_Click(object sender, EventArgs e)
        {
            frmPhieuDatphong PDP = new frmPhieuDatphong();
            this.Hide();
            PDP.ShowDialog();
            this.Show();
        }

        private void btnChiTiet6_Click(object sender, EventArgs e)
        {
            frmPhieuDatphong PDP = new frmPhieuDatphong();
            this.Hide();
            PDP.ShowDialog();
            this.Show();
        }

        private void btnChiTiet7_Click(object sender, EventArgs e)
        {
            frmPhieuDatphong PDP = new frmPhieuDatphong();
            this.Hide();
            PDP.ShowDialog();
            this.Show();
        }

        private void btnChiTiet8_Click(object sender, EventArgs e)
        {
            frmPhieuDatphong PDP = new frmPhieuDatphong();
            this.Hide();
            PDP.ShowDialog();
            this.Show();
        }

        private void cbbPhongH2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cbbPhongH2.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Ở":
                    pn_Phong2.BackColor = Color.OrangeRed;
                    break;
                case "Phòng Trả":
                    pn_Phong2.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    pn_Phong2.BackColor = Color.SpringGreen;
                    break;
                case "Phòng Đang Dọn":
                    pn_Phong2.BackColor = Color.LightSteelBlue;
                    break;
            }
        }

        private void cbbPhongH3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cbbPhongH3.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Ở":
                    pn_Phong3.BackColor = Color.OrangeRed;
                    break;
                case "Phòng Trả":
                    pn_Phong3.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    pn_Phong3.BackColor = Color.SpringGreen;
                    break;
                case "Phòng Đang Dọn":
                    pn_Phong3.BackColor = Color.LightSteelBlue;
                    break;
            }
        }

        private void cbbPhongH4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cbbPhongH4.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Ở":
                    pn_Phong4.BackColor = Color.OrangeRed;
                    break;
                case "Phòng Trả":
                    pn_Phong4.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    pn_Phong4.BackColor = Color.SpringGreen;
                    break;
                case "Phòng Đang Dọn":
                    pn_Phong4.BackColor = Color.LightSteelBlue;
                    break;
            }
        }

        private void cbbPhongH5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cbbPhongH5.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Ở":
                    pn_Phong5.BackColor = Color.OrangeRed;
                    break;
                case "Phòng Trả":
                    pn_Phong5.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    pn_Phong5.BackColor = Color.SpringGreen;
                    break;
                case "Phòng Đang Dọn":
                    pn_Phong5.BackColor = Color.LightSteelBlue;
                    break;
            }
        }

        private void cbbPhongH6_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cbbPhongH6.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Ở":
                    pn_Phong6.BackColor = Color.OrangeRed;
                    break;
                case "Phòng Trả":
                    pn_Phong6.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    pn_Phong6.BackColor = Color.SpringGreen;
                    break;
                case "Phòng Đang Dọn":
                    pn_Phong6.BackColor = Color.LightSteelBlue;
                    break;
            }
        }

        private void cbbPhongH7_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cbbPhongH7.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Ở":
                    pn_Phong7.BackColor = Color.OrangeRed;
                    break;
                case "Phòng Trả":
                    pn_Phong7.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    pn_Phong7.BackColor = Color.SpringGreen;
                    break;
                case "Phòng Đang Dọn":
                    pn_Phong7.BackColor = Color.LightSteelBlue;
                    break;
            }
        }

        private void cbbPhongH8_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cbbPhongH8.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Ở":
                    pn_Phong8.BackColor = Color.OrangeRed;
                    break;
                case "Phòng Trả":
                    pn_Phong8.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    pn_Phong8.BackColor = Color.SpringGreen;
                    break;
                case "Phòng Đang Dọn":
                    pn_Phong8.BackColor = Color.LightSteelBlue;
                    break;
            }
        }

        private void btnCheckOut1_Click(object sender, EventArgs e)
        {
            lbNoiDungTenBooking1.Text = ".................................";
            lbNoiDungHovTenH1.Text = ".................................";
            lbNoiDungSDTKh1.Text = ".................................";
            lbNoiDungTenBooking1.Text = ".................................";
            lbNoiDungCheckInH1.Text = ".................................";
            lbNoiDungCheckOutH1.Text = ".................................";
           
            pn_Phong1.BackColor = Color.SpringGreen;
        }

        private void btnCheckOut2_Click(object sender, EventArgs e)
        {
            lbNoiDungTenBooking2.Text = ".................................";
            lbNoiDungHovTenH2.Text = ".................................";
            lbNoiDungSDTKh2.Text = ".................................";
            lbNoiDungTenBooking2.Text = ".................................";
            lbNoiDungCheckInH2.Text = ".................................";
            lbNoiDungCheckOutH2.Text = ".................................";

            pn_Phong2.BackColor = Color.SpringGreen;
        }

        private void btnCheckOut3_Click(object sender, EventArgs e)
        {
            lbNoiDungTenBooking3.Text = ".................................";
            lbNoiDungHovTenH3.Text = ".................................";
            lbNoiDungSDTKh3.Text = ".................................";
            lbNoiDungTenBooking3.Text = ".................................";
            lbNoiDungCheckInH3.Text = ".................................";
            lbNoiDungCheckOutH3.Text = ".................................";

            pn_Phong3.BackColor = Color.SpringGreen;
        }

        private void btnCheckOut4_Click(object sender, EventArgs e)
        {
            lbNoiDungTenBooking4.Text = ".................................";
            lbNoiDungHovTenH4.Text = ".................................";
            lbNoiDungSDTKh4.Text = ".................................";
            lbNoiDungTenBooking4.Text = ".................................";
            lbNoiDungCheckInH4.Text = ".................................";
            lbNoiDungCheckOutH4.Text = ".................................";

            pn_Phong4.BackColor = Color.SpringGreen;
        }

        private void btnCheckOut5_Click(object sender, EventArgs e)
        {
            lbNoiDungTenBooking5.Text = ".................................";
            lbNoiDungHovTenH5.Text = ".................................";
            lbNoiDungSDTKh5.Text = ".................................";
            lbNoiDungTenBooking5.Text = ".................................";
            lbNoiDungCheckInH5.Text = ".................................";
            lbNoiDungCheckOutH5.Text = ".................................";

            pn_Phong5.BackColor = Color.SpringGreen;
        }

        private void btnCheckOut6_Click(object sender, EventArgs e)
        {
            lbNoiDungTenBooking6.Text = ".................................";
            lbNoiDungHovTenH6.Text = ".................................";
            lbNoiDungSDTKh6.Text = ".................................";
            lbNoiDungTenBooking6.Text = ".................................";
            lbNoiDungCheckInH6.Text = ".................................";
            lbNoiDungCheckOutH6.Text = ".................................";

            pn_Phong6.BackColor = Color.SpringGreen;
        }

        private void btnCheckOut7_Click(object sender, EventArgs e)
        {
            lbNoiDungTenBooking7.Text = ".................................";
            lbNoiDungHovTenH7.Text = ".................................";
            lbNoiDungSDTKh7.Text = ".................................";
            lbNoiDungTenBooking7.Text = ".................................";
            lbNoiDungCheckInH7.Text = ".................................";
            lbNoiDungCheckOutH7.Text = ".................................";

            pn_Phong7.BackColor = Color.SpringGreen;
        }

        private void btnCheckOut8_Click(object sender, EventArgs e)
        {
            lbNoiDungTenBooking8.Text = ".................................";
            lbNoiDungHovTenH8.Text = ".................................";
            lbNoiDungSDTKh8.Text = ".................................";
            lbNoiDungTenBooking8.Text = ".................................";
            lbNoiDungCheckInH8.Text = ".................................";
            lbNoiDungCheckOutH8.Text = ".................................";

            pn_Phong8.BackColor = Color.SpringGreen;
        }

       
        private void LoadHienThiphong1(int MaPhong)
        {
            using (connection = connectionClass.GetConnection())
            {
                connection.Open();
                string query = @"SELECT HD.TenBooking, KH.TenKH, HD.SoKhach, HD.dateCheckIn, HD.dateCheckOut, P.PhongID, LP.TenLoai
	    FROM
		    (SELECT TenBooking, KhachHangID, PhongID, SoKhach, dateCheckIn, dateCheckOut 
		    FROM HoaDon 
		    WHERE DATEDIFF(day, GETDATE(), dateCheckOut) >= 0) AS HD
	    JOIN KhachHang AS KH ON KH.KhachHangID = HD.KhachHangID
	    JOIN Phong AS P ON P.PhongID = HD.PhongID
	    JOIN LoaiPhong AS LP ON P.LoaiPhongID = LP.LoaiPhongID
    WHERE P.PhongID = '" + MaPhong + "';";
                using (command = new SqlCommand(query, connection))
                {
                    // Thực thi truy vấn và lấy dữ liệu
                    SqlDataReader reader = command.ExecuteReader();

                    // Đọc dữ liệu từ SqlDataReader và gán cho các biến tương ứng
                    while (reader.Read())
                    {
                        lbNoiDungTenBooking1.Text = reader["TenBooking"].ToString();
                        lbNoiDungHovTenH1.Text = reader["TenKH"].ToString();
                        lbNoiDungSDTKh1.Text = reader["SoKhach"].ToString();
                        lbNoiDungCheckInH1.Text = reader["dateCheckIn"].ToString();
                        lbNoiDungCheckOutH1.Text = reader["dateCheckOut"].ToString();
                        int IDPhong = Convert.ToInt32(reader["PhongID"]);
                        string LoaiPhong = reader["TenLoai"].ToString();

                        pn_Phong1.BackColor = Color.OrangeRed;
                        
                        bool ketQua1 = string.Equals(LoaiPhong, "Standard", StringComparison.OrdinalIgnoreCase);
                        if (ketQua1)
                        {
                            lbPhong1.Text = "Standard";
                            lbPhong1.BackColor = Color.Linen;
                            pnLoaiPhong1.BackColor = Color.Linen;
                              
                        }
                        else 
                        {
                            bool ketQua2 = string.Equals(LoaiPhong, "Deluxe", StringComparison.OrdinalIgnoreCase);
                            if (ketQua2)
                            {
                                lbPhong1.Text = "Deluxe";
                                lbPhong1.BackColor = Color.DarkSalmon;
                                pnLoaiPhong1.BackColor = Color.DarkSalmon;
                            }
                            else
                            {
                                lbPhong1.Text = "Superior";
                                lbPhong1.BackColor = Color.PeachPuff;
                                pnLoaiPhong1.BackColor = Color.PeachPuff;
                            }

                        }
                    }

                    reader.Close();


                }
                connection.Close();
            }
        }

        private void LoadHienThiphong2(int MaPhong)
        {
            using (connection = connectionClass.GetConnection())
            {
                connection.Open();
                string query = @"SELECT HD.TenBooking, KH.TenKH, HD.SoKhach, HD.dateCheckIn, HD.dateCheckOut, P.PhongID, LP.TenLoai
	    FROM
		    (SELECT TenBooking, KhachHangID, PhongID, SoKhach, dateCheckIn, dateCheckOut 
		    FROM HoaDon 
		    WHERE DATEDIFF(day, GETDATE(), dateCheckOut) >= 0) AS HD
	    JOIN KhachHang AS KH ON KH.KhachHangID = HD.KhachHangID
	    JOIN Phong AS P ON P.PhongID = HD.PhongID
	    JOIN LoaiPhong AS LP ON P.LoaiPhongID = LP.LoaiPhongID
    WHERE P.PhongID = '" + MaPhong + "';";
                using (command = new SqlCommand(query, connection))
                {
                    // Thực thi truy vấn và lấy dữ liệu
                    SqlDataReader reader = command.ExecuteReader();

                    // Đọc dữ liệu từ SqlDataReader và gán cho các biến tương ứng
                    while (reader.Read())
                    {
                        //2
                        lbNoiDungTenBooking2.Text = reader["TenBooking"].ToString();
                        lbNoiDungHovTenH2.Text = reader["TenKH"].ToString();
                        lbNoiDungSDTKh2.Text = reader["SoKhach"].ToString();
                        lbNoiDungCheckInH2.Text = reader["dateCheckIn"].ToString();
                        lbNoiDungCheckOutH2.Text = reader["dateCheckOut"].ToString();

                        int IDPhong = Convert.ToInt32(reader["PhongID"]);
                        string LoaiPhong = reader["TenLoai"].ToString();

                        pn_Phong2.BackColor = Color.OrangeRed;
                        bool ketQua1 = string.Equals(LoaiPhong, "Standard", StringComparison.OrdinalIgnoreCase);
                        if (ketQua1)
                        {
                            lbPhong2.Text = "Standard";
                            lbPhong2.BackColor = Color.Linen;
                            pnLoaiPhong2.BackColor = Color.Linen;

                        }
                        else
                        {
                            bool ketQua2 = string.Equals(LoaiPhong, "Deluxe", StringComparison.OrdinalIgnoreCase);
                            if (ketQua2)
                            {
                                lbPhong2.Text = "Deluxe";
                                lbPhong2.BackColor = Color.DarkSalmon;
                                pnLoaiPhong2.BackColor = Color.DarkSalmon;
                            }
                            else
                            {
                                lbPhong2.Text = "Superior";
                                lbPhong2.BackColor = Color.PeachPuff;
                                pnLoaiPhong2.BackColor = Color.PeachPuff;
                            }

                        }

                    }

                    reader.Close();


                }
                connection.Close();
            }
        }

        private void LoadHienThiphong3(int MaPhong)
        {
            using (connection = connectionClass.GetConnection())
            {
                connection.Open();
                string query = @"SELECT HD.TenBooking, KH.TenKH, HD.SoKhach, HD.dateCheckIn, HD.dateCheckOut, P.PhongID, LP.TenLoai
	    FROM
		    (SELECT TenBooking, KhachHangID, PhongID, SoKhach, dateCheckIn, dateCheckOut 
		    FROM HoaDon 
		    WHERE DATEDIFF(day, GETDATE(), dateCheckOut) >= 0) AS HD
	    JOIN KhachHang AS KH ON KH.KhachHangID = HD.KhachHangID
	    JOIN Phong AS P ON P.PhongID = HD.PhongID
	    JOIN LoaiPhong AS LP ON P.LoaiPhongID = LP.LoaiPhongID
    WHERE P.PhongID = '" + MaPhong + "';";
                using (command = new SqlCommand(query, connection))
                {
                    // Thực thi truy vấn và lấy dữ liệu
                    SqlDataReader reader = command.ExecuteReader();

                    // Đọc dữ liệu từ SqlDataReader và gán cho các biến tương ứng
                    while (reader.Read())
                    {
                        //3
                        lbNoiDungTenBooking3.Text = reader["TenBooking"].ToString();
                        lbNoiDungHovTenH3.Text = reader["TenKH"].ToString();
                        lbNoiDungSDTKh3.Text = reader["SoKhach"].ToString();
                        lbNoiDungCheckInH3.Text = reader["dateCheckIn"].ToString();
                        lbNoiDungCheckOutH3.Text = reader["dateCheckOut"].ToString();
                        int IDPhong = Convert.ToInt32(reader["PhongID"]);
                        string LoaiPhong = reader["TenLoai"].ToString();
                        pn_Phong3.BackColor = Color.OrangeRed;
                        bool ketQua1 = string.Equals(LoaiPhong, "Standard", StringComparison.OrdinalIgnoreCase);
                        if (ketQua1)
                        {
                            lbPhong3.Text = "Standard";
                            lbPhong3.BackColor = Color.Linen;
                            pnLoaiPhong3.BackColor = Color.Linen;

                        }
                        else
                        {
                            bool ketQua2 = string.Equals(LoaiPhong, "Deluxe", StringComparison.OrdinalIgnoreCase);
                            if (ketQua2)
                            {
                                lbPhong3.Text = "Deluxe";
                                lbPhong3.BackColor = Color.DarkSalmon;
                                pnLoaiPhong3.BackColor = Color.DarkSalmon;
                            }
                            else
                            {
                                lbPhong3.Text = "Superior";
                                lbPhong3.BackColor = Color.PeachPuff;
                                pnLoaiPhong3.BackColor = Color.PeachPuff;
                            }

                        }

                    }

                    reader.Close();


                }
                connection.Close();
            }
        }

        private void LoadHienThiphong4(int MaPhong)
        {
            using (connection = connectionClass.GetConnection())
            {
                connection.Open();
                string query = @"SELECT HD.TenBooking, KH.TenKH, HD.SoKhach, HD.dateCheckIn, HD.dateCheckOut, P.PhongID, LP.TenLoai
	    FROM
		    (SELECT TenBooking, KhachHangID, PhongID, SoKhach, dateCheckIn, dateCheckOut 
		    FROM HoaDon 
		    WHERE DATEDIFF(day, GETDATE(), dateCheckOut) >= 0) AS HD
	    JOIN KhachHang AS KH ON KH.KhachHangID = HD.KhachHangID
	    JOIN Phong AS P ON P.PhongID = HD.PhongID
	    JOIN LoaiPhong AS LP ON P.LoaiPhongID = LP.LoaiPhongID
    WHERE P.PhongID = '" + MaPhong + "';";
                using (command = new SqlCommand(query, connection))
                {
                    // Thực thi truy vấn và lấy dữ liệu
                    SqlDataReader reader = command.ExecuteReader();

                    // Đọc dữ liệu từ SqlDataReader và gán cho các biến tương ứng
                    while (reader.Read())
                    {

                        //4
                        lbNoiDungTenBooking4.Text = reader["TenBooking"].ToString();
                        lbNoiDungHovTenH4.Text = reader["TenKH"].ToString();
                        lbNoiDungSDTKh4.Text = reader["SoKhach"].ToString();
                        lbNoiDungCheckInH4.Text = reader["dateCheckIn"].ToString();
                        lbNoiDungCheckOutH4.Text = reader["dateCheckOut"].ToString();
                        int IDPhong = Convert.ToInt32(reader["PhongID"]);
                        string LoaiPhong = reader["TenLoai"].ToString();
                        pn_Phong4.BackColor = Color.OrangeRed;
                        bool ketQua1 = string.Equals(LoaiPhong, "Standard", StringComparison.OrdinalIgnoreCase);
                        if (ketQua1)
                        {
                            lbPhong4.Text = "Standard";
                            lbPhong4.BackColor = Color.Linen;
                            pnLoaiPhong4.BackColor = Color.Linen;

                        }
                        else
                        {
                            bool ketQua2 = string.Equals(LoaiPhong, "Deluxe", StringComparison.OrdinalIgnoreCase);
                            if (ketQua2)
                            {
                                lbPhong4.Text = "Deluxe";
                                lbPhong4.BackColor = Color.DarkSalmon;
                                pnLoaiPhong4.BackColor = Color.DarkSalmon;
                            }
                            else
                            {
                                lbPhong4.Text = "Superior";
                                lbPhong4.BackColor = Color.PeachPuff;
                                pnLoaiPhong4.BackColor = Color.PeachPuff;
                            }

                        }

                    }

                    reader.Close();


                }
                connection.Close();
            }
        }

        private void LoadHienThiphong5(int MaPhong)
        {
            using (connection = connectionClass.GetConnection())
            {
                connection.Open();
                string query = @"SELECT HD.TenBooking, KH.TenKH, HD.SoKhach, HD.dateCheckIn, HD.dateCheckOut, P.PhongID, LP.TenLoai
	    FROM
		    (SELECT TenBooking, KhachHangID, PhongID, SoKhach, dateCheckIn, dateCheckOut 
		    FROM HoaDon 
		    WHERE DATEDIFF(day, GETDATE(), dateCheckOut) >= 0) AS HD
	    JOIN KhachHang AS KH ON KH.KhachHangID = HD.KhachHangID
	    JOIN Phong AS P ON P.PhongID = HD.PhongID
	    JOIN LoaiPhong AS LP ON P.LoaiPhongID = LP.LoaiPhongID
    WHERE P.PhongID = '" + MaPhong + "';";
                using (command = new SqlCommand(query, connection))
                {
                    // Thực thi truy vấn và lấy dữ liệu
                    SqlDataReader reader = command.ExecuteReader();

                    // Đọc dữ liệu từ SqlDataReader và gán cho các biến tương ứng
                    while (reader.Read())
                    {

                        //5
                        lbNoiDungTenBooking5.Text = reader["TenBooking"].ToString();
                        lbNoiDungHovTenH5.Text = reader["TenKH"].ToString();
                        lbNoiDungSDTKh5.Text = reader["SoKhach"].ToString();
                        lbNoiDungCheckInH5.Text = reader["dateCheckIn"].ToString();
                        lbNoiDungCheckOutH5.Text = reader["dateCheckOut"].ToString();
                        int IDPhong = Convert.ToInt32(reader["PhongID"]);
                        string LoaiPhong = reader["TenLoai"].ToString();
                        pn_Phong5.BackColor = Color.OrangeRed;
                        bool ketQua1 = string.Equals(LoaiPhong, "Standard", StringComparison.OrdinalIgnoreCase);
                        if (ketQua1)
                        {
                            lbPhong5.Text = "Standard";
                            lbPhong5.BackColor = Color.Linen;
                            pnLoaiPhong5.BackColor = Color.Linen;

                        }
                        else
                        {
                            bool ketQua2 = string.Equals(LoaiPhong, "Deluxe", StringComparison.OrdinalIgnoreCase);
                            if (ketQua2)
                            {
                                lbPhong5.Text = "Deluxe";
                                lbPhong5.BackColor = Color.DarkSalmon;
                                pnLoaiPhong5.BackColor = Color.DarkSalmon;
                            }
                            else
                            {
                                lbPhong5.Text = "Superior";
                                lbPhong5.BackColor = Color.PeachPuff;
                                pnLoaiPhong5.BackColor = Color.PeachPuff;
                            }

                        }

                    }

                    reader.Close();


                }
                connection.Close();
            }
        }

        private void LoadHienThiphong6(int MaPhong)
        {
            using (connection = connectionClass.GetConnection())
            {
                connection.Open();
                string query = @"SELECT HD.TenBooking, KH.TenKH, HD.SoKhach, HD.dateCheckIn, HD.dateCheckOut, P.PhongID, LP.TenLoai
	    FROM
		    (SELECT TenBooking, KhachHangID, PhongID, SoKhach, dateCheckIn, dateCheckOut 
		    FROM HoaDon 
		    WHERE DATEDIFF(day, GETDATE(), dateCheckOut) >= 0) AS HD
	    JOIN KhachHang AS KH ON KH.KhachHangID = HD.KhachHangID
	    JOIN Phong AS P ON P.PhongID = HD.PhongID
	    JOIN LoaiPhong AS LP ON P.LoaiPhongID = LP.LoaiPhongID
    WHERE P.PhongID = '" + MaPhong + "';";
                using (command = new SqlCommand(query, connection))
                {
                    // Thực thi truy vấn và lấy dữ liệu
                    SqlDataReader reader = command.ExecuteReader();

                    // Đọc dữ liệu từ SqlDataReader và gán cho các biến tương ứng
                    while (reader.Read())
                    {

                        //6
                        lbNoiDungTenBooking6.Text = reader["TenBooking"].ToString();
                        lbNoiDungHovTenH6.Text = reader["TenKH"].ToString();
                        lbNoiDungSDTKh6.Text = reader["SoKhach"].ToString();
                        lbNoiDungCheckInH6.Text = reader["dateCheckIn"].ToString();
                        lbNoiDungCheckOutH6.Text = reader["dateCheckOut"].ToString();
                        int IDPhong = Convert.ToInt32(reader["PhongID"]);
                        string LoaiPhong = reader["TenLoai"].ToString();
                        pn_Phong6.BackColor = Color.OrangeRed;
                        bool ketQua1 = string.Equals(LoaiPhong, "Standard", StringComparison.OrdinalIgnoreCase);
                        if (ketQua1)
                        {
                            lbPhong6.Text = "Standard";
                            lbPhong6.BackColor = Color.Linen;
                            pnLoaiPhong6.BackColor = Color.Linen;

                        }
                        else
                        {
                            bool ketQua2 = string.Equals(LoaiPhong, "Deluxe", StringComparison.OrdinalIgnoreCase);
                            if (ketQua2)
                            {
                                lbPhong6.Text = "Deluxe";
                                lbPhong6.BackColor = Color.DarkSalmon;
                                pnLoaiPhong6.BackColor = Color.DarkSalmon;
                            }
                            else
                            {
                                lbPhong6.Text = "Superior";
                                lbPhong6.BackColor = Color.PeachPuff;
                                pnLoaiPhong6.BackColor = Color.PeachPuff;
                            }

                        }

                    }

                    reader.Close();


                }
                connection.Close();
            }
        }

        private void LoadHienThiphong7(int MaPhong)
        {
            using (connection = connectionClass.GetConnection())
            {
                connection.Open();
                string query = @"SELECT HD.TenBooking, KH.TenKH, HD.SoKhach, HD.dateCheckIn, HD.dateCheckOut, P.PhongID, LP.TenLoai
	    FROM
		    (SELECT TenBooking, KhachHangID, PhongID, SoKhach, dateCheckIn, dateCheckOut 
		    FROM HoaDon 
		    WHERE DATEDIFF(day, GETDATE(), dateCheckOut) >= 0) AS HD
	    JOIN KhachHang AS KH ON KH.KhachHangID = HD.KhachHangID
	    JOIN Phong AS P ON P.PhongID = HD.PhongID
	    JOIN LoaiPhong AS LP ON P.LoaiPhongID = LP.LoaiPhongID
    WHERE P.PhongID = '" + MaPhong + "';";
                using (command = new SqlCommand(query, connection))
                {
                    // Thực thi truy vấn và lấy dữ liệu
                    SqlDataReader reader = command.ExecuteReader();

                    // Đọc dữ liệu từ SqlDataReader và gán cho các biến tương ứng
                    while (reader.Read())
                    {
                        //7
                        lbNoiDungTenBooking7.Text = reader["TenBooking"].ToString();
                        lbNoiDungHovTenH7.Text = reader["TenKH"].ToString();
                        lbNoiDungSDTKh7.Text = reader["SoKhach"].ToString();
                        lbNoiDungCheckInH7.Text = reader["dateCheckIn"].ToString();
                        lbNoiDungCheckOutH7.Text = reader["dateCheckOut"].ToString();
                        int IDPhong = Convert.ToInt32(reader["PhongID"]);
                        string LoaiPhong = reader["TenLoai"].ToString();
                        pn_Phong7.BackColor = Color.OrangeRed;
                        bool ketQua1 = string.Equals(LoaiPhong, "Standard", StringComparison.OrdinalIgnoreCase);
                        if (ketQua1)
                        {
                            lbPhong7.Text = "Standard";
                            lbPhong7.BackColor = Color.Linen;
                            pnLoaiPhong7.BackColor = Color.Linen;

                        }
                        else
                        {
                            bool ketQua2 = string.Equals(LoaiPhong, "Deluxe", StringComparison.OrdinalIgnoreCase);
                            if (ketQua2)
                            {
                                lbPhong7.Text = "Deluxe";
                                lbPhong7.BackColor = Color.DarkSalmon;
                                pnLoaiPhong7.BackColor = Color.DarkSalmon;
                            }
                            else
                            {
                                lbPhong7.Text = "Superior";
                                lbPhong7.BackColor = Color.PeachPuff;
                                pnLoaiPhong7.BackColor = Color.PeachPuff;
                            }

                        }

                    }

                    reader.Close();


                }
                connection.Close();
            }
        }
        private void LoadHienThiphong8(int MaPhong)
        {
            using (connection = connectionClass.GetConnection())
            {
                connection.Open();
                string query = @"SELECT HD.TenBooking, KH.TenKH, HD.SoKhach, HD.dateCheckIn, HD.dateCheckOut, P.PhongID, LP.TenLoai
	    FROM
		    (SELECT TenBooking, KhachHangID, PhongID, SoKhach, dateCheckIn, dateCheckOut 
		    FROM HoaDon 
		    WHERE DATEDIFF(day, GETDATE(), dateCheckOut) >= 0) AS HD
	    JOIN KhachHang AS KH ON KH.KhachHangID = HD.KhachHangID
	    JOIN Phong AS P ON P.PhongID = HD.PhongID
	    JOIN LoaiPhong AS LP ON P.LoaiPhongID = LP.LoaiPhongID
    WHERE P.PhongID = '" + MaPhong + "';";
                using (command = new SqlCommand(query, connection))
                {
                    // Thực thi truy vấn và lấy dữ liệu
                    SqlDataReader reader = command.ExecuteReader();

                    // Đọc dữ liệu từ SqlDataReader và gán cho các biến tương ứng
                    while (reader.Read())
                    {
                        //8
                        lbNoiDungTenBooking8.Text = reader["TenBooking"].ToString();
                        lbNoiDungHovTenH8.Text = reader["TenKH"].ToString();
                        lbNoiDungSDTKh8.Text = reader["SoKhach"].ToString();
                        lbNoiDungCheckInH8.Text = reader["dateCheckIn"].ToString();
                        lbNoiDungCheckOutH8.Text = reader["dateCheckOut"].ToString();
                        int IDPhong = Convert.ToInt32(reader["PhongID"]);
                        pn_Phong8.BackColor = Color.OrangeRed;
                        string LoaiPhong = reader["TenLoai"].ToString();
                        bool ketQua1 = string.Equals(LoaiPhong, "Standard", StringComparison.OrdinalIgnoreCase);
                        if (ketQua1)
                        {
                            lbPhong8.Text = "Standard";
                            lbPhong8.BackColor = Color.Linen;
                            pnLoaiPhong8.BackColor = Color.Linen;

                        }
                        else
                        {
                            bool ketQua2 = string.Equals(LoaiPhong, "Deluxe", StringComparison.OrdinalIgnoreCase);
                            if (ketQua2)
                            {
                                lbPhong8.Text = "Deluxe";
                                lbPhong8.BackColor = Color.DarkSalmon;
                                pnLoaiPhong8.BackColor = Color.DarkSalmon;
                            }
                            else
                            {
                                lbPhong8.Text = "Superior";
                                lbPhong8.BackColor = Color.PeachPuff;
                                pnLoaiPhong8.BackColor = Color.PeachPuff;
                            }

                        }


                    }

                    reader.Close();


                }
                connection.Close();
            }
        }

    }
}
