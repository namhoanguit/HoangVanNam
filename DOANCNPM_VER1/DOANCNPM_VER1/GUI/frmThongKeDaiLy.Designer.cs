namespace DOANCNPM_VER1.GUI
{
    partial class frmThongKeDaiLy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvThongKeSP = new System.Windows.Forms.DataGridView();
            this.MaDaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiDaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTiepNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbMaLoaiDaiLy = new System.Windows.Forms.Label();
            this.cbbMaLoaiDaiLy = new System.Windows.Forms.ComboBox();
            this.Thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongKeSP)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvThongKeSP
            // 
            this.dtgvThongKeSP.BackgroundColor = System.Drawing.Color.White;
            this.dtgvThongKeSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThongKeSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDaiLy,
            this.TenDaiLy,
            this.MaLoaiDaiLy,
            this.DienThoai,
            this.DiaChi,
            this.MaQuan,
            this.NgayTiepNhan,
            this.TienNo,
            this.Email});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvThongKeSP.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvThongKeSP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvThongKeSP.GridColor = System.Drawing.Color.Silver;
            this.dtgvThongKeSP.Location = new System.Drawing.Point(0, 101);
            this.dtgvThongKeSP.MultiSelect = false;
            this.dtgvThongKeSP.Name = "dtgvThongKeSP";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvThongKeSP.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvThongKeSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvThongKeSP.Size = new System.Drawing.Size(904, 359);
            this.dtgvThongKeSP.TabIndex = 11;
            this.dtgvThongKeSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvThongKeSP_CellContentClick);
            // 
            // MaDaiLy
            // 
            this.MaDaiLy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaDaiLy.DataPropertyName = "MaDaiLy";
            this.MaDaiLy.Frozen = true;
            this.MaDaiLy.HeaderText = "Mã Đại Lý";
            this.MaDaiLy.Name = "MaDaiLy";
            this.MaDaiLy.ReadOnly = true;
            this.MaDaiLy.Width = 96;
            // 
            // TenDaiLy
            // 
            this.TenDaiLy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenDaiLy.DataPropertyName = "TenDaiLy";
            this.TenDaiLy.HeaderText = "Tên Đại Lý";
            this.TenDaiLy.Name = "TenDaiLy";
            this.TenDaiLy.ReadOnly = true;
            // 
            // MaLoaiDaiLy
            // 
            this.MaLoaiDaiLy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaLoaiDaiLy.DataPropertyName = "MaLoaiDaiLy";
            this.MaLoaiDaiLy.HeaderText = "Mã Loại Đại Lý";
            this.MaLoaiDaiLy.Name = "MaLoaiDaiLy";
            this.MaLoaiDaiLy.ReadOnly = true;
            // 
            // DienThoai
            // 
            this.DienThoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Điện Thoại";
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // MaQuan
            // 
            this.MaQuan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaQuan.DataPropertyName = "MaQuan";
            this.MaQuan.HeaderText = "Mã Quận";
            this.MaQuan.Name = "MaQuan";
            this.MaQuan.ReadOnly = true;
            // 
            // NgayTiepNhan
            // 
            this.NgayTiepNhan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayTiepNhan.DataPropertyName = "NgayTiepNhan";
            this.NgayTiepNhan.HeaderText = "Ngày Tiếp Nhận";
            this.NgayTiepNhan.Name = "NgayTiepNhan";
            this.NgayTiepNhan.ReadOnly = true;
            // 
            // TienNo
            // 
            this.TienNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TienNo.DataPropertyName = "TienNo";
            this.TienNo.HeaderText = "Tiền Nợ";
            this.TienNo.Name = "TienNo";
            this.TienNo.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // lbMaLoaiDaiLy
            // 
            this.lbMaLoaiDaiLy.AutoSize = true;
            this.lbMaLoaiDaiLy.BackColor = System.Drawing.Color.Transparent;
            this.lbMaLoaiDaiLy.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLoaiDaiLy.Location = new System.Drawing.Point(49, 37);
            this.lbMaLoaiDaiLy.Name = "lbMaLoaiDaiLy";
            this.lbMaLoaiDaiLy.Size = new System.Drawing.Size(206, 32);
            this.lbMaLoaiDaiLy.TabIndex = 15;
            this.lbMaLoaiDaiLy.Text = "Mã Loại Đại Lý:";
            // 
            // cbbMaLoaiDaiLy
            // 
            this.cbbMaLoaiDaiLy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaLoaiDaiLy.FormattingEnabled = true;
            this.cbbMaLoaiDaiLy.Location = new System.Drawing.Point(263, 40);
            this.cbbMaLoaiDaiLy.Name = "cbbMaLoaiDaiLy";
            this.cbbMaLoaiDaiLy.Size = new System.Drawing.Size(129, 26);
            this.cbbMaLoaiDaiLy.TabIndex = 16;
            this.cbbMaLoaiDaiLy.SelectedIndexChanged += new System.EventHandler(this.cbbMaLoaiDaiLy_SelectedIndexChanged);
            // 
            // Thoat
            // 
            this.Thoat.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.Image = global::DOANCNPM_VER1.Properties.Resources.btnexit;
            this.Thoat.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Thoat.Location = new System.Drawing.Point(701, 40);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(93, 34);
            this.Thoat.TabIndex = 17;
            this.Thoat.Text = "Thoát";
            this.Thoat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // frmThongKeDaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DOANCNPM_VER1.Properties.Resources.ThongKe1;
            this.ClientSize = new System.Drawing.Size(904, 460);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.cbbMaLoaiDaiLy);
            this.Controls.Add(this.lbMaLoaiDaiLy);
            this.Controls.Add(this.dtgvThongKeSP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmThongKeDaiLy";
            this.Text = "frmThongKeDaiLy";
            this.Load += new System.EventHandler(this.frmThongKeDaiLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongKeSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvThongKeSP;
        private System.Windows.Forms.Label lbMaLoaiDaiLy;
        private System.Windows.Forms.ComboBox cbbMaLoaiDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTiepNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Button Thoat;
    }
}