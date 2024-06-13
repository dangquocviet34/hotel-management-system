
namespace QuanLyKhachSan
{
    partial class frmManHinhChinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManHinhChinh));
            this.btnDatPhongMain = new System.Windows.Forms.Button();
            this.btnThongKeDoanhThu = new System.Windows.Forms.Button();
            this.btnQuanLy = new System.Windows.Forms.Button();
            this.pnPhanMemQL = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.btnThoatPMQLKS = new System.Windows.Forms.Button();
            this.pnPhanMemQL.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDatPhongMain
            // 
            this.btnDatPhongMain.BackColor = System.Drawing.Color.BurlyWood;
            this.btnDatPhongMain.Font = new System.Drawing.Font("Constantia", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhongMain.Location = new System.Drawing.Point(34, 2);
            this.btnDatPhongMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDatPhongMain.Name = "btnDatPhongMain";
            this.btnDatPhongMain.Size = new System.Drawing.Size(267, 68);
            this.btnDatPhongMain.TabIndex = 0;
            this.btnDatPhongMain.Text = "Đặt phòng ";
            this.btnDatPhongMain.UseVisualStyleBackColor = false;
            this.btnDatPhongMain.Click += new System.EventHandler(this.btnDatPhongMain_Click);
            // 
            // btnThongKeDoanhThu
            // 
            this.btnThongKeDoanhThu.BackColor = System.Drawing.Color.BurlyWood;
            this.btnThongKeDoanhThu.Font = new System.Drawing.Font("Constantia", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeDoanhThu.Location = new System.Drawing.Point(623, 2);
            this.btnThongKeDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongKeDoanhThu.Name = "btnThongKeDoanhThu";
            this.btnThongKeDoanhThu.Size = new System.Drawing.Size(267, 68);
            this.btnThongKeDoanhThu.TabIndex = 8;
            this.btnThongKeDoanhThu.Text = "Thống kê doanh thu";
            this.btnThongKeDoanhThu.UseVisualStyleBackColor = false;
            this.btnThongKeDoanhThu.Click += new System.EventHandler(this.btnThongKeDoanhThu_Click);
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.BackColor = System.Drawing.Color.BurlyWood;
            this.btnQuanLy.Font = new System.Drawing.Font("Constantia", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLy.Location = new System.Drawing.Point(329, 2);
            this.btnQuanLy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Size = new System.Drawing.Size(267, 68);
            this.btnQuanLy.TabIndex = 10;
            this.btnQuanLy.Text = "Quản lý khách sạn";
            this.btnQuanLy.UseVisualStyleBackColor = false;
            this.btnQuanLy.Click += new System.EventHandler(this.btnQuanLy_Click);
            // 
            // pnPhanMemQL
            // 
            this.pnPhanMemQL.BackColor = System.Drawing.Color.Transparent;
            this.pnPhanMemQL.Controls.Add(this.btnQuanLy);
            this.pnPhanMemQL.Controls.Add(this.btnDatPhongMain);
            this.pnPhanMemQL.Controls.Add(this.btnThongKeDoanhThu);
            this.pnPhanMemQL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(105)))), ((int)(((byte)(20)))));
            this.pnPhanMemQL.Location = new System.Drawing.Point(0, 254);
            this.pnPhanMemQL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnPhanMemQL.Name = "pnPhanMemQL";
            this.pnPhanMemQL.Size = new System.Drawing.Size(913, 74);
            this.pnPhanMemQL.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(79)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbWelcome);
            this.panel1.Location = new System.Drawing.Point(-7, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 242);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(74, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(728, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ KHÁCH SẠN";
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lbWelcome.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(105)))), ((int)(((byte)(20)))));
            this.lbWelcome.Location = new System.Drawing.Point(271, 74);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(324, 49);
            this.lbWelcome.TabIndex = 0;
            this.lbWelcome.Text = "WELCOME TO...";
            // 
            // btnThoatPMQLKS
            // 
            this.btnThoatPMQLKS.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnThoatPMQLKS.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatPMQLKS.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnThoatPMQLKS.Location = new System.Drawing.Point(790, 426);
            this.btnThoatPMQLKS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoatPMQLKS.Name = "btnThoatPMQLKS";
            this.btnThoatPMQLKS.Size = new System.Drawing.Size(123, 35);
            this.btnThoatPMQLKS.TabIndex = 13;
            this.btnThoatPMQLKS.Text = "Thoát";
            this.btnThoatPMQLKS.UseVisualStyleBackColor = false;
            this.btnThoatPMQLKS.Click += new System.EventHandler(this.btnThoatPMQLKS_Click);
            // 
            // frmManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(913, 461);
            this.Controls.Add(this.btnThoatPMQLKS);
            this.Controls.Add(this.pnPhanMemQL);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmManHinhChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý Khách sạn";
            this.Load += new System.EventHandler(this.frmTableManage_Load);
            this.pnPhanMemQL.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDatPhongMain;
        private System.Windows.Forms.Button btnThongKeDoanhThu;
        private System.Windows.Forms.Button btnQuanLy;
        private System.Windows.Forms.Panel pnPhanMemQL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Button btnThoatPMQLKS;
        private System.Windows.Forms.Label label1;
    }
}