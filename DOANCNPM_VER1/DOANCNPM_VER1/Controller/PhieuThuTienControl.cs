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
    class PhieuThuTienControl
    {
        private PhieuThuTienData _PhieuThuTienData;
        private HoSoDaiLyControl _HoSoDaiLyControl;
        public PhieuThuTienControl()
        {
            _PhieuThuTienData = new PhieuThuTienData();
            _HoSoDaiLyControl = new HoSoDaiLyControl();
        }

        public void Display(DataGridView dg)
        {
            dg.DataSource = _PhieuThuTienData.LayTatCaPhieuThu_D();
        }
        public DataTable LayTatCaPhieuThu()
        {
            return _PhieuThuTienData.LayTatCaPhieuThu_D();
        }

        public void LoadCboMaDL(ComboBox maDL)
        {
            maDL.Items.Clear();
            DataTable _DSDaiLy = _HoSoDaiLyControl.LayTatCaDaiLy();
            foreach(DataRow dr in _DSDaiLy.Rows)
            {
                maDL.Items.Add(dr["MaDaiLy"]);
            }
        }
        public void InsertPhieuThuTien(Label maPhieuThuTien, ComboBox maDaiLy, TextBox soTienThu, DateTimePicker ngayThuTien)
        {
            DateTime _NgayThuTien = ngayThuTien.Value.Date;
            int _SoTienThu = Convert.ToInt32(soTienThu.Text);
            _PhieuThuTienData.InsertPhieuThuTien_D(maPhieuThuTien.Text, maDaiLy.SelectedItem.ToString(),_SoTienThu,_NgayThuTien);
        }
        public void DeletePhieuThuTien(Label maPhieuThuTien)
        {
            _PhieuThuTienData.DeletePhieuThuTien_D(maPhieuThuTien.Text);
        }
        public void UpdatePhieuThuTien(Label maPhieuThuTien, ComboBox maDaiLy, TextBox soTienThu, DateTimePicker ngayThuTien)
        {
            DateTime _NgayThuTien = ngayThuTien.Value;
            int _SoTienThu = Convert.ToInt32(soTienThu.Text);
            _PhieuThuTienData.UpdatePhieuThuTien_D(maPhieuThuTien.Text, maDaiLy.SelectedItem.ToString(), _SoTienThu, _NgayThuTien);
        }

        public void SetMaPhieuThuTien(Label maPhieuThuTien)
        {
            DataTable _DSPhieuThu = _PhieuThuTienData.LayTatCaPhieuThu_D();
            int _RowCount = _DSPhieuThu.Rows.Count;
            if(_RowCount < 10)
            {
                maPhieuThuTien.Text = "PT0" + (_RowCount+1).ToString();
            }
            else
                maPhieuThuTien.Text = (_RowCount+1).ToString();
        }

        public void ExitPhieuThuTien(Form FormExit)
        {

            FormExit.Close();
        }

        public void Exit(Form FormExit)
        {
            DialogResult _Dr = MessageBox.Show("Bạn có chắc muốn thoát !", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
