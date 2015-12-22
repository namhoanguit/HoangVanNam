using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace DOANCNPM_VER1.GUI
{
    public partial class frmBaoCaoCN : Form
    {
        public frmBaoCaoCN()
        {
            InitializeComponent();
        }

        private void frmBaoCaoCN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyDaiLyDataSet.BaoCaoCN' table. You can move, or remove it, as needed.
            this.baoCaoCNTableAdapter.Fill(this.quanLyDaiLyDataSet.BaoCaoCN);

            this.reportViewer1.RefreshReport();
            SetPara(comboBox1.SelectedValue.ToString());
            this.reportViewer1.RefreshReport();

        }

        private void SetPara(String val)
        {
            ReportParameter rp = new ReportParameter("MaDaiLy");
            rp.Values.Add(val);
            reportViewer1.LocalReport.SetParameters(rp);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SetPara(comboBox1.SelectedValue.ToString());
            reportViewer1.RefreshReport();
        }
    }
}
