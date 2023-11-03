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
            this.tbx_phoneNumber = new TextBox();
            this.tbx_password = new TextBox();
            this.tbx_fullName = new TextBox();
            this.tbx_newPassword = new TextBox();
            this.tbx_confrimPassword = new TextBox();
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
            label1.Location = new Point(305, 11);
            label1.Name = "label1";
            label1.Size = new Size(114, 39);
            label1.TabIndex = 0;
            label1.Text = "Profile";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 86);
            label2.Name = "label2";
            label2.Size = new Size(161, 29);
            label2.TabIndex = 1;
            label2.Text = "Số điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 169);
            label3.Name = "label3";
            label3.Size = new Size(121, 29);
            label3.TabIndex = 2;
            label3.Text = "Họ và tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(31, 252);
            label4.Name = "label4";
            label4.Size = new Size(121, 29);
            label4.TabIndex = 3;
            label4.Text = "Mật Khẩu";
            // 
            // tbx_phoneNumber
            // 
            this.tbx_phoneNumber.Location = new Point(344, 96);
            this.tbx_phoneNumber.Margin = new Padding(3, 4, 3, 4);
            this.tbx_phoneNumber.Multiline = true;
            this.tbx_phoneNumber.Name = "tbx_phoneNumber";
            this.tbx_phoneNumber.Size = new Size(358, 42);
            this.tbx_phoneNumber.TabIndex = 0;
            // 
            // tbx_password
            // 
            this.tbx_password.Location = new Point(344, 246);
            this.tbx_password.Margin = new Padding(3, 4, 3, 4);
            this.tbx_password.Multiline = true;
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new Size(358, 42);
            this.tbx_password.TabIndex = 2;
            // 
            // tbx_fullName
            // 
            this.tbx_fullName.Location = new Point(344, 162);
            this.tbx_fullName.Margin = new Padding(3, 4, 3, 4);
            this.tbx_fullName.Multiline = true;
            this.tbx_fullName.Name = "tbx_fullName";
            this.tbx_fullName.Size = new Size(358, 42);
            this.tbx_fullName.TabIndex = 1;
            // 
            // tbx_newPassword
            // 
            this.tbx_newPassword.Location = new Point(344, 325);
            this.tbx_newPassword.Margin = new Padding(3, 4, 3, 4);
            this.tbx_newPassword.Multiline = true;
            this.tbx_newPassword.Name = "tbx_newPassword";
            this.tbx_newPassword.Size = new Size(358, 42);
            this.tbx_newPassword.TabIndex = 3;
            // 
            // tbx_confrimPassword
            // 
            tbx_confrimPassword.Location = new Point(344, 408);
            tbx_confrimPassword.Margin = new Padding(3, 4, 3, 4);
            tbx_confrimPassword.Multiline = true;
            tbx_confrimPassword.Name = "tbx_confrimPassword";
            tbx_confrimPassword.Size = new Size(358, 42);
            tbx_confrimPassword.TabIndex = 4;
            // 
            // btn_capNhat
            // 
            btn_capNhat.Location = new Point(312, 472);
            btn_capNhat.Margin = new Padding(3, 4, 3, 4);
            btn_capNhat.Name = "btn_capNhat";
            btn_capNhat.Size = new Size(158, 58);
            btn_capNhat.TabIndex = 5;
            btn_capNhat.Text = "Cập Nhật";
            btn_capNhat.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(630, 472);
            btn_exit.Margin = new Padding(3, 4, 3, 4);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(158, 58);
            btn_exit.TabIndex = 6;
            btn_exit.Text = "Thoát";
            btn_exit.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(31, 414);
            label6.Name = "label6";
            label6.Size = new Size(229, 29);
            label6.TabIndex = 5;
            label6.Text = "Nhập Lại Mật Khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(31, 331);
            label5.Name = "label5";
            label5.Size = new Size(169, 29);
            label5.TabIndex = 4;
            label5.Text = "Mật Khẩu Mới";
            // 
            // PersonnInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 562);
            Controls.Add(btn_exit);
            Controls.Add(btn_capNhat);
            Controls.Add(tbx_confrimPassword);
            Controls.Add(this.tbx_newPassword);
            Controls.Add(this.tbx_fullName);
            Controls.Add(this.tbx_password);
            Controls.Add(this.tbx_phoneNumber);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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