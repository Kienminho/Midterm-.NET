namespace QuanlyOto
{
    partial class MainForm
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
            label2 = new Label();
            tbx_phonenumber = new TextBox();
            tbx_password = new TextBox();
            label3 = new Label();
            btn_login = new Button();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(86, 119);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 0;
            label1.Text = "Số điện thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(86, 218);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 0;
            label2.Text = "Mật Khẩu";
            // 
            // tbx_phonenumber
            // 
            tbx_phonenumber.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_phonenumber.Location = new Point(300, 102);
            tbx_phonenumber.Multiline = true;
            tbx_phonenumber.Name = "tbx_phonenumber";
            tbx_phonenumber.Size = new Size(318, 43);
            tbx_phonenumber.TabIndex = 0;
            // 
            // tbx_password
            // 
            tbx_password.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_password.Location = new Point(300, 200);
            tbx_password.Multiline = true;
            tbx_password.Name = "tbx_password";
            tbx_password.PasswordChar = '*';
            tbx_password.Size = new Size(318, 43);
            tbx_password.TabIndex = 1;
            tbx_password.UseWaitCursor = true;
            tbx_password.KeyDown += tbx_password_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(162, 41);
            label3.Name = "label3";
            label3.Size = new Size(280, 31);
            label3.TabIndex = 0;
            label3.Text = "Quản Lý Ô Tô by Kiên";
            // 
            // btn_login
            // 
            btn_login.Location = new Point(207, 281);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(144, 49);
            btn_login.TabIndex = 2;
            btn_login.Text = "Đăng Nhập";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(519, 281);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(144, 49);
            btn_exit.TabIndex = 3;
            btn_exit.Text = "Thoát";
            btn_exit.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.hinh_nen_xe_oto_dep_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(792, 510);
            Controls.Add(btn_exit);
            Controls.Add(btn_login);
            Controls.Add(label3);
            Controls.Add(tbx_password);
            Controls.Add(tbx_phonenumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "MainForm";
            Text = "Quản Lý Ô Tô Cho Thuê";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbx_phonenumber;
        private TextBox tbx_password;
        private Label label3;
        private Button btn_login;
        private Button btn_exit;
    }
}