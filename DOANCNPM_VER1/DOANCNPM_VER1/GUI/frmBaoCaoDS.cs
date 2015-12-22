using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DOANCNPM_VER1.GUI
{
    public partial class frmBaoCaoDS : Form
    {
        public frmBaoCaoDS()
        {
            InitializeComponent();
        }

        private void frmBaoCaoDS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyDaiLyDataSet.BAOCAODS' table. You can move, or remove it, as needed.
            this.bAOCAODSTableAdapter.Fill(this.quanLyDaiLyDataSet.BAOCAODS);

            this.reportViewer1.RefreshReport();
        }
    }
}
