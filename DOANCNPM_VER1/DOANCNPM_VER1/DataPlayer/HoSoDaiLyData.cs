using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DOANCNPM_VER1.DataPlayer
{
    class HoSoDaiLyData
    {
        DataConnection _DataConnection;
        public HoSoDaiLyData()
        {
            _DataConnection = new DataConnection();
        }

        public DataTable GetDS_DaiLy()
        {
            string query = "select * from DAILY";
            return _DataConnection.Read(query);
        }
        public void Insert_DaiLy_D(string maDaiLy, string TenDaiLy, string maLoai_DL,string dienThoai, string diaChi,string maQuan, string ngayTiepNhan, int tienNo, string email)
        {
            string _Query = "insert into DAILY values ('" + maDaiLy + "','" + TenDaiLy + "','" + maLoai_DL + "','" + dienThoai + "','" + diaChi + "','" + maQuan + "','"+ngayTiepNhan+"'," + tienNo + ",'" + email + "')";
            //string _Query = "insert into DAILY values ('DL03','DL BAN NUOC','MDL001','00131','HCM','MQ01','1/1/2003','10000','dsfsdfsd')";
            _DataConnection.Write(_Query);
        }

        public void Delete_DaiLy_D(string maDaiLy)
        {
            string _Query = "DELETE FROM DAILY where ( MaDaiLy = '" + maDaiLy + "' )";
            _DataConnection.Write(_Query);
        }

        public void Update_DonViTinh_D(string maDVT, string tenDVT)
        {
            string _Query = "UPDATE DONVITINH SET MaDonViTinh = '" + maDVT + "', TenDonViTinh = '" + tenDVT + "' where MaDonViTinh = '" + maDVT + "'";
            _DataConnection.Write(_Query);
        }
        // them
        public void GetLoaiDL(string maloaiDL)
        {
            string query = "select * from DAILY where  (MaLoaiDaiLy ='" + maloaiDL + "')";
            _DataConnection.Write(query);
        }
    }
}
