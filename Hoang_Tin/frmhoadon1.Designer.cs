namespace Hoang_Tin
{
    partial class frmhoadon1
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
            this.tblCTHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Hoang_TinDataSet = new Hoang_Tin.Hoang_TinDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblCTHoaDonTableAdapter = new Hoang_Tin.Hoang_TinDataSetTableAdapters.tblCTHoaDonTableAdapter();
            this.txthoadon1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbohoadon1 = new System.Windows.Forms.ComboBox();
            this.tblHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblHoaDonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblHoaDonTableAdapter = new Hoang_Tin.Hoang_TinDataSetTableAdapters.tblHoaDonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblCTHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hoang_TinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHoaDonBindingSource1)).BeginInit();
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "datase007";
            reportDataSource1.Value = this.tblCTHoaDonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hoang_Tin.frmhoadon1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 73);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(681, 349);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // tblCTHoaDonTableAdapter
            // 
            this.tblCTHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // txthoadon1
            // 
            this.txthoadon1.Enabled = false;
            this.txthoadon1.Location = new System.Drawing.Point(164, 32);
            this.txthoadon1.Name = "txthoadon1";
            this.txthoadon1.Size = new System.Drawing.Size(100, 20);
            this.txthoadon1.TabIndex = 1;
            this.txthoadon1.Visible = false;
            this.txthoadon1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(580, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cbohoadon1
            // 
            this.cbohoadon1.DataSource = this.tblHoaDonBindingSource;
            this.cbohoadon1.DisplayMember = "MaOder";
            this.cbohoadon1.FormattingEnabled = true;
            this.cbohoadon1.Location = new System.Drawing.Point(24, 31);
            this.cbohoadon1.Name = "cbohoadon1";
            this.cbohoadon1.Size = new System.Drawing.Size(121, 21);
            this.cbohoadon1.TabIndex = 3;
            this.cbohoadon1.ValueMember = "MaHD";
            this.cbohoadon1.Visible = false;
            this.cbohoadon1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // tblHoaDonBindingSource
            // 
            this.tblHoaDonBindingSource.DataMember = "tblHoaDon";
            this.tblHoaDonBindingSource.DataSource = this.Hoang_TinDataSet;
            // 
            // tblHoaDonBindingSource1
            // 
            this.tblHoaDonBindingSource1.DataMember = "tblHoaDon";
            this.tblHoaDonBindingSource1.DataSource = this.Hoang_TinDataSet;
            // 
            // tblHoaDonTableAdapter
            // 
            this.tblHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // frmhoadon1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 422);
            this.Controls.Add(this.cbohoadon1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txthoadon1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmhoadon1";
            this.Text = "frmhoadon1";
            this.Load += new System.EventHandler(this.frmhoadon1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblCTHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hoang_TinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHoaDonBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblCTHoaDonBindingSource;
        private Hoang_TinDataSet Hoang_TinDataSet;
        private Hoang_TinDataSetTableAdapters.tblCTHoaDonTableAdapter tblCTHoaDonTableAdapter;
        private System.Windows.Forms.TextBox txthoadon1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbohoadon1;
        private System.Windows.Forms.BindingSource tblHoaDonBindingSource;
        private Hoang_TinDataSetTableAdapters.tblHoaDonTableAdapter tblHoaDonTableAdapter;
        private System.Windows.Forms.BindingSource tblHoaDonBindingSource1;

    }
}