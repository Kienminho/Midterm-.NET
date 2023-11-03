namespace QuanlyOto
{
    partial class AdminForm
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
            tbl_DoanhThu = new TabControl();
            tabPage1 = new TabPage();
            btn_thongKe = new Button();
            tbx_tongDoanhThu = new TextBox();
            label2 = new Label();
            tbx_soTrang = new TextBox();
            btn_nextAll = new Button();
            btn_next = new Button();
            btn_preAll = new Button();
            btn_pre = new Button();
            dtp_denNgay = new DateTimePicker();
            label1 = new Label();
            dtp_tuNgay = new DateTimePicker();
            dgw_DoanhThu = new DataGridView();
            tabPage2 = new TabPage();
            btn_xoa = new Button();
            btn_sua = new Button();
            btn_them = new Button();
            dtp_ngaySinh = new DateTimePicker();
            tbx_QueQuan = new TextBox();
            tbx_TenNhanVien = new TextBox();
            tbx_CMND = new TextBox();
            tbx_gioiTinh = new TextBox();
            tbx_SDT = new TextBox();
            tbx_ID = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dgw_Staff = new DataGridView();
            tpg_TaiKhoan = new TabPage();
            btn_resetPw = new Button();
            btn_SuaTk = new Button();
            btn_xoaTk = new Button();
            btn_themTk = new Button();
            label14 = new Label();
            label13 = new Label();
            numericUpDown1 = new NumericUpDown();
            tbx_tenHT = new TextBox();
            tbx_tenTK = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            dgw_TaiKhoan = new DataGridView();
            btn_reset = new Button();
            tbl_DoanhThu.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_DoanhThu).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_Staff).BeginInit();
            tpg_TaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgw_TaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // tbl_DoanhThu
            // 
            tbl_DoanhThu.Controls.Add(tabPage1);
            tbl_DoanhThu.Controls.Add(tabPage2);
            tbl_DoanhThu.Controls.Add(tpg_TaiKhoan);
            tbl_DoanhThu.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbl_DoanhThu.Location = new Point(20, 30);
            tbl_DoanhThu.Margin = new Padding(10);
            tbl_DoanhThu.Name = "tbl_DoanhThu";
            tbl_DoanhThu.SelectedIndex = 0;
            tbl_DoanhThu.Size = new Size(962, 515);
            tbl_DoanhThu.TabIndex = 0;
            tbl_DoanhThu.Click += tbl_DoanhThu_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btn_thongKe);
            tabPage1.Controls.Add(tbx_tongDoanhThu);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(tbx_soTrang);
            tabPage1.Controls.Add(btn_nextAll);
            tabPage1.Controls.Add(btn_next);
            tabPage1.Controls.Add(btn_preAll);
            tabPage1.Controls.Add(btn_pre);
            tabPage1.Controls.Add(dtp_denNgay);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dtp_tuNgay);
            tabPage1.Controls.Add(dgw_DoanhThu);
            tabPage1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(10);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(5);
            tabPage1.Size = new Size(954, 482);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Doanh Thu";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_thongKe
            // 
            btn_thongKe.Location = new Point(782, 436);
            btn_thongKe.Margin = new Padding(2);
            btn_thongKe.Name = "btn_thongKe";
            btn_thongKe.Size = new Size(110, 30);
            btn_thongKe.TabIndex = 2;
            btn_thongKe.Text = "Thống Kê";
            btn_thongKe.UseVisualStyleBackColor = true;
            // 
            // tbx_tongDoanhThu
            // 
            tbx_tongDoanhThu.Location = new Point(342, 438);
            tbx_tongDoanhThu.Margin = new Padding(2);
            tbx_tongDoanhThu.Multiline = true;
            tbx_tongDoanhThu.Name = "tbx_tongDoanhThu";
            tbx_tongDoanhThu.Size = new Size(331, 28);
            tbx_tongDoanhThu.TabIndex = 10;
            tbx_tongDoanhThu.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(77, 441);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(172, 26);
            label2.TabIndex = 9;
            label2.Text = "Tổng Doanh Thu";
            // 
            // tbx_soTrang
            // 
            tbx_soTrang.Location = new Point(432, 394);
            tbx_soTrang.Margin = new Padding(2);
            tbx_soTrang.Multiline = true;
            tbx_soTrang.Name = "tbx_soTrang";
            tbx_soTrang.Size = new Size(32, 28);
            tbx_soTrang.TabIndex = 5;
            tbx_soTrang.Text = "1";
            tbx_soTrang.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_nextAll
            // 
            btn_nextAll.Location = new Point(853, 392);
            btn_nextAll.Margin = new Padding(2);
            btn_nextAll.Name = "btn_nextAll";
            btn_nextAll.Size = new Size(70, 30);
            btn_nextAll.TabIndex = 7;
            btn_nextAll.Text = ">>";
            btn_nextAll.UseVisualStyleBackColor = true;
            // 
            // btn_next
            // 
            btn_next.Location = new Point(742, 392);
            btn_next.Margin = new Padding(2);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(70, 30);
            btn_next.TabIndex = 6;
            btn_next.Text = ">";
            btn_next.UseVisualStyleBackColor = true;
            // 
            // btn_preAll
            // 
            btn_preAll.Location = new Point(27, 392);
            btn_preAll.Margin = new Padding(2);
            btn_preAll.Name = "btn_preAll";
            btn_preAll.Size = new Size(70, 30);
            btn_preAll.TabIndex = 3;
            btn_preAll.Text = "<<";
            btn_preAll.UseVisualStyleBackColor = true;
            // 
            // btn_pre
            // 
            btn_pre.Location = new Point(151, 392);
            btn_pre.Margin = new Padding(2);
            btn_pre.Name = "btn_pre";
            btn_pre.Size = new Size(70, 30);
            btn_pre.TabIndex = 4;
            btn_pre.Text = "<";
            btn_pre.UseVisualStyleBackColor = true;
            // 
            // dtp_denNgay
            // 
            dtp_denNgay.CustomFormat = "dd/MM/yyyy";
            dtp_denNgay.Format = DateTimePickerFormat.Custom;
            dtp_denNgay.Location = new Point(742, 15);
            dtp_denNgay.Margin = new Padding(2);
            dtp_denNgay.Name = "dtp_denNgay";
            dtp_denNgay.Size = new Size(167, 26);
            dtp_denNgay.TabIndex = 1;
            dtp_denNgay.Value = new DateTime(2023, 10, 27, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(280, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(341, 29);
            label1.TabIndex = 2;
            label1.Text = "Danh Sách Bill Đã Thanh Toán";
            // 
            // dtp_tuNgay
            // 
            dtp_tuNgay.CustomFormat = "dd/MM/yyyy";
            dtp_tuNgay.Format = DateTimePickerFormat.Custom;
            dtp_tuNgay.Location = new Point(27, 15);
            dtp_tuNgay.Margin = new Padding(2);
            dtp_tuNgay.Name = "dtp_tuNgay";
            dtp_tuNgay.Size = new Size(167, 26);
            dtp_tuNgay.TabIndex = 0;
            dtp_tuNgay.Value = new DateTime(2023, 10, 27, 0, 0, 0, 0);
            // 
            // dgw_DoanhThu
            // 
            dgw_DoanhThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_DoanhThu.Location = new Point(0, 58);
            dgw_DoanhThu.Margin = new Padding(5);
            dgw_DoanhThu.Name = "dgw_DoanhThu";
            dgw_DoanhThu.RowHeadersWidth = 51;
            dgw_DoanhThu.RowTemplate.Height = 24;
            dgw_DoanhThu.Size = new Size(947, 319);
            dgw_DoanhThu.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btn_reset);
            tabPage2.Controls.Add(btn_xoa);
            tabPage2.Controls.Add(btn_sua);
            tabPage2.Controls.Add(btn_them);
            tabPage2.Controls.Add(dtp_ngaySinh);
            tabPage2.Controls.Add(tbx_QueQuan);
            tabPage2.Controls.Add(tbx_TenNhanVien);
            tabPage2.Controls.Add(tbx_CMND);
            tabPage2.Controls.Add(tbx_gioiTinh);
            tabPage2.Controls.Add(tbx_SDT);
            tabPage2.Controls.Add(tbx_ID);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(dgw_Staff);
            tabPage2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(10);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(5);
            tabPage2.Size = new Size(954, 482);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Nhân Viên";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(571, 447);
            btn_xoa.Margin = new Padding(2);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(115, 28);
            btn_xoa.TabIndex = 9;
            btn_xoa.Text = "Xoá";
            btn_xoa.UseCompatibleTextRendering = true;
            btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(808, 394);
            btn_sua.Margin = new Padding(2);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(115, 28);
            btn_sua.TabIndex = 8;
            btn_sua.Text = "Sửa";
            btn_sua.UseCompatibleTextRendering = true;
            btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(571, 394);
            btn_them.Margin = new Padding(2);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(115, 28);
            btn_them.TabIndex = 7;
            btn_them.Text = "Thêm";
            btn_them.UseCompatibleTextRendering = true;
            btn_them.UseVisualStyleBackColor = true;
            // 
            // dtp_ngaySinh
            // 
            dtp_ngaySinh.Cursor = Cursors.AppStarting;
            dtp_ngaySinh.DropDownAlign = LeftRightAlignment.Right;
            dtp_ngaySinh.Format = DateTimePickerFormat.Short;
            dtp_ngaySinh.Location = new Point(708, 178);
            dtp_ngaySinh.Margin = new Padding(2);
            dtp_ngaySinh.Name = "dtp_ngaySinh";
            dtp_ngaySinh.Size = new Size(223, 26);
            dtp_ngaySinh.TabIndex = 3;
            // 
            // tbx_QueQuan
            // 
            tbx_QueQuan.Location = new Point(708, 339);
            tbx_QueQuan.Margin = new Padding(2);
            tbx_QueQuan.Multiline = true;
            tbx_QueQuan.Name = "tbx_QueQuan";
            tbx_QueQuan.Size = new Size(228, 26);
            tbx_QueQuan.TabIndex = 6;
            // 
            // tbx_TenNhanVien
            // 
            tbx_TenNhanVien.Location = new Point(708, 74);
            tbx_TenNhanVien.Margin = new Padding(2);
            tbx_TenNhanVien.Multiline = true;
            tbx_TenNhanVien.Name = "tbx_TenNhanVien";
            tbx_TenNhanVien.Size = new Size(228, 26);
            tbx_TenNhanVien.TabIndex = 1;
            // 
            // tbx_CMND
            // 
            tbx_CMND.Location = new Point(708, 122);
            tbx_CMND.Margin = new Padding(2);
            tbx_CMND.Multiline = true;
            tbx_CMND.Name = "tbx_CMND";
            tbx_CMND.Size = new Size(228, 26);
            tbx_CMND.TabIndex = 2;
            // 
            // tbx_gioiTinh
            // 
            tbx_gioiTinh.Location = new Point(708, 237);
            tbx_gioiTinh.Margin = new Padding(2);
            tbx_gioiTinh.Multiline = true;
            tbx_gioiTinh.Name = "tbx_gioiTinh";
            tbx_gioiTinh.Size = new Size(228, 26);
            tbx_gioiTinh.TabIndex = 4;
            // 
            // tbx_SDT
            // 
            tbx_SDT.Location = new Point(708, 289);
            tbx_SDT.Margin = new Padding(2);
            tbx_SDT.Multiline = true;
            tbx_SDT.Name = "tbx_SDT";
            tbx_SDT.Size = new Size(228, 26);
            tbx_SDT.TabIndex = 5;
            // 
            // tbx_ID
            // 
            tbx_ID.Location = new Point(708, 24);
            tbx_ID.Margin = new Padding(2);
            tbx_ID.Multiline = true;
            tbx_ID.Name = "tbx_ID";
            tbx_ID.Size = new Size(228, 26);
            tbx_ID.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(578, 342);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(82, 20);
            label9.TabIndex = 8;
            label9.Text = "Quê Quán";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(578, 76);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(114, 20);
            label8.TabIndex = 7;
            label8.Text = "Tên Nhân Viên";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(578, 122);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 6;
            label7.Text = "CMND";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(578, 178);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 5;
            label6.Text = "Ngày Sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(578, 242);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 4;
            label5.Text = "Giới Tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(578, 294);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 3;
            label4.Text = "SDT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(586, 30);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 2;
            label3.Text = "ID";
            // 
            // dgw_Staff
            // 
            dgw_Staff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_Staff.Location = new Point(0, 0);
            dgw_Staff.Margin = new Padding(5);
            dgw_Staff.Name = "dgw_Staff";
            dgw_Staff.RowHeadersWidth = 51;
            dgw_Staff.RowTemplate.Height = 24;
            dgw_Staff.Size = new Size(545, 485);
            dgw_Staff.TabIndex = 1;
            // 
            // tpg_TaiKhoan
            // 
            tpg_TaiKhoan.Controls.Add(btn_resetPw);
            tpg_TaiKhoan.Controls.Add(btn_SuaTk);
            tpg_TaiKhoan.Controls.Add(btn_xoaTk);
            tpg_TaiKhoan.Controls.Add(btn_themTk);
            tpg_TaiKhoan.Controls.Add(label14);
            tpg_TaiKhoan.Controls.Add(label13);
            tpg_TaiKhoan.Controls.Add(numericUpDown1);
            tpg_TaiKhoan.Controls.Add(tbx_tenHT);
            tpg_TaiKhoan.Controls.Add(tbx_tenTK);
            tpg_TaiKhoan.Controls.Add(label12);
            tpg_TaiKhoan.Controls.Add(label11);
            tpg_TaiKhoan.Controls.Add(label10);
            tpg_TaiKhoan.Controls.Add(dgw_TaiKhoan);
            tpg_TaiKhoan.Location = new Point(4, 29);
            tpg_TaiKhoan.Margin = new Padding(5);
            tpg_TaiKhoan.Name = "tpg_TaiKhoan";
            tpg_TaiKhoan.Padding = new Padding(10);
            tpg_TaiKhoan.Size = new Size(954, 482);
            tpg_TaiKhoan.TabIndex = 2;
            tpg_TaiKhoan.Text = "Tài Khoản";
            tpg_TaiKhoan.UseVisualStyleBackColor = true;
            // 
            // btn_resetPw
            // 
            btn_resetPw.Location = new Point(748, 389);
            btn_resetPw.Margin = new Padding(2);
            btn_resetPw.Name = "btn_resetPw";
            btn_resetPw.Size = new Size(182, 35);
            btn_resetPw.TabIndex = 6;
            btn_resetPw.Text = "Đặt Lại Mật Khẩu";
            btn_resetPw.UseVisualStyleBackColor = true;
            // 
            // btn_SuaTk
            // 
            btn_SuaTk.Location = new Point(836, 295);
            btn_SuaTk.Margin = new Padding(2);
            btn_SuaTk.Name = "btn_SuaTk";
            btn_SuaTk.Size = new Size(95, 41);
            btn_SuaTk.TabIndex = 5;
            btn_SuaTk.Text = "Sửa";
            btn_SuaTk.UseVisualStyleBackColor = true;
            // 
            // btn_xoaTk
            // 
            btn_xoaTk.Location = new Point(718, 295);
            btn_xoaTk.Margin = new Padding(2);
            btn_xoaTk.Name = "btn_xoaTk";
            btn_xoaTk.Size = new Size(95, 41);
            btn_xoaTk.TabIndex = 4;
            btn_xoaTk.Text = "Xoá";
            btn_xoaTk.UseVisualStyleBackColor = true;
            // 
            // btn_themTk
            // 
            btn_themTk.Location = new Point(582, 295);
            btn_themTk.Margin = new Padding(2);
            btn_themTk.Name = "btn_themTk";
            btn_themTk.Size = new Size(95, 41);
            btn_themTk.TabIndex = 3;
            btn_themTk.Text = "Thêm";
            btn_themTk.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(832, 235);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(60, 20);
            label14.TabIndex = 10;
            label14.Text = "1: User";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(832, 198);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(71, 20);
            label13.TabIndex = 9;
            label13.Text = "0: Admin";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            numericUpDown1.Location = new Point(749, 194);
            numericUpDown1.Margin = new Padding(2);
            numericUpDown1.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(64, 26);
            numericUpDown1.TabIndex = 2;
            // 
            // tbx_tenHT
            // 
            tbx_tenHT.Location = new Point(749, 110);
            tbx_tenHT.Margin = new Padding(2);
            tbx_tenHT.Name = "tbx_tenHT";
            tbx_tenHT.Size = new Size(184, 26);
            tbx_tenHT.TabIndex = 1;
            // 
            // tbx_tenTK
            // 
            tbx_tenTK.Location = new Point(749, 40);
            tbx_tenTK.Margin = new Padding(2);
            tbx_tenTK.Name = "tbx_tenTK";
            tbx_tenTK.Size = new Size(184, 26);
            tbx_tenTK.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(584, 195);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(114, 20);
            label12.TabIndex = 4;
            label12.Text = "Loại Tài Khoản";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(584, 114);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(98, 20);
            label11.TabIndex = 3;
            label11.Text = "Tên Hiển Thị";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(584, 44);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(111, 20);
            label10.TabIndex = 2;
            label10.Text = "Tên Tài Khoản";
            // 
            // dgw_TaiKhoan
            // 
            dgw_TaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_TaiKhoan.Location = new Point(0, 0);
            dgw_TaiKhoan.Margin = new Padding(5);
            dgw_TaiKhoan.Name = "dgw_TaiKhoan";
            dgw_TaiKhoan.RowHeadersWidth = 51;
            dgw_TaiKhoan.RowTemplate.Height = 24;
            dgw_TaiKhoan.Size = new Size(545, 475);
            dgw_TaiKhoan.TabIndex = 1;
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(808, 447);
            btn_reset.Margin = new Padding(2);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(115, 28);
            btn_reset.TabIndex = 10;
            btn_reset.Text = "Reset";
            btn_reset.UseCompatibleTextRendering = true;
            btn_reset.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 560);
            Controls.Add(tbl_DoanhThu);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "AdminForm";
            Text = "Admin";
            tbl_DoanhThu.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_DoanhThu).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_Staff).EndInit();
            tpg_TaiKhoan.ResumeLayout(false);
            tpg_TaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgw_TaiKhoan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbl_DoanhThu;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tpg_TaiKhoan;
        private DataGridView dgw_DoanhThu;
        private DataGridView dgw_Staff;
        private DataGridView dgw_TaiKhoan;
        private DateTimePicker dtp_denNgay;
        private Label label1;
        private DateTimePicker dtp_tuNgay;
        private TextBox tbx_soTrang;
        private Button btn_nextAll;
        private Button btn_next;
        private Button btn_preAll;
        private Button btn_pre;
        private TextBox tbx_tongDoanhThu;
        private Label label2;
        private Button btn_thongKe;
        private TextBox tbx_ID;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DateTimePicker dtp_ngaySinh;
        private TextBox tbx_QueQuan;
        private TextBox tbx_TenNhanVien;
        private TextBox tbx_CMND;
        private TextBox tbx_gioiTinh;
        private TextBox tbx_SDT;
        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_them;
        private Label label14;
        private Label label13;
        private NumericUpDown numericUpDown1;
        private TextBox tbx_tenHT;
        private TextBox tbx_tenTK;
        private Label label12;
        private Label label11;
        private Label label10;
        private Button btn_resetPw;
        private Button btn_SuaTk;
        private Button btn_xoaTk;
        private Button btn_themTk;
        private Button btn_reset;
    }
}