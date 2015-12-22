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
    
    class HoSoDaiLyControl
    {
        private HoSoDaiLyData _HoSoDaiLyData;
        public HoSoDaiLyControl()
        {
            _HoSoDaiLyData = new HoSoDaiLyData();

        }
        public void Display(DataGridView dg)
        {
            DataTable _DS_DaiLy = _HoSoDaiLyData.GetDS_DaiLy();
            dg.DataSource = _DS_DaiLy;
        }
        public DataTable LayTatCaDaiLy()
        {
            return _HoSoDaiLyData.GetDS_DaiLy();
        }
        public void InsertDaiLy(Label maDaiLy,TextBox tenDL,TextBox diachi,ComboBox quan,ComboBox loaiDL,TextBox dienThoai, TextBox email, DateTimePicker datetimePicker,TextBox tienNo)
        {
            string _NgayTiepNhan = datetimePicker.Value.ToShortDateString();
            int _TienNo = Convert.ToInt32(tienNo.Text);
            _HoSoDaiLyData.Insert_DaiLy_D(maDaiLy.Text,tenDL.Text,loaiDL.SelectedItem.ToString(),dienThoai.Text,diachi.Text,quan.SelectedItem.ToString(),_NgayTiepNhan,_TienNo,email.Text);
        }

        public void UpdateDaiLy()
        {

        }
        public void SetMaDaiLy(Label maDaiLy)
        {
            DataTable _DS_DaiLy = _HoSoDaiLyData.GetDS_DaiLy();
            int _RowCount = _DS_DaiLy.Rows.Count;
            if (_RowCount < 10)
            {
                maDaiLy.Text = "DL00" + (_RowCount+1).ToString();
            }
            else
                maDaiLy.Text = "DL" + (_RowCount+1).ToString();
        }
        public void LoadComboboxQuan(ComboBox quan)
        {
            quan.Items.Clear();
            QuanControl _QuanControl = new QuanControl();
            DataTable _DS_Quan = _QuanControl.GetDS_Quan();
            foreach(DataRow dr in _DS_Quan.Rows)
            {
                quan.Items.Add(dr["MaQuan"]);
            }
        }
        public void LoadComboboxLoaiDL(ComboBox loaiDaiLy)
        {
            loaiDaiLy.Items.Clear();
            LoaiDaiLyControl _LoaiDL = new LoaiDaiLyControl();
            DataTable _DS_Quan = _LoaiDL.getDSLoaiDL();
            foreach(DataRow dr in _DS_Quan.Rows)
            {
                loaiDaiLy.Items.Add(dr["MaLoaiDaiLy"]);
            }
        }
        public void DeleteDaiLy(Label maDL)
        {
            _HoSoDaiLyData.Delete_DaiLy_D(maDL.Text);
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
