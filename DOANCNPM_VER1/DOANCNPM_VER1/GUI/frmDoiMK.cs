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
    public partial class frmDoiMK : Form
    {
        public frmDoiMK()
        {
            InitializeComponent();
        }

        private void btDoiMK_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "" || txtMkcu.Text == "" || txtMkMoi.Text == "" || txtNhapLaiMK.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Đủ Thông Tin");
            }
            else if (txtMkcu.Text == "")
                 MessageBox.Show("Bạn Chưa Nhập Mật Khẩu Cũ");
            else if(txtMkMoi.Text=="")
                MessageBox.Show("Bạn Chưa Nhập Mật Khẩu Mới ");
            else if(txtNhapLaiMK.Text=="")
            {
                MessageBox.Show("Bạn Chưa Nhập Lại Mật Khẩu Mới");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=NAMHOANG;Initial Catalog=QuanLyDaiLy;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from NGUOIDUNG where TaiKhoan ='" + txtTaiKhoan.Text + "'and MatKhau = '" + txtMkcu.Text + "'",con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                if(tb.Rows.Count>0 && txtMkMoi.Text==txtNhapLaiMK.Text)
                {
                    
                  
                    SqlCommand command = new SqlCommand("UPDATE NGUOIDUNG SET MatKhau='" + txtMkMoi.Text + "' WHERE TaiKhoan='" + txtTaiKhoan.Text + "'", con);                
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thay đổi mật khẩu thành công!");
                }
                  
            }
        }

        private void frmDoiMK_Load(object sender, EventArgs e)
        {

        }

        private void btNhapLai_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.Focus();
            txtTaiKhoan.Clear();
            txtMkMoi.Clear();
            txtNhapLaiMK.Clear();
            txtMkcu.Clear();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
