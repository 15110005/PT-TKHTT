using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Hoang_Tin.DataAccess
{
    class DBAccess
    {
        SqlConnection connect;
        SqlDataAdapter da;
        SqlCommand command;

        public DBAccess()
        {
            connectDB();
        }

        public void connectDB()
        {
            connect = new SqlConnection(@"Data Source=WIN81;Initial Catalog=Hoang_Tin;Integrated Security=True");
            try
            {
                connect.Open();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
                connect.Dispose();
            }
        }

        public DataTable getDS(string sql)
        {
            DataTable table = new DataTable();
            da = new SqlDataAdapter(sql, connect);
            da.Fill(table);
            return table;
        }

        public bool ExecuteNonQueryPara(string sql, string[] parameters, object[] value)
        {
            int number = 0;
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                command = new SqlCommand(sql, connect);
                SqlParameter p;
                for (int i = 0; i < parameters.Length; i++)
                {
                    p = new SqlParameter(parameters[i], value[i]);
                    command.Parameters.Add(p);
                }
                number = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (number > 0)
                return true;
            else
                return false;
        }

        

       

     

      

        public int layMaOder(string tableName, string colum)
        {
            string query = "Select top 1 MaOder from " + tableName + " order by " + colum + " DESC";
            command = new SqlCommand(query, connect);
            int number = 0;
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            number = (int)command.ExecuteScalar();

            connect.Close();
            return number;
        }

        public bool kiemTraTonTai1()
        {
            string query = "Select count (*) from tblOder";
            command = new SqlCommand(query, connect);
            int number = 0;
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                number = (int)command.ExecuteScalar();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (number > 0)
                return true;
            else
                return false;
        }

        public bool kiemTraTonTai2(string giaTri)
        {
            string query = "Select count (*) from tblNhanVien where MaNV='" + giaTri + "'";
            command = new SqlCommand(query, connect);
            int number = 0;
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                number = (int)command.ExecuteScalar();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (number > 0)
                return true;
            else
                return false;
        }    

        public bool kiemTraTonTai8(string maBan)
        {
            string query = "Select count (*) from tblBanCoKhach where MaBan='" + maBan + "'";
            command = new SqlCommand(query, connect);
            int number = 0;
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                number = (int)command.ExecuteScalar();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (number > 0)
                return true;
            else
                return false;
        }

        public bool kiemTraTonTai9(string maMon, string maBan, int maOder)
        {
            string query = "Select count (*) from tblCTOder where MaMon='" + maMon + "' and MaBan='" + maBan + "' and MaOder='" + maOder + "'";
            command = new SqlCommand(query, connect);
            int number = 0;
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                number = (int)command.ExecuteScalar();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (number > 0)
                return true;
            else
                return false;
        }

        public bool kiemTraTonTai10(int maOder)
        {
            string query = "Select count (*) from tblCTOder where MaOder='" + maOder + "'";
            command = new SqlCommand(query, connect);
            int number = 0;
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                number = (int)command.ExecuteScalar();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (number > 0)
                return true;
            else
                return false;
        }

        public bool kiemTraTonTai11(int soBan)
        {
            string query = "Select count (*) from tblBanCoKhach where SoBan='" + soBan + "'";
            command = new SqlCommand(query, connect);
            int number = 0;
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                number = (int)command.ExecuteScalar();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (number > 0)
                return true;
            else
                return false;
        }

        public bool kiemTraTonTai12(int maHD, string maMon)
        {
            string query = "Select count (*) from tblCTHoaDon where MaHD='" + maHD + "' and MaMon='" + maMon + "'";
            command = new SqlCommand(query, connect);
            int number = 0;
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                number = (int)command.ExecuteScalar();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (number > 0)
                return true;
            else
                return false;
        }

        public bool kiemTraTonTai13(DateTime ngay)
        {
            string query = "Select count (*) from tblDoanhThu where Ngay='" + ngay + "'";
            command = new SqlCommand(query, connect);
            int number = 0;
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                number = (int)command.ExecuteScalar();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (number > 0)
                return true;
            else
                return false;
        }      
        public bool kiemTraTonTai16(string maMon, DateTime ngay)
        {
            string query = "Select count (*) from tblCTDoanhThu where MaMon='" + maMon + "' and Ngay='" + ngay + "'";
            command = new SqlCommand(query, connect);
            int number = 0;
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                number = (int)command.ExecuteScalar();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (number > 0)
                return true;
            else
                return false;
        }

        public bool kiemTraTonTai17(int maOder)
        {
            string query = "Select count (*) from tblOder where MaOder='" + maOder + "'";
            command = new SqlCommand(query, connect);
            int number = 0;
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                number = (int)command.ExecuteScalar();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (number > 0)
                return true;
            else
                return false;
        }
        public string layDonViTinhNL(string maNL)
        {
            string dvtNL = "";
            string query = "Select DonViTinh from tblNguyenLieu where MaNL='" + maNL + "'";
            da.SelectCommand = new SqlCommand(query, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblNguyenLieu");
            DataTable dt = ds.Tables["tblNguyenLieu"];
            foreach (DataRow row in dt.Rows)
                dvtNL = row["DonViTinh"].ToString();
            return dvtNL;
        }
        public string layDonGia(string maNL)
        {
            string donGia = "";
            string query = "Select DonGia from tblNguyenLieu where MaNL='" + maNL + "'";
            da.SelectCommand = new SqlCommand(query, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblNguyenLieu");
            DataTable dt = ds.Tables["tblNguyenLieu"];
            foreach (DataRow row in dt.Rows)
                donGia = row["DonGia"].ToString();
            return donGia;
        }

        public string layTenNV(string maNV)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string tenNV = "";
            string query = "Select TenNV from tblNhanVien where MaNV='" + maNV + "'";
            da.SelectCommand = new SqlCommand(query, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblNhanVien");
            DataTable dt = ds.Tables["tblNhanVien"];
            foreach (DataRow row in dt.Rows)
                tenNV = row["TenNV"].ToString();
            return tenNV;
        }

        public string layMaBan(int soBan)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string maBan = "";
            string query = "Select MaBan from tblBan where SoBan='" + soBan + "'";
            da.SelectCommand = new SqlCommand(query, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblBan");
            DataTable dt = ds.Tables["tblBan"];
            foreach (DataRow row in dt.Rows)
                maBan = row["MaBan"].ToString();
            return maBan;
        }

        public string laySoBan(string maBan)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string soBan = "";
            string query = "Select SoBan from tblBan where MaBan='" + maBan + "'";
            da.SelectCommand = new SqlCommand(query, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblBan");
            DataTable dt = ds.Tables["tblBan"];
            foreach (DataRow row in dt.Rows)
                soBan = row["SoBan"].ToString();
            return soBan;
        }

        public string laySLMon(string maMon, string maBan)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string sl = "";
            string query = "Select SoLuong from tblCTOder where MaMon='" + maMon + "' and MaBan='" + maBan + "'";
            da.SelectCommand = new SqlCommand(query, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblCTOder");
            DataTable dt = ds.Tables["tblCTOder"];
            foreach (DataRow row in dt.Rows)
                sl = row["SoLuong"].ToString();
            return sl;
        }
        public string layDVT(string maMon)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string dvt = "";
            string query = "Select DonViTinh from tblDSMon where MaMon='" + maMon + "'";
            da.SelectCommand = new SqlCommand(query, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblDSMon");
            DataTable dt = ds.Tables["tblDSMon"];
            foreach (DataRow row in dt.Rows)
                dvt = row["DonViTinh"].ToString();
            return dvt;
        }

        public string layTenMon(string maMon)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string tenmon = "";
            string query = "Select TenMon from tblDSMon where MaMon='" + maMon + "'";
            da.SelectCommand = new SqlCommand(query, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblDSMon");
            DataTable dt = ds.Tables["tblDSMon"];
            foreach (DataRow row in dt.Rows)
                tenmon = row["TenMon"].ToString();
            return tenmon;
        }

        public string layDonGiaMon(string maMon)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string dg = "";
            string query = "Select DonGia from tblDSMon where MaMon='" + maMon + "'";
            da.SelectCommand = new SqlCommand(query, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblDSMon");
            DataTable dt = ds.Tables["tblDSMon"];
            foreach (DataRow row in dt.Rows)
                dg = row["DonGia"].ToString();
            return dg;
        }

        public string layMaHD(int maOder)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string mahd = "";
            string query = "Select MaHD from tblHoaDon where MaOder='" + maOder + "'";
            da.SelectCommand = new SqlCommand(query, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblHoaDon");
            DataTable dt = ds.Tables["tblHoaDon"];
            foreach (DataRow row in dt.Rows)
                mahd = row["MaHD"].ToString();
            return mahd;
        }

        public string layDoanhThu(DateTime ngay)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string doanhthu = "";
            string query = "Select DoanhThu from tblDoanhThu where Ngay='" + ngay + "'";
            da.SelectCommand = new SqlCommand(query, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblDoanhThu");
            DataTable dt = ds.Tables["tblDoanhThu"];
            foreach (DataRow row in dt.Rows)
                doanhthu = row["DoanhThu"].ToString();
            return doanhthu;
        }           
        public string laySLMonBan(string maMon)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string sl = "";
            string query = "Select SoLuongBan from tblCTDoanhThu where MaMon='" + maMon + "'";
            da.SelectCommand = new SqlCommand(query, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblCTDoanhThu");
            DataTable dt = ds.Tables["tblCTDoanhThu"];
            foreach (DataRow row in dt.Rows)
                sl = row["SoLuongBan"].ToString();
            return sl;
        }

    }
}
