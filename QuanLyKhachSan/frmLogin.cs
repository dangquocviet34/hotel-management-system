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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn thực sự muốn thoát?","Thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            frmManHinhChinh mhc = new frmManHinhChinh();
            this.Hide();
            mhc.ShowDialog();
            this.Show();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            string username = txbAccount.Text;
            string password = txbPassWord.Text;
            if (Login(username, password))
            {
                frmManHinhChinh mhc = new frmManHinhChinh();
                this.Hide();
                mhc.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
        bool Login(string username, string password)
        {
            return AccountDAO.Instance1.Login(username, password);
        }
    }
}
