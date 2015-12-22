namespace DOANCNPM_VER1.GUI
{
    partial class frmBaoCaoDS
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
            this.quanLyDaiLyDataSet = new DOANCNPM_VER1.QuanLyDaiLyDataSet();
            this.bAOCAODSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAOCAODSTableAdapter = new DOANCNPM_VER1.QuanLyDaiLyDataSetTableAdapters.BAOCAODSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDaiLyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAOCAODSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "BaoCaoDSDataset";
            reportDataSource1.Value = this.bAOCAODSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DOANCNPM_VER1.Report.rpBaoCaoDS.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(714, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // quanLyDaiLyDataSet
            // 
            this.quanLyDaiLyDataSet.DataSetName = "QuanLyDaiLyDataSet";
            this.quanLyDaiLyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bAOCAODSBindingSource
            // 
            this.bAOCAODSBindingSource.DataMember = "BAOCAODS";
            this.bAOCAODSBindingSource.DataSource = this.quanLyDaiLyDataSet;
            // 
            // bAOCAODSTableAdapter
            // 
            this.bAOCAODSTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaoCaoDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmBaoCaoDS";
            this.Text = "frmBaoCaoDS";
            this.Load += new System.EventHandler(this.frmBaoCaoDS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDaiLyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAOCAODSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QuanLyDaiLyDataSet quanLyDaiLyDataSet;
        private System.Windows.Forms.BindingSource bAOCAODSBindingSource;
        private QuanLyDaiLyDataSetTableAdapters.BAOCAODSTableAdapter bAOCAODSTableAdapter;
    }
}