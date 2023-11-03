using DAL;
using DTO.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyOto
{
    public partial class HomeForm : Form
    {
        private readonly CustomerAccess customerAccess;

        public HomeForm(CustomerAccess customerAccess)
        {
            InitializeComponent();
            this.customerAccess = customerAccess;
        }
        private void HomeForm_Load(object sender, EventArgs e)
        {
            displayUI();
        }

        private void mnu_QuanLyBanHang_Click(object sender, EventArgs e)
        {
            CustomerForm khachHang = new CustomerForm(customerAccess);
            khachHang.Show();
        }

        private void mnu_TTCN_Click(object sender, EventArgs e)
        {
            PersonnInfoForm thongTinCaNhan = new PersonnInfoForm();
            thongTinCaNhan.Show();
        }

        private void mnu_Admin_Click(object sender, EventArgs e)
        {
            AdminForm admin = new AdminForm();
            admin.Show();
        }



        //display UI by account type
        void displayUI()
        {
            if (!GlobalVariables.AccountTypes)
                mnu_Admin.Enabled = false;
            else
                mnu_TTCN.Enabled = false;
        }
    }
}
