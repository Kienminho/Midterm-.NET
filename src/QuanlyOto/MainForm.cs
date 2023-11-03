﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO.Entity;

namespace QuanlyOto
{
    public partial class MainForm : Form
    {


        private readonly AccountAccess _accountAccess;
        private readonly CustomerAccess _customerAccess;
        public MainForm(AccountAccess accountAccess, CustomerAccess customerAccess)
        {
            _accountAccess = accountAccess;
            InitializeComponent();
            _customerAccess = customerAccess;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            handleLogin();
        }

        private void tbx_password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                handleLogin();
            }
        }

        async void handleLogin()
        {
            string phoneNumber = tbx_phonenumber.Text;
            string password = tbx_password.Text;
            if (phoneNumber == "" || password == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.");
                return;
            }
            int codeError = await _accountAccess.CheckLogin(phoneNumber, password);
            if (codeError == 0)
            {
                MessageBox.Show("Tài khoản không tồn tại, liên hệ với admin để được cung cấp.");
                tbx_phonenumber.Text = "";
                tbx_password.Text = "";
            }
            else if (codeError == -1)
            {
                MessageBox.Show("Mật khẩu không chính xác, vui lòng nhập lại.");
                tbx_password.Text = "";
            }
            else
            {
                HomeForm homeForm = new HomeForm(_customerAccess);
                this.Hide();
                homeForm.Show();
            }

        }
    }
}
