namespace QuanlyOto
{
    partial class PersonnInfoForm
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
            label3 = new Label();
            label4 = new Label();
            tbx_phoneNumber = new TextBox();
            tbx_password = new TextBox();
            tbx_fullName = new TextBox();
            tbx_newPassword = new TextBox();
            tbx_confrimPassword = new TextBox();
            btn_capNhat = new Button();
            btn_exit = new Button();
            label6 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(267, 8);
            label1.Name = "label1";
            label1.Size = new Size(91, 31);
            label1.TabIndex = 0;
            label1.Text = "Profile";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 64);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 1;
            label2.Text = "Số điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(27, 127);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 2;
            label3.Text = "Họ và tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(27, 189);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 3;
            label4.Text = "Mật Khẩu";
            // 
            // tbx_phoneNumber
            // 
            tbx_phoneNumber.Location = new Point(301, 72);
            tbx_phoneNumber.Multiline = true;
            tbx_phoneNumber.Name = "tbx_phoneNumber";
            tbx_phoneNumber.Size = new Size(314, 32);
            tbx_phoneNumber.TabIndex = 0;
            // 
            // tbx_password
            // 
            tbx_password.Location = new Point(301, 184);
            tbx_password.Multiline = true;
            tbx_password.Name = "tbx_password";
            tbx_password.Size = new Size(314, 32);
            tbx_password.TabIndex = 2;
            // 
            // tbx_fullName
            // 
            tbx_fullName.Location = new Point(301, 122);
            tbx_fullName.Multiline = true;
            tbx_fullName.Name = "tbx_fullName";
            tbx_fullName.Size = new Size(314, 32);
            tbx_fullName.TabIndex = 1;
            // 
            // tbx_newPassword
            // 
            tbx_newPassword.Location = new Point(301, 244);
            tbx_newPassword.Multiline = true;
            tbx_newPassword.Name = "tbx_newPassword";
            tbx_newPassword.Size = new Size(314, 32);
            tbx_newPassword.TabIndex = 3;
            // 
            // tbx_confrimPassword
            // 
            tbx_confrimPassword.Location = new Point(301, 306);
            tbx_confrimPassword.Multiline = true;
            tbx_confrimPassword.Name = "tbx_confrimPassword";
            tbx_confrimPassword.Size = new Size(314, 32);
            tbx_confrimPassword.TabIndex = 4;
            // 
            // btn_capNhat
            // 
            btn_capNhat.Location = new Point(273, 354);
            btn_capNhat.Name = "btn_capNhat";
            btn_capNhat.Size = new Size(138, 44);
            btn_capNhat.TabIndex = 5;
            btn_capNhat.Text = "Cập Nhật";
            btn_capNhat.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(551, 354);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(138, 44);
            btn_exit.TabIndex = 6;
            btn_exit.Text = "Thoát";
            btn_exit.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(27, 310);
            label6.Name = "label6";
            label6.Size = new Size(180, 25);
            label6.TabIndex = 5;
            label6.Text = "Nhập Lại Mật Khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(27, 248);
            label5.Name = "label5";
            label5.Size = new Size(134, 25);
            label5.TabIndex = 4;
            label5.Text = "Mật Khẩu Mới";
            // 
            // PersonnInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(700, 422);
            Controls.Add(btn_exit);
            Controls.Add(btn_capNhat);
            Controls.Add(tbx_confrimPassword);
            Controls.Add(tbx_newPassword);
            Controls.Add(tbx_fullName);
            Controls.Add(tbx_password);
            Controls.Add(tbx_phoneNumber);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PersonnInfoForm";
            Text = "ThongTinCaNhan";
            Load += PersonnInfoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbx_phoneNumber;
        private TextBox tbx_password;
        private TextBox tbx_fullName;
        private TextBox tbx_newPassword;
        private TextBox tbx_confrimPassword;
        private Button btn_capNhat;
        private Button btn_exit;
        private Label label6;
        private Label label5;
    }
}