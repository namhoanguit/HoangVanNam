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
namespace DOANCNPM_VER1.GUI
{
    public partial class frmThemTaiKhoan : Form
    {
        public frmThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.Focus();
            txtMatKhau.Clear();
            txtTaiKhoan.Clear();
            txtNhapLaiMK.Clear();
            
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DUYTHANH-PC;Initial Catalog=QuanLyDaiLy123;Integrated Security=True");
            con.Open();
            if(txtMatKhau.Text==txtNhapLaiMK.Text)
            {
               
                SqlCommand command = new SqlCommand("INSERT into  NGUOIDUNG VALUES ('" + txtTaiKhoan.Text + "','" + txtMatKhau.Text + "','"+cmbQuyen.Text+"');", con);
                command.ExecuteNonQuery();
                MessageBox.Show("Thêm Tài Khoản Thành Công!");
            }
            else
            {
                MessageBox.Show("Mật Khẩu Mới Và Xác Nhận Mật Khẩu Cần Giống Nhau");
            }
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemTaiKhoan_Load(object sender, EventArgs e)
        {

        }

       
    }
}
