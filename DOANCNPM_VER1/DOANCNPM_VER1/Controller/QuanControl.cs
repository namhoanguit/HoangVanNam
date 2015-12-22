using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using DOANCNPM_VER1.DataPlayer;

namespace DOANCNPM_VER1.Controller
{
    class QuanControl
    {
        QuanData QuanData;
        public QuanControl()
        {
            QuanData = new QuanData();
        }
        
        public void Display(DataGridView _DataGridView)
        {
            _DataGridView.DataSource = QuanData.GetDSQuan();
        }

        public void InsertQuanControl(TextBox maQuan, TextBox tenQuan)
        {
            QuanData.InsertQuan(maQuan.Text,tenQuan.Text);
        }

        public DataTable GetDS_Quan()
        {
            return QuanData.GetDSQuan();
        }
        public void DeleteQuan(TextBox maQuan)
        {
            QuanData.DeleteQuan(maQuan.Text);
        }

        public void SetMaQuan(Label maQuan)
        {
            int _Count = 0;
            _Count = QuanData.GetDSQuan().Rows.Count;
            maQuan.Text = "MQ00" + (_Count + 1).ToString();
        }

        public void UpdateQuan(Label maQuan, TextBox tenQuan)
        {
            QuanData.UpdateQuan(maQuan.Text, tenQuan.Text);
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
