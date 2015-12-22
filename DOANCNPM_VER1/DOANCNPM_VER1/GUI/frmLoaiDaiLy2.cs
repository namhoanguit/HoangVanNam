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
    public partial class frmLoaiDaiLy2 : Form
    {
        LoaiDaiLyControl _LoaiDaiLyControl;
        public frmLoaiDaiLy2()
        {
            InitializeComponent();
            _LoaiDaiLyControl = new LoaiDaiLyControl();
        }

        public void LoadData()
        {
            _LoaiDaiLyControl.Display(dataGridView_LoaiDl);
            //_LoaiDaiLyControl.SetMaLoaiDL(lblMaLoaiDL);
        }
        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLoaDL.Text = dataGridView_LoaiDl.CurrentRow.Cells["MaloaiDaiLy"].Value.ToString();
            txtLoaiDL.Text = dataGridView_LoaiDl.CurrentRow.Cells["TenLoaiDaiLy"].Value.ToString();
            btnXoa.Enabled = true;
            btnTaoMoi.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void frmLoaiDaiLy2_Load(object sender, EventArgs e)
        {
            LoadData();
            txtLoaiDL.Enabled = false;
            txtMaLoaDL.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            Refresh();
        }
        // ham luu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            _LoaiDaiLyControl.InsertLoaiDLControl(txtMaLoaDL, txtLoaiDL);
            LoadData();
            Refresh();
            if (txtLoaiDL.Text == "" || txtMaLoaDL.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Đầy Đủ Thông Tin !");
            }
        }
        // ham xoa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            _LoaiDaiLyControl.DeleteLoaiDL(txtMaLoaDL);
            Refresh();
            LoadData();
        }
        // ham refresh
        public void Refresh()
        {
            //_LoaiDaiLyControl.SetMaLoaiDL(txtMaLoaDL);
            txtMaLoaDL.Text = "";
            txtLoaiDL.Text = "";
        }
        // ham tao moi
        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtLoaiDL.Enabled = true;
            txtMaLoaDL.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            Refresh();
            if(txtLoaiDL.Text==""||txtMaLoaDL.Text=="")
            {
                MessageBox.Show("Bạn Chưa Nhập Đầy Đủ Thông Tin !");
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Refresh();
            _LoaiDaiLyControl.Exit(this);
        }
    }
}
