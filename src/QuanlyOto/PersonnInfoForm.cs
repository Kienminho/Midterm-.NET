using DAL;
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
    public partial class PersonnInfoForm : Form
    {
        public PersonnInfoForm()
        {
            InitializeComponent();
        }

        private void PersonnInfoForm_Load(object sender, EventArgs e)
        {
            tbx_phoneNumber.Text = GlobalVariables.infoAccount.PhoneNumber;
            tbx_fullName.Text = GlobalVariables.infoAccount.FullName;
            tbx_password.Text = GlobalVariables.infoAccount.Password;

        }
    }
}
