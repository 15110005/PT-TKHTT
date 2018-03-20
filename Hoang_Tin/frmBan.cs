using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hoang_Tin
{
    public partial class frmBan : Form
    {
        OderBO odBO = new OderBO();
        CTOderBO ctBO = new CTOderBO();
        BanCoKhachBO bckBO = new BanCoKhachBO();
        public frmBan()
        {
            InitializeComponent();
            
        }     
        private void btn1_Click_1(object sender, EventArgs e)
        {
            int i = 1;
            string maBan = odBO.layMaBan(i);
            this.Close();
            frmCTBan FromCTBan;
            FromCTBan = new frmCTBan(maBan);            
            FromCTBan.Show();            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int i = 2;
            string maBan = odBO.layMaBan(i);
            this.Close();
            frmCTBan FromCTBan;
            FromCTBan = new frmCTBan(maBan);
            FromCTBan.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int i = 3;
            string maBan = odBO.layMaBan(i);
            this.Close();
            frmCTBan FromCTBan;
            FromCTBan = new frmCTBan(maBan);
            FromCTBan.Show();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int i = 4;
            string maBan = odBO.layMaBan(i);
            this.Close();
            frmCTBan FromCTBan;
            FromCTBan = new frmCTBan(maBan);
            FromCTBan.Show();
        }

        private void frmBan_Load(object sender, EventArgs e)
        {
            if (bckBO.kiemTraBanCoKhach("A01"))
                btn1.Text = "1(CK)";
            else
                btn1.Text = "BÀN 1";

            if (bckBO.kiemTraBanCoKhach("A02"))
                btn2.Text = "2(CK)";
            else
                btn2.Text = "BÀN 2";

            if (bckBO.kiemTraBanCoKhach("A03"))
                btn3.Text = "3(CK)";
            else
                btn3.Text = "BÀN 3";

            if (bckBO.kiemTraBanCoKhach("A04"))
                btn4.Text = "4(CK)";
            else
                btn4.Text = "BÀN 4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
    }
}
