namespace Hoang_Tin
{
    partial class slhangban
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.cbomamon = new System.Windows.Forms.ComboBox();
            this.btnthongke = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.hoang_TinDataSet = new Hoang_Tin.Hoang_TinDataSet();
            this.tblCTHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCTHoaDonTableAdapter = new Hoang_Tin.Hoang_TinDataSetTableAdapters.tblCTHoaDonTableAdapter();
            this.tblCTDoanhThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCTDoanhThuTableAdapter = new Hoang_Tin.Hoang_TinDataSetTableAdapters.tblCTDoanhThuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hoang_TinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCTHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCTDoanhThuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbomamon
            // 
            this.cbomamon.DataSource = this.tblCTHoaDonBindingSource;
            this.cbomamon.DisplayMember = "TenMon";
            this.cbomamon.FormattingEnabled = true;
            this.cbomamon.Location = new System.Drawing.Point(43, 33);
            this.cbomamon.Name = "cbomamon";
            this.cbomamon.Size = new System.Drawing.Size(121, 21);
            this.cbomamon.TabIndex = 0;
            this.cbomamon.ValueMember = "MaMon";
            // 
            // btnthongke
            // 
            this.btnthongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthongke.Location = new System.Drawing.Point(231, 22);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(89, 40);
            this.btnthongke.TabIndex = 1;
            this.btnthongke.Text = "Thống kê";
            this.btnthongke.UseVisualStyleBackColor = true;
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(399, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.tblCTDoanhThuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hoang_Tin.slhangban.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 68);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(486, 281);
            this.reportViewer1.TabIndex = 2;
            // 
            // hoang_TinDataSet
            // 
            this.hoang_TinDataSet.DataSetName = "Hoang_TinDataSet";
            this.hoang_TinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCTHoaDonBindingSource
            // 
            this.tblCTHoaDonBindingSource.DataMember = "tblCTHoaDon";
            this.tblCTHoaDonBindingSource.DataSource = this.hoang_TinDataSet;
            // 
            // tblCTHoaDonTableAdapter
            // 
            this.tblCTHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // tblCTDoanhThuBindingSource
            // 
            this.tblCTDoanhThuBindingSource.DataMember = "tblCTDoanhThu";
            this.tblCTDoanhThuBindingSource.DataSource = this.hoang_TinDataSet;
            // 
            // tblCTDoanhThuTableAdapter
            // 
            this.tblCTDoanhThuTableAdapter.ClearBeforeFill = true;
            // 
            // slhangban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 348);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnthongke);
            this.Controls.Add(this.cbomamon);
            this.Name = "slhangban";
            this.Text = "slhangban";
            this.Load += new System.EventHandler(this.slhangban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hoang_TinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCTHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCTDoanhThuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbomamon;
        private System.Windows.Forms.Button btnthongke;
        private System.Windows.Forms.Button button2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Hoang_TinDataSet hoang_TinDataSet;
        private System.Windows.Forms.BindingSource tblCTHoaDonBindingSource;
        private Hoang_TinDataSetTableAdapters.tblCTHoaDonTableAdapter tblCTHoaDonTableAdapter;
        private System.Windows.Forms.BindingSource tblCTDoanhThuBindingSource;
        private Hoang_TinDataSetTableAdapters.tblCTDoanhThuTableAdapter tblCTDoanhThuTableAdapter;
    }
}