namespace DOANCNPM_VER1.GUI
{
    partial class frmBaoCaoCN
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.baoCaoCNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyDaiLyDataSet = new DOANCNPM_VER1.QuanLyDaiLyDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.baoCaoCNTableAdapter = new DOANCNPM_VER1.QuanLyDaiLyDataSetTableAdapters.BaoCaoCNTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.baoCaoCNBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoCNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDaiLyDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoCNBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // baoCaoCNBindingSource
            // 
            this.baoCaoCNBindingSource.DataMember = "BaoCaoCN";
            this.baoCaoCNBindingSource.DataSource = this.quanLyDaiLyDataSet;
            // 
            // quanLyDaiLyDataSet
            // 
            this.quanLyDaiLyDataSet.DataSetName = "QuanLyDaiLyDataSet";
            this.quanLyDaiLyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "BaoCaoCNDataset";
            reportDataSource2.Value = this.baoCaoCNBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DOANCNPM_VER1.Report.rpBaoCaoCN.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(710, 272);
            this.reportViewer1.TabIndex = 0;
            // 
            // baoCaoCNTableAdapter
            // 
            this.baoCaoCNTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 272);
            this.panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.baoCaoCNBindingSource1;
            this.comboBox1.DisplayMember = "TenDaiLy";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(253, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "MaDaiLy";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(443, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Lọc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // baoCaoCNBindingSource1
            // 
            this.baoCaoCNBindingSource1.DataMember = "BaoCaoCN";
            this.baoCaoCNBindingSource1.DataSource = this.quanLyDaiLyDataSet;
            // 
            // frmBaoCaoCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 337);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmBaoCaoCN";
            this.Text = "frmBaoCaoCN";
            this.Load += new System.EventHandler(this.frmBaoCaoCN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoCNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDaiLyDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoCNBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QuanLyDaiLyDataSet quanLyDaiLyDataSet;
        private System.Windows.Forms.BindingSource baoCaoCNBindingSource;
        private QuanLyDaiLyDataSetTableAdapters.BaoCaoCNTableAdapter baoCaoCNTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource baoCaoCNBindingSource1;
    }
}