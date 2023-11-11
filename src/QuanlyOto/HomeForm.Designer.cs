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
            mnu_Import = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            listView1 = new ListView();
            label1 = new Label();
            listView3 = new ListView();
            label2 = new Label();
            label3 = new Label();
            nud_ngayThue = new NumericUpDown();
            lbx_tenKH = new ListBox();
            btn_datXe = new Button();
            btn_huyDat = new Button();
            dataGridView2 = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            btn_ThanhToan = new Button();
            tbx_TongTien = new TextBox();
            textBox1 = new TextBox();
            fl_displayCar = new FlowLayoutPanel();
            tbx_options = new TextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_ngayThue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnu_Admin, mnu_ThongTinTaiKhoan, mnu_QuanLyBanHang, mnu_Import });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(315, 28);
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
            mnu_logOut.Click += mnu_logOut_Click;
            // 
            // mnu_QuanLyBanHang
            // 
            mnu_QuanLyBanHang.Name = "mnu_QuanLyBanHang";
            mnu_QuanLyBanHang.Size = new Size(159, 24);
            mnu_QuanLyBanHang.Text = "Quản Lý Khách Hàng";
            mnu_QuanLyBanHang.Click += mnu_QuanLyBanHang_Click;
            // 
            // mnu_Import
            // 
            mnu_Import.Name = "mnu_Import";
            mnu_Import.Size = new Size(68, 24);
            mnu_Import.Text = "Import";
            mnu_Import.Click += mnu_Import_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.BackColor = SystemColors.ButtonHighlight;
            listView1.BorderStyle = BorderStyle.FixedSingle;
            listView1.ForeColor = Color.Transparent;
            listView1.Location = new Point(12, 27);
            listView1.Name = "listView1";
            listView1.Size = new Size(540, 109);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 255, 255);
            label1.Font = new Font("Microsoft Sans Serif", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(135, 63);
            label1.Name = "label1";
            label1.Size = new Size(359, 37);
            label1.TabIndex = 6;
            label1.Text = "Cửa Hàng Cho Thuê Xe";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listView3
            // 
            listView3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            listView3.BackColor = Color.FromArgb(128, 255, 255);
            listView3.ForeColor = Color.Transparent;
            listView3.Location = new Point(561, 27);
            listView3.Name = "listView3";
            listView3.Size = new Size(506, 109);
            listView3.TabIndex = 1;
            listView3.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(128, 255, 255);
            label2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(568, 39);
            label2.Name = "label2";
            label2.Size = new Size(174, 26);
            label2.TabIndex = 8;
            label2.Text = "Tên Khách Hàng";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(128, 255, 255);
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(568, 95);
            label3.Name = "label3";
            label3.Size = new Size(139, 25);
            label3.TabIndex = 9;
            label3.Text = "Số Ngày Thuê";
            // 
            // nud_ngayThue
            // 
            nud_ngayThue.Location = new Point(2988, 358);
            nud_ngayThue.Margin = new Padding(12, 13, 12, 13);
            nud_ngayThue.Name = "nud_ngayThue";
            nud_ngayThue.Size = new Size(252, 36);
            nud_ngayThue.TabIndex = 2;
            nud_ngayThue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lbx_tenKH
            // 
            lbx_tenKH.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbx_tenKH.BorderStyle = BorderStyle.None;
            lbx_tenKH.FormattingEnabled = true;
            lbx_tenKH.ItemHeight = 29;
            lbx_tenKH.Items.AddRange(new object[] { "a", "b", "c" });
            lbx_tenKH.Location = new Point(748, 39);
            lbx_tenKH.Name = "lbx_tenKH";
            lbx_tenKH.Size = new Size(164, 29);
            lbx_tenKH.TabIndex = 0;
            // 
            // btn_datXe
            // 
            btn_datXe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_datXe.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_datXe.Location = new Point(874, 94);
            btn_datXe.Name = "btn_datXe";
            btn_datXe.Size = new Size(74, 30);
            btn_datXe.TabIndex = 3;
            btn_datXe.Text = "Đặt Xe";
            btn_datXe.UseVisualStyleBackColor = true;
            // 
            // btn_huyDat
            // 
            btn_huyDat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_huyDat.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_huyDat.Location = new Point(982, 94);
            btn_huyDat.Name = "btn_huyDat";
            btn_huyDat.Size = new Size(74, 30);
            btn_huyDat.TabIndex = 4;
            btn_huyDat.Text = "Huỷ Đặt";
            btn_huyDat.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView2.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(560, 140);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(507, 348);
            dataGridView2.TabIndex = 15;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(589, 502);
            label4.Name = "label4";
            label4.Size = new Size(147, 25);
            label4.TabIndex = 17;
            label4.Text = "Tiền chức năng";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(762, 502);
            label5.Name = "label5";
            label5.Size = new Size(94, 25);
            label5.TabIndex = 18;
            label5.Text = "Tổng tiền";
            // 
            // btn_ThanhToan
            // 
            btn_ThanhToan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_ThanhToan.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ThanhToan.Location = new Point(931, 545);
            btn_ThanhToan.Name = "btn_ThanhToan";
            btn_ThanhToan.Size = new Size(125, 30);
            btn_ThanhToan.TabIndex = 9;
            btn_ThanhToan.Text = "Thanh Toán";
            btn_ThanhToan.UseVisualStyleBackColor = true;
            // 
            // tbx_TongTien
            // 
            tbx_TongTien.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tbx_TongTien.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_TongTien.Location = new Point(748, 548);
            tbx_TongTien.Name = "tbx_TongTien";
            tbx_TongTien.Size = new Size(108, 30);
            tbx_TongTien.TabIndex = 8;
            tbx_TongTien.Text = "0.00 VNĐ";
            tbx_TongTien.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Location = new Point(712, 88);
            textBox1.Margin = new Padding(2);
            textBox1.MinimumSize = new Size(4, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(102, 36);
            textBox1.TabIndex = 19;
            // 
            // fl_displayCar
            // 
            fl_displayCar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            fl_displayCar.Location = new Point(12, 142);
            fl_displayCar.Name = "fl_displayCar";
            fl_displayCar.Size = new Size(540, 436);
            fl_displayCar.TabIndex = 20;
            // 
            // tbx_options
            // 
            tbx_options.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tbx_options.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_options.Location = new Point(599, 548);
            tbx_options.Name = "tbx_options";
            tbx_options.Size = new Size(108, 30);
            tbx_options.TabIndex = 21;
            tbx_options.Text = "0.00 VNĐ";
            tbx_options.TextAlign = HorizontalAlignment.Right;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(15F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 585);
            Controls.Add(tbx_options);
            Controls.Add(fl_displayCar);
            Controls.Add(textBox1);
            Controls.Add(tbx_TongTien);
            Controls.Add(btn_ThanhToan);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dataGridView2);
            Controls.Add(btn_huyDat);
            Controls.Add(btn_datXe);
            Controls.Add(lbx_tenKH);
            Controls.Add(nud_ngayThue);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listView3);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(menuStrip1);
            Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrangChu";
            WindowState = FormWindowState.Maximized;
            Load += HomeForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_ngayThue).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private Label label1;
        private ListView listView3;
        private Label label2;
        private Label label3;
        private NumericUpDown nud_ngayThue;
        private ListBox lbx_tenKH;
        private Button btn_datXe;
        private Button btn_huyDat;
        private DataGridView dataGridView2;
        private Label label4;
        private Label label5;
        private Button btn_ThanhToan;
        private TextBox tbx_TongTien;
        private ToolStripMenuItem mnu_TTCN;
        private ToolStripMenuItem mnu_logOut;
        private TextBox textBox1;
        private FlowLayoutPanel fl_displayCar;
        private TextBox tbx_options;
        private ToolStripMenuItem mnu_Import;
    }
}