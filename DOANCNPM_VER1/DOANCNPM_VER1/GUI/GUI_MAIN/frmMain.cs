using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DOANCNPM_VER1.GUI;

namespace DOANCNPM_VER1.GUI.GUI_MAIN
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmMain1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyDaiLyDataSet.DAILY' table. You can move, or remove it, as needed.
            this.dAILYTableAdapter.Fill(this.quanLyDaiLyDataSet.DAILY);
            // TODO: This line of code loads data into the 'quanLyDaiLy.DAILY' table. You can move, or remove it, as needed.
           // this.dAILYTableAdapter.Fill(this.quanLyDaiLy.DAILY);
            
        }

        

        private void barStaticItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDaiLy_Click(object sender, EventArgs e)
        {
            frmHoSoDaiLy1 daily = new frmHoSoDaiLy1();
            daily.Show();
        }

        private void btnPhieuXuat_Click(object sender, EventArgs e)
        {
            frmPhieuXuatHang2 phieuxuat = new frmPhieuXuatHang2();
            phieuxuat.Show();
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            frmPhieuNhapHang phieunhap = new frmPhieuNhapHang();
            phieunhap.Show();
        }

        private void btnPhieuthu_Click(object sender, EventArgs e)
        {
            frmPhieuThuTien_1 phieuthu = new frmPhieuThuTien_1();
            phieuthu.Show();

        }

        private void btnbcDoanhso_Click(object sender, EventArgs e)
        {
          //  frmBaoCaoDSReport baocaoDS = new frmBaoCaoDSReport();
           // baocaoDS.Show();
        }

        private void btnbcCongno_Click(object sender, EventArgs e)
        {
           // frmBaoCaoCNReport baocaoCN = new frmBaoCaoCNReport();
           // baocaoCN.Show();
        }

        private void btntkDaiLy_Click(object sender, EventArgs e)
        {
            frmThongKeDaiLy TKdaily = new frmThongKeDaiLy();
            TKdaily.Show();
        }

        private void btntkSanPham_Click(object sender, EventArgs e)
        {
            frmThongKeSanPham TKsanpham = new frmThongKeSanPham();
            TKsanpham.Show();
        }

        private void btnTracuuDL_Click(object sender, EventArgs e)
        {
            frmHoSoDaiLy1 tracuuDL = new frmHoSoDaiLy1();
            tracuuDL.Show();
        }

        private void btnTracuuSP_Click(object sender, EventArgs e)
        {
            frmTraCuuSanPham tracuuSP = new frmTraCuuSanPham();
            tracuuSP.Show();
        }

        private void btnQuyDinh_Click(object sender, EventArgs e)
        {
            frmQuyDinh quydinh = new frmQuyDinh();
            quydinh.Show();

        }

        private void btnGiupdo_Click(object sender, EventArgs e)
        {
            frmGiupDo giupdo = new frmGiupDo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDangNhap dangnhap = new frmDangNhap();
            dangnhap.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemTaiKhoan themtk = new frmThemTaiKhoan();
            themtk.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDoiMK doimk = new frmDoiMK();
            doimk.Show();
        }

        private void btnMathang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMatHang2 mathang = new frmMatHang2();
            mathang.Show();
        }

        private void btnDaily1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHoSoDaiLy1 hosodl = new frmHoSoDaiLy1();
            hosodl.Show();
        }

        private void btnPhieuXuat1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPhieuXuatHang2 phieuxuat = new frmPhieuXuatHang2();
            phieuxuat.Show();

        }

        private void btnPhieunhap1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPhieuNhapHang phieunhap = new frmPhieuNhapHang();
            phieunhap.Show();
        }

        private void btnPhieuthu1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPhieuThuTien_1 phieuthu = new frmPhieuThuTien_1();
            phieuthu.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDonViTinh2 donvt = new frmDonViTinh2();
            donvt.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQuan2 quan = new frmQuan2();
            quan.Show();
        }

        private void btnQuydinh1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQuyDinh quydinh= new frmQuyDinh();
            quydinh.Show();
        }
    }
}