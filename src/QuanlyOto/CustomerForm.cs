using DAL;
using DTO.Entity;
using QuanlyOto.Common;
using System.ComponentModel;


namespace QuanlyOto
{
    public partial class CustomerForm : Form
    {
        private readonly CustomerAccess _customerAccess;
        private readonly ActionAccess _actionAccess;
        private BindingList<Customer> customers;
        private DataGridViewRow rowSelected = null;


        public CustomerForm(CustomerAccess customerAccess, ActionAccess actionAccess)
        {
            InitializeComponent();
            _customerAccess = customerAccess;
            _actionAccess = actionAccess;


        }

        private async void Customer_Load(object sender, EventArgs e)
        {
            List<Customer> list = await _customerAccess.GetCustomers();
            customers = new BindingList<Customer>(list);
            dgv_customer.DataSource = customers;

            dgv_customer.Refresh();

        }

        private async void btn_sua_Click(object sender, EventArgs e)
        {
            //dialog confim 
            DialogResult res = Commons.ConfirmUpdate();
            if (res == DialogResult.OK)
            {
                Guid id = new Guid(tbx_ID.Text);
                string name = tbx_Ten.Text;
                string numberPhone = tbx_sdt.Text;
                string address = tbx_diachi.Text;
                string gender = cb_gender.GetItemText(cb_gender.SelectedItem).ToString();

                if (id.Equals("") || name.Equals("") || numberPhone.Equals("") || address.Equals("") || gender.Equals(""))
                {
                    MessageBox.Show("Cần nhập đủ thông tin nhân viên, để cập nhật.");
                    return;
                }


                Customer customer = new Customer
                {
                    CustomerId = id,
                    FullName = name,
                    Address = address,
                    PhoneNumber = numberPhone,
                    Gender = gender

                };

                bool isUpdated = await _customerAccess.updateCustomer(customer);

                if (isUpdated)
                {
                    await LoadCustomersAsync();
                    cleanData();

                }
            }

        }

        private async void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult res = Commons.ConfirmAdd();
            if (res == DialogResult.OK)
            {
                string name = tbx_Ten.Text;
                string numberPhone = tbx_sdt.Text;
                string address = tbx_diachi.Text;
                string gender = cb_gender.GetItemText(cb_gender.SelectedItem).ToString();

                if (name.Equals("") || numberPhone.Equals("") || address.Equals("") || gender.Equals(""))
                {
                    MessageBox.Show("Cần nhập đủ thông tin nhân viên.");
                    return;
                }

                var newCustomer = await _customerAccess.addCustomer(name, numberPhone, address, gender);
                customers.Add(newCustomer);
                cleanData();
                dgv_customer.DataSource = null;
                dgv_customer.Rows.Clear();
                dgv_customer.DataSource = customers;
                dgv_customer.Refresh();
            }


        }

        private void dgv_customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                rowSelected = dgv_customer.Rows[e.RowIndex];

                tbx_ID.Text = rowSelected.Cells["CustomerId"].Value.ToString();
                tbx_Ten.Text = rowSelected.Cells["FullName"].Value.ToString();
                tbx_diachi.Text = rowSelected.Cells["Address"].Value.ToString();
                tbx_sdt.Text = rowSelected.Cells["phoneNumber"].Value.ToString();

            }
        }

        // Declare a BindingList field
        private async void btn_xoa_Click(object sender, EventArgs e)
        {
            //display box confirm deleted
            //DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xoá", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            DialogResult res = Commons.ConfirmDelete();
            if (res == DialogResult.OK)
            {
                if (rowSelected != null)
                {
                    Guid id = new Guid(rowSelected.Cells["CustomerId"].Value.ToString());
                    // Delete the customer using your async method
                    bool isDeleted = await _customerAccess.deleteCustomer(id);

                    if (isDeleted)
                    {
                        Customer customerToDelete = (Customer)rowSelected.DataBoundItem;
                        // Remove the customer from the BindingList
                        customers.Remove(customerToDelete);
                        dgv_customer.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xoá khách hàng này.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hàng để xoá.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // load data gird view
        private async Task LoadCustomersAsync(string keywords = null)
        {
            var customers = new List<Customer>();
            // Reload data into the DataGridView
            if (keywords != null)
                customers = await GCustomers(keywords);
            else
                customers = await GCustomers(); // Replace with your method to get customers

            // Assuming dgv_customers is the name of your DataGridView
            dgv_customer.DataSource = null;
            dgv_customer.Rows.Clear();
            dgv_customer.DataSource = customers;
        }

        //reset data
        private void btn_reset_Click(object sender, EventArgs e)
        {
            cleanData();
        }

        //clean data
        private void cleanData()
        {
            tbx_ID.Text = "";
            tbx_Ten.Text = "";
            tbx_sdt.Text = "";
            tbx_diachi.Text = "";
            cb_gender.SelectedIndex = -1;
        }

        private async void btn_export_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = folderDialog.SelectedPath;
                    string fileName = $"KhachHang_{DateTime.Now.ToString("yyyy_MM_dd")}.xlsx";
                    string filePath = Path.Combine(folderPath, fileName);
                    var listCustomers = await _customerAccess.GetCustomers();
                    bool isExport = _actionAccess.ExportCustomerToExcel(filePath, listCustomers);
                    if (isExport)
                        MessageBox.Show("Xuất báo cáo thành công.");
                }
            }
        }

        private async Task<List<Customer>> GCustomers(string keyword = null)
        {
            List<Customer> customerList = new List<Customer>();
            if (!string.IsNullOrEmpty(keyword))
                customerList = await _customerAccess.GetCustomers(keyword);
            else
                customerList = await _customerAccess.GetCustomers();
            return customerList;
        }

        private async void tbx_search_TextChanged(object sender, EventArgs e)
        {
            string keywords = tbx_search.Text ?? "";
            await LoadCustomersAsync(keywords);
        }
    }
}
