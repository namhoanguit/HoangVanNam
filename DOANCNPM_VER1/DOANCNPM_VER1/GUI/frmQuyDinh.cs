using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANCNPM_VER1.GUI
{
    public partial class frmQuyDinh : Form
    {
        public frmQuyDinh()
        {
            InitializeComponent();
        }

        private void btnCapNhat1_Click(object sender, EventArgs e)
        {
            frmQuyDinh1 qd1 = new frmQuyDinh1();
            qd1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmQuyDinh2 qd2 = new frmQuyDinh2();
            qd2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmQuyDinh3 qd3 = new frmQuyDinh3();
            qd3.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
