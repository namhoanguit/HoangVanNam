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
    public partial class frmHoSoDaiLy1 : Form
    {
        private HoSoDaiLyControl _HoSoDaiLyControl;
        public frmHoSoDaiLy1()
        {
            InitializeComponent();
            _HoSoDaiLyControl = new HoSoDaiLyControl();
        }
        DataConnection con = new DataConnection();
        public void  LoadData()
        {
            _HoSoDaiLyControl.Display(dataGridViewDaiLy);
        }

        public void Refresh()
        {
            try
            {

                _HoSoDaiLyControl.SetMaDaiLy(lblMaDL);
                _HoSoDaiLyControl.LoadComboboxLoaiDL(cboLoaiDL);
                _HoSoDaiLyControl.LoadComboboxQuan(cboQuan);
                txtDiachi.Text = "";
                txtDienThoai.Text = "";
                txtMail.Text = "";
                txtTenDL.Text = "";
                cboLoaiDL.SelectedIndex = 0;
                cboQuan.SelectedIndex = 0;
                txtTienNo.Text = "0";
            }
            catch
            {

            }
        }
        // ham luu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (KiemTraTruocNhap())
                {
                    _HoSoDaiLyControl.InsertDaiLy(lblMaDL, txtTenDL, txtDiachi, cboQuan, cboLoaiDL, txtDienThoai, txtMail, dtpNgayTiepNhan, txtTienNo);
                    LoadData();
                    Refresh();
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập còn thiếu thông tin, vui lòng kiểm tra lại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (txtDiachi.Text == "" || txtDienThoai.Text == "" || txtMail.Text == "" || txtTenDL.Text == "" || txtTienNo.Text == "" || cboLoaiDL.Items.Count == 0 || cboQuan.Items.Count == 0)
            {
                return false;
            }
            else
                return true;
        }
        // ham load len du lieu
        private void frmHoSoDaiLy1_Load(object sender, EventArgs e)
        {
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                LoadData();
                Refresh();
                txtDiachi.Enabled = false;
                txtDienThoai.Enabled = false;
                txtMail.Enabled = false;
                txtTenDL.Enabled = false;
                txtTienNo.Enabled = false;
            
        }
        // ham xoa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa !","Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                _HoSoDaiLyControl.DeleteDaiLy(lblMaDL);
                LoadData();
                Refresh();
            }
            else
                return;
        }
        // ham tao moi
        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            txtDiachi.Enabled = true;
            txtDienThoai.Enabled = true;
            txtMail.Enabled = true;
            txtTenDL.Enabled = true;
            txtTienNo.Enabled = true;
            Refresh();
        }

        private void dataGridViewDaiLy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblMaDL.Text = Convert.ToString(dataGridViewDaiLy.CurrentRow.Cells["MaDaiLy"].Value);
                txtDiachi.Text = Convert.ToString(dataGridViewDaiLy.CurrentRow.Cells["DiaChi"].Value);
                txtDienThoai.Text = Convert.ToString(dataGridViewDaiLy.CurrentRow.Cells["DienThoai"].Value);
                txtMail.Text = Convert.ToString(dataGridViewDaiLy.CurrentRow.Cells["Email"].Value);
                txtTenDL.Text = Convert.ToString(dataGridViewDaiLy.CurrentRow.Cells["TenDaiLy"].Value);
                txtTienNo.Text = Convert.ToString(dataGridViewDaiLy.CurrentRow.Cells["TienNo"].Value);
                cboLoaiDL.SelectedItem = Convert.ToString(dataGridViewDaiLy.CurrentRow.Cells["MaLoaiDaiLy"].Value);
                cboQuan.SelectedItem = Convert.ToString(dataGridViewDaiLy.CurrentRow.Cells["MaQuan"].Value);
                dtpNgayTiepNhan.Value = Convert.ToDateTime(dataGridViewDaiLy.CurrentRow.Cells["NgayTiepNhan"].Value);

            }
            catch
            {

            }
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnTaoMoi.Enabled = true;

        }
        // ham them du lieu
        private void btnThemLoaiDL_Click(object sender, EventArgs e)
        {
            frmLoaiDaiLy2 _FormLoaiDL = new frmLoaiDaiLy2();
            _FormLoaiDL.Show();
            Refresh();
        }
        // ham them quan
        private void btnThemQuan_Click(object sender, EventArgs e)
        {
            frmQuan2 _FormQuan = new frmQuan2();
            _FormQuan.Show();
        }
        // ham thoat
        private void btnThoat_Click(object sender, EventArgs e)
        {
            _HoSoDaiLyControl.Exit(this);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cmbCachTim.Text == "Mã Đại Lý")
            {
                string sql = "select *from DaiLy where MaDaiLy like '%" + txtTuTim.Text + "%'";
                dataGridViewDaiLy.DataSource = con.Read(sql);
            }
            if (cmbCachTim.Text == "Tên Đại Lý")
            {
                string sql = "select *from DaiLy where TenDaiLy like N'%" + txtTuTim.Text + "%'";
                dataGridViewDaiLy.DataSource = con.Read(sql);
            }
        }

        private void txtTuTim_TextChanged(object sender, EventArgs e)
        {
            if (cmbCachTim.Text == "Mã Đại Lý")
            {
                string sql = "select *from DaiLy where MaDaiLy like '%" + txtTuTim.Text + "%'";
                dataGridViewDaiLy.DataSource = con.Read(sql);
            }
            if (cmbCachTim.Text == "Tên Đại Lý")
            {
                string sql = "select *from DaiLy where TenDaiLy like N'%" + txtTuTim.Text + "%'";
                dataGridViewDaiLy.DataSource = con.Read(sql);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnTaoMoi.Enabled = true;
            btnXoa.Enabled = true;
        }
    }
}
