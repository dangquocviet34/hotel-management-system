using QuanLyKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmThongTinCaNhan : Form
    {
        
        public frmThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void btnCapNhatMK_Click(object sender, EventArgs e)
        {
            string username1 = txbTenTK.Text;
            string password1 = txbMatKhau.Text;
            string passwordnew = txbMKMoi.Text;
            string confirmpassword = txbNhapLaiMK.Text;

            if (Login(username1, password1))
            {
                capnhat(username1, passwordnew, confirmpassword);
                txbTenTK.Clear();
                txbMatKhau.Clear();
                txbMKMoi.Clear();
                txbNhapLaiMK.Clear();
                
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbTenTK.Clear();
                txbMatKhau.Clear();
                txbMKMoi.Clear();
                txbNhapLaiMK.Clear();
                txbTenTK.Focus();

            }
        }
        bool Login(string username, string password)
        {
            return AccountDAO.Instance1.Login(username, password);
        }

        private void capnhat(string username, string passwordnew, string confirmpassword)
        {
            if(passwordnew == confirmpassword)
            {
                string query = @"update [dbo].[MatKhau] set [password] = '"+ passwordnew + "' WHERE [username] = '"+ username+ "'";
                if (AccountDAO.Instance1.UpdatePassword(username, passwordnew, query))
                {
                    MessageBox.Show("Cập nhật mật khẩu thành công");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        
    }
}
