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
    public delegate DataTable Search(TextBox textbox);
    public partial class frmTraCuuSanPham : Form
    {
        TraCuuSanPhamControl _TraCuuSanPhamControl;
        public frmTraCuuSanPham()
        {
            InitializeComponent();
            _TraCuuSanPhamControl = new TraCuuSanPhamControl();
            
        }
        private void frmTraCuuSanPham_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }
        public void LoadDuLieu()
        {
            _TraCuuSanPhamControl.LoadDuLieu(dataGridViewTraCuu);
        }
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            if (cmbTraCuu.SelectedItem.ToString() == "Mã Mặt Hàng")
            {
                Search _search = _TraCuuSanPhamControl.SearchMaMatHang;
                dataGridViewTraCuu.DataSource = _search(txtTraCuu);
            }
            if (cmbTraCuu.SelectedItem.ToString() == "Tên Mặt Hàng")
            {
                Search _search = _TraCuuSanPhamControl.SearchTenMatHang;
                dataGridViewTraCuu.DataSource = _search(txtTraCuu);
            }
            this.AcceptButton = btnTraCuu;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK==MessageBox.Show("Bạn có chắc chắn muốn thoát không","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question));
            this.Close();
        }
    }
}
