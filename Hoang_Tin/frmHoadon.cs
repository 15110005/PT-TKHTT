using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hoang_Tin
{
    public partial class frmHoadon : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=WIN81;Initial Catalog=QuanLiCaPhe;Integrated Security=True");
        BindingSource bd = new BindingSource();
        SqlCommandBuilder cb;
        public frmHoadon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHoadon_Load(object sender, EventArgs e)
        {
            this.tblCTHoaDonTableAdapter.Fill(this.DataSet1.tblCTHoaDon);

            this.reportViewer1.RefreshReport();
        }

        private void txtinhoadon_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=WIN81;Initial Catalog=QuanLiCaPhe;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from tblCTHoaDon where MaHD like N'" + txtinhoadon.Text + "'", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblCTHoaDon");


            //reportViewer1.DataSource = dshoadon;
            //reportViewer1.DisplayMember = "TenMon";
            //reportViewer1.ValueMember = "MaMon";

            // TODO: This line of code loads data into the 'DataSet1.tblCTHoaDon' table. You can move, or remove it, as needed.
            
        }

        private void txtinhoadon_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=WIN81;Initial Catalog=QuanLiCaPhe;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from tblCTHoaDon where MaHD like N'" + txtinhoadon.Text + "'", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblCTHoaDon");
            //reportViewer1.DataSource = ds;
            //reportViewer1.DataMember = "tblCTHoaDon";
            this.tblCTHoaDonTableAdapter.Fill(this.DataSet1.tblCTHoaDon);

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=WIN81;Initial Catalog=QuanLiCaPhe;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from tblCTHoaDon where MaHD like N'" + txtinhoadon.Text + "'", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblCTHoaDon");
            
        }
    }
}
