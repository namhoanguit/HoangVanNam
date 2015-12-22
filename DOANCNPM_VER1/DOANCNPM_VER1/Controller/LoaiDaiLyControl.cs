using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DOANCNPM_VER1.DataPlayer;
using System.Windows.Forms;

namespace DOANCNPM_VER1.Controller
{
    class LoaiDaiLyControl
    {
        LoaiDaiLyData _LoaiDaiLyData;
        public LoaiDaiLyControl()
        {
            _LoaiDaiLyData = new LoaiDaiLyData();
        }
        
        public void Display(DataGridView _DataGridView)
        {
            _DataGridView.DataSource = _LoaiDaiLyData.GetDSLoaiDL_D();
        }

        public DataTable getDSLoaiDL()
        {
            return _LoaiDaiLyData.GetDSLoaiDL_D();
        }
        public void InsertLoaiDLControl(TextBox maLoaiDL, TextBox tenLoaiDL)
        {
            _LoaiDaiLyData.InsertLoaiDL_D(maLoaiDL.Text,tenLoaiDL.Text);
        }


        public void DeleteLoaiDL(TextBox maLoaiDL)
        {
            _LoaiDaiLyData.DeleteLoaiDL_D(maLoaiDL.Text);
        }
        /*
        public void SetMaLoaiDL(Label maLoaiDL)
        {
            int _Count = 0;
            _Count = _LoaiDaiLyData.GetDSLoaiDL_D().Rows.Count;
            maLoaiDL.Text = "LDL00" + (_Count + 1).ToString();
            //MessageBox.Show(_Count.ToString());
        }
        */
        public void UpdateLoaiDL(Label maLoaiDL, TextBox tenLoaiDL)
        {
            _LoaiDaiLyData.UpdateLoaiDL_D(maLoaiDL.Text,tenLoaiDL.Text);
        }

        public void Exit(Form FormExit)
        {
            DialogResult _Dr = MessageBox.Show("Bạn có chắc muốn thoát !","Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Question );
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
