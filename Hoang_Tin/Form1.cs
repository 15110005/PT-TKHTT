using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Configuration;

namespace Hoang_Tin
{
    public partial class Form1 : Form
    {
        clsBNhanVien objBNhanVien = new clsBNhanVien();
        public Form1()
        {
            InitializeComponent();
            string con_str = Program.ConnectionString;
            objBNhanVien.ConnectionString = con_str;
            objBNhanVien.Initialize();
        }
        private void DangNhap()
        {
            objBNhanVien.MaNV = txtTenDangNhap.Text;
            objBNhanVien.MatKhau = txtMatKhau.Text;

            if (objBNhanVien.DangNhap() != true)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                return;
            }
            DataTable NhanVien = new DataTable();
            NhanVien = objBNhanVien.SELECT_NHANVIEN_BY_ID();

            frmMain mainForm = new frmMain();
            mainForm.MaNV = NhanVien.Rows[0]["MaNV"].ToString();
            mainForm.TenNV = NhanVien.Rows[0]["TenNV"].ToString();            
            mainForm.LaAdmin = Convert.ToBoolean(NhanVien.Rows[0]["laAdmin"].ToString());
            mainForm.Show();
            mainForm.Activate();
            this.Hide();

        }
        private void bntDangNhap_Click(object sender, EventArgs e)
        {
            this.DangNhap();
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.DangNhap();
            }
        }

        private void txtTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.DangNhap();
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
