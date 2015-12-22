using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using DOANCNPM_VER1.Controller;

namespace DOANCNPM_VER1.GUI
{
    public partial class frmDonViTinh2 : Form
    {
        private DonViTinhControl _DonViTinhControl;
        public frmDonViTinh2()
        {
            InitializeComponent();
            _DonViTinhControl = new DonViTinhControl();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void Refresh()
        {
            _DonViTinhControl.SetMaDVT(txtMaDVT);
            txtTenDVT.Text = "";
        }

        public void LoadData()
        {
            _DonViTinhControl.Display(dgrv_DVT);
        }

        private void frmDonViTinh2_Load(object sender, EventArgs e)
        {
            
            
                LoadData();
                btnTaoMoi.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                Refresh();
                txtMaDVT.Enabled = false;
                txtTenDVT.Enabled = false;
           
        }
         // ham luu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (KiemTraTruocNhap() == true)
                {
                    _DonViTinhControl.Insert_DVT(txtMaDVT, txtTenDVT);
                    LoadData();
                    Refresh();
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập tên đại lý , vui lòng nhập lại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {

            }
        }
         // ham kiem tra truoc khi nhap
        public bool KiemTraTruocNhap()
        {
            if (txtMaDVT.Text == "" || txtTenDVT.Text == "")
            {
                return false;
            }
            else
                return true;
        }
        // ham xoa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                _DonViTinhControl.Delete_DVT(txtMaDVT);
                LoadData();
                Refresh();
            }
            catch
            {

            }
        }

        // ham tao moi
        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnTaoMoi.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtTenDVT.Enabled = true;
            txtTenDVT.Enabled = true;

            Refresh();
        }

        private void dgrv_DVT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaDVT.Text = Convert.ToString(dgrv_DVT.CurrentRow.Cells["MaDonViTinh"].Value);
                txtTenDVT.Text = Convert.ToString(dgrv_DVT.CurrentRow.Cells["TenDonViTinh"].Value);
                btnLuu.Enabled = false;
                btnXoa.Enabled = true;
                btnTaoMoi.Enabled = true;
            }
            catch
            {

            }
        }

        // ham thoat
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát !", "Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                Dispose();
            }
            else
                return;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenDVT.Text = "";
        }
    }
}
