using DAL;
using DTO.Entity;
using QuanlyOto.Common;
using System.ComponentModel;


namespace QuanlyOto
{
    public partial class CustomerForm : Form
    {
        private readonly CustomerAccess _customerAccess;
        private BindingList<Customer> customers;
        private DataGridViewRow rowSelected = null;


        public CustomerForm(CustomerAccess customerAccess)
        {
            InitializeComponent();
            _customerAccess = customerAccess;


        }
        private async void Customer_Load(object sender, EventArgs e)
        {
            var list = await _customerAccess.getListCustomer();
            customers = new BindingList<Customer>(list);
            dgv_customer.DataSource = customers;

            dgv_customer.Refresh();

        }

        private async void btn_sua_Click(object sender, EventArgs e)
        {
            //dialog confim 
            DialogResult res = DialogConfirm.ConfirmUpdate();
            if (res == DialogResult.OK)
            {
                Guid id = new Guid(tbx_ID.Text);
                string name = tbx_Ten.Text;
                string numberPhone = tbx_sdt.Text;
                string address = tbx_diachi.Text;

                Customer customer = new Customer
                {
                    CustomerId = id,
                    FullName = name,
                    PhoneNumber = numberPhone,
                    Address = address,
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
            DialogResult res = DialogConfirm.ConfirmAdd();
            if (res == DialogResult.OK)
            {
                string name = tbx_Ten.Text;
                string numberPhone = tbx_sdt.Text;
                string address = tbx_diachi.Text;

                if (name.Equals("") || numberPhone.Equals("") || address.Equals(""))
                {
                    MessageBox.Show("Cần nhập đủ thông tin nhân viên.");
                    return;
                }

                var newCustomer = await _customerAccess.addCustomer(name, numberPhone, address);
                customers.Add(newCustomer);
                cleanData();
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
            DialogResult res = DialogConfirm.ConfirmDelete();
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
        private async Task LoadCustomersAsync()
        {
            // Assuming dgv_customers is the name of your DataGridView
            dgv_customer.DataSource = null;
            dgv_customer.Rows.Clear();

            // Reload data into the DataGridView
            var customers = await _customerAccess.getListCustomer(); // Replace with your method to get customers
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
        }

        
    }
}
