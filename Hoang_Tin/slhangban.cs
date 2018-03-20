using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Hoang_Tin
{
    public partial class slhangban : Form
    {
        public slhangban()
        {
            InitializeComponent();
        }

        private void slhangban_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hoang_TinDataSet.tblCTDoanhThu' table. You can move, or remove it, as needed.
            this.tblCTDoanhThuTableAdapter.Fill(this.hoang_TinDataSet.tblCTDoanhThu);
            // TODO: This line of code loads data into the 'hoang_TinDataSet.tblCTHoaDon' table. You can move, or remove it, as needed.
            this.tblCTHoaDonTableAdapter.Fill(this.hoang_TinDataSet.tblCTHoaDon);

            this.reportViewer1.RefreshReport();

            setparameters(cbomamon.SelectedValue.ToString());
            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void setparameters(string MAMON)
        {
            ReportParameter rp = new ReportParameter("soluongban");
            rp.Values.Add(MAMON);
            reportViewer1.LocalReport.SetParameters(rp);
        }
        private void btnthongke_Click(object sender, EventArgs e)
        {
            setparameters(cbomamon.SelectedValue.ToString());
            reportViewer1.RefreshReport();
        }
    }
}
