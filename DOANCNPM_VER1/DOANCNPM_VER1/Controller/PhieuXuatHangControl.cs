using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOANCNPM_VER1.DataPlayer;
using System.Data;
using System.Windows.Forms;
using DOANCNPM_VER1.VO;

namespace DOANCNPM_VER1.Controller
{
    class PhieuXuatHangControl
    {
        private PhieuXuatHangData _PhieuXuatHangData;
        public List<PhieuXuatBO> _DSPhieuXuatBO;
        public PhieuXuatHangControl()
        {
            _PhieuXuatHangData = new PhieuXuatHangData();
            _DSPhieuXuatBO = new List<PhieuXuatBO>();
        }
        
        public void Display(DataGridView _DataGridView)
        {
            _DataGridView.DataSource = _PhieuXuatHangData.GetDSPhieuXuat_D() ;  
        }

        public DataTable LayTatCaPhieuXuat()
        {
            return _PhieuXuatHangData.GetDSPhieuXuat_D();
        }

        public DataTable LayTatCaPhieuXuatVaCT_PX()
        {
            return _PhieuXuatHangData.LayTatCaPhieuXuatVaCT_PX_D();
        }

        public List<PhieuXuatBO> LayDSPhieuXuat()
        {
            DataTable _DataTable = _PhieuXuatHangData.GetDSPhieuXuat_D();
            int _SoDong = _DataTable.Rows.Count;
            for (int i = 0; i < _SoDong; i++)
            {
                PhieuXuatBO _PhieuXuat = new PhieuXuatBO();
                DataRow dr = _DataTable.Rows[i];
                _PhieuXuat.MaDaiLy = dr["MaDaiLy"].ToString();
                _PhieuXuat.MaPhieuXuat = dr["MaPhieuXuatHang"].ToString();
                _PhieuXuat.NgayLapPhieu = Convert.ToDateTime(dr["NgayLapPhieu"]);
                _PhieuXuat.TongTien = Convert.ToInt32(dr["TongTien"]);
               
                _DSPhieuXuatBO.Add(_PhieuXuat);

            }
            return _DSPhieuXuatBO;
        }

        public void InsertPhieuXuat(Label maPhieuXuat,ComboBox maDaiLy, DateTimePicker ngayLapPhieu, Label tongTien)
        {
            DateTime _NgayLapPX = ngayLapPhieu.Value.Date;
            int _TongTien = Convert.ToInt32(tongTien.Text);
            _PhieuXuatHangData.InsertPhieuXuat_D(maPhieuXuat.Text, maDaiLy.SelectedItem.ToString(), _NgayLapPX, _TongTien);
        }

        public void DeletePhieuXuat(Label maPhieuXuat)
        {
            _PhieuXuatHangData.DeletePhieuXuat_D(maPhieuXuat.Text);
        }

        public void UpdatePhieuXuat(Label maPhieuXuat, ComboBox maDaiLy, DateTimePicker ngayLapPhieu, int tienTong)
        {
            DateTime _NgayLapPX = ngayLapPhieu.Value.Date;
            _PhieuXuatHangData.UpdatePhieuXuat_D(maPhieuXuat.Text,maDaiLy.Text, _NgayLapPX,tienTong);
        }
        public void SetMaPhieuXuat(Label maPhieuXuat)
        {
            int _RowCount = _PhieuXuatHangData.GetDSPhieuXuat_D().Rows.Count;
            maPhieuXuat.Text = "PX" + (_RowCount + 1).ToString();
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
