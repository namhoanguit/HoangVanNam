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
    
    public partial class frmPhieuThuTien_1 : Form
    {
        private PhieuThuTienControl _PhieuThuTienControl;
        
        public frmPhieuThuTien_1()
        {
            InitializeComponent();
            _PhieuThuTienControl = new PhieuThuTienControl();
            _PhieuThuTienControl = new PhieuThuTienControl();
        }

        public void LoadData()
        {
            try
            {
                _PhieuThuTienControl.Display(dgrv_PhieuThuTien);
            }
            catch
            {
                
            }
        }
        public void Refresh()
        {
            _PhieuThuTienControl.SetMaPhieuThuTien(lblMaPhieuThu);
            txtSoTienThu.Text = "";
            dtpNgayThuTien.Value = DateTime.Now;
            _PhieuThuTienControl.LoadCboMaDL(cboMaDaiLy);
            cboMaDaiLy.SelectedIndex = 0;
            dtpNgayThuTien.Value = DateTime.Now;
        }

        // ham kiem tra truoc khi luu
        public bool KiemTraTruocLuu()
        {
            if (lblMaPhieuThu.Text == "" || cboMaDaiLy.Items.Count == 0 || txtSoTienThu.Text == "")
            {
                return false;
            }
            else
                return true;
        }
        private void frmPhieuThuTien_1_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
                Refresh();
                btnXoa.Enabled = false;
                btnTaoMoi.Enabled = false;
                btnLuu.Enabled = true;
            }
            catch
            {

            }
        }

        private void dgrv_PhieuThuTien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblMaPhieuThu.Text = Convert.ToString(dgrv_PhieuThuTien.CurrentRow.Cells["MaPhieuThuTien"].Value);
                cboMaDaiLy.SelectedItem = Convert.ToString(dgrv_PhieuThuTien.CurrentRow.Cells["MaDaiLy"].Value);
                txtSoTienThu.Text = Convert.ToString(dgrv_PhieuThuTien.CurrentRow.Cells["SoTienThu"].Value);
                dtpNgayThuTien.Value = Convert.ToDateTime(dgrv_PhieuThuTien.CurrentRow.Cells["NgayThuTien"].Value);
                btnLuu.Enabled = false;
                btnTaoMoi.Enabled = true;
                btnXoa.Enabled = true;
            }
            catch
            {

            }
        }
        // ham luu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocLuu())
            {
                _PhieuThuTienControl.InsertPhieuThuTien(lblMaPhieuThu, cboMaDaiLy, txtSoTienThu, dtpNgayThuTien);
                LoadData();
                Refresh();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin , vui lòng kiểm tra lại !!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }
        // ham xoa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            _PhieuThuTienControl.DeletePhieuThuTien(lblMaPhieuThu);
            LoadData();
            Refresh();
        }
        //ham tao moi
        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            btnTaoMoi.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            Refresh();
        }
        // ham thoat
        private void btnThoat_Click(object sender, EventArgs e)
        {
            _PhieuThuTienControl.Exit(this);
        }

    }
}
