using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOANCNPM_VER1.DataPlayer;
using System.Data;
using System.Windows.Forms;

namespace DOANCNPM_VER1.Controller
{
    class MatHangControl
    {
        private MatHangData _MatHangData;
        public MatHangControl()
        {
            _MatHangData = new MatHangData();
        }

        public void Display(DataGridView dg)
        {
            dg.DataSource = _MatHangData.LayTatCaMatHang_D();
        }

        public DataTable LayTatCaMatHang()
        {
            return _MatHangData.LayTatCaMatHang_D();
        }
        public void SetMaMH(TextBox txtMaMH)
        {
            DataTable _DSMatHang = _MatHangData.LayTatCaMatHang_D();
            int _RowsCount = _DSMatHang.Rows.Count;
            if (_RowsCount < 10)
            {
                txtMaMH.Text = "MMH0" + (_RowsCount + 1).ToString();
            }
            else
                txtMaMH.Text = "MMH" + (_RowsCount + 1).ToString();
        }
        public void InsertMatHang(TextBox txtMaMH, TextBox tenMatHang, ComboBox maDVT, TextBox soLuongTon)
        {
            try
            {
                _MatHangData.InsertMatHang_D(txtMaMH.Text, tenMatHang.Text, maDVT.SelectedItem.ToString(), Convert.ToInt32(soLuongTon.Text));
            }
            catch
            {

            }
        }
        public void UpdateMatHang(TextBox txtMaMH, TextBox tenMatHang, ComboBox maDVT, TextBox soLuongTon)
        {
            _MatHangData.UpdateMatHang_D(txtMaMH.Text,tenMatHang.Text, maDVT.SelectedItem.ToString(),Convert.ToInt32(soLuongTon.Text));
        }

        public void DeleteMatHang(TextBox txtMaMH)
        {
            _MatHangData.DeleteMatHang_D(txtMaMH.Text);
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
