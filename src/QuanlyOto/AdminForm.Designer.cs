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
            tc_admin = new TabControl();
            tabPage1 = new TabPage();
            lb_numberOfRentals = new Label();
            lb_totalRevenue = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label15 = new Label();
            btn_thongKe = new Button();
            label2 = new Label();
            dtp_denNgay = new DateTimePicker();
            label1 = new Label();
            dtp_tuNgay = new DateTimePicker();
            dgw_DoanhThu = new DataGridView();
            tabPage2 = new TabPage();
            btn_reset = new Button();
            btn_xoa = new Button();
            btn_edit_staff = new Button();
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
            tbx_address = new TextBox();
            label17 = new Label();
            lb_gender = new ListBox();
            label16 = new Label();
            btn_reset_staff = new Button();
            btn_editStaff = new Button();
            btn_deleteStaff = new Button();
            btn_addStaff = new Button();
            label14 = new Label();
            label13 = new Label();
            numericUpDown1 = new NumericUpDown();
            tbx_fullname = new TextBox();
            tbx_phoneNumber = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            dgw_TaiKhoan = new DataGridView();
            btn_chart = new Button();
            tc_admin.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_DoanhThu).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_Staff).BeginInit();
            tpg_TaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgw_TaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // tc_admin
            // 
            tc_admin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tc_admin.Controls.Add(tabPage1);
            tc_admin.Controls.Add(tabPage2);
            tc_admin.Controls.Add(tpg_TaiKhoan);
            tc_admin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tc_admin.Location = new Point(29, 48);
            tc_admin.Margin = new Padding(15);
            tc_admin.Name = "tc_admin";
            tc_admin.SelectedIndex = 0;
            tc_admin.Size = new Size(1212, 630);
            tc_admin.TabIndex = 0;
            tc_admin.SelectedIndexChanged += tc_admin_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btn_chart);
            tabPage1.Controls.Add(lb_numberOfRentals);
            tabPage1.Controls.Add(lb_totalRevenue);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(btn_thongKe);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(dtp_denNgay);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dtp_tuNgay);
            tabPage1.Controls.Add(dgw_DoanhThu);
            tabPage1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(15);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(8);
            tabPage1.Size = new Size(1204, 597);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Doanh Thu";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lb_numberOfRentals
            // 
            lb_numberOfRentals.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lb_numberOfRentals.AutoSize = true;
            lb_numberOfRentals.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_numberOfRentals.Location = new Point(206, 542);
            lb_numberOfRentals.Name = "lb_numberOfRentals";
            lb_numberOfRentals.Size = new Size(18, 20);
            lb_numberOfRentals.TabIndex = 16;
            lb_numberOfRentals.Text = "0";
            // 
            // lb_totalRevenue
            // 
            lb_totalRevenue.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lb_totalRevenue.AutoSize = true;
            lb_totalRevenue.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_totalRevenue.Location = new Point(206, 497);
            lb_totalRevenue.Name = "lb_totalRevenue";
            lb_totalRevenue.Size = new Size(31, 20);
            lb_totalRevenue.TabIndex = 15;
            lb_totalRevenue.Text = "0 đ";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(1059, 24);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 19);
            textBox3.TabIndex = 14;
            textBox3.Text = "Đến ngày";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(11, 24);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 19);
            textBox2.TabIndex = 13;
            textBox2.Text = "Từ ngày";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(3, 536);
            label15.Name = "label15";
            label15.Size = new Size(134, 26);
            label15.TabIndex = 11;
            label15.Text = "Số lượt thuê:";
            // 
            // btn_thongKe
            // 
            btn_thongKe.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_thongKe.Location = new Point(1064, 487);
            btn_thongKe.Margin = new Padding(3, 2, 3, 2);
            btn_thongKe.Name = "btn_thongKe";
            btn_thongKe.Size = new Size(125, 40);
            btn_thongKe.TabIndex = 2;
            btn_thongKe.Text = "Xuất báo cáo";
            btn_thongKe.UseVisualStyleBackColor = true;
            btn_thongKe.Click += btn_thongKe_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 493);
            label2.Name = "label2";
            label2.Size = new Size(178, 26);
            label2.TabIndex = 9;
            label2.Text = "Tổng Doanh Thu:";
            // 
            // dtp_denNgay
            // 
            dtp_denNgay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtp_denNgay.CustomFormat = "dd/MM/yyyy";
            dtp_denNgay.Format = DateTimePickerFormat.Custom;
            dtp_denNgay.Location = new Point(1059, 54);
            dtp_denNgay.Margin = new Padding(3, 2, 3, 2);
            dtp_denNgay.Name = "dtp_denNgay";
            dtp_denNgay.Size = new Size(130, 26);
            dtp_denNgay.TabIndex = 1;
            dtp_denNgay.Value = new DateTime(2023, 11, 12, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(432, 24);
            label1.Name = "label1";
            label1.Size = new Size(285, 29);
            label1.TabIndex = 2;
            label1.Text = "Danh sách các đơn đặt xe";
            // 
            // dtp_tuNgay
            // 
            dtp_tuNgay.CustomFormat = "dd/MM/yyyy";
            dtp_tuNgay.Format = DateTimePickerFormat.Custom;
            dtp_tuNgay.Location = new Point(11, 54);
            dtp_tuNgay.Margin = new Padding(3, 2, 3, 2);
            dtp_tuNgay.Name = "dtp_tuNgay";
            dtp_tuNgay.Size = new Size(130, 26);
            dtp_tuNgay.TabIndex = 0;
            dtp_tuNgay.Value = new DateTime(2023, 11, 12, 0, 0, 0, 0);
            // 
            // dgw_DoanhThu
            // 
            dgw_DoanhThu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgw_DoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgw_DoanhThu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgw_DoanhThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_DoanhThu.Location = new Point(0, 90);
            dgw_DoanhThu.Margin = new Padding(8);
            dgw_DoanhThu.Name = "dgw_DoanhThu";
            dgw_DoanhThu.RowHeadersWidth = 51;
            dgw_DoanhThu.RowTemplate.Height = 24;
            dgw_DoanhThu.Size = new Size(1204, 375);
            dgw_DoanhThu.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btn_reset);
            tabPage2.Controls.Add(btn_xoa);
            tabPage2.Controls.Add(btn_edit_staff);
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
            tabPage2.Margin = new Padding(15);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(8);
            tabPage2.Size = new Size(1204, 597);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Nhân Viên";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            btn_reset.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_reset.Location = new Point(1021, 502);
            btn_reset.Margin = new Padding(3, 2, 3, 2);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(172, 44);
            btn_reset.TabIndex = 10;
            btn_reset.Text = "Reset";
            btn_reset.UseCompatibleTextRendering = true;
            btn_reset.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            btn_xoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_xoa.Location = new Point(807, 502);
            btn_xoa.Margin = new Padding(3, 2, 3, 2);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(172, 44);
            btn_xoa.TabIndex = 9;
            btn_xoa.Text = "Xoá";
            btn_xoa.UseCompatibleTextRendering = true;
            btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_edit_staff
            // 
            btn_edit_staff.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_edit_staff.Location = new Point(1021, 436);
            btn_edit_staff.Margin = new Padding(3, 2, 3, 2);
            btn_edit_staff.Name = "btn_edit_staff";
            btn_edit_staff.Size = new Size(172, 44);
            btn_edit_staff.TabIndex = 8;
            btn_edit_staff.Text = "Sửa";
            btn_edit_staff.UseCompatibleTextRendering = true;
            btn_edit_staff.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            btn_them.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_them.Location = new Point(807, 436);
            btn_them.Margin = new Padding(3, 2, 3, 2);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(172, 44);
            btn_them.TabIndex = 7;
            btn_them.Text = "Thêm";
            btn_them.UseCompatibleTextRendering = true;
            btn_them.UseVisualStyleBackColor = true;
            // 
            // dtp_ngaySinh
            // 
            dtp_ngaySinh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtp_ngaySinh.Cursor = Cursors.AppStarting;
            dtp_ngaySinh.DropDownAlign = LeftRightAlignment.Right;
            dtp_ngaySinh.Format = DateTimePickerFormat.Short;
            dtp_ngaySinh.Location = new Point(967, 228);
            dtp_ngaySinh.Margin = new Padding(3, 2, 3, 2);
            dtp_ngaySinh.Name = "dtp_ngaySinh";
            dtp_ngaySinh.Size = new Size(226, 26);
            dtp_ngaySinh.TabIndex = 3;
            // 
            // tbx_QueQuan
            // 
            tbx_QueQuan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbx_QueQuan.Location = new Point(967, 372);
            tbx_QueQuan.Margin = new Padding(3, 2, 3, 2);
            tbx_QueQuan.Multiline = true;
            tbx_QueQuan.Name = "tbx_QueQuan";
            tbx_QueQuan.Size = new Size(226, 33);
            tbx_QueQuan.TabIndex = 6;
            // 
            // tbx_TenNhanVien
            // 
            tbx_TenNhanVien.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbx_TenNhanVien.Location = new Point(967, 96);
            tbx_TenNhanVien.Margin = new Padding(3, 2, 3, 2);
            tbx_TenNhanVien.Multiline = true;
            tbx_TenNhanVien.Name = "tbx_TenNhanVien";
            tbx_TenNhanVien.Size = new Size(226, 33);
            tbx_TenNhanVien.TabIndex = 1;
            // 
            // tbx_CMND
            // 
            tbx_CMND.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbx_CMND.Location = new Point(967, 158);
            tbx_CMND.Margin = new Padding(3, 2, 3, 2);
            tbx_CMND.Multiline = true;
            tbx_CMND.Name = "tbx_CMND";
            tbx_CMND.Size = new Size(226, 33);
            tbx_CMND.TabIndex = 2;
            // 
            // tbx_gioiTinh
            // 
            tbx_gioiTinh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbx_gioiTinh.Location = new Point(967, 274);
            tbx_gioiTinh.Margin = new Padding(3, 2, 3, 2);
            tbx_gioiTinh.Multiline = true;
            tbx_gioiTinh.Name = "tbx_gioiTinh";
            tbx_gioiTinh.Size = new Size(226, 33);
            tbx_gioiTinh.TabIndex = 4;
            // 
            // tbx_SDT
            // 
            tbx_SDT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbx_SDT.Location = new Point(967, 322);
            tbx_SDT.Margin = new Padding(3, 2, 3, 2);
            tbx_SDT.Multiline = true;
            tbx_SDT.Name = "tbx_SDT";
            tbx_SDT.Size = new Size(226, 33);
            tbx_SDT.TabIndex = 5;
            // 
            // tbx_ID
            // 
            tbx_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbx_ID.Location = new Point(967, 38);
            tbx_ID.Margin = new Padding(3, 2, 3, 2);
            tbx_ID.Multiline = true;
            tbx_ID.Name = "tbx_ID";
            tbx_ID.Size = new Size(226, 33);
            tbx_ID.TabIndex = 0;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(807, 385);
            label9.Name = "label9";
            label9.Size = new Size(82, 20);
            label9.TabIndex = 8;
            label9.Text = "Quê Quán";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(807, 109);
            label8.Name = "label8";
            label8.Size = new Size(114, 20);
            label8.TabIndex = 7;
            label8.Text = "Tên Nhân Viên";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(807, 171);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 6;
            label7.Text = "CMND";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(807, 233);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 5;
            label6.Text = "Ngày Sinh";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(807, 287);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 4;
            label5.Text = "Giới Tính";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(807, 335);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 3;
            label4.Text = "SDT";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(807, 51);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 2;
            label3.Text = "ID";
            // 
            // dgw_Staff
            // 
            dgw_Staff.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgw_Staff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgw_Staff.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgw_Staff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_Staff.Location = new Point(0, 4);
            dgw_Staff.Margin = new Padding(8);
            dgw_Staff.Name = "dgw_Staff";
            dgw_Staff.RowHeadersWidth = 51;
            dgw_Staff.RowTemplate.Height = 24;
            dgw_Staff.Size = new Size(796, 589);
            dgw_Staff.TabIndex = 1;
            // 
            // tpg_TaiKhoan
            // 
            tpg_TaiKhoan.Controls.Add(tbx_address);
            tpg_TaiKhoan.Controls.Add(label17);
            tpg_TaiKhoan.Controls.Add(lb_gender);
            tpg_TaiKhoan.Controls.Add(label16);
            tpg_TaiKhoan.Controls.Add(btn_reset_staff);
            tpg_TaiKhoan.Controls.Add(btn_editStaff);
            tpg_TaiKhoan.Controls.Add(btn_deleteStaff);
            tpg_TaiKhoan.Controls.Add(btn_addStaff);
            tpg_TaiKhoan.Controls.Add(label14);
            tpg_TaiKhoan.Controls.Add(label13);
            tpg_TaiKhoan.Controls.Add(numericUpDown1);
            tpg_TaiKhoan.Controls.Add(tbx_fullname);
            tpg_TaiKhoan.Controls.Add(tbx_phoneNumber);
            tpg_TaiKhoan.Controls.Add(label12);
            tpg_TaiKhoan.Controls.Add(label11);
            tpg_TaiKhoan.Controls.Add(label10);
            tpg_TaiKhoan.Controls.Add(dgw_TaiKhoan);
            tpg_TaiKhoan.Location = new Point(4, 29);
            tpg_TaiKhoan.Margin = new Padding(8);
            tpg_TaiKhoan.Name = "tpg_TaiKhoan";
            tpg_TaiKhoan.Padding = new Padding(15);
            tpg_TaiKhoan.Size = new Size(1204, 597);
            tpg_TaiKhoan.TabIndex = 2;
            tpg_TaiKhoan.Text = "Tài Khoản";
            tpg_TaiKhoan.UseVisualStyleBackColor = true;
            // 
            // tbx_address
            // 
            tbx_address.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbx_address.Location = new Point(1006, 255);
            tbx_address.Margin = new Padding(3, 2, 3, 2);
            tbx_address.Name = "tbx_address";
            tbx_address.Size = new Size(180, 26);
            tbx_address.TabIndex = 16;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Location = new Point(876, 261);
            label17.Name = "label17";
            label17.Size = new Size(57, 20);
            label17.TabIndex = 15;
            label17.Text = "Địa chỉ";
            // 
            // lb_gender
            // 
            lb_gender.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lb_gender.FormattingEnabled = true;
            lb_gender.ItemHeight = 20;
            lb_gender.Items.AddRange(new object[] { "Nam", "Nữ" });
            lb_gender.Location = new Point(1008, 198);
            lb_gender.Name = "lb_gender";
            lb_gender.Size = new Size(178, 4);
            lb_gender.TabIndex = 14;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Location = new Point(876, 202);
            label16.Name = "label16";
            label16.Size = new Size(67, 20);
            label16.TabIndex = 12;
            label16.Text = "Giới tính";
            // 
            // btn_reset_staff
            // 
            btn_reset_staff.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_reset_staff.Location = new Point(1076, 512);
            btn_reset_staff.Margin = new Padding(3, 2, 3, 2);
            btn_reset_staff.Name = "btn_reset_staff";
            btn_reset_staff.Size = new Size(83, 35);
            btn_reset_staff.TabIndex = 11;
            btn_reset_staff.Text = "Reset ";
            btn_reset_staff.UseVisualStyleBackColor = true;
            // 
            // btn_editStaff
            // 
            btn_editStaff.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_editStaff.Location = new Point(923, 512);
            btn_editStaff.Margin = new Padding(3, 2, 3, 2);
            btn_editStaff.Name = "btn_editStaff";
            btn_editStaff.Size = new Size(83, 35);
            btn_editStaff.TabIndex = 5;
            btn_editStaff.Text = "Sửa";
            btn_editStaff.UseVisualStyleBackColor = true;
            // 
            // btn_deleteStaff
            // 
            btn_deleteStaff.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_deleteStaff.Location = new Point(1076, 445);
            btn_deleteStaff.Margin = new Padding(3, 2, 3, 2);
            btn_deleteStaff.Name = "btn_deleteStaff";
            btn_deleteStaff.Size = new Size(83, 35);
            btn_deleteStaff.TabIndex = 4;
            btn_deleteStaff.Text = "Xoá";
            btn_deleteStaff.UseVisualStyleBackColor = true;
            // 
            // btn_addStaff
            // 
            btn_addStaff.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_addStaff.Location = new Point(923, 445);
            btn_addStaff.Margin = new Padding(3, 2, 3, 2);
            btn_addStaff.Name = "btn_addStaff";
            btn_addStaff.Size = new Size(83, 35);
            btn_addStaff.TabIndex = 3;
            btn_addStaff.Text = "Thêm";
            btn_addStaff.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Location = new Point(1104, 358);
            label14.Name = "label14";
            label14.Size = new Size(60, 20);
            label14.TabIndex = 10;
            label14.Text = "1: User";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Location = new Point(1126, 325);
            label13.Name = "label13";
            label13.Size = new Size(71, 20);
            label13.TabIndex = 9;
            label13.Text = "0: Admin";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDown1.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            numericUpDown1.Location = new Point(1008, 340);
            numericUpDown1.Margin = new Padding(2);
            numericUpDown1.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(64, 26);
            numericUpDown1.TabIndex = 2;
            // 
            // tbx_fullname
            // 
            tbx_fullname.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbx_fullname.Location = new Point(1008, 134);
            tbx_fullname.Margin = new Padding(3, 2, 3, 2);
            tbx_fullname.Name = "tbx_fullname";
            tbx_fullname.Size = new Size(180, 26);
            tbx_fullname.TabIndex = 1;
            // 
            // tbx_phoneNumber
            // 
            tbx_phoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbx_phoneNumber.Location = new Point(1008, 63);
            tbx_phoneNumber.Margin = new Padding(3, 2, 3, 2);
            tbx_phoneNumber.Name = "tbx_phoneNumber";
            tbx_phoneNumber.Size = new Size(180, 26);
            tbx_phoneNumber.TabIndex = 0;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(876, 346);
            label12.Name = "label12";
            label12.Size = new Size(114, 20);
            label12.TabIndex = 4;
            label12.Text = "Loại Tài Khoản";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(876, 140);
            label11.Name = "label11";
            label11.Size = new Size(77, 20);
            label11.TabIndex = 3;
            label11.Text = "Họ và tên";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(876, 69);
            label10.Name = "label10";
            label10.Size = new Size(102, 20);
            label10.TabIndex = 2;
            label10.Text = "Số điện thoại";
            // 
            // dgw_TaiKhoan
            // 
            dgw_TaiKhoan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgw_TaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_TaiKhoan.Location = new Point(0, 4);
            dgw_TaiKhoan.Margin = new Padding(8);
            dgw_TaiKhoan.Name = "dgw_TaiKhoan";
            dgw_TaiKhoan.RowHeadersWidth = 51;
            dgw_TaiKhoan.RowTemplate.Height = 24;
            dgw_TaiKhoan.Size = new Size(865, 589);
            dgw_TaiKhoan.TabIndex = 1;
            // 
            // btn_chart
            // 
            btn_chart.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_chart.Location = new Point(1064, 542);
            btn_chart.Margin = new Padding(3, 2, 3, 2);
            btn_chart.Name = "btn_chart";
            btn_chart.Size = new Size(125, 40);
            btn_chart.TabIndex = 17;
            btn_chart.Text = "Xem biểu đồ";
            btn_chart.UseVisualStyleBackColor = true;
            btn_chart.Click += btn_chart_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 700);
            Controls.Add(tc_admin);
            Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(8);
            Name = "AdminForm";
            Text = "Admin";
            Load += AdminForm_Load;
            tc_admin.ResumeLayout(false);
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

        private TabControl tc_admin;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tpg_TaiKhoan;
        private DataGridView dgw_DoanhThu;
        private DataGridView dgw_Staff;
        private DataGridView dgw_TaiKhoan;
        private DateTimePicker dtp_denNgay;
        private Label label1;
        private DateTimePicker dtp_tuNgay;
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
        private Button btn_edit_staff;
        private Button btn_them;
        private Label label14;
        private Label label13;
        private NumericUpDown numericUpDown1;
        private TextBox tbx_fullname;
        private TextBox tbx_phoneNumber;
        private Label label12;
        private Label label11;
        private Label label10;
        private Button btn_editStaff;
        private Button btn_deleteStaff;
        private Button btn_addStaff;
        private Button btn_reset;
        private Label label15;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btn_reset_staff;
        private Label label16;
        private TextBox tbx_address;
        private Label label17;
        private ListBox lb_gender;
        private Label lb_numberOfRentals;
        private Label lb_totalRevenue;
        private Button btn_chart;
    }
}