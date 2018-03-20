namespace Hoang_Tin
{
    partial class frmHoadon
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
            this.tblCTHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Hoang_Tin.DataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.txtinhoadon = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblCTHoaDonTableAdapter = new Hoang_Tin.DataSet1TableAdapters.tblCTHoaDonTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblCTHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblCTHoaDonBindingSource
            // 
            this.tblCTHoaDonBindingSource.DataMember = "tblCTHoaDon";
            this.tblCTHoaDonBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "thoat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtinhoadon
            // 
            this.txtinhoadon.Location = new System.Drawing.Point(76, 23);
            this.txtinhoadon.Name = "txtinhoadon";
            this.txtinhoadon.Size = new System.Drawing.Size(100, 20);
            this.txtinhoadon.TabIndex = 1;
            this.txtinhoadon.TextChanged += new System.EventHandler(this.txtinhoadon_TextChanged);
            this.txtinhoadon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinhoadon_KeyPress);
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.tblCTHoaDonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hoang_Tin.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 72);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(554, 321);
            this.reportViewer1.TabIndex = 2;
            // 
            // tblCTHoaDonTableAdapter
            // 
            this.tblCTHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 444);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.txtinhoadon);
            this.Controls.Add(this.button1);
            this.Name = "frmHoadon";
            this.Text = "frmHoadon";
            this.Load += new System.EventHandler(this.frmHoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblCTHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtinhoadon;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblCTHoaDonBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.tblCTHoaDonTableAdapter tblCTHoaDonTableAdapter;
        private System.Windows.Forms.Button button2;
    }
}