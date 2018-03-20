namespace Hoang_Tin
{
    partial class frmCTBan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tblCTHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Hoang_TinDataSet = new Hoang_Tin.Hoang_TinDataSet();
            this.txtmaHD = new System.Windows.Forms.TextBox();
            this.gbSoLuong = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.gbNuocNgot = new System.Windows.Forms.GroupBox();
            this.btnStingVang = new System.Windows.Forms.Button();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.txtMonDaChon = new System.Windows.Forms.TextBox();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.dgCTOder = new System.Windows.Forms.DataGridView();
            this.clMaOder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaOder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaBan = new System.Windows.Forms.TextBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBoMon = new System.Windows.Forms.Button();
            this.btnGoiMon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCTHoaDonTableAdapter = new Hoang_Tin.Hoang_TinDataSetTableAdapters.tblCTHoaDonTableAdapter();
            this.DataSet1 = new Hoang_Tin.DataSet1();
            this.tblHoaDonTableAdapter = new Hoang_Tin.Hoang_TinDataSetTableAdapters.tblHoaDonTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblCTHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hoang_TinDataSet)).BeginInit();
            this.gbSoLuong.SuspendLayout();
            this.gbNuocNgot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCTOder)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblCTHoaDonBindingSource
            // 
            this.tblCTHoaDonBindingSource.DataMember = "tblCTHoaDon";
            this.tblCTHoaDonBindingSource.DataSource = this.Hoang_TinDataSet;
            // 
            // Hoang_TinDataSet
            // 
            this.Hoang_TinDataSet.DataSetName = "Hoang_TinDataSet";
            this.Hoang_TinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtmaHD
            // 
            this.txtmaHD.Location = new System.Drawing.Point(479, 436);
            this.txtmaHD.Name = "txtmaHD";
            this.txtmaHD.Size = new System.Drawing.Size(95, 20);
            this.txtmaHD.TabIndex = 41;
            this.txtmaHD.Visible = false;
            // 
            // gbSoLuong
            // 
            this.gbSoLuong.Controls.Add(this.btnHuy);
            this.gbSoLuong.Controls.Add(this.btnOK);
            this.gbSoLuong.Controls.Add(this.txtSoLuong);
            this.gbSoLuong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSoLuong.Location = new System.Drawing.Point(408, 314);
            this.gbSoLuong.Name = "gbSoLuong";
            this.gbSoLuong.Size = new System.Drawing.Size(167, 97);
            this.gbSoLuong.TabIndex = 36;
            this.gbSoLuong.TabStop = false;
            this.gbSoLuong.Text = "Nhập số Lượng";
            this.gbSoLuong.Visible = false;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(100, 60);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(57, 27);
            this.btnHuy.TabIndex = 21;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(32, 60);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(62, 27);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(32, 23);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(125, 26);
            this.txtSoLuong.TabIndex = 0;
            // 
            // gbNuocNgot
            // 
            this.gbNuocNgot.Controls.Add(this.label6);
            this.gbNuocNgot.Controls.Add(this.label1);
            this.gbNuocNgot.Controls.Add(this.btnStingVang);
            this.gbNuocNgot.Controls.Add(this.comboBox1);
            this.gbNuocNgot.Controls.Add(this.comboBox2);
            this.gbNuocNgot.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNuocNgot.Location = new System.Drawing.Point(12, 304);
            this.gbNuocNgot.Name = "gbNuocNgot";
            this.gbNuocNgot.Size = new System.Drawing.Size(380, 126);
            this.gbNuocNgot.TabIndex = 40;
            this.gbNuocNgot.TabStop = false;
            this.gbNuocNgot.Text = "Chọn Món";
            this.gbNuocNgot.Visible = false;
            // 
            // btnStingVang
            // 
            this.btnStingVang.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStingVang.Location = new System.Drawing.Point(262, 42);
            this.btnStingVang.Name = "btnStingVang";
            this.btnStingVang.Size = new System.Drawing.Size(86, 55);
            this.btnStingVang.TabIndex = 0;
            this.btnStingVang.Text = "OK";
            this.btnStingVang.UseVisualStyleBackColor = true;
            this.btnStingVang.Click += new System.EventHandler(this.btnStingVang_Click);
            // 
            // txtSL
            // 
            this.txtSL.Enabled = false;
            this.txtSL.Location = new System.Drawing.Point(351, 436);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(88, 20);
            this.txtSL.TabIndex = 39;
            this.txtSL.Visible = false;
            // 
            // txtMaMon
            // 
            this.txtMaMon.Enabled = false;
            this.txtMaMon.Location = new System.Drawing.Point(206, 436);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(113, 20);
            this.txtMaMon.TabIndex = 38;
            this.txtMaMon.Visible = false;
            // 
            // txtMonDaChon
            // 
            this.txtMonDaChon.Enabled = false;
            this.txtMonDaChon.Location = new System.Drawing.Point(60, 436);
            this.txtMonDaChon.Name = "txtMonDaChon";
            this.txtMonDaChon.Size = new System.Drawing.Size(116, 20);
            this.txtMonDaChon.TabIndex = 37;
            this.txtMonDaChon.Visible = false;
            this.txtMonDaChon.TextChanged += new System.EventHandler(this.txtMonDaChon_TextChanged);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.Location = new System.Drawing.Point(12, 229);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(175, 61);
            this.btnHoaDon.TabIndex = 42;
            this.btnHoaDon.Text = "HÓA ĐƠN";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Visible = false;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // dgCTOder
            // 
            this.dgCTOder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCTOder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaOder,
            this.clMaBan,
            this.clMaMon,
            this.clSoLuong,
            this.clDonViTinh});
            this.dgCTOder.Location = new System.Drawing.Point(12, 115);
            this.dgCTOder.Name = "dgCTOder";
            this.dgCTOder.Size = new System.Drawing.Size(573, 93);
            this.dgCTOder.TabIndex = 35;
            this.dgCTOder.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCTOder_RowEnter);
            // 
            // clMaOder
            // 
            this.clMaOder.DataPropertyName = "MaOder";
            this.clMaOder.HeaderText = "Mã Oder";
            this.clMaOder.Name = "clMaOder";
            this.clMaOder.Width = 80;
            // 
            // clMaBan
            // 
            this.clMaBan.DataPropertyName = "MaBan";
            this.clMaBan.HeaderText = "Mã Bàn";
            this.clMaBan.Name = "clMaBan";
            // 
            // clMaMon
            // 
            this.clMaMon.DataPropertyName = "MaMon";
            this.clMaMon.HeaderText = "Mã Món";
            this.clMaMon.Name = "clMaMon";
            this.clMaMon.Width = 150;
            // 
            // clSoLuong
            // 
            this.clSoLuong.DataPropertyName = "SoLuong";
            this.clSoLuong.HeaderText = "Số Lượng";
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.Width = 80;
            // 
            // clDonViTinh
            // 
            this.clDonViTinh.DataPropertyName = "DonViTinh";
            this.clDonViTinh.HeaderText = "Đơn Vị Tính";
            this.clDonViTinh.Name = "clDonViTinh";
            this.clDonViTinh.Width = 120;
            // 
            // dtNgay
            // 
            this.dtNgay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgay.Location = new System.Drawing.Point(411, 59);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(151, 26);
            this.dtNgay.TabIndex = 8;
            // 
            // cbMaNV
            // 
            this.cbMaNV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(411, 14);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(151, 26);
            this.cbMaNV.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(305, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày     :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã NV   :";
            // 
            // txtMaOder
            // 
            this.txtMaOder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaOder.Location = new System.Drawing.Point(155, 54);
            this.txtMaOder.Name = "txtMaOder";
            this.txtMaOder.Size = new System.Drawing.Size(111, 26);
            this.txtMaOder.TabIndex = 4;
            this.txtMaOder.TextChanged += new System.EventHandler(this.txtMaOder_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Oder   :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtNgay);
            this.groupBox2.Controls.Add(this.cbMaNV);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMaOder);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMaBan);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 88);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Bàn    :";
            // 
            // txtMaBan
            // 
            this.txtMaBan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBan.Location = new System.Drawing.Point(155, 15);
            this.txtMaBan.Name = "txtMaBan";
            this.txtMaBan.Size = new System.Drawing.Size(111, 26);
            this.txtMaBan.TabIndex = 2;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTinhTien.Location = new System.Drawing.Point(198, 21);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(87, 55);
            this.btnTinhTien.TabIndex = 11;
            this.btnTinhTien.Text = "TÍNH TIỀN";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(498, 235);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 55);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBoMon
            // 
            this.btnBoMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoMon.Location = new System.Drawing.Point(105, 21);
            this.btnBoMon.Name = "btnBoMon";
            this.btnBoMon.Size = new System.Drawing.Size(87, 55);
            this.btnBoMon.TabIndex = 1;
            this.btnBoMon.Text = "BỎ MÓN";
            this.btnBoMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBoMon.UseVisualStyleBackColor = true;
            this.btnBoMon.Click += new System.EventHandler(this.btnBoMon_Click);
            // 
            // btnGoiMon
            // 
            this.btnGoiMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoiMon.Location = new System.Drawing.Point(9, 21);
            this.btnGoiMon.Name = "btnGoiMon";
            this.btnGoiMon.Size = new System.Drawing.Size(87, 55);
            this.btnGoiMon.TabIndex = 0;
            this.btnGoiMon.Text = "GỌI MÓN";
            this.btnGoiMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGoiMon.UseVisualStyleBackColor = true;
            this.btnGoiMon.Click += new System.EventHandler(this.btnGoiMon_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTinhTien);
            this.groupBox1.Controls.Add(this.btnBoMon);
            this.groupBox1.Controls.Add(this.btnGoiMon);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(202, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 85);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 43;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(115, 80);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 27);
            this.comboBox2.TabIndex = 43;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(840, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(10, 10);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // tblHoaDonBindingSource
            // 
            this.tblHoaDonBindingSource.DataMember = "tblHoaDon";
            this.tblHoaDonBindingSource.DataSource = this.Hoang_TinDataSet;
            // 
            // tblCTHoaDonTableAdapter
            // 
            this.tblCTHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblHoaDonTableAdapter
            // 
            this.tblHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "Tên món  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 45;
            this.label6.Text = "Mã món  :";
            // 
            // frmCTBan
            // 
            this.ClientSize = new System.Drawing.Size(587, 468);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtmaHD);
            this.Controls.Add(this.gbSoLuong);
            this.Controls.Add(this.gbNuocNgot);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtMaMon);
            this.Controls.Add(this.txtMonDaChon);
            this.Controls.Add(this.btnHoaDon);
            this.Controls.Add(this.dgCTOder);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCTBan";
            this.Load += new System.EventHandler(this.frmCTBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblCTHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hoang_TinDataSet)).EndInit();
            this.gbSoLuong.ResumeLayout(false);
            this.gbSoLuong.PerformLayout();
            this.gbNuocNgot.ResumeLayout(false);
            this.gbNuocNgot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCTOder)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmaHD;
        private System.Windows.Forms.GroupBox gbSoLuong;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.GroupBox gbNuocNgot;
        private System.Windows.Forms.Button btnStingVang;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.TextBox txtMonDaChon;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.DataGridView dgCTOder;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaOder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaBan;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBoMon;
        private System.Windows.Forms.Button btnGoiMon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaOder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonViTinh;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblCTHoaDonBindingSource;
        private Hoang_TinDataSet Hoang_TinDataSet;
        private Hoang_TinDataSetTableAdapters.tblCTHoaDonTableAdapter tblCTHoaDonTableAdapter;
        private DataSet1 DataSet1;
        private System.Windows.Forms.BindingSource tblHoaDonBindingSource;
        private Hoang_TinDataSetTableAdapters.tblHoaDonTableAdapter tblHoaDonTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;




    }
}