using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOANCNPM_VER1.Controller;
namespace DOANCNPM_VER1.GUI
{
    public partial class frmThongKeSanPham : Form
    {
        private MatHangControl _MatHang;
        public frmThongKeSanPham()
        {
            InitializeComponent();
            _MatHang = new MatHangControl();
        }

        private void frmThongKeSanPham_Load(object sender, EventArgs e)
        {
            _MatHang.Display(dtgvTKSanPham);
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            _MatHang.Exit(this);
        }
    }
}
