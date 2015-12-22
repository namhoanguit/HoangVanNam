using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOANCNPM_VER1.Controller;
namespace DOANCNPM_VER1.GUI
{
    public partial class frmThongKeDaiLy : Form
    {
        private HoSoDaiLyControl HoSoDaiLy;
        DataConnection con = new DataConnection();
        public frmThongKeDaiLy()
        {
            InitializeComponent();
            HoSoDaiLy = new HoSoDaiLyControl();
            HoSoDaiLy.LoadComboboxLoaiDL(cbbMaLoaiDaiLy);
            
            LoadData();
        }
        public void LoadData()
        {
            HoSoDaiLy.Display(dtgvThongKeSP);
            
        }
        
        private void dtgvThongKeSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbMaLoaiDaiLy.SelectedItem = Convert.ToString(dtgvThongKeSP.CurrentRow.Cells["MaLoaiDaiLy"].Value);
            //HoSoDaiLy.GetLoaiDL(cbbMaLoaiDaiLy.SelectedText);
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            HoSoDaiLy.Exit(this);
        }

        private void cbbMaLoaiDaiLy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select *from DAILY where MaLoaiDaiLy like N'%" + cbbMaLoaiDaiLy.Text + "%'";
            dtgvThongKeSP.DataSource = con.Read(sql);
        }

        private void frmThongKeDaiLy_Load(object sender, EventArgs e)
        {

        }
    }
}
