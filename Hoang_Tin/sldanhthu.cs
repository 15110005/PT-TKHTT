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
    public partial class sldanhthu : Form
    {
        public sldanhthu()
        {
            InitializeComponent();
        }

        private void sldanhthu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Hoang_TinDataSet.tblDoanhThu' table. You can move, or remove it, as needed.
            this.tblDoanhThuTableAdapter.Fill(this.Hoang_TinDataSet.tblDoanhThu);

            this.reportViewer1.RefreshReport();

            setparameters(dtformyaer.Value, dttoyear.Value);
            this.reportViewer1.RefreshReport();
        }
        private void setparameters(DateTime formyear, DateTime toyear)
        {
            ReportParameter[] rp = new ReportParameter[2];
            rp[0] = new ReportParameter("formyear");
            rp[1] = new ReportParameter("toyear");
            rp[0].Values.Add(formyear.ToString());
            rp[1].Values.Add(toyear.ToString());
            reportViewer1.LocalReport.SetParameters(rp);
        }
        private void btnthongkesl_Click(object sender, EventArgs e)
        {
            setparameters(dtformyaer.Value, dttoyear.Value);
            reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
