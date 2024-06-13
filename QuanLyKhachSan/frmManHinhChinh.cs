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
    public partial class frmManHinhChinh : Form
    {
        public frmManHinhChinh()
        {
            InitializeComponent();
        }

        private void btnDatPhongMain_Click(object sender, EventArgs e)
        {
            frmPhieuDatphong DP = new frmPhieuDatphong();
            this.Hide();
            DP.ShowDialog();
            this.Show();
            
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome h = new frmHome();
            h.ShowDialog();
            
        }

        private void btnSuDungDichVuMain_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {

        }

        private void frmTableManage_Load(object sender, EventArgs e)
        {

        }

        private void btnThoatPMQLKS_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
