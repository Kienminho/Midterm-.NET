namespace QuanlyOto
{
    partial class HomeForm
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            mnu_Admin = new ToolStripMenuItem();
            mnu_ThongTinTaiKhoan = new ToolStripMenuItem();
            mnu_TTCN = new ToolStripMenuItem();
            mnu_logOut = new ToolStripMenuItem();
            mnu_QuanLyBanHang = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            listView1 = new ListView();
            listView2 = new ListView();
            label1 = new Label();
            listView3 = new ListView();
            label2 = new Label();
            label3 = new Label();
            nud_ngayThue = new NumericUpDown();
            lbx_tenKH = new ListBox();
            btn_datXe = new Button();
            btn_huyDat = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            btn_ThanhToan = new Button();
            lbx_doiXe = new ListBox();
            nud_GiamGia = new NumericUpDown();
            tbx_TongTien = new TextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_ngayThue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_GiamGia).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnu_Admin, mnu_ThongTinTaiKhoan, mnu_QuanLyBanHang });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1067, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnu_Admin
            // 
            mnu_Admin.Name = "mnu_Admin";
            mnu_Admin.Size = new Size(67, 24);
            mnu_Admin.Text = "Admin";
            mnu_Admin.Click += mnu_Admin_Click;
            // 
            // mnu_ThongTinTaiKhoan
            // 
            mnu_ThongTinTaiKhoan.DropDownItems.AddRange(new ToolStripItem[] { mnu_TTCN, mnu_logOut });
            mnu_ThongTinTaiKhoan.Name = "mnu_ThongTinTaiKhoan";
            mnu_ThongTinTaiKhoan.Size = new Size(151, 24);
            mnu_ThongTinTaiKhoan.Text = "Thông tin tài khoản";
            // 
            // mnu_TTCN
            // 
            mnu_TTCN.Name = "mnu_TTCN";
            mnu_TTCN.Size = new Size(224, 26);
            mnu_TTCN.Text = "Thông Tin Cá Nhân";
            mnu_TTCN.Click += mnu_TTCN_Click;
            // 
            // mnu_logOut
            // 
            mnu_logOut.Name = "mnu_logOut";
            mnu_logOut.Size = new Size(224, 26);
            mnu_logOut.Text = "Đăng Xuất";
            // 
            // mnu_QuanLyBanHang
            // 
            mnu_QuanLyBanHang.Name = "mnu_QuanLyBanHang";
            mnu_QuanLyBanHang.Size = new Size(159, 24);
            mnu_QuanLyBanHang.Text = "Quản Lý Khách Hàng";
            mnu_QuanLyBanHang.Click += mnu_QuanLyBanHang_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.ButtonHighlight;
            listView1.ForeColor = Color.Transparent;
            listView1.Location = new Point(12, 32);
            listView1.Name = "listView1";
            listView1.Size = new Size(540, 109);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            listView2.Location = new Point(560, 32);
            listView2.Name = "listView2";
            listView2.Size = new Size(504, 109);
            listView2.TabIndex = 5;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 255, 255);
            label1.Font = new Font("Microsoft Sans Serif", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(91, 66);
            label1.Name = "label1";
            label1.Size = new Size(359, 37);
            label1.TabIndex = 6;
            label1.Text = "Cửa Hàng Cho Thuê Xe";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listView3
            // 
            listView3.BackColor = Color.FromArgb(128, 255, 255);
            listView3.ForeColor = Color.Transparent;
            listView3.Location = new Point(560, 32);
            listView3.Name = "listView3";
            listView3.Size = new Size(507, 109);
            listView3.TabIndex = 1;
            listView3.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(128, 255, 255);
            label2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(568, 39);
            label2.Name = "label2";
            label2.Size = new Size(192, 29);
            label2.TabIndex = 8;
            label2.Text = "Tên Khách Hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(128, 255, 255);
            label3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(568, 96);
            label3.Name = "label3";
            label3.Size = new Size(167, 29);
            label3.TabIndex = 9;
            label3.Text = "Số Ngày Thuê";
            // 
            // nud_ngayThue
            // 
            nud_ngayThue.Location = new Point(747, 96);
            nud_ngayThue.Name = "nud_ngayThue";
            nud_ngayThue.Size = new Size(63, 26);
            nud_ngayThue.TabIndex = 2;
            nud_ngayThue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lbx_tenKH
            // 
            lbx_tenKH.FormattingEnabled = true;
            lbx_tenKH.ItemHeight = 20;
            lbx_tenKH.Items.AddRange(new object[] { "a", "b", "c" });
            lbx_tenKH.Location = new Point(783, 44);
            lbx_tenKH.Name = "lbx_tenKH";
            lbx_tenKH.Size = new Size(165, 24);
            lbx_tenKH.TabIndex = 0;
            // 
            // btn_datXe
            // 
            btn_datXe.Location = new Point(875, 93);
            btn_datXe.Name = "btn_datXe";
            btn_datXe.Size = new Size(73, 25);
            btn_datXe.TabIndex = 3;
            btn_datXe.Text = "Đặt Xe";
            btn_datXe.UseVisualStyleBackColor = true;
            // 
            // btn_huyDat
            // 
            btn_huyDat.Location = new Point(982, 93);
            btn_huyDat.Name = "btn_huyDat";
            btn_huyDat.Size = new Size(73, 25);
            btn_huyDat.TabIndex = 4;
            btn_huyDat.Text = "Huỷ Đặt";
            btn_huyDat.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 141);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(540, 446);
            dataGridView1.TabIndex = 14;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(560, 141);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(507, 348);
            dataGridView2.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(572, 502);
            button1.Name = "button1";
            button1.Size = new Size(94, 27);
            button1.TabIndex = 5;
            button1.Text = "Đổi Xe";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(693, 509);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 17;
            label4.Text = "Giảm Giá";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(800, 509);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 18;
            label5.Text = "Tổng tiền";
            // 
            // btn_ThanhToan
            // 
            btn_ThanhToan.Location = new Point(936, 509);
            btn_ThanhToan.Name = "btn_ThanhToan";
            btn_ThanhToan.Size = new Size(110, 52);
            btn_ThanhToan.TabIndex = 9;
            btn_ThanhToan.Text = "Thanh Toán";
            btn_ThanhToan.UseVisualStyleBackColor = true;
            // 
            // lbx_doiXe
            // 
            lbx_doiXe.FormattingEnabled = true;
            lbx_doiXe.ItemHeight = 20;
            lbx_doiXe.Items.AddRange(new object[] { "a", "b", "c" });
            lbx_doiXe.Location = new Point(572, 552);
            lbx_doiXe.Name = "lbx_doiXe";
            lbx_doiXe.SelectionMode = SelectionMode.MultiExtended;
            lbx_doiXe.Size = new Size(94, 24);
            lbx_doiXe.TabIndex = 6;
            // 
            // nud_GiamGia
            // 
            nud_GiamGia.Location = new Point(697, 548);
            nud_GiamGia.Name = "nud_GiamGia";
            nud_GiamGia.Size = new Size(63, 26);
            nud_GiamGia.TabIndex = 7;
            nud_GiamGia.TextAlign = HorizontalAlignment.Center;
            // 
            // tbx_TongTien
            // 
            tbx_TongTien.Location = new Point(804, 548);
            tbx_TongTien.Name = "tbx_TongTien";
            tbx_TongTien.Size = new Size(108, 26);
            tbx_TongTien.TabIndex = 8;
            tbx_TongTien.Text = "0.00 VNĐ";
            tbx_TongTien.TextAlign = HorizontalAlignment.Right;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 585);
            Controls.Add(tbx_TongTien);
            Controls.Add(nud_GiamGia);
            Controls.Add(lbx_doiXe);
            Controls.Add(btn_ThanhToan);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(btn_huyDat);
            Controls.Add(btn_datXe);
            Controls.Add(lbx_tenKH);
            Controls.Add(nud_ngayThue);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listView3);
            Controls.Add(label1);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(menuStrip1);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "HomeForm";
            Text = "TrangChu";
            Load += HomeForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_ngayThue).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_GiamGia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnu_Admin;
        private ToolStripMenuItem mnu_ThongTinTaiKhoan;
        private ToolStripMenuItem mnu_QuanLyBanHang;
        private ContextMenuStrip contextMenuStrip1;
        private ListView listView1;
        private ListView listView2;
        private Label label1;
        private ListView listView3;
        private Label label2;
        private Label label3;
        private NumericUpDown nud_ngayThue;
        private ListBox lbx_tenKH;
        private Button btn_datXe;
        private Button btn_huyDat;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button button1;
        private Label label4;
        private Label label5;
        private Button btn_ThanhToan;
        private ListBox lbx_doiXe;
        private NumericUpDown nud_GiamGia;
        private TextBox tbx_TongTien;
        private ToolStripMenuItem mnu_TTCN;
        private ToolStripMenuItem mnu_logOut;
    }
}