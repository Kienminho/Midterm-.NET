namespace QuanlyOto
{
    partial class CustomerForm
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
            label1 = new Label();
            dgv_customer = new DataGridView();
            tbx_Tim = new TextBox();
            btn_tim = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label8 = new Label();
            tbx_thuexe = new TextBox();
            tbx_diachi = new TextBox();
            tbx_sdt = new TextBox();
            tbx_Ten = new TextBox();
            tbx_ID = new TextBox();
            btn_them = new Button();
            btn_sua = new Button();
            btn_xoa = new Button();
            label5 = new Label();
            tbx_CMND = new TextBox();
            label7 = new Label();
            btn_reset = new Button();
            cb_gender = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_customer).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(480, 22);
            label1.Name = "label1";
            label1.Size = new Size(163, 31);
            label1.TabIndex = 0;
            label1.Text = "Khách Hàng";
            // 
            // dgv_customer
            // 
            dgv_customer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_customer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_customer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_customer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_customer.Location = new Point(-51, 86);
            dgv_customer.Name = "dgv_customer";
            dgv_customer.RowHeadersWidth = 51;
            dgv_customer.RowTemplate.Height = 30;
            dgv_customer.Size = new Size(736, 479);
            dgv_customer.TabIndex = 0;
            dgv_customer.CellContentClick += dgv_customer_CellContentClick;
            // 
            // tbx_Tim
            // 
            tbx_Tim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbx_Tim.Location = new Point(729, 94);
            tbx_Tim.Margin = new Padding(2);
            tbx_Tim.Name = "tbx_Tim";
            tbx_Tim.Size = new Size(178, 23);
            tbx_Tim.TabIndex = 1;
            // 
            // btn_tim
            // 
            btn_tim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_tim.Location = new Point(974, 88);
            btn_tim.Margin = new Padding(2);
            btn_tim.Name = "btn_tim";
            btn_tim.Size = new Size(110, 34);
            btn_tim.TabIndex = 2;
            btn_tim.Text = "Tìm kiếm";
            btn_tim.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(729, 161);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(29, 17);
            label2.TabIndex = 4;
            label2.Text = "ID :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(729, 452);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 17);
            label3.TabIndex = 5;
            label3.Text = "Phí thuê";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(729, 381);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 17);
            label4.TabIndex = 6;
            label4.Text = "Địa Chỉ :";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(729, 282);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(44, 17);
            label6.TabIndex = 8;
            label6.Text = "SDT :";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(729, 201);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(123, 17);
            label8.TabIndex = 10;
            label8.Text = "Tên Khách Hàng :";
            // 
            // tbx_thuexe
            // 
            tbx_thuexe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbx_thuexe.Location = new Point(906, 446);
            tbx_thuexe.Margin = new Padding(2);
            tbx_thuexe.Name = "tbx_thuexe";
            tbx_thuexe.Size = new Size(178, 23);
            tbx_thuexe.TabIndex = 9;
            // 
            // tbx_diachi
            // 
            tbx_diachi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbx_diachi.Location = new Point(906, 375);
            tbx_diachi.Margin = new Padding(2);
            tbx_diachi.Name = "tbx_diachi";
            tbx_diachi.Size = new Size(178, 23);
            tbx_diachi.TabIndex = 8;
            // 
            // tbx_sdt
            // 
            tbx_sdt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbx_sdt.Location = new Point(906, 282);
            tbx_sdt.Margin = new Padding(2);
            tbx_sdt.Name = "tbx_sdt";
            tbx_sdt.Size = new Size(178, 23);
            tbx_sdt.TabIndex = 6;
            // 
            // tbx_Ten
            // 
            tbx_Ten.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbx_Ten.Location = new Point(906, 195);
            tbx_Ten.Margin = new Padding(2);
            tbx_Ten.Name = "tbx_Ten";
            tbx_Ten.Size = new Size(178, 23);
            tbx_Ten.TabIndex = 4;
            // 
            // tbx_ID
            // 
            tbx_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbx_ID.Location = new Point(906, 155);
            tbx_ID.Margin = new Padding(2);
            tbx_ID.Name = "tbx_ID";
            tbx_ID.Size = new Size(178, 23);
            tbx_ID.TabIndex = 3;
            // 
            // btn_them
            // 
            btn_them.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_them.Location = new Point(752, 500);
            btn_them.Margin = new Padding(2);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(100, 28);
            btn_them.TabIndex = 10;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_sua
            // 
            btn_sua.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_sua.Location = new Point(984, 500);
            btn_sua.Margin = new Padding(2);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(100, 28);
            btn_sua.TabIndex = 11;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_xoa.Location = new Point(752, 549);
            btn_xoa.Margin = new Padding(2);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(100, 28);
            btn_xoa.TabIndex = 12;
            btn_xoa.Text = "Xoá";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(729, 336);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 17);
            label5.TabIndex = 7;
            label5.Text = "Giới Tính :";
            // 
            // tbx_CMND
            // 
            tbx_CMND.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbx_CMND.Location = new Point(906, 242);
            tbx_CMND.Margin = new Padding(2);
            tbx_CMND.Name = "tbx_CMND";
            tbx_CMND.Size = new Size(178, 23);
            tbx_CMND.TabIndex = 5;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(729, 242);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(56, 17);
            label7.TabIndex = 9;
            label7.Text = "CMND :";
            // 
            // btn_reset
            // 
            btn_reset.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_reset.Location = new Point(984, 549);
            btn_reset.Margin = new Padding(2);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(100, 28);
            btn_reset.TabIndex = 13;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // cb_gender
            // 
            cb_gender.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cb_gender.FormattingEnabled = true;
            cb_gender.Items.AddRange(new object[] { "Nam", "Nữ" });
            cb_gender.Location = new Point(906, 329);
            cb_gender.Name = "cb_gender";
            cb_gender.Size = new Size(178, 24);
            cb_gender.TabIndex = 14;
            cb_gender.Text = "Chọn giới tính";
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 613);
            Controls.Add(cb_gender);
            Controls.Add(btn_reset);
            Controls.Add(btn_xoa);
            Controls.Add(btn_sua);
            Controls.Add(btn_them);
            Controls.Add(tbx_ID);
            Controls.Add(tbx_Ten);
            Controls.Add(tbx_CMND);
            Controls.Add(tbx_sdt);
            Controls.Add(tbx_diachi);
            Controls.Add(tbx_thuexe);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_tim);
            Controls.Add(tbx_Tim);
            Controls.Add(dgv_customer);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "CustomerForm";
            Text = "Khách hàng";
            Load += Customer_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_customer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgv_customer;
        private TextBox tbx_Tim;
        private Button btn_tim;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label8;
        private TextBox tbx_thuexe;
        private TextBox tbx_diachi;
        private TextBox tbx_sdt;
        private TextBox tbx_Ten;
        private TextBox tbx_ID;
        private Button btn_them;
        private Button btn_sua;
        private Button btn_xoa;
        private Label label5;
        private TextBox tbx_CMND;
        private Label label7;
        private Button btn_reset;
        private ComboBox cb_gender;
    }
}