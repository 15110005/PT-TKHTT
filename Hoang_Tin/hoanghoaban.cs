using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Hoang_Tin
{
    public partial class hoanghoaban : Form
    {
        SqlCommand cmdselect;
        SqlCommand cmdindext;
        SqlCommand cmdxoa;
        SqlConnection conn;
        clsCommonUI objCommonUI = new clsCommonUI();
        SqlDataAdapter adapter;
        DataTable tblTable = new DataTable();
        int _newrecord = 0;
        public hoanghoaban()
        {
            InitializeComponent();
            string con_str = Program.ConnectionString;
            conn = new SqlConnection(con_str);
        }

        private void button4thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void hoanghoaban_Load(object sender, EventArgs e)
        {
            this.bindData();
            this.disableInput();
        }
        public void bindData()
        {
            adapter = new SqlDataAdapter("SELECT * FROM tblDSMon", conn);
            SqlCommandBuilder builder;
            builder = new SqlCommandBuilder(adapter);
            tblTable.Clear();
            adapter.Fill(tblTable);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns["MaMon"].DataPropertyName = "MaMon";
            dataGridView1.Columns["TenMon"].DataPropertyName = "TenMon";
            dataGridView1.Columns["Nhom"].DataPropertyName = "Nhom";
            dataGridView1.Columns["DonGia"].DataPropertyName = "DonGia";
            dataGridView1.Columns["DonViTinh"].DataPropertyName = "DonViTinh";            
            dataGridView1.DataSource = tblTable;
        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["MaMon"].Value.ToString();            
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["TenMon"].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["Nhom"].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["DonGia"].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["DonViTinh"].Value.ToString();           
            this.enableInput();
            _newrecord = 0;
        }
        private void disableInput()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;            
        }

        private void enableInput()
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;            
        }

        private bool validateInput()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Mã món không được để trống");
                textBox1.Focus();
                return false;
            }

            if (textBox2.Text == "")
            {
                MessageBox.Show("Tên món không được để trống");
                textBox2.Focus();
                return false;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Giá không được để trống");
                textBox4.Focus();
                return false;
            }
            return true;
        }

        private void clearInput()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";            
        }

        private void button1them_Click(object sender, EventArgs e)
        {
            this.clearInput();
            _newrecord = 1;
            this.enableInput();
            textBox1.Focus();
        }

        private void button3xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Chắc chắn xóa hay không ?","Thông báo",MessageBoxButtons.YesNo);
            if(dr==DialogResult.Yes)
            {
                moketnoi();
                string sql1 = "DELETE FROM tblDSMon WHERE MaMon ='"+textBox1.Text+"' ";
                cmdxoa = new SqlCommand(sql1, conn);
                if(cmdxoa.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Xóa thành công !");
                    bindData();
                }
                else
                
                    MessageBox.Show("Không tồn tại mã món"+ textBox1.Text);
                    cmdxoa.Dispose();
                
            }            
        }
        private void moketnoi()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
        }
        private int kiemtra(string ma)
        {
            moketnoi();
            cmdselect = new SqlCommand("SELECT  count(*) FROM tblDSMon WHERE MaMon='"+ma.Trim()+"'");
            cmdselect.Connection = conn;
            return (int)cmdselect.ExecuteScalar();
        }
        private void button2ghi_Click(object sender, EventArgs e)
        {
            if (this.validateInput() == false)
                return;

            if(kiemtra(textBox1.Text)==1)
            {
                MessageBox.Show("Mã này đã có !");
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                string ma = textBox1.Text;
                string tenmon = textBox2.Text;
                string nhom = textBox3.Text;
                string dongia = textBox4.Text;
                string donvitinh = textBox5.Text;

                moketnoi();
                string sql = "INSERT INTO tblDSMon VALUES(" + " '" + ma + "','" + tenmon + "','" + nhom + "','" + dongia + "','" + donvitinh + "')";
                cmdindext = new SqlCommand(sql, conn);
                cmdindext.ExecuteNonQuery();
                MessageBox.Show("Đã lưu thành công !");
                cmdindext.Dispose();
                bindData();
            }
        }      
    }
}
