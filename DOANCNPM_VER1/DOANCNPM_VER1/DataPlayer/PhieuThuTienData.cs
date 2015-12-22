using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DOANCNPM_VER1.DataPlayer
{
    class PhieuThuTienData
    {
        private DataConnection _DataConnection;

        public PhieuThuTienData()
        {
            _DataConnection  = new DataConnection();
        }

        public DataTable LayTatCaPhieuThu_D()
        {
            string _Query = "select *from PHIEUTHUTIEN";
            return _DataConnection.Read(_Query);
        }
        public void InsertPhieuThuTien_D(string maPhieuThuTien, string maDaiLy, int soTienThu, DateTime ngayThuTien)
        {
            string _NgayThuTien = ngayThuTien.ToShortDateString();
            string _Query = "insert into PHIEUTHUTIEN values('" + maPhieuThuTien + "','" + maDaiLy + "'," + soTienThu + "," +_NgayThuTien+ ")";
            _DataConnection.Write(_Query);
        }

        public void UpdatePhieuThuTien_D(string maPhieuThuTien, string maDaiLy, int soTienThu, DateTime ngayThuTien)
        {
            //string _NgayThuTien = ngayThuTien.ToString("dd/MM/yyyy");
            string _Query = "update PHIEUTHUTIEN set MaPhieuThuTien = '"+maPhieuThuTien+"',MaDaiLy='"+maDaiLy+"', SoTienThu = "+soTienThu+", NgayThuTien = '"+ngayThuTien+"' where MaPhieuThuTien = '"+maPhieuThuTien+"'";
            _DataConnection.Write(_Query);
        }

        public void DeletePhieuThuTien_D(string maPhieuThuTien)
        {
            string _Query = "delete from PHIEUTHUTIEN where MaPhieuThuTien = '" + maPhieuThuTien + "'";
            _DataConnection.Write(_Query);
        }
    }
}
