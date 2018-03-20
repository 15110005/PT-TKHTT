using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoang_Tin
{
    public partial class frmMain : Form
    {
        string strMaNV;
        string strTenNV;
        Boolean bolLaAdmin;
        public static string staticMaNV;


        public string MaNV
        {
            get { return strMaNV; }
            set { strMaNV = value; }
        }
        public string TenNV
        {
            get { return strTenNV; }
            set { strTenNV = value; }
        }      
        public Boolean LaAdmin
        {
            get { return bolLaAdmin; }
            set { bolLaAdmin = value; }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {            
            lblTenNV.Text = TenNV;
            lblMaNV.Text = MaNV;            
            staticMaNV = MaNV;
            if (!LaAdmin)
            {
                mnuHeThong.Enabled = false;                
                mnuThongKe.Enabled = false;
                mnuNhapGia.Enabled = false;                
            }            
        }

        private void mnuBanHang_Click(object sender, EventArgs e)
        {
            frmBan frmchitietban = new frmBan();
            frmchitietban.Show();
        }

        private void mnuDSNhanvien_Click(object sender, EventArgs e)
        {
            frmNhanVien frmnhanvien = new frmNhanVien();
            frmnhanvien.Show();
        }
        private void mnuNhapGia_Click(object sender, EventArgs e)
        {
            hoanghoaban hoanghoaban = new hoanghoaban();
            hoanghoaban.Show();
        }

        private void dangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void mnuTKeBanHang_Click(object sender, EventArgs e)
        {
            slhangban slhang = new slhangban();
            slhang.Show();
        }

        private void mnuTKeHangTrongKho_Click(object sender, EventArgs e)
        {

            sldanhthu slhban = new sldanhthu();
            slhban.Show();
        }
    }
}
