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
    public partial class frmMatHang2 : Form
    {
        private MatHangControl _MatHangControl;
        public frmMatHang2()
        {
            InitializeComponent();
            _MatHangControl = new MatHangControl();
        }

        private void frmMatHang2_Load(object sender, EventArgs e)
        {
            LoadData();
            txtMaMH.Enabled = false;
            txtSoLuongTon.Enabled = false;
            txtTenMH.Enabled = false;
            btnHuy.Enabled = false;
        }
        public void Refresh()
        {
            _MatHangControl.SetMaMH(txtMaMH);
            txtTenMH.Text = "";
            txtSoLuongTon.Text = "";
        }
        public void LoadData()
        {
            _MatHangControl.Display(dataGridView_MatHang);
            btnTaoMoi.Enabled = true;
            btnLuu.Enabled = false;
        }
        public bool KiemTraTruocLuu()
        {
            if(txtTenMH.Text==""||txtSoLuongTon.Text=="")
            {
                return false;
            }
            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(KiemTraTruocLuu()==true)
            {
                _MatHangControl.InsertMatHang(txtMaMH, txtTenMH, cboDonViTinh, txtSoLuongTon);
                LoadData();

            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin , vui lòng nhập lại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnXoa.Enabled = true;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa !", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                _MatHangControl.DeleteMatHang(txtMaMH);
                LoadData();
                Refresh();
            }
            else
                return;
        }

        private void dataGridView_MatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMH.Text = Convert.ToString(dataGridView_MatHang.CurrentRow.Cells["MaMatHang"].Value);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            _MatHangControl.Exit(this);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnTaoMoi.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            txtMaMH.Enabled = true;
            txtSoLuongTon.Enabled = true;
            txtTenMH.Enabled = true;
            btnHuy.Enabled = true;

            Refresh();
        }


        
    }
}
