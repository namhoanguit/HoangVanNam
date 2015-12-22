using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DOANCNPM_VER1.GUI.GUI_MAIN;

namespace DOANCNPM_VER1.GUI
{
    public partial class frmDangNhap : Form
    {
        DataConnection cn = new DataConnection();
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private int Number_Account = 2;
        public int GetNumberAccount()
        {
            return Number_Account;
        }
        public string GetstrDangNhap()
        {
            return txtTaiKhoan.Text.Trim();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "" || rbGuest.Checked == false || rbAdmin.Checked==false)
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin", "Có lỗi xảy ra!");
                txtMatKhau.Focus();
                return;
            }
            else{
                SqlConnection con = new SqlConnection(@"Data Source=NAMHOANG;Initial Catalog=QuanLyDaiLy;Integrated Security=True");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from NGUOIDUNG where TaiKhoan ='" + txtTaiKhoan.Text.ToString() + "'and MatKhau = '" + txtMatKhau.Text.ToString() + "'and Quyen ='" + Number_Account + "'", con);
                DataTable tb = new DataTable();
                da.Fill(tb);
                if (tb == null || tb.Rows.Count > 0)
                {
                   // frmMain.quyen = cn.XemDL("select Quyen from NGUOIDUNG where TaiKhoan = '" + txtTaiKhoan.Text.Trim() + "'and MatKhau ='" + txtMatKhau.Text.Trim() + "'").Rows[0][0].ToString().Trim();
                    this.Hide();
                    MessageBox.Show("Bạn Đã Đăng Nhập Thành Công", "Chào Mừng Bạn Đến Chương Trình Quản Lý Các Đại Lý");
                    frmMain Main = new frmMain();
                    Main.Show();
                    con.Close();
                }
                else{

                    MessageBox.Show("Tên đăng nhập và mật khẩu không hợp lệ hoặc có thể quyền truy cập của bạn không đúng!", "Có lỗi xảy ra");
                    txtMatKhau.Focus();
                }
                con.Close();
            }
            }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnDangNhap;
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            this.txtTaiKhoan.Clear();
            this.txtMatKhau.Clear();
            this.txtTaiKhoan.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK==MessageBox.Show("Bạn có chắc chắn muốn thoát không","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question));
            Application.Exit();
        }

        private void rbGuest_CheckedChanged(object sender, EventArgs e)
        {
            Number_Account = 0;
        }

        private void rbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            Number_Account = 1;
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

       

       
    }
}
