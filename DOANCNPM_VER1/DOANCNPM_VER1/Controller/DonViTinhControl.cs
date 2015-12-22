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
    class DonViTinhControl
    {
        private DonViTinhData _DonViTinhData;
        public DonViTinhControl()
        {
            _DonViTinhData = new DonViTinhData();
        }

        public void Display(DataGridView dg)
        {
            DataTable _DSDonViTinh = _DonViTinhData.GetDS_DonViTinh();
            dg.DataSource = _DSDonViTinh;
        }
        public DataTable LayTatCaDonViTinh()
        {
            return _DonViTinhData.GetDS_DonViTinh();
        }

        public void Insert_DVT(TextBox maDVT, TextBox tenDVT)
        {
            _DonViTinhData.Insert_DonViTinh_D(maDVT.Text,tenDVT.Text);
        }

        public void Delete_DVT(TextBox maDVT)
        {
            _DonViTinhData.Delete_DonViTinh_D(maDVT.Text);
        }
        public void SetMaDVT(TextBox maDVT)
        {
            DataTable _DSDonViTinh = _DonViTinhData.GetDS_DonViTinh();
            int _RowsCount = _DSDonViTinh.Rows.Count;
            if(_RowsCount < 10)
            {
                maDVT.Text = "DVT0" + (_RowsCount + 1).ToString();
            }
            else
                maDVT.Text = "DVT" + (_RowsCount + 1).ToString();
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
