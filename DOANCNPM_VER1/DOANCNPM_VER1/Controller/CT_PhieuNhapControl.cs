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
    class CT_PhieuNhapControl
    {
        private CT_PhieuNhapData _CT_PhieuNhapData;
        private PhieuXuatHangControl _PhieuXuatHangControl;
        private MatHangControl _MatHangControl;
        public CT_PhieuNhapControl()
        {
            _CT_PhieuNhapData = new CT_PhieuNhapData();
            _PhieuXuatHangControl = new PhieuXuatHangControl();
            _MatHangControl = new MatHangControl();
        }

        public void Display(DataGridView dg)
        {
            dg.DataSource = _CT_PhieuNhapData.LayTatCaCT_PN_D();
        }

        public DataTable LayCT_PN_TheoMaPN_D(string maPN)
        {
            return _CT_PhieuNhapData.LayCT_PN_TheoMaPN_D(maPN);
        }

        public void LoadComboboxMaPN(ComboBox maPhieuNhap)
        {
            maPhieuNhap.Items.Clear();
            DataTable _DSCT_PhieuNhap= _CT_PhieuNhapData.LayTatCaCT_PN_D();
            foreach(DataRow dr in _DSCT_PhieuNhap.Rows)
            {
                maPhieuNhap.Items.Add(dr["MaPhieuNhap"]);
            }
        }

        public void LoadComboboxMaMH(ComboBox maMatHang)
        {
            DataTable _DSMatHang = _MatHangControl.LayTatCaMatHang();
            maMatHang.Items.Clear();
            foreach (DataRow dr in _DSMatHang.Rows)
            {
                maMatHang.Items.Add(dr["MaMatHang"]);
            }
        }

        public void SetMaChiTiet_PX(TextBox maCT_PX) 
        {
            DataTable _DS_CTPX = _CT_PhieuNhapData.LayTatCaCT_PN_D();
            int _RowCount = _DS_CTPX.Rows.Count;
            if (_RowCount < 10)
            {
                maCT_PX.Text = "CTPX0" + (_RowCount + 1).ToString();
            }
            else
                maCT_PX.Text = "CTPX" + (_RowCount + 1).ToString();
        }

        public void InsertCT_PN(TextBox maCT_PN, TextBox maPNH, ComboBox maMatHang, TextBox soLuong, TextBox donGia, TextBox thanhTien)
        {
            try
            {
                _CT_PhieuNhapData.InsertCT_PN_D(maCT_PN.Text, maPNH.Text, maMatHang.SelectedItem.ToString(), Convert.ToInt32(soLuong.Text), Convert.ToInt32(donGia.Text), Convert.ToInt32(thanhTien.Text));

            }
            catch
            {

            }
        }

        public void UpdateCT_PN(TextBox maCT_PN, Label maPNH, ComboBox maMatHang, TextBox soLuong, TextBox donGia, TextBox thanhTien)
        {
            int _SoLuong = Convert.ToInt32(soLuong.Text);
            int _DonGia = Convert.ToInt32(donGia.Text);
            int _ThanhTien = Convert.ToInt32(thanhTien.Text);
            _CT_PhieuNhapData.UpdateCT_PN_D(maCT_PN.Text, maPNH.Text, maMatHang.SelectedItem.ToString(), _SoLuong,_DonGia,_ThanhTien);
        }
        public void DeleteCT_PX(TextBox maCT_PN)
        {
            _CT_PhieuNhapData.DeleteCT_PN_D(maCT_PN.Text);
        }

        public void Exit(Form formExit)
        {
            MessageBox.Show("Bạn có muốn thoát !");
            formExit.Close();
        }
    }
}
