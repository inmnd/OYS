namespace OkulYönetimSistemi
{
    partial class ÖğrenciNotRapor
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ogrenciNotBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciNotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.okulDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.okulDataSet1 = new OkulYönetimSistemi.OkulDataSet1();
            this.ogrenciNotTableAdapter1 = new OkulYönetimSistemi.OkulDataSet1TableAdapters.OgrenciNotTableAdapter();
            this.ogrenciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.okulDataSet = new OkulYönetimSistemi.OkulDataSet();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinifBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciTableAdapter = new OkulYönetimSistemi.OkulDataSetTableAdapters.OgrenciTableAdapter();
            this.dataTable1TableAdapter = new OkulYönetimSistemi.OkulDataSetTableAdapters.DataTable1TableAdapter();
            this.sinifTableAdapter = new OkulYönetimSistemi.OkulDataSetTableAdapters.SinifTableAdapter();
            this.dersTableAdapter = new OkulYönetimSistemi.OkulDataSetTableAdapters.DersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciNotBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciNotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okulDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okulDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okulDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinifBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ogrenciNotBindingSource1
            // 
            this.ogrenciNotBindingSource1.DataMember = "OgrenciNot";
            this.ogrenciNotBindingSource1.DataSource = this.okulDataSet1BindingSource;
            // 
            // ogrenciNotBindingSource
            // 
            this.ogrenciNotBindingSource.DataMember = "OgrenciNot";
            this.ogrenciNotBindingSource.DataSource = this.okulDataSet1BindingSource;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ogrenciNotBindingSource1;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.ogrenciBindingSource1;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.dataTable1BindingSource;
            reportDataSource4.Name = "DataSet4";
            reportDataSource4.Value = this.sinifBindingSource;
            reportDataSource5.Name = "DataSet5";
            reportDataSource5.Value = this.dersBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OkulYönetimSistemi.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1303, 649);
            this.reportViewer1.TabIndex = 0;
            // 
            // okulDataSet1BindingSource
            // 
            this.okulDataSet1BindingSource.DataSource = this.okulDataSet1;
            this.okulDataSet1BindingSource.Position = 0;
            // 
            // okulDataSet1
            // 
            this.okulDataSet1.DataSetName = "OkulDataSet1";
            this.okulDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciNotTableAdapter1
            // 
            this.ogrenciNotTableAdapter1.ClearBeforeFill = true;
            // 
            // ogrenciBindingSource1
            // 
            this.ogrenciBindingSource1.DataMember = "Ogrenci";
            this.ogrenciBindingSource1.DataSource = this.okulDataSet;
            // 
            // okulDataSet
            // 
            this.okulDataSet.DataSetName = "OkulDataSet";
            this.okulDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.okulDataSet;
            // 
            // sinifBindingSource
            // 
            this.sinifBindingSource.DataMember = "Sinif";
            this.sinifBindingSource.DataSource = this.okulDataSet;
            // 
            // dersBindingSource
            // 
            this.dersBindingSource.DataMember = "Ders";
            this.dersBindingSource.DataSource = this.okulDataSet;
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "Ogrenci";
            this.ogrenciBindingSource.DataSource = this.okulDataSet;
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // sinifTableAdapter
            // 
            this.sinifTableAdapter.ClearBeforeFill = true;
            // 
            // dersTableAdapter
            // 
            this.dersTableAdapter.ClearBeforeFill = true;
            // 
            // ÖğrenciNotRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 649);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ÖğrenciNotRapor";
            this.Text = "ÖğrenciNotRapor";
            this.Load += new System.EventHandler(this.ÖğrenciNotRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciNotBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciNotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okulDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okulDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okulDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinifBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private OkulDataSet1 okulDataSet1;
        private System.Windows.Forms.BindingSource okulDataSet1BindingSource;
        private System.Windows.Forms.BindingSource ogrenciNotBindingSource;
        private System.Windows.Forms.BindingSource ogrenciNotBindingSource1;
        private OkulDataSet1TableAdapters.OgrenciNotTableAdapter ogrenciNotTableAdapter1;
        private OkulDataSet okulDataSet;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private OkulDataSetTableAdapters.OgrenciTableAdapter ogrenciTableAdapter;
        private System.Windows.Forms.BindingSource ogrenciBindingSource1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private OkulDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.BindingSource sinifBindingSource;
        private OkulDataSetTableAdapters.SinifTableAdapter sinifTableAdapter;
        private System.Windows.Forms.BindingSource dersBindingSource;
        private OkulDataSetTableAdapters.DersTableAdapter dersTableAdapter;
    }
}