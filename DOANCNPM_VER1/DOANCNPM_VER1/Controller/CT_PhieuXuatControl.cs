using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DOANCNPM_VER1.DataPlayer;
using System.Windows.Forms;
using DOANCNPM_VER1.VO;

namespace DOANCNPM_VER1.Controller
{
    class CT_PhieuXuatControl
    {
        private CT_PhieuXuatData _CT_PhieuXuatData;
        private PhieuXuatHangControl _PhieuXuatHangControl;
        private MatHangControl _MatHangControl;
        public CT_PhieuXuatControl()
        {
            _CT_PhieuXuatData = new CT_PhieuXuatData();
            _PhieuXuatHangControl = new PhieuXuatHangControl();
            _MatHangControl = new MatHangControl();
        }

        public void Display(DataGridView dg)
        {
            dg.DataSource = _CT_PhieuXuatData.LayTatCaCT_PX_D();
        }

        public DataTable LayCT_PX_TheoMaDL_D(string maPX)
        {
            return _CT_PhieuXuatData.LayCT_PX_TheoMaDL_D(maPX);
        }

        public void LoadComboboxMaPX(ComboBox maPhieuXuat)
        {
            maPhieuXuat.Items.Clear();
            List<PhieuXuatBO> _DSPhieuXuat = _PhieuXuatHangControl.LayDSPhieuXuat();
            for(int i=0;i<_DSPhieuXuat.Count;i++)
            {
                maPhieuXuat.Items.Add(_DSPhieuXuat[i].MaPhieuXuat.ToString());
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
            DataTable _DS_CTPX = _CT_PhieuXuatData.LayTatCaCT_PX_D();
            int _RowCount = _DS_CTPX.Rows.Count;
            if (_RowCount < 10)
            {
                maCT_PX.Text = "CTPX0" + (_RowCount + 1).ToString();
            }
            else
                maCT_PX.Text = "CTPX" + (_RowCount + 1).ToString();
        }

        public void InsertCT_PX(TextBox maCT_PX, TextBox maPXH, ComboBox maMatHang, TextBox soLuong, TextBox donGia, TextBox thanhTien)
        {
            try
            {
                _CT_PhieuXuatData.InsertCT_PX_D(maCT_PX.Text, maPXH.Text, maMatHang.SelectedItem.ToString(), Convert.ToInt32(soLuong.Text), Convert.ToInt32(donGia.Text), Convert.ToInt32(thanhTien.Text));

            }
            catch
            {

            }
        }

        public void UpdateCT_PX(Label maCT_PX, ComboBox maPXH, ComboBox maMatHang, TextBox soLuong, TextBox donGia, TextBox thanhTien)
        {
            int _SoLuong = Convert.ToInt32(soLuong.Text);
            int _DonGia = Convert.ToInt32(donGia.Text);
            int _ThanhTien = Convert.ToInt32(thanhTien.Text);
            _CT_PhieuXuatData.UpdateCT_PX_D(maCT_PX.Text, maPXH.SelectedItem.ToString(), maMatHang.SelectedItem.ToString(), _SoLuong,_DonGia,_ThanhTien);
        }
        public void DeleteCT_PX(TextBox maCT_PX)
        {
            _CT_PhieuXuatData.DeleteCT_PX_D(maCT_PX.Text);
        }

        public void Exit(Form formExit)
        {
            MessageBox.Show("Bạn có muốn thoát !");
            formExit.Close();
        }
    }

}
