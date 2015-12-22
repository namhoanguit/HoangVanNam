using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using DOANCNPM_VER1.DataPlayer;
namespace DOANCNPM_VER1.Controller
{
    class TraCuuSanPhamControl
    {
        private TraCuuSanPhamData _TraCuuMatHangDaTa;
        public TraCuuSanPhamControl()
        {
            _TraCuuMatHangDaTa = new TraCuuSanPhamData();
        }
        public void LoadDuLieu(DataGridView dg)
        {
            DataTable dt = _TraCuuMatHangDaTa.GetTenMatHang();
            dg.DataSource = dt;
        }
        public void LoadCombobox(ComboBox cmb)
        {
            cmb.Items.Clear();
            DataTable dt = _TraCuuMatHangDaTa.GetTenMatHang();
            foreach (DataRow row in dt.Rows)
            {
                cmb.Items.Add(row["MaMatHang"]);
            }
        }
        public DataTable SearchMaMatHang(TextBox textbox)
        {
            return _TraCuuMatHangDaTa.SearchMaMatHang(textbox.Text);
        }
        public DataTable SearchTenMatHang(TextBox textbox)
        {
            return _TraCuuMatHangDaTa.SearchTenMatHang(textbox.Text);
        }
    }
}
