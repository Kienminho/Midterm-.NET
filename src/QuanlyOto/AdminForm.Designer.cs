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
            dgw_DoanhThu = new DataGridView();
            btn_chart = new Button();
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
            tabPage2 = new TabPage();
            btn_search = new Button();
            tb_search = new TextBox();
            tbx_price = new TextBox();
            label4 = new Label();
            tbx_brand = new TextBox();
            btn_reset = new Button();
            btn_deleteCar = new Button();
            btn_editCar = new Button();
            btn_addCar = new Button();
            tbx_nameCar = new TextBox();
            tbx_typeCar = new TextBox();
            tbx_statuts = new TextBox();
            tbx_ID = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            dgw_carManagement = new DataGridView();
            tpg_Schedule = new TabPage();
            btn_successSchedule = new Button();
            btn_resetSchedule = new Button();
            btn_deleteSchedule = new Button();
            dgw_Schedule = new DataGridView();
            tc_admin.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_DoanhThu).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_carManagement).BeginInit();
            tpg_Schedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_Schedule).BeginInit();
            SuspendLayout();
            // 
            // tc_admin
            // 
            tc_admin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tc_admin.Controls.Add(tabPage1);
            tc_admin.Controls.Add(tabPage2);
            tc_admin.Controls.Add(tpg_Schedule);
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
            tabPage1.Controls.Add(dgw_DoanhThu);
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
            // dgw_DoanhThu
            // 
            dgw_DoanhThu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgw_DoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgw_DoanhThu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgw_DoanhThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_DoanhThu.Location = new Point(11, 89);
            dgw_DoanhThu.Name = "dgw_DoanhThu";
            dgw_DoanhThu.RowHeadersWidth = 51;
            dgw_DoanhThu.RowTemplate.Height = 29;
            dgw_DoanhThu.Size = new Size(1178, 393);
            dgw_DoanhThu.TabIndex = 18;
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
            // lb_numberOfRentals
            // 
            lb_numberOfRentals.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lb_numberOfRentals.AutoSize = true;
            lb_numberOfRentals.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_numberOfRentals.Location = new Point(234, 542);
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
            lb_totalRevenue.Location = new Point(234, 495);
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
            // tabPage2
            // 
            tabPage2.Controls.Add(btn_search);
            tabPage2.Controls.Add(tb_search);
            tabPage2.Controls.Add(tbx_price);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(tbx_brand);
            tabPage2.Controls.Add(btn_reset);
            tabPage2.Controls.Add(btn_deleteCar);
            tabPage2.Controls.Add(btn_editCar);
            tabPage2.Controls.Add(btn_addCar);
            tabPage2.Controls.Add(tbx_nameCar);
            tabPage2.Controls.Add(tbx_typeCar);
            tabPage2.Controls.Add(tbx_statuts);
            tabPage2.Controls.Add(tbx_ID);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(dgw_carManagement);
            tabPage2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(15);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(8);
            tabPage2.Size = new Size(1204, 597);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Quản lý xe";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            btn_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_search.Location = new Point(1043, 31);
            btn_search.Margin = new Padding(3, 2, 3, 2);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(138, 35);
            btn_search.TabIndex = 15;
            btn_search.Text = "Tìm kiếm";
            btn_search.UseCompatibleTextRendering = true;
            btn_search.UseVisualStyleBackColor = true;
            // 
            // tb_search
            // 
            tb_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_search.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_search.Location = new Point(789, 31);
            tb_search.Margin = new Padding(3, 2, 3, 2);
            tb_search.Multiline = true;
            tb_search.Name = "tb_search";
            tb_search.Size = new Size(204, 33);
            tb_search.TabIndex = 14;
            tb_search.TextChanged += tb_search_TextChanged;
            // 
            // tbx_price
            // 
            tbx_price.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbx_price.Location = new Point(913, 412);
            tbx_price.Margin = new Padding(3, 2, 3, 2);
            tbx_price.Multiline = true;
            tbx_price.Name = "tbx_price";
            tbx_price.Size = new Size(279, 33);
            tbx_price.TabIndex = 13;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(789, 425);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 12;
            label4.Text = "Giá";
            // 
            // tbx_brand
            // 
            tbx_brand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbx_brand.Location = new Point(913, 276);
            tbx_brand.Margin = new Padding(3, 2, 3, 2);
            tbx_brand.Multiline = true;
            tbx_brand.Name = "tbx_brand";
            tbx_brand.Size = new Size(280, 33);
            tbx_brand.TabIndex = 11;
            // 
            // btn_reset
            // 
            btn_reset.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_reset.Location = new Point(1021, 538);
            btn_reset.Margin = new Padding(3, 2, 3, 2);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(172, 44);
            btn_reset.TabIndex = 10;
            btn_reset.Text = "Reset";
            btn_reset.UseCompatibleTextRendering = true;
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // btn_deleteCar
            // 
            btn_deleteCar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_deleteCar.Location = new Point(807, 538);
            btn_deleteCar.Margin = new Padding(3, 2, 3, 2);
            btn_deleteCar.Name = "btn_deleteCar";
            btn_deleteCar.Size = new Size(172, 44);
            btn_deleteCar.TabIndex = 9;
            btn_deleteCar.Text = "Xoá";
            btn_deleteCar.UseCompatibleTextRendering = true;
            btn_deleteCar.UseVisualStyleBackColor = true;
            btn_deleteCar.Click += btn_deleteCar_Click;
            // 
            // btn_editCar
            // 
            btn_editCar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_editCar.Location = new Point(1020, 482);
            btn_editCar.Margin = new Padding(3, 2, 3, 2);
            btn_editCar.Name = "btn_editCar";
            btn_editCar.Size = new Size(172, 44);
            btn_editCar.TabIndex = 8;
            btn_editCar.Text = "Sửa";
            btn_editCar.UseCompatibleTextRendering = true;
            btn_editCar.UseVisualStyleBackColor = true;
            btn_editCar.Click += btn_editCar_Click;
            // 
            // btn_addCar
            // 
            btn_addCar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_addCar.Location = new Point(807, 482);
            btn_addCar.Margin = new Padding(3, 2, 3, 2);
            btn_addCar.Name = "btn_addCar";
            btn_addCar.Size = new Size(172, 44);
            btn_addCar.TabIndex = 7;
            btn_addCar.Text = "Thêm";
            btn_addCar.UseCompatibleTextRendering = true;
            btn_addCar.UseVisualStyleBackColor = true;
            btn_addCar.Click += btn_addCar_Click;
            // 
            // tbx_nameCar
            // 
            tbx_nameCar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbx_nameCar.Location = new Point(913, 159);
            tbx_nameCar.Margin = new Padding(3, 2, 3, 2);
            tbx_nameCar.Multiline = true;
            tbx_nameCar.Name = "tbx_nameCar";
            tbx_nameCar.Size = new Size(280, 33);
            tbx_nameCar.TabIndex = 1;
            // 
            // tbx_typeCar
            // 
            tbx_typeCar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbx_typeCar.Location = new Point(913, 213);
            tbx_typeCar.Margin = new Padding(3, 2, 3, 2);
            tbx_typeCar.Multiline = true;
            tbx_typeCar.Name = "tbx_typeCar";
            tbx_typeCar.Size = new Size(280, 33);
            tbx_typeCar.TabIndex = 2;
            // 
            // tbx_statuts
            // 
            tbx_statuts.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbx_statuts.Location = new Point(913, 347);
            tbx_statuts.Margin = new Padding(3, 2, 3, 2);
            tbx_statuts.Multiline = true;
            tbx_statuts.Name = "tbx_statuts";
            tbx_statuts.Size = new Size(280, 33);
            tbx_statuts.TabIndex = 4;
            // 
            // tbx_ID
            // 
            tbx_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbx_ID.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_ID.Location = new Point(913, 97);
            tbx_ID.Margin = new Padding(3, 2, 3, 2);
            tbx_ID.Multiline = true;
            tbx_ID.Name = "tbx_ID";
            tbx_ID.Size = new Size(280, 33);
            tbx_ID.TabIndex = 0;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(789, 172);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 7;
            label8.Text = "Tên xe";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(789, 226);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 6;
            label7.Text = "Loại xe";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(789, 289);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 5;
            label6.Text = "Thương hiệu";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(789, 350);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 4;
            label5.Text = "Trạng thái";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(789, 110);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Car ID";
            // 
            // dgw_carManagement
            // 
            dgw_carManagement.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgw_carManagement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgw_carManagement.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgw_carManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_carManagement.Location = new Point(0, 4);
            dgw_carManagement.Margin = new Padding(8);
            dgw_carManagement.Name = "dgw_carManagement";
            dgw_carManagement.RowHeadersWidth = 51;
            dgw_carManagement.RowTemplate.Height = 24;
            dgw_carManagement.Size = new Size(766, 589);
            dgw_carManagement.TabIndex = 1;
            dgw_carManagement.CellContentClick += dgw_carManagement_CellContentClick;
            // 
            // tpg_Schedule
            // 
            tpg_Schedule.Controls.Add(btn_successSchedule);
            tpg_Schedule.Controls.Add(btn_resetSchedule);
            tpg_Schedule.Controls.Add(btn_deleteSchedule);
            tpg_Schedule.Controls.Add(dgw_Schedule);
            tpg_Schedule.Location = new Point(4, 29);
            tpg_Schedule.Margin = new Padding(8);
            tpg_Schedule.Name = "tpg_Schedule";
            tpg_Schedule.Padding = new Padding(15);
            tpg_Schedule.Size = new Size(1204, 597);
            tpg_Schedule.TabIndex = 2;
            tpg_Schedule.Text = "Lịch trình";
            tpg_Schedule.UseVisualStyleBackColor = true;
            // 
            // btn_successSchedule
            // 
            btn_successSchedule.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_successSchedule.Location = new Point(1067, 259);
            btn_successSchedule.Margin = new Padding(3, 2, 3, 2);
            btn_successSchedule.Name = "btn_successSchedule";
            btn_successSchedule.Size = new Size(119, 35);
            btn_successSchedule.TabIndex = 12;
            btn_successSchedule.Text = "Hoàn tất";
            btn_successSchedule.UseVisualStyleBackColor = true;
            btn_successSchedule.Click += btn_successSchedule_Click;
            // 
            // btn_resetSchedule
            // 
            btn_resetSchedule.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_resetSchedule.Location = new Point(983, 341);
            btn_resetSchedule.Margin = new Padding(3, 2, 3, 2);
            btn_resetSchedule.Name = "btn_resetSchedule";
            btn_resetSchedule.Size = new Size(119, 35);
            btn_resetSchedule.TabIndex = 11;
            btn_resetSchedule.Text = "Reset ";
            btn_resetSchedule.UseVisualStyleBackColor = true;
            // 
            // btn_deleteSchedule
            // 
            btn_deleteSchedule.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_deleteSchedule.Location = new Point(876, 259);
            btn_deleteSchedule.Margin = new Padding(3, 2, 3, 2);
            btn_deleteSchedule.Name = "btn_deleteSchedule";
            btn_deleteSchedule.Size = new Size(119, 35);
            btn_deleteSchedule.TabIndex = 4;
            btn_deleteSchedule.Text = "Xoá lịch trình";
            btn_deleteSchedule.UseVisualStyleBackColor = true;
            btn_deleteSchedule.Click += btn_deleteSchedule_Click;
            // 
            // dgw_Schedule
            // 
            dgw_Schedule.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgw_Schedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgw_Schedule.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgw_Schedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_Schedule.Location = new Point(0, 4);
            dgw_Schedule.Margin = new Padding(8);
            dgw_Schedule.Name = "dgw_Schedule";
            dgw_Schedule.RowHeadersWidth = 51;
            dgw_Schedule.RowTemplate.Height = 24;
            dgw_Schedule.Size = new Size(865, 589);
            dgw_Schedule.TabIndex = 1;
            dgw_Schedule.CellContentClick += dgw_Schedule_CellContentClick;
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
            ((System.ComponentModel.ISupportInitialize)dgw_carManagement).EndInit();
            tpg_Schedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgw_Schedule).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tc_admin;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tpg_Schedule;
        private DataGridView dgw_carManagement;
        private DataGridView dgw_Schedule;
        private DateTimePicker dtp_denNgay;
        private Label label1;
        private DateTimePicker dtp_tuNgay;
        private Label label2;
        private Button btn_thongKe;
        private TextBox tbx_ID;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private TextBox tbx_nameCar;
        private TextBox tbx_typeCar;
        private TextBox tbx_statuts;
        private Button btn_deleteCar;
        private Button btn_editCar;
        private Button btn_addCar;
        private Button btn_editStaff;
        private Button btn_deleteStaff;
        private Button btn_addStaff;
        private Button btn_reset;
        private Label label15;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btn_resetSchedule;
        private Button btn_deleteSchedule;
        private Label lb_numberOfRentals;
        private Label lb_totalRevenue;
        private Button btn_chart;
        private TextBox tbx_brand;
        private TextBox tbx_price;
        private Label label4;
        private Button btn_search;
        private TextBox tb_search;
        private Button btn_successSchedule;
        private DataGridView dgw_DoanhThu;
    }
}