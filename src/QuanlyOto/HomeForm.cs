using DAL;
using DTO.Entity;

namespace QuanlyOto
{
    public partial class HomeForm : Form
    {
        private readonly CustomerAccess customerAccess;
        private readonly AccountAccess accountAccess;
        private readonly ActionAccess actionAccess;
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

        private void mnu_logOut_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm form = new MainForm(accountAccess, customerAccess);
            form.Show();
        }

        private void mnu_Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // Set the filter to allow only Excel files
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx|All Files|*.*";
            // Set the initial directory (optional)
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            // Show the OpenFileDialog
            DialogResult result = openFileDialog.ShowDialog();
            // Check if the user selected a file
            if (result == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                MessageBox.Show("Selected File: " + filePath);
                actionAccess.ReadExcel(filePath);
            }
        
        }

        //display UI by account type
        void displayUI()
        {
            if (!GlobalVariables.AccountTypes)
            {
                mnu_Admin.Enabled = false;
                mnu_Import.Enabled = false;
            }
            else
                mnu_TTCN.Enabled = false;
        }


    }
}
