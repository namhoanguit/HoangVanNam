using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOANCNPM_VER1.DataPlayer;
using DOANCNPM_VER1.Controller;

namespace DOANCNPM_VER1.GUI
{
    public partial class frmQuan2 : Form
    {
        private QuanControl _QuanControl;
        public frmQuan2()
        {
            InitializeComponent();
            _QuanControl = new QuanControl();
        }

        public void LoadData()
        {
            try
            {
                _QuanControl.Display(dataGridView_Quan);
                //_QuanControl.SetMaQuan(txtMaQuan);
            }
            catch
            {

            }
        }

        public void Refresh()
        {
            txtQuan.Text = "";
            txtMaQuan.Text = "";
            //_QuanControl.SetMaQuan(lblMaQuan);
        }

        private void frmQuan2_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnEdit.Enabled = false;
            txtMaQuan.Enabled = false;
            txtQuan.Enabled = false;
            LoadData();
            Refresh();
        }
        // ham xoa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            _QuanControl.DeleteQuan(txtMaQuan);
            LoadData();
            Refresh();
        }
        // ham kiem tra truoc khi luu
        public bool KiemTraTruocLuu()
        {
            if (txtQuan.Text == "" || txtMaQuan.Text == "")
            {
                return false;
            }
            else
                return true;
        }
        // ham luu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocLuu())
            {
                _QuanControl.InsertQuanControl(txtMaQuan, txtQuan);
                LoadData();
                Refresh();
            }
            else
                MessageBox.Show("Bạn nhập thiếu thông tin , vui lòng kiểm tra lại !!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        // ham tao moi
        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnEdit.Enabled = true;
            btnXoa.Enabled = false;
            txtQuan.Enabled = true;
            txtMaQuan.Enabled = true;
            Refresh();
            //_QuanControl.SetMaQuan(txtMaQuan);
        }
        // ham thoat
        private void btnThoat_Click(object sender, EventArgs e)
        {
            _QuanControl.Exit(this);
        }

        private void dataGridView_Quan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                btnTaoMoi.Enabled = true;
                txtMaQuan.Text = dataGridView_Quan.CurrentRow.Cells["MaQuan"].Value.ToString();
                txtQuan.Text = dataGridView_Quan.CurrentRow.Cells["TenQuan"].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtMaQuan.Text = "";
            txtQuan.Text ="";
        }

    }
}
