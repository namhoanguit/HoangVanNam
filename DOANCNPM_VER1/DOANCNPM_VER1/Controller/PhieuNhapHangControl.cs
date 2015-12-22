using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DOANCNPM_VER1.DataPlayer;
using System.Windows.Forms;

namespace DOANCNPM_VER1.Controller
{
    class PhieuNhapHangControl
    {
        private PhieuNhapHangData _PhieuNhapHangData;

        public PhieuNhapHangControl()
        {
            _PhieuNhapHangData = new PhieuNhapHangData();

        }
        
        public void Display(DataGridView _DataGridView)
        {
            _DataGridView.DataSource = _PhieuNhapHangData.LaytatCaPhieuNhap();
        }

        public DataTable LayTatCaPhieuNhap()
        {
            return _PhieuNhapHangData.LaytatCaPhieuNhap();
        }

        public void InsertPhieuNhap(Label maPhieuNhap, DateTimePicker ngayLapPhieu, Label tongTien)
        {
            DateTime _NgayLapPX = ngayLapPhieu.Value.Date;
            int _TongTien = Convert.ToInt32(tongTien.Text);
            _PhieuNhapHangData.InsertPhieuNhap_D(maPhieuNhap.Text,  _NgayLapPX, _TongTien);
        }

        public void DeletePhieuNhap(Label maPhieuNhap)
        {
            _PhieuNhapHangData.DeletePhieuNhap_D(maPhieuNhap.Text);
        }

        public void UpdatePhieuNhap(Label maPhieuNhap, DateTimePicker ngayLapPhieu, int tienTong)
        {
            DateTime _NgayLapPN = ngayLapPhieu.Value.Date;
            _PhieuNhapHangData.UpdatePhieuNhap_D(maPhieuNhap.Text,_NgayLapPN,tienTong);
        }
        public void SetMaPhieuNhap(Label maPhieuNhap)
        {
            int _RowCount = _PhieuNhapHangData.LaytatCaPhieuNhap().Rows.Count;
            maPhieuNhap.Text = "PX" + (_RowCount + 1).ToString();
        }

        public void SetTienTong(Label tienTong , ComboBox maDaiLy)
        {

        }


        public void SetComboboxMaDL(ComboBox maDaiLy)
        {

        }

        public void Exit(Form FormExit)
        {
            DialogResult _Dr = MessageBox.Show("Bạn có chắc muốn thoát !","Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Question );
            if (_Dr == DialogResult.OK)
            {
                FormExit.Close();
                FormExit.Dispose();
            }
            else
                return;

        }
    }
}
