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
using Microsoft.Reporting.WinForms;

namespace Hoang_Tin
{
    public partial class frmhoadon1 : Form
    {

        public frmhoadon1(string hoanganh)
        {
            InitializeComponent();
            //cbohoadon1.Text = hoanganh;
            txthoadon1.Text = hoanganh;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmhoadon1_Load(object sender, EventArgs e)
        {
// TODO: This line of code loads data into the 'Hoang_TinDataSet.tblHoaDon' table. You can move, or remove it, as needed.
this.tblHoaDonTableAdapter.Fill(this.Hoang_TinDataSet.tblHoaDon);
            // TODO: This line of code loads data into the 'Hoang_TinDataSet.tblCTHoaDon' table. You can move, or remove it, as needed.
            this.tblCTHoaDonTableAdapter.Fill(this.Hoang_TinDataSet.tblCTHoaDon);
            this.reportViewer1.RefreshReport();

            cbohoadon1.Text = txthoadon1.Text;
            setparameters(cbohoadon1.SelectedValue.ToString());
            this.reportViewer1.RefreshReport();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {            
        }
        private void button2_Click(object sender, EventArgs e)
        {                       
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {                        
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {           
        }
        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {           
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void setparameters(string MAHOADON)
        {
            ReportParameter rp = new ReportParameter("mahoadon");
            rp.Values.Add(MAHOADON);
            reportViewer1.LocalReport.SetParameters(rp);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            //setparameters(cbohoadon1.SelectedValue.ToString());
            //reportViewer1.RefreshReport();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
        
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {            
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmBan ban = new frmBan();
            ban.Show();
        }
    }
}
