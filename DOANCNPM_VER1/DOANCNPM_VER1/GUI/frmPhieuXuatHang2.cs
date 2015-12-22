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
    public partial class frmPhieuXuatHang2 : Form
    {
        private PhieuXuatHangControl _PhieuXuatHangControl;
        private CT_PhieuXuatControl _CT_PhieuXuatControl;
        public frmPhieuXuatHang2()
        {
            InitializeComponent();
            _PhieuXuatHangControl = new PhieuXuatHangControl();
            _CT_PhieuXuatControl = new CT_PhieuXuatControl();
        }

        public void LoadData()
        {
            try
            {
                _PhieuXuatHangControl.Display(dgrv_DS_PhieuXuat);
                _PhieuXuatHangControl.SetMaPhieuXuat(lblMaPhieuXuat);

                _CT_PhieuXuatControl.Display(dgrvDS_CT_PX);
                _CT_PhieuXuatControl.SetMaChiTiet_PX(txtMaCTPX);
                _CT_PhieuXuatControl.LoadComboboxMaMH(cboMaMatHang);
                cboMaMatHang.SelectedIndex = 0;
                Refresh();
            }
            catch
            {

            }
        }
        public void Refresh()
        {
            try
            {
                _PhieuXuatHangControl.SetMaPhieuXuat(lblMaPhieuXuat);
                _PhieuXuatHangControl.SetComboboxMaDL(cboMaDL); //note
                cboMaDL.SelectedIndex = 0;
                dtpNgayLapPhieu.Value = DateTime.Now;
                _PhieuXuatHangControl.SetTienTong(lblTienTong, cboMaDL);//note
                txtDonGia.Text = "";
                txtSoluong.Text = "";
                //txtThanhTien.Text = "";
                txtThanhTien.Enabled = false;
                cboMaMatHang.SelectedIndex = 0;
            }
            catch
            {

            }
        }

        // ham load phieu xuat hang
        private void frmPhieuXuatHang2_Load(object sender, EventArgs e)
        {
            LoadData();
            btnTaoMoiCT_PX.Enabled = true;
            btnLuuCT_PX.Enabled = true;
            btnXoaCT_PX.Enabled = true;

            btnTaoMoi.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            

           
            


        }
        // ham tao moi chi tiet phieu xuat
        private void btnTaoMoiCT_PX_Click(object sender, EventArgs e)
        {
            btnTaoMoiCT_PX.Enabled = false;
            btnLuuCT_PX.Enabled = true;
            btnXoaCT_PX.Enabled = false;
            _CT_PhieuXuatControl.SetMaChiTiet_PX(txtMaCTPX);
            Refresh();
        }

        // ham kiem tra phieu xuat truoc khi luu
        public bool KiemtraPhieuXuatTruocLuu()
        {
            if (lblMaPhieuXuat.Text == "" || lblTienTong.Text == "" || cboMaMatHang.Items.Count == 0)
            {
                return false;
            }
            else
                return true;
        }

        // ham kiem tra chi tuet phieu truoc khi luu
        public bool KiemtraCTPhieuXuatTruocLuu()
        {
            txtThanhTien.Text = Convert.ToString((Convert.ToInt64(txtSoluong.Text)) * (Convert.ToInt64(txtDonGia.Text)));
            if (txtDonGia.Text == "" || txtMaCTPX.Text == "" || txtMaPhieuXuat.Text == "" || txtSoluong.Text == "" || txtThanhTien.Text == "" || cboMaMatHang.Items.Count == 0)
            {
                return false;
            }
            else
                return true;
        }
        // ham luu chi tiet phieu xuat
        private void btnLuuCT_PX_Click(object sender, EventArgs e)
        {
            if (KiemtraCTPhieuXuatTruocLuu())
            {
                _CT_PhieuXuatControl.InsertCT_PX(txtMaCTPX, txtMaPhieuXuat, cboMaMatHang, txtSoluong, txtDonGia, txtThanhTien);
                LoadData();
                _CT_PhieuXuatControl.SetMaChiTiet_PX(txtMaCTPX);
            }
            else
            {
                MessageBox.Show("Bạn nhập thiếu thông tin , vui lòng kiểm tra lại !!", "Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
         // ham xoa chi tiet phieu xuat
        private void btnXoaCT_PX_Click(object sender, EventArgs e)
        {

            _CT_PhieuXuatControl.DeleteCT_PX(txtMaCTPX);
            LoadData();
        }

        private void dgrv_DS_PhieuXuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblMaPhieuXuat.Text = dgrv_DS_PhieuXuat.CurrentRow.Cells["MaPhieuXuatHang"].Value.ToString();
                cboMaDL.SelectedItem = dgrv_DS_PhieuXuat.CurrentRow.Cells["MaDaiLy"].Value.ToString();
                dtpNgayLapPhieu.Value = Convert.ToDateTime(dgrv_DS_PhieuXuat.CurrentRow.Cells["NgayLapPhieu"].Value);
                lblTienTong.Text = Convert.ToString(dgrv_DS_PhieuXuat.CurrentRow.Cells["TongTien"].Value);
                string _MaPhieXuat = dgrv_DS_PhieuXuat.CurrentRow.Cells["MaPhieuXuatHang"].Value.ToString();
                txtMaPhieuXuat.Text = _MaPhieXuat;
                btnLuu.Enabled = false;
                btnXoa.Enabled = true;
                btnTaoMoi.Enabled = true;
                DataTable _DS_CTPX = _CT_PhieuXuatControl.LayCT_PX_TheoMaDL_D(_MaPhieXuat);
                dgrvDS_CT_PX.DataSource = _DS_CTPX;
            }
            catch
            {

            }
        }

        //  ham thoat
        private void btnThoat_Click(object sender, EventArgs e)
        {
            _PhieuXuatHangControl.Exit(this);
        }

        //ham luu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (KiemtraPhieuXuatTruocLuu())
            {
                _PhieuXuatHangControl.InsertPhieuXuat(lblMaPhieuXuat, cboMaDL, dtpNgayLapPhieu, lblTienTong);
                _PhieuXuatHangControl.SetMaPhieuXuat(lblMaPhieuXuat);
                LoadData();
            }
            else
            {
                MessageBox.Show("Bạn nhập thiếu thông tin , vui lòng kiểm tra lại !!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ham xoa 
        private void btnXoa_Click(object sender, EventArgs e)
        {
            _PhieuXuatHangControl.DeletePhieuXuat(lblMaPhieuXuat);
            _PhieuXuatHangControl.SetMaPhieuXuat(lblMaPhieuXuat);
            LoadData();
        }

        //ham tao
        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            btnTaoMoi.Enabled = false;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            Refresh();
        }


        private void dgrvDS_CT_PX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaCTPX.Text = Convert.ToString(dgrvDS_CT_PX.CurrentRow.Cells["MaCT_PXH"].Value);
                txtMaPhieuXuat.Text = Convert.ToString(dgrvDS_CT_PX.CurrentRow.Cells["MaPhieuXuat"].Value);
                cboMaMatHang.SelectedItem = Convert.ToString(dgrvDS_CT_PX.CurrentRow.Cells["MaMatHang"].Value);
                txtDonGia.Text = Convert.ToString(dgrvDS_CT_PX.CurrentRow.Cells["DonGia"].Value);
                txtSoluong.Text = Convert.ToString(dgrvDS_CT_PX.CurrentRow.Cells["SoLuong"].Value);
                txtThanhTien.Text = Convert.ToString(dgrvDS_CT_PX.CurrentRow.Cells["ThanhTien"].Value);

            }
            catch
            {

            }
            btnXoaCT_PX.Enabled = false;
            btnTaoMoiCT_PX.Enabled = true;
            btnLuuCT_PX.Enabled = true;
        }

        private void lblTienTong_Click(object sender, EventArgs e)
        {

        }

    }
}
