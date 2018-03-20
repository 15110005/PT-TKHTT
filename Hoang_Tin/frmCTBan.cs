using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hoang_Tin
{
    public partial class frmCTBan : Form
    {      
        OderBO odBO = new OderBO();
        BanCoKhachBO bckBO = new BanCoKhachBO();
        CTOderBO ctBO = new CTOderBO();
        HoaDonBO hdBO = new HoaDonBO();
        CTHoaDonBO cthdBO = new CTHoaDonBO();
        DoanhThuBO dtBO = new DoanhThuBO();
        CTDoanhThuBO ctdtBO = new CTDoanhThuBO();

        SqlConnection cn = new SqlConnection("Data Source=WIN81;Initial Catalog=Hoang_Tin;Integrated Security=True");
        BindingSource bd = new BindingSource();      
        SqlCommandBuilder cb;

        public frmCTBan(string text)
        {
            InitializeComponent();
            txtMaBan.Text = text;
            //cbMaNV.Text = Text;
        }       
        private Oder getOder()
        {
            Oder od = new Oder();
            int i = 0;
            od.MaNV = cbMaNV.SelectedValue.ToString();
            od.MaBan = txtMaBan.Text;
            Int32.TryParse(txtMaOder.Text, out i);
            od.MaOder = i;
            od.Ngay = Convert.ToDateTime(dtNgay.Value.ToShortDateString());
            return od;
        }

        private BanCoKhach getBanCoKhach()
        {
            BanCoKhach ban = new BanCoKhach();
            int i = 0;
            ban.MaBan = txtMaBan.Text;
            string soban = bckBO.laySoBan(txtMaBan.Text);
            Int32.TryParse(soban, out i);
            ban.SoBan = i;
            return ban;
        }


        private CTOder getCTOder()
        {
            CTOder ct = new CTOder();

            string maMon = "";
            int i = 0;
            if (txtMonDaChon.Text == comboBox1.Text) maMon = comboBox2.Text;
            //if (txtMonDaChon.Text == "Sting Vàng")
            //    maMon = "NN001";
            //if (txtMonDaChon.Text == "Sting Dâu")
            //    maMon = "NN002";
            ct.MaMon = maMon;
            i = int.Parse(txtMaOder.Text);
            ct.MaOder = i;
            string dvt = "";
            dvt = ctBO.layDVT(maMon);
            ct.MaBan = txtMaBan.Text;
            ct.DonViTinh = dvt;
            ct.SoLuong = 0;
            return ct;
        }

        private HoaDon getHD()
        {
            HoaDon hd = new HoaDon();
            
            hd.MaBan = txtMaBan.Text;
            
            int i = 0;
            Int32.TryParse(txtMaOder.Text, out i);
            hd.MaOder = i;
            hd.Ngay = Convert.ToDateTime(dtNgay.Value.ToShortDateString());
            return hd;
        }

        private CTHoaDon getCTHD()
        {
            CTHoaDon cthd = new CTHoaDon();
            CTOder ct = getCTOder();
            int i = 0;
            int maOder = int.Parse(txtMaOder.Text);
            Int32.TryParse(cthdBO.layMaHD(maOder), out i);
            cthd.MaHD = i;
            cthd.MaMon = ct.MaMon;
            cthd.TenMon = cthdBO.layTenMon(ct.MaMon);
            string soLuong = txtSoLuong.Text;
            int sl = 0;
            Int32.TryParse(soLuong, out sl);
            cthd.SoLuong = sl;
            string dg = cthdBO.layDonGia(cthd.MaMon);
            float j = 0;
            float.TryParse(dg, out j);
            cthd.DonGia = j;
            cthd.ThanhTien = cthd.SoLuong * cthd.DonGia;
            return cthd;
        }

        private DoanhThu getDoanhThu()
        {
            DoanhThu dt = new DoanhThu();
            dt.Ngay = Convert.ToDateTime(dtNgay.Value.ToShortDateString());
            dt.Tong = 0;
            return dt;
        }
        private CTDoanhThu getCTDoanhThu()
        {
            CTDoanhThu ct = new CTDoanhThu();
            CTOder ctod = getCTOder();
            ct.Ngay = Convert.ToDateTime(dtNgay.Value.ToShortDateString());
            ct.MaMon = ctod.MaMon;
            ct.SoLuong = 0;
            string dongia = ctdtBO.layDonGia(ct.MaMon);
            float i = 0;
            float.TryParse(dongia, out i);
            ct.TongTien = ct.SoLuong * i;
            return ct;
        }
        private void btnGoiMon_Click(object sender, EventArgs e)
        {
            gbNuocNgot.Visible = true;
        }

        private void btnNuocNgot_Click(object sender, EventArgs e)
        {
            gbNuocNgot.Visible = true;
        }              
        private void button5_Click(object sender, EventArgs e)
        {

        }
        
        private void frmCTBan_Load(object sender, EventArgs e)
        {            
            cn.Open();
            SqlCommand cmddsmon = new SqlCommand("select * from tblDSMon", cn);
            SqlDataAdapter dadsmon = new SqlDataAdapter(cmddsmon);
            DataSet dsdsmon = new DataSet();
            dadsmon.Fill(dsdsmon, "tblDSMon");
            DataTable dtdsmon = new DataTable();
            dadsmon.Fill(dtdsmon);
            comboBox1.DataSource = dtdsmon;
            comboBox1.DisplayMember = "TenMon";
            comboBox1.ValueMember = "MaMon";


            int i = 0;
            if (odBO.kiemTraTonTai1() == false)
                txtMaOder.Text = "1";
            else
                if (bckBO.kiemTraBanCoKhach(txtMaBan.Text) == false)
                {
                    i = odBO.layMaOder() + 1;
                    txtMaOder.Text = i.ToString();
                }
            DataTable tableNV = new DataTable();
            tableNV = odBO.getMaNV();
            cbMaNV.DataSource = tableNV;
            cbMaNV.DisplayMember = "MaNV";
            cbMaNV.ValueMember = "MaNV";
            if (bckBO.kiemTraBanCoKhach(txtMaBan.Text))
            {
                binData1();
            }
        }
        private void btnGoiMon_Click_1(object sender, EventArgs e)
        {
            Oder od = getOder();
            HoaDon hd = getHD();
            BanCoKhach ban = getBanCoKhach();
            if (bckBO.kiemTraBanCoKhach(ban.MaBan))
            {
                gbNuocNgot.Visible = true;                
            }
            else
            {
                if (odBO.ThemOder(od) == false || bckBO.ThemBanCoKhach(ban) == false)
                    MessageBox.Show("Không thể thực hiện gọi món");
                else
                {
                    gbNuocNgot.Visible = true;
                }
                if (hdBO.ThemHD(hd) == false)
                    MessageBox.Show("Không thể thêm hóa đơn");
            }
        }

        private void btnNuocNgot_Click_1(object sender, EventArgs e)
        {
            gbNuocNgot.Visible = true;  
        }

        private void btnStingVang_Click(object sender, EventArgs e)
        {
            gbSoLuong.Visible = true;
            txtMonDaChon.Text = comboBox1.Text;
            //txtMonDaChon.Text = "Sting Vàng";
            string maMon = comboBox2.Text;
            //string maMon = "NN001";
            string maBan = txtMaBan.Text;
            int i = 0;
            Int32.TryParse(txtMaOder.Text, out i);
            CTOder ct = getCTOder();
            if (ctBO.kiemTraMon(maMon, maBan, i) == false)
                if (ctBO.ThemCTOder(ct) == false)
                    MessageBox.Show("Không thể thêm món");
            binData();
        }

        private void btnStingDau_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            gbSoLuong.Visible = false;
            CTOder ct = getCTOder();
            CTHoaDon cthd = getCTHD();
            DoanhThu dt = getDoanhThu();
            CTDoanhThu ctdt = getCTDoanhThu();
            int i = 0;
            i = int.Parse(txtSoLuong.Text);
            ct.SoLuong = i;
            cthd.SoLuong = i;
            dt.Ngay = Convert.ToDateTime(dtNgay.Value.ToShortDateString());
            ctdt.Ngay = Convert.ToDateTime(dtNgay.Value.ToShortDateString());
            if (dtBO.kiemTraTonTaiDT(dt.Ngay) == false)
                dtBO.ThemDoanhThu(dt);
            if (ctdtBO.kiemTraTonTaiCTDT(ctdt.MaMon, ctdt.Ngay) == false)
            {
                ctdt.SoLuong = i;
                string dongia = ctdtBO.layDonGia(ctdt.MaMon);
                float dg = 0;
                float.TryParse(dongia, out dg);
                ctdt.TongTien = ctdt.SoLuong * dg;
                ctdtBO.ThemCTDoanhThu(ctdt);
            }

            if (cthdBO.kiemTraMonHD(cthd.MaHD, cthd.MaMon))
            {
                cthdBO.SuaCTHD(cthd);
                float dthu = 0;
                string doanhthu = dtBO.layDoanhThu(Convert.ToDateTime(dtNgay.Value.ToShortDateString()));
                float.TryParse(doanhthu, out dthu);
                dt.Tong = dthu + (cthd.SoLuong * cthd.DonGia);
                dtBO.SuaDoanhThu(dt);

                int slb = 0;
                string slban = ctdtBO.laySLBan(ct.MaMon);
                Int32.TryParse(slban, out slb);
                int slc = 0;
                string slcon = ctdtBO.laySLMonCu(ctdt.MaMon, txtMaBan.Text);
                Int32.TryParse(slcon, out i);
                ctdt.SoLuong = (slb + i) - slc;
                string dongia = ctdtBO.layDonGia(ctdt.MaMon);
                float dg = 0;
                float.TryParse(dongia, out dg);
                ctdt.TongTien = ctdt.SoLuong * dg;
                ctdtBO.SuaCTDoanhThu(ctdt);
            }
            else
            {
                if (cthdBO.ThemCTHD(cthd) == false)
                    MessageBox.Show("Không thể thêm chi tiết vào hóa đơn");
                float dthu = 0;
                string doanhthu = dtBO.layDoanhThu(Convert.ToDateTime(dtNgay.Value.ToShortDateString()));
                float.TryParse(doanhthu, out dthu);
                dt.Tong = dthu + (cthd.SoLuong * cthd.DonGia);
                dtBO.SuaDoanhThu(dt);

                int slb = 0;
                string slban = ctdtBO.laySLBan(ct.MaMon);
                Int32.TryParse(slban, out slb);
                ctdt.SoLuong = slb + i;
                string dongia = ctdtBO.layDonGia(ctdt.MaMon);
                float dg = 0;
                float.TryParse(dongia, out dg);
                ctdt.TongTien = ctdt.SoLuong * dg;
                ctdtBO.SuaCTDoanhThu(ctdt);
            }
            if (ctBO.NhapSoLuong(ct) == false)
                MessageBox.Show("Không thể thêm số lượng");
            txtSoLuong.Text = "";
            binData();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            BanCoKhach bck = getBanCoKhach();
            Oder od = getOder();
            CTOder ctod = getCTOder();
            int i = 0;
            Int32.TryParse(txtMaOder.Text, out i);
            ctod.MaOder = i;

            gbNuocNgot.Visible = false;
            btnHoaDon.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            dgCTOder.Visible = false;
            gbSoLuong.Visible = false;

            bckBO.XoaBanCoKhach(bck);
            ctBO.XoaCTOder(ctod);  
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {            
            this.Close();
            frmBan ban = new frmBan();
            ban.Show();
        }

        private void dgCTOder_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowSelect = e.RowIndex;
            //txtMonDaChon.Text = dgCTOder.Rows[rowSelect].Cells[0].Value.ToString();
            txtMaMon.Text = dgCTOder.Rows[rowSelect].Cells[2].Value.ToString();
            txtSL.Text = dgCTOder.Rows[rowSelect].Cells[3].Value.ToString();            
        }
        private void ClearBind()
        {
            dgCTOder.DataBindings.Clear();
        }

        private void ClearBind1()
        {
            txtMaOder.DataBindings.Clear();
        }

        private void binData1()
        {
            BindingSource bindSource = new BindingSource();
            string maBan = txtMaBan.Text;
            bindSource.DataSource = ctBO.getCTOder(maBan);
            ClearBind();
            dgCTOder.DataSource = bindSource;
            txtMaOder.DataBindings.Add("Text", bindSource, "MaOder");
        }

        private void binData()
        {
            BindingSource bindSource = new BindingSource();
            string maBan = txtMaBan.Text;
            bindSource.DataSource = ctBO.getCTOder(maBan);
            ClearBind();
            //txtMaOder.DataBindings.Add("Text", bindSource, "MaOder");
            dgCTOder.DataSource = bindSource;
        }

        private void btnBoMon_Click(object sender, EventArgs e)
        {
            CTOder ct = getCTOder();
            CTHoaDon cthd = getCTHD();
            CTDoanhThu ctdt = getCTDoanhThu();
            if (txtMaMon.Text == "")
                MessageBox.Show("Vui lòng chọn món muốn bỏ!");
            else
            {
                string sl = ctBO.laySLMon(txtMaMon.Text, txtMaBan.Text);
                int i = 0;
                i = int.Parse(sl);
                int slc = int.Parse(txtSL.Text);
                if (i > 1)
                {
                    ct.SoLuong = slc - 1;
                    cthd.SoLuong = slc - 1;
                    ct.MaOder = int.Parse(txtMaOder.Text);
                    ct.MaMon = txtMaMon.Text;
                    cthd.MaMon = txtMaMon.Text;
                    if (ctBO.NhapSoLuong(ct) == false)
                        MessageBox.Show("Không thể bỏ món");
                    if (cthdBO.SuaCTHD(cthd) == false)
                        MessageBox.Show("Không thể bỏ món trong hóa đơn");
                }
                else
                {
                    ct.MaMon = txtMaMon.Text;
                    cthd.MaMon = txtMaMon.Text;
                    ct.MaBan = txtMaBan.Text;
                    if (ctBO.XoaMon(ct) && cthdBO.XoaMon(cthd))
                        MessageBox.Show("Đã xóa món");
                    else
                        MessageBox.Show("Xóa thành công !");
                }
            }
            ctdt.MaMon = txtMaMon.Text;
            int slb = 0;
            string slban = ctdtBO.laySLBan(ctdt.MaMon);
            Int32.TryParse(slban, out slb);
            ctdt.SoLuong = slb - 1;
            string dongia = ctdtBO.layDonGia(ctdt.MaMon);
            float dg = 0;
            float.TryParse(dongia, out dg);
            ctdt.TongTien = ctdt.SoLuong * dg;
            ctdtBO.SuaCTDoanhThu(ctdt);
            binData();            
        }
        private void btnHoaDon_Click(object sender, EventArgs e)
        {            
            frmhoadon1 frmhoadon = new frmhoadon1(txtMaOder.Text);
            frmhoadon.Show();
        }        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnStingVang.Visible = true;
            SqlConnection cn = new SqlConnection("Data Source=WIN81;Initial Catalog=Hoang_Tin;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from tblDSMon where TenMon like N'" + comboBox1.Text + "'", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblDSMon");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "tblDSMon";
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["MaMon"].Value.ToString();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {           
        }

        private void dataGridView3_RowEnter(object sender, DataGridViewCellEventArgs e)
        {            
        }

        private void txtMaOder_TextChanged(object sender, EventArgs e)
        {           
        }

        private void txtMonDaChon_TextChanged(object sender, EventArgs e)
        {           
        }
        
    }
}
