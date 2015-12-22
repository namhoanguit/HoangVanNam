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
    public partial class frmPhieuNhapHang : Form
    {
        private CT_PhieuNhapControl _CT_PhieuNhapControl;
        private PhieuNhapHangControl _PhieuNhapHangControl;
        public frmPhieuNhapHang()
        {
            InitializeComponent();
            _CT_PhieuNhapControl = new CT_PhieuNhapControl();
            _PhieuNhapHangControl = new PhieuNhapHangControl();
        }
        // ham cap nhap
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            _PhieuNhapHangControl.UpdatePhieuNhap(lblMaPhieuNhap,dtpNgayLapPhieu,Convert.ToInt32(lblTienTong.Text));
            LoadDataPhieuNhap();
        }
        public void LoadDataPhieuNhap()
        {
            //_PhieuXuatHangControl.Display(dataGridView_PhieuXH);
            //_PhieuXuatHangControl.SetMaPhieuXuat(lblMaPhieuXuat);

            //_CT_PhieuXuatControl.Display(dgrvCT_PXH);
            //_CT_PhieuXuatControl.SetMaChiTiet_PX(txtMaCTPX);
            //_CT_PhieuXuatControl.LoadComboboxMaMH(cboMaMatHang);
            //cboMaMatHang.SelectedIndex = 0;
            //Refresh(); 

            _PhieuNhapHangControl.Display(dataGridView_PhieuXH);
            _PhieuNhapHangControl.SetMaPhieuNhap(lblMaPhieuNhap);
        }
        public void LoadDataCT_PN()
        {
            _CT_PhieuNhapControl.Display(dgrvCT_PXH);
        }

        private void frmPhieuNhapHang_Load(object sender, EventArgs e)
        {
            LoadDataCT_PN();
            LoadDataPhieuNhap();

            btnLuu.Enabled = true;
            btnCapNhat.Enabled = false;
            btnThemMoi.Enabled = false;
            btnXoa.Enabled = false;
            _CT_PhieuNhapControl.SetMaChiTiet_PX(txtMaCT_PN);
            _CT_PhieuNhapControl.LoadComboboxMaMH(cboMaMatHang);
            cboMaMatHang.SelectedIndex = 0;
            cboMaDL.SelectedIndex = 0;

            btnXoaCTPN.Enabled = false;
            btnThemMoiCTPN.Enabled = false;
            btnCapNhatCTPN.Enabled = false;
            btnLuuCTPN.Enabled = false;
        }
        // ham luu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            _PhieuNhapHangControl.InsertPhieuNhap(lblMaPhieuNhap, dtpNgayLapPhieu, lblTienTong);
            LoadDataPhieuNhap();
            _CT_PhieuNhapControl.SetMaChiTiet_PX(txtMaCT_PN);
        }
        // ham xoa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            _PhieuNhapHangControl.DeletePhieuNhap(lblMaPhieuNhap);
            LoadDataPhieuNhap();
        }

        private void dataGridView_PhieuXH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblMaPhieuNhap.Text = Convert.ToString(dataGridView_PhieuXH.CurrentRow.Cells["MaPhieuNhapHang"].Value);
            dtpNgayLapPhieu.Value = Convert.ToDateTime(dataGridView_PhieuXH.CurrentRow.Cells["NgayLapPhieu"].Value);
            lblTienTong.Text = Convert.ToString(dataGridView_PhieuXH.CurrentRow.Cells["TongTien"].Value);

            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = true;
            btnThemMoi.Enabled = true;

            string _MaPhieuNhap = Convert.ToString(dataGridView_PhieuXH.CurrentRow.Cells["MaPhieuNhapHang"].Value);
            //MessageBox.Show(_MaPhieuNhap);
            DataTable _DSPhieuNhap = _CT_PhieuNhapControl.LayCT_PN_TheoMaPN_D(_MaPhieuNhap);
            dgrvCT_PXH.DataSource = _DSPhieuNhap;
            lblMaPhieuNhap_CTPN.Text = _MaPhieuNhap;
            _CT_PhieuNhapControl.SetMaChiTiet_PX(txtMaCT_PN);
            btnLuuCTPN.Enabled = true;
        }
        // ham them moi
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
            btnThemMoi.Enabled = false;
            lblTienTong.Text = "0";
            _PhieuNhapHangControl.SetMaPhieuNhap(lblMaPhieuNhap);

            _CT_PhieuNhapControl.SetMaChiTiet_PX(txtMaCT_PN);
        }
        // ham thoat
        private void btnThoat_Click(object sender, EventArgs e)
        {
            _PhieuNhapHangControl.Exit(this);
        }
        // ham them moi chi tiet phieu nhap
        private void btnThemMoiCTPN_Click(object sender, EventArgs e)
        {
            btnCapNhatCTPN.Enabled = false;
            btnLuuCTPN.Enabled = false;
            btnLuuCTPN.Enabled = true;
            btnThemMoiCTPN.Enabled = false;
            _CT_PhieuNhapControl.SetMaChiTiet_PX(txtMaCT_PN);
            _CT_PhieuNhapControl.LoadComboboxMaMH(cboMaMatHang);
        }
        // ham luu chi tiet phieu nhap
        private void btnLuuCTPN_Click(object sender, EventArgs e)
        {
            //_CT_PhieuNhapControl.InsertCT_PN(txtMaCT_PN);
            //LoadDataCT_PN();
        }
        // ham xoa chi tiet phieu nhap
        private void btnXoaCTPN_Click(object sender, EventArgs e)
        {
            _CT_PhieuNhapControl.DeleteCT_PX(txtMaCT_PN);
            LoadDataCT_PN();
        }
        // ham cap nhat chi tiet phieu nhap
        private void btnCapNhatCTPN_Click(object sender, EventArgs e)
        {
            _CT_PhieuNhapControl.UpdateCT_PN(txtMaCT_PN, lblMaPhieuNhap, cboMaMatHang, txtSoluong, txtDonGia, txtThanhTien);
            LoadDataCT_PN();
        }

        private void dgrvCT_PXH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCT_PN.Text = Convert.ToString(dgrvCT_PXH.CurrentRow.Cells["MaCT_PNH"].Value);
            lblMaPhieuNhap_CTPN.Text = Convert.ToString(dgrvCT_PXH.CurrentRow.Cells["MaPhieuNhap"].Value);
            cboMaMatHang.SelectedItem = Convert.ToString(dgrvCT_PXH.CurrentRow.Cells["MaMatHang"].Value);
            txtSoluong.Text = Convert.ToString(dgrvCT_PXH.CurrentRow.Cells["SoLuong"].Value);
            txtThanhTien.Text = Convert.ToString(dgrvCT_PXH.CurrentRow.Cells["ThanhTien"].Value);
            txtDonGia.Text = Convert.ToString(dgrvCT_PXH.CurrentRow.Cells["DonGia"].Value);

            btnThemMoiCTPN.Enabled = true;
            btnXoaCTPN.Enabled = true;
            btnLuuCTPN.Enabled = false;
            btnCapNhatCTPN.Enabled = true;
        }
        
        private void btnMaMatHang_Click(object sender, EventArgs e)
        {
            frmMatHang2 _FormMatHang = new frmMatHang2();
            _FormMatHang.Show();
        }


    }
}
