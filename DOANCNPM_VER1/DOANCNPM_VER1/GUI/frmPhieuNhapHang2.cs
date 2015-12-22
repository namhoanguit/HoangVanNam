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
    public partial class frmPhieuNhapHang2 : Form
    {
        private CT_PhieuNhapControl _CT_PhieuNhapControl;
        private PhieuNhapHangControl _PhieuNhapHangControl;

        public frmPhieuNhapHang2()
        {
            InitializeComponent();
            _CT_PhieuNhapControl = new CT_PhieuNhapControl();
            _PhieuNhapHangControl = new PhieuNhapHangControl();
        }
        // ham refresh phieu nhap
        public void Refresh_PhieuNhap()
        {
            try
            {
                _PhieuNhapHangControl.SetMaPhieuNhap(lblMaPhieuNhap);
                dtpNgayLapPhieu.Value = DateTime.Now;
                lblTienTong.Text = "0";
            }
            catch
            {

            }
        }
        //ham refresh chi tiet phieu nhap
        public void Refresh_CT_PhieuNhap()
        {
            try
            {
                txtDonGia.Text = "";
                _CT_PhieuNhapControl.SetMaChiTiet_PX(txtMaCT_PN);
                txtSoluong.Text = "";
                txtThanhTien.Enabled = false;
                txtMaPN_CT_PN.Text = "NULL";
                _CT_PhieuNhapControl.LoadComboboxMaMH(cboMaMatHang);
                cboMaMatHang.SelectedIndex = 0;
            }
            catch
            {

            }
        }
        // ham load du lieu phieu nhap
        public void LoadDataPhieuNhap()
        {
            try
            {
                _PhieuNhapHangControl.Display(dgrv_PhieuNhap);
            }
            catch
            {
                MessageBox.Show("Kết nối CSDL có vấn đề , vui lòng kiểm tra lại CSDL !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        // ham load dât chi tiet phieu nhap
        public void LoadDataCT_PN()
        {
            try
            {
                _CT_PhieuNhapControl.Display(dgrvDS_CT_PX);
            }
            catch
            {
                MessageBox.Show("Kết nối CSDL có vấn đề , vui lòng kiểm tra lại CSDL !","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }
        private void frmPhieuNhapHang2_Load(object sender, EventArgs e)
        {
            LoadDataCT_PN();
            LoadDataPhieuNhap();
     
            Refresh_PhieuNhap();
            Refresh_CT_PhieuNhap();

            btnLuu.Enabled = true;
            btnTaoMoi.Enabled = true;
            btnXoa.Enabled = true;

            btnLuuCT_PX.Enabled = true;
            btnTaoMoiCT_PX.Enabled = true;
            btnXoaCT_PX.Enabled = true;
        }
        // ham kiem tra truoc khi luu
        public bool KiemTraTruocLuu_PNH()
        {
            if (lblMaPhieuNhap.Text == "" || lblTienTong.Text == "")
            {
                return false;
            }
            else
                return true;
        }
        //ham kiem tra truoc khi luu cua chi tiet phieu  nhap
        public bool KiemTraTruocLuu_CT_PNH()
        {
            txtThanhTien.Text = Convert.ToString((Convert.ToInt64(txtSoluong.Text)) * (Convert.ToInt64(txtDonGia.Text)));
            if (txtDonGia.Text == "" || txtMaCT_PN.Text == "" || txtMaPN_CT_PN.Text == "" || txtSoluong.Text == "" || txtThanhTien.Text == "" || cboMaMatHang.Items.Count == 0)
            {
                return false;
            }
            else
                return true;
        }

        private void dgrv_PhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblMaPhieuNhap.Text = Convert.ToString(dgrv_PhieuNhap.CurrentRow.Cells["MaPhieuNhapHang"].Value);
                dtpNgayLapPhieu.Value = Convert.ToDateTime(dgrv_PhieuNhap.CurrentRow.Cells["NgayLapPhieu"].Value);
                lblTienTong.Text = Convert.ToString(dgrv_PhieuNhap.CurrentRow.Cells["TongTien"].Value);

                string _MaPhieuNhap = Convert.ToString(dgrv_PhieuNhap.CurrentRow.Cells["MaPhieuNhapHang"].Value);
                DataTable _DSPhieuNhap = _CT_PhieuNhapControl.LayCT_PN_TheoMaPN_D(_MaPhieuNhap);
                dgrvDS_CT_PX.DataSource = _DSPhieuNhap;
                txtMaPN_CT_PN.Text = _MaPhieuNhap;
            }
            catch
            {

            }
            btnLuu.Enabled = false;
            btnTaoMoi.Enabled = true;
            btnXoa.Enabled = true;
        }
        // ham luu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocLuu_PNH())
            {
                _PhieuNhapHangControl.InsertPhieuNhap(lblMaPhieuNhap, dtpNgayLapPhieu, lblTienTong);
                LoadDataPhieuNhap();
                _CT_PhieuNhapControl.SetMaChiTiet_PX(txtMaCT_PN);
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin , vui lòng kiểm tra lại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        // ham xoa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            _PhieuNhapHangControl.DeletePhieuNhap(lblMaPhieuNhap);
            LoadDataPhieuNhap();
        }
        // ham luu chi tiet phieu xuat
        private void btnLuuCT_PX_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocLuu_CT_PNH())
            {
                _CT_PhieuNhapControl.InsertCT_PN(txtMaCT_PN, txtMaPN_CT_PN, cboMaMatHang, txtSoluong, txtDonGia, txtThanhTien);
                LoadDataCT_PN();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin , vui lòng kiểm tra lại !", "Thông Báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }
        // ham xoa phieu xuat
        private void btnXoaCT_PX_Click(object sender, EventArgs e)
        {
            _CT_PhieuNhapControl.DeleteCT_PX(txtMaCT_PN);
            LoadDataCT_PN();
            Refresh_CT_PhieuNhap();
        }

        private void dgrvDS_CT_PX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaCT_PN.Text = Convert.ToString(dgrvDS_CT_PX.CurrentRow.Cells["MaCT_PNH"].Value);
                txtMaPN_CT_PN.Text = Convert.ToString(dgrvDS_CT_PX.CurrentRow.Cells["MaPhieuNhap"].Value);
                cboMaMatHang.SelectedItem = Convert.ToString(dgrvDS_CT_PX.CurrentRow.Cells["MaMatHang"].Value);
                txtSoluong.Text = Convert.ToString(dgrvDS_CT_PX.CurrentRow.Cells["SoLuong"].Value);
                txtThanhTien.Text = Convert.ToString(dgrvDS_CT_PX.CurrentRow.Cells["ThanhTien"].Value);
                txtDonGia.Text = Convert.ToString(dgrvDS_CT_PX.CurrentRow.Cells["DonGia"].Value);
            }
            catch
            {

            }

            btnTaoMoiCT_PX.Enabled = true;
            btnLuuCT_PX.Enabled = true;
            btnLuuCT_PX.Enabled = false;
        }
        // ham tao moi
        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnTaoMoi.Enabled = false;
            Refresh_PhieuNhap();
            LoadDataPhieuNhap();
        }
        // ham tao moi chi tiet phieu xuat
        private void btnTaoMoiCT_PX_Click(object sender, EventArgs e)
        {
            btnTaoMoiCT_PX.Enabled = false;
            btnLuuCT_PX.Enabled = false;
            btnLuuCT_PX.Enabled = true;

            Refresh_CT_PhieuNhap();
            LoadDataCT_PN();
        }
        // ham thoat
        private void btnThoat_Click(object sender, EventArgs e)
        {
            _PhieuNhapHangControl.Exit(this);
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
