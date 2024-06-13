using QuanLyKhachSan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cập_Nhật_dịch_vụ
{
    public partial class frmCNDV : Form
    {
        public frmCNDV()
        {
            InitializeComponent();
        }

        

        private void frmCNDV_Load(object sender, EventArgs e)
        {

        }

        private void btnThoatDichVu_Click(object sender, EventArgs e)
        {
            frmQuanLy QLthoat = new frmQuanLy();
            this.Hide();
            QLthoat.ShowDialog();
        }
    }
}
