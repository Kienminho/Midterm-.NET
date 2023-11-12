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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            nud_ngayThue = new NumericUpDown();
            btn_datXe = new Button();
            btn_reset = new Button();
            label4 = new Label();
            label5 = new Label();
            fl_displayCar = new FlowLayoutPanel();
            panel_order = new Panel();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label12 = new Label();
            checkBox9 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label11 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            lb_totalPrice = new Label();
            label10 = new Label();
            lb_totalDay = new Label();
            label7 = new Label();
            cbb_customer = new ComboBox();
            dtp_to = new DateTimePicker();
            label6 = new Label();
            dtp_from = new DateTimePicker();
            lb_priceEachDay = new Label();
            label8 = new Label();
            lb_moneyOptions = new Label();
            lb_typeCar = new Label();
            panel3 = new Panel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_ngayThue).BeginInit();
            panel_order.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            menuStrip1.Size = new Size(315, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnu_Admin
            // 
            mnu_Admin.Name = "mnu_Admin";
            mnu_Admin.Size = new Size(55, 20);
            mnu_Admin.Text = "Admin";
            mnu_Admin.Click += mnu_Admin_Click;
            // 
            // mnu_ThongTinTaiKhoan
            // 
            mnu_ThongTinTaiKhoan.DropDownItems.AddRange(new ToolStripItem[] { mnu_TTCN, mnu_logOut });
            mnu_ThongTinTaiKhoan.Name = "mnu_ThongTinTaiKhoan";
            mnu_ThongTinTaiKhoan.Size = new Size(122, 20);
            mnu_ThongTinTaiKhoan.Text = "Thông tin tài khoản";
            // 
            // mnu_TTCN
            // 
            mnu_TTCN.Name = "mnu_TTCN";
            mnu_TTCN.Size = new Size(176, 22);
            mnu_TTCN.Text = "Thông Tin Cá Nhân";
            mnu_TTCN.Click += mnu_TTCN_Click;
            // 
            // mnu_logOut
            // 
            mnu_logOut.Name = "mnu_logOut";
            mnu_logOut.Size = new Size(176, 22);
            mnu_logOut.Text = "Đăng Xuất";
            mnu_logOut.Click += mnu_logOut_Click;
            // 
            // mnu_QuanLyBanHang
            // 
            mnu_QuanLyBanHang.Name = "mnu_QuanLyBanHang";
            mnu_QuanLyBanHang.Size = new Size(130, 20);
            mnu_QuanLyBanHang.Text = "Quản Lý Khách Hàng";
            mnu_QuanLyBanHang.Click += mnu_QuanLyBanHang_Click;
            // 
            // mnu_Import
            // 
            mnu_Import.Name = "mnu_Import";
            mnu_Import.Size = new Size(55, 20);
            mnu_Import.Text = "Import";
            mnu_Import.Click += mnu_Import_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 255, 255);
            label1.Font = new Font("Microsoft Sans Serif", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(106, 38);
            label1.Name = "label1";
            label1.Size = new Size(285, 30);
            label1.TabIndex = 6;
            label1.Text = "Cửa Hàng Cho Thuê Xe";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(128, 255, 255);
            label2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(5, 5);
            label2.Margin = new Padding(5, 5, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(146, 22);
            label2.TabIndex = 8;
            label2.Text = "Tên Khách Hàng";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(128, 255, 255);
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(5, 52);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 9;
            label3.Text = "Từ ngày";
            // 
            // nud_ngayThue
            // 
            nud_ngayThue.Location = new Point(2988, 358);
            nud_ngayThue.Margin = new Padding(12, 13, 12, 13);
            nud_ngayThue.Name = "nud_ngayThue";
            nud_ngayThue.Size = new Size(252, 30);
            nud_ngayThue.TabIndex = 2;
            nud_ngayThue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btn_datXe
            // 
            btn_datXe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_datXe.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_datXe.Location = new Point(419, 115);
            btn_datXe.Name = "btn_datXe";
            btn_datXe.Size = new Size(74, 30);
            btn_datXe.TabIndex = 3;
            btn_datXe.Text = "Đặt Xe";
            btn_datXe.UseVisualStyleBackColor = true;
            btn_datXe.Click += btn_datXe_Click;
            // 
            // btn_reset
            // 
            btn_reset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_reset.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_reset.Location = new Point(421, 5);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(74, 30);
            btn_reset.TabIndex = 4;
            btn_reset.Text = "Làm mới";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(185, 10);
            label4.Name = "label4";
            label4.Size = new Size(119, 22);
            label4.TabIndex = 17;
            label4.Text = "Tiền chức năng";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(383, 10);
            label5.Name = "label5";
            label5.Size = new Size(102, 22);
            label5.TabIndex = 18;
            label5.Text = "Giá xe / ngày";
            // 
            // fl_displayCar
            // 
            fl_displayCar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            fl_displayCar.AutoScroll = true;
            fl_displayCar.Location = new Point(12, 142);
            fl_displayCar.Name = "fl_displayCar";
            fl_displayCar.Size = new Size(540, 436);
            fl_displayCar.TabIndex = 20;
            // 
            // panel_order
            // 
            panel_order.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel_order.AutoScroll = true;
            panel_order.BackColor = SystemColors.Control;
            panel_order.Controls.Add(radioButton3);
            panel_order.Controls.Add(radioButton2);
            panel_order.Controls.Add(radioButton1);
            panel_order.Controls.Add(label12);
            panel_order.Controls.Add(checkBox9);
            panel_order.Controls.Add(checkBox8);
            panel_order.Controls.Add(checkBox7);
            panel_order.Controls.Add(checkBox6);
            panel_order.Controls.Add(checkBox5);
            panel_order.Controls.Add(checkBox4);
            panel_order.Controls.Add(checkBox3);
            panel_order.Controls.Add(checkBox2);
            panel_order.Controls.Add(checkBox1);
            panel_order.Controls.Add(label11);
            panel_order.Location = new Point(561, 254);
            panel_order.Name = "panel_order";
            panel_order.Size = new Size(506, 226);
            panel_order.TabIndex = 22;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.Location = new Point(363, 220);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(56, 22);
            radioButton3.TabIndex = 13;
            radioButton3.TabStop = true;
            radioButton3.Text = "Điện";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += checkRadio;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(185, 220);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(53, 22);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "Dầu";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += checkRadio;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(15, 220);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(60, 22);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "Xăng";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += checkRadio;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 177);
            label12.Name = "label12";
            label12.Size = new Size(98, 25);
            label12.TabIndex = 10;
            label12.Text = "Nhiên liệu";
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox9.Location = new Point(363, 139);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(137, 22);
            checkBox9.TabIndex = 9;
            checkBox9.Text = "Cảnh báo tốc độ";
            checkBox9.UseVisualStyleBackColor = true;
            checkBox9.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox8.Location = new Point(185, 139);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(148, 22);
            checkBox8.TabIndex = 8;
            checkBox8.Text = "Màn hình cảm ứng";
            checkBox8.UseVisualStyleBackColor = true;
            checkBox8.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox7.Location = new Point(15, 139);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(100, 22);
            checkBox7.TabIndex = 7;
            checkBox7.Text = "Cửa sổ trời";
            checkBox7.UseVisualStyleBackColor = true;
            checkBox7.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox6.Location = new Point(363, 93);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(108, 22);
            checkBox6.TabIndex = 6;
            checkBox6.Text = "Camera 360";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox5.Location = new Point(185, 93);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(148, 22);
            checkBox5.TabIndex = 5;
            checkBox5.Text = "Camera hành trình";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox4.Location = new Point(15, 93);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(114, 22);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "Cảm biến lốp";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox3.Location = new Point(363, 47);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(98, 22);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "Camera lùi";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(187, 47);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(123, 22);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "Camera cập lề";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(15, 47);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(74, 22);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Bản đồ";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox_CheckedChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(5, 9);
            label11.Name = "label11";
            label11.Size = new Size(100, 25);
            label11.TabIndex = 0;
            label11.Text = "Tính năng";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(15, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(537, 109);
            panel1.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lb_totalPrice);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(lb_totalDay);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(cbb_customer);
            panel2.Controls.Add(dtp_to);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(dtp_from);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btn_reset);
            panel2.Controls.Add(btn_datXe);
            panel2.Location = new Point(561, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(506, 221);
            panel2.TabIndex = 24;
            // 
            // lb_totalPrice
            // 
            lb_totalPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lb_totalPrice.AutoSize = true;
            lb_totalPrice.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_totalPrice.Location = new Point(185, 184);
            lb_totalPrice.Name = "lb_totalPrice";
            lb_totalPrice.Size = new Size(31, 20);
            lb_totalPrice.TabIndex = 31;
            lb_totalPrice.Text = "0 đ";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(128, 255, 255);
            label10.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(5, 182);
            label10.Margin = new Padding(5, 5, 3, 0);
            label10.Name = "label10";
            label10.Size = new Size(52, 22);
            label10.TabIndex = 30;
            label10.Text = "Tổng";
            // 
            // lb_totalDay
            // 
            lb_totalDay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lb_totalDay.AutoSize = true;
            lb_totalDay.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_totalDay.Location = new Point(185, 139);
            lb_totalDay.Name = "lb_totalDay";
            lb_totalDay.Size = new Size(18, 20);
            lb_totalDay.TabIndex = 29;
            lb_totalDay.Text = "1";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(128, 255, 255);
            label7.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(5, 137);
            label7.Margin = new Padding(5, 5, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(116, 22);
            label7.TabIndex = 15;
            label7.Text = "Số ngày thuê";
            // 
            // cbb_customer
            // 
            cbb_customer.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbb_customer.FormattingEnabled = true;
            cbb_customer.Items.AddRange(new object[] { "Nguyễn Văn A", "Nguyễn Văn B", "Nguyễn Thị Bê Đê" });
            cbb_customer.Location = new Point(187, 5);
            cbb_customer.Name = "cbb_customer";
            cbb_customer.Size = new Size(169, 26);
            cbb_customer.TabIndex = 13;
            // 
            // dtp_to
            // 
            dtp_to.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_to.Format = DateTimePickerFormat.Custom;
            dtp_to.Location = new Point(185, 91);
            dtp_to.Name = "dtp_to";
            dtp_to.Size = new Size(140, 24);
            dtp_to.TabIndex = 12;
            dtp_to.ValueChanged += dtp_to_ValueChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(128, 255, 255);
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(187, 52);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 11;
            label6.Text = "Đến ngày";
            // 
            // dtp_from
            // 
            dtp_from.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_from.Format = DateTimePickerFormat.Custom;
            dtp_from.Location = new Point(5, 91);
            dtp_from.Name = "dtp_from";
            dtp_from.Size = new Size(140, 24);
            dtp_from.TabIndex = 10;
            // 
            // lb_priceEachDay
            // 
            lb_priceEachDay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lb_priceEachDay.AutoSize = true;
            lb_priceEachDay.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_priceEachDay.Location = new Point(381, 55);
            lb_priceEachDay.Name = "lb_priceEachDay";
            lb_priceEachDay.Size = new Size(31, 20);
            lb_priceEachDay.TabIndex = 25;
            lb_priceEachDay.Text = "0 đ";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(5, 10);
            label8.Name = "label8";
            label8.Size = new Size(70, 22);
            label8.TabIndex = 26;
            label8.Text = "Hãng xe";
            // 
            // lb_moneyOptions
            // 
            lb_moneyOptions.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lb_moneyOptions.AutoSize = true;
            lb_moneyOptions.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_moneyOptions.Location = new Point(185, 57);
            lb_moneyOptions.Name = "lb_moneyOptions";
            lb_moneyOptions.Size = new Size(31, 20);
            lb_moneyOptions.TabIndex = 27;
            lb_moneyOptions.Text = "0 đ";
            // 
            // lb_typeCar
            // 
            lb_typeCar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lb_typeCar.AutoSize = true;
            lb_typeCar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_typeCar.Location = new Point(5, 59);
            lb_typeCar.Name = "lb_typeCar";
            lb_typeCar.Size = new Size(86, 20);
            lb_typeCar.TabIndex = 28;
            lb_typeCar.Text = "Mersai dec";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lb_priceEachDay);
            panel3.Controls.Add(lb_moneyOptions);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(lb_typeCar);
            panel3.Location = new Point(561, 486);
            panel3.Name = "panel3";
            panel3.Size = new Size(506, 92);
            panel3.TabIndex = 25;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 585);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel_order);
            Controls.Add(fl_displayCar);
            Controls.Add(nud_ngayThue);
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
            panel_order.ResumeLayout(false);
            panel_order.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnu_Admin;
        private ToolStripMenuItem mnu_ThongTinTaiKhoan;
        private ToolStripMenuItem mnu_QuanLyBanHang;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown nud_ngayThue;
        private Button btn_datXe;
        private Label label4;
        private Label label5;
        private ToolStripMenuItem mnu_TTCN;
        private ToolStripMenuItem mnu_logOut;
        private FlowLayoutPanel fl_displayCar;
        private ToolStripMenuItem mnu_Import;
        private Panel panel_order;
        private Panel panel1;
        private Panel panel2;
        private Label label6;
        private DateTimePicker dtp_from;
        private DateTimePicker dtp_to;
        private ComboBox cbb_customer;
        private Label lb_priceEachDay;
        private Label label8;
        private Label lb_moneyOptions;
        private Label lb_typeCar;
        private Label label11;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox9;
        private CheckBox checkBox8;
        private Panel panel3;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label12;
        private Button btn_reset;
        private Label lb_totalPrice;
        private Label label10;
        private Label lb_totalDay;
        private Label label7;
    }
}