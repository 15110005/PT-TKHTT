namespace Hoang_Tin
{
    partial class sldanhthu
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Hoang_TinDataSet = new Hoang_Tin.Hoang_TinDataSet();
            this.tblDoanhThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDoanhThuTableAdapter = new Hoang_Tin.Hoang_TinDataSetTableAdapters.tblDoanhThuTableAdapter();
            this.dtformyaer = new System.Windows.Forms.DateTimePicker();
            this.dttoyear = new System.Windows.Forms.DateTimePicker();
            this.btnthongkesl = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Hoang_TinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoanhThuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblDoanhThuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hoang_Tin.sldanhthu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 113);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(406, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // Hoang_TinDataSet
            // 
            this.Hoang_TinDataSet.DataSetName = "Hoang_TinDataSet";
            this.Hoang_TinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDoanhThuBindingSource
            // 
            this.tblDoanhThuBindingSource.DataMember = "tblDoanhThu";
            this.tblDoanhThuBindingSource.DataSource = this.Hoang_TinDataSet;
            // 
            // tblDoanhThuTableAdapter
            // 
            this.tblDoanhThuTableAdapter.ClearBeforeFill = true;
            // 
            // dtformyaer
            // 
            this.dtformyaer.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtformyaer.Location = new System.Drawing.Point(12, 44);
            this.dtformyaer.Name = "dtformyaer";
            this.dtformyaer.Size = new System.Drawing.Size(103, 20);
            this.dtformyaer.TabIndex = 1;
            // 
            // dttoyear
            // 
            this.dttoyear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttoyear.Location = new System.Drawing.Point(136, 44);
            this.dttoyear.Name = "dttoyear";
            this.dttoyear.Size = new System.Drawing.Size(103, 20);
            this.dttoyear.TabIndex = 1;
            // 
            // btnthongkesl
            // 
            this.btnthongkesl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthongkesl.Location = new System.Drawing.Point(267, 44);
            this.btnthongkesl.Name = "btnthongkesl";
            this.btnthongkesl.Size = new System.Drawing.Size(75, 23);
            this.btnthongkesl.TabIndex = 2;
            this.btnthongkesl.Text = "Thống kê";
            this.btnthongkesl.UseVisualStyleBackColor = true;
            this.btnthongkesl.Click += new System.EventHandler(this.btnthongkesl_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(349, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sldanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnthongkesl);
            this.Controls.Add(this.dttoyear);
            this.Controls.Add(this.dtformyaer);
            this.Controls.Add(this.reportViewer1);
            this.Name = "sldanhthu";
            this.Text = "sldanhthu";
            this.Load += new System.EventHandler(this.sldanhthu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Hoang_TinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoanhThuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblDoanhThuBindingSource;
        private Hoang_TinDataSet Hoang_TinDataSet;
        private Hoang_TinDataSetTableAdapters.tblDoanhThuTableAdapter tblDoanhThuTableAdapter;
        private System.Windows.Forms.DateTimePicker dtformyaer;
        private System.Windows.Forms.DateTimePicker dttoyear;
        private System.Windows.Forms.Button btnthongkesl;
        private System.Windows.Forms.Button button1;
    }
}