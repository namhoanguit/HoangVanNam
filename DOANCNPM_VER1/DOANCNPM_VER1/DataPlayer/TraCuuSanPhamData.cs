using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DOANCNPM_VER1.DataPlayer
{
    class TraCuuSanPhamData
    {
        DataConnection _DataConnection;
        public TraCuuSanPhamData()
        {
            _DataConnection = new DataConnection();
        }
        public DataTable GetTenMatHang()
        {
            string _query = "Select distinct MH.MaMatHang,MH.TenMatHang,DVT.TenDonViTinh,CT.DonGia,MH.SoLuongTon From MATHANG MH JOIN DONVITINH DVT ON MH.MaDonViTinh=DVT.MaDonViTinh JOIN CT_PNH CT ON MH.MaMatHang=CT.MaMatHang";
            return _DataConnection.Read(_query);
        }
        public DataTable SearchMaMatHang(string ma)
        {
            string _query = "Select MH.MaMatHang,MH.TenMatHang,DVT.TenDonViTinh,CT.DonGia,MH.SoLuongTon From MATHANG MH JOIN DONVITINH DVT ON MH.MaDonViTinh=DVT.MaDonViTinh JOIN CT_PNH CT ON MH.MaMatHang=CT.MaMatHang Where MH.MaMatHang like N'%"+ma+"%'";
            return _DataConnection.Read(_query);
        }
        public DataTable SearchTenMatHang(string name)
        {
            string _query = "Select MH.MaMatHang,MH.TenMatHang,DVT.TenDonViTinh,CT.DonGia MH.SoLuongTon From MATHANG MH JOIN DONVITINH DVT ON MH.MaDonViTinh=DVT.MaDonViTinh JOIN CT_PNH CT ON MH.MaMatHang=CT.MaMatHang Where MH.TenMatHang like N'%"+name+"%'";
            return _DataConnection.Read(_query);
        }
    }
}
