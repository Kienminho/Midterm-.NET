using DAL;
using DTO.Entity;
using OxyPlot;
using QuanlyOto.Common;
using System.ComponentModel;

namespace QuanlyOto
{
    public partial class HomeForm : Form
    {
        private readonly CustomerAccess _customerAccess;
        private readonly AccountAccess _accountAccess;
        private readonly ActionAccess _actionAccess;
        private readonly CarAccess _carAccess;
        private readonly BookingsAccess _bookingsAccess;
        private readonly SchedulesAccess _scheduleAccess;
        private List<String> nameCustomers = new List<String>();
        private Guid idCar;
        private int moneyOptions = 0;
        private int moneyEnergy = 0;
        private int totalMoneyOptions = 0;
        private double moneyEachDay = 0;
        private double totalPrice = 0;
        private int numberOfDays = 1;

        public HomeForm(CustomerAccess customerAccess, AccountAccess accountAccess, ActionAccess actionAccess,
            CarAccess carAccess, BookingsAccess bookingsAccess, SchedulesAccess scheduleAccess)
        {
            InitializeComponent();
            _customerAccess = customerAccess;
            _accountAccess = accountAccess;
            _actionAccess = actionAccess;
            _carAccess = carAccess;
            _bookingsAccess = bookingsAccess;
            dtp_from.Value = DateTime.Now;
            _scheduleAccess = scheduleAccess;
        }
        private async void HomeForm_Load(object sender, EventArgs e)
        {
            GetCustomers();
            displayUI();
            List<Car> list = await _carAccess.getAllCar();
            displayCarItem(list);
        }

        private void mnu_QuanLyBanHang_Click(object sender, EventArgs e)
        {
            CustomerForm khachHang = new CustomerForm(_customerAccess, _actionAccess);
            khachHang.Show();
        }

        private void mnu_TTCN_Click(object sender, EventArgs e)
        {
            PersonnInfoForm thongTinCaNhan = new PersonnInfoForm();
            thongTinCaNhan.Show();
        }

        private void mnu_Admin_Click(object sender, EventArgs e)
        {
            AdminForm admin = new AdminForm(_bookingsAccess, _actionAccess);
            admin.Show();
        }

        private void mnu_logOut_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm form = new MainForm(_accountAccess, _customerAccess, _actionAccess, _carAccess, _bookingsAccess, _scheduleAccess);
            form.Show();
        }

        private async void mnu_Import_Click(object sender, EventArgs e)
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

                var cars = await _actionAccess.ReadExcel(filePath);
                MessageBox.Show("Import thành công.");
                fl_displayCar.Controls.Clear();
                displayCarItem(cars);
            }
        }

        void displayCarItem(List<Car> list)
        {
            uControl_carItems[] carItems = new uControl_carItems[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                carItems[i] = new uControl_carItems();
                carItems[i].id = list[i].CarId;
                carItems[i].nameCar = list[i].CarName;
                carItems[i].brandCar = list[i].Brand;
                carItems[i].price = list[i].RentalFee;
                carItems[i].Click += new System.EventHandler(this.selectCar);
                fl_displayCar.Controls.Add(carItems[i]);
            }
        }

        //display UI by account type
        async void displayUI()
        {
            //lấy danh sách khách hàng
            

            cbb_customer.DataSource = nameCustomers;
            /*if (!GlobalVariables.AccountTypes)
            {
                mnu_Admin.Enabled = false;
                mnu_Import.Enabled = false;
            }
            else
                mnu_TTCN.Enabled = false;*/
        }

        void selectCar(object sender, EventArgs e)
        {
            uControl_carItems carItem = (uControl_carItems)sender;
            idCar = carItem.id;
            lb_typeCar.Text = carItem.brandCar.ToString();
            moneyEachDay = carItem.price;
            totalPrice = moneyEachDay;
            lb_priceEachDay.Text = Commons.formatStringVietNammes(carItem.price);
            lb_totalPrice.Text = Commons.formatStringVietNammes(moneyEachDay);
        }

        void checkRadio(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = sender as RadioButton;
            totalMoneyOptions -= moneyEnergy;
            if (selectedRadioButton != null && selectedRadioButton.Checked)
            {
                // Reset moneyOptions to zero before assigning new value

                if (selectedRadioButton.Text.Equals("Xăng"))
                    moneyEnergy = 100000;
                else if (selectedRadioButton.Text.Equals("Dầu"))
                    moneyEnergy = 200000;
                else
                    moneyEnergy = 300000;
            }

            totalMoneyOptions += moneyEnergy; // Recalculate totalMoneyOptions
            lb_moneyOptions.Text = Commons.formatStringVietNammes(totalMoneyOptions);
            totalPrice = (moneyEachDay * numberOfDays) + totalMoneyOptions;
            lb_totalPrice.Text = Commons.formatStringVietNammes(totalPrice);

        }

        void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox selectedCheckBox = sender as CheckBox;

            if (selectedCheckBox != null)
            {
                if (selectedCheckBox.Checked)
                {
                    // Checkbox is checked, add moneyOptions
                    moneyOptions += 100000;
                }
                else
                {
                    // Checkbox is unchecked, subtract moneyOptions
                    moneyOptions -= 100000;
                }
            }

            totalMoneyOptions = moneyOptions + moneyEnergy; // Recalculate totalMoneyOptions
            lb_moneyOptions.Text = Commons.formatStringVietNammes(totalMoneyOptions);
            totalPrice = (moneyEachDay * numberOfDays) + totalMoneyOptions;
            lb_totalPrice.Text = Commons.formatStringVietNammes(totalPrice);

        }

        private void dtp_to_ValueChanged(object sender, EventArgs e)
        {
            // Calculate the number of days between fromDay and toDay
            TimeSpan duration = dtp_to.Value - dtp_from.Value;
            // Display the result
            numberOfDays = (int)duration.TotalDays <= 0 ? 1 : (int)duration.TotalDays;
            if (numberOfDays <= 0)
            {
                MessageBox.Show("Thời gian thuê phải từ một ngày trở lên, vui lòng chọn lại!");
                return;
            }
            lb_totalDay.Text = numberOfDays.ToString();
            totalPrice = (moneyEachDay * numberOfDays) + totalMoneyOptions;
            lb_totalPrice.Text = Commons.formatStringVietNammes(totalPrice);

        }

        private async void btn_datXe_Click(object sender, EventArgs e)
        {
            string nameCustomer = cbb_customer.SelectedValue?.ToString();
            //check
            if (nameCustomer.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn khách hàng, nếu không có hãy tạo khách hàng mới.");
                return;
            }

            // logic here
            Customer c = await _customerAccess.getCustomerByName(nameCustomer);
            Car car = await _carAccess.getCar(idCar);
            var isBooking = await _bookingsAccess.addBooking(dtp_from.Value, dtp_to.Value, totalPrice, car, c);
            var isSchedules = await _scheduleAccess.addSchedule(dtp_from.Value, dtp_to.Value, car, c);
            if (isBooking && isSchedules)
            {
                MessageBox.Show("Đặt xe thành công.");
                btn_reset_Click(sender, e);
            }

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            cbb_customer.SelectedIndex = 0;
            dtp_to.Value = DateTime.Now;
            lb_moneyOptions.Text = "0 đ";
            lb_priceEachDay.Text = "0 đ";
            lb_totalPrice.Text = "0 đ";
            lb_totalDay.Text = "0";
            lb_typeCar.Text = " ";

            nameCustomers.Clear();
            cbb_customer.DataSource = null;
            cbb_customer.Items.Clear();

            GetCustomers();
            cbb_customer.DataSource = nameCustomers;
            ResetRadioAndCheckBoxControls(this);
        }

        //reset radio and checkbox
        private void ResetRadioAndCheckBoxControls(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
                else if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }

                // Recursively reset controls in containers (Panel, GroupBox, etc.)
                if (control.HasChildren)
                {
                    ResetRadioAndCheckBoxControls(control);
                }
            }
        }


        //lấy danh sách khách hàng
        void GetCustomers()
        {
            Task.Run(async () =>
            {
                var list = await _customerAccess.GetCustomers();
                nameCustomers.Add("");
                foreach (var item in list)
                {
                    nameCustomers.Add(item.FullName);
                }
            }).Wait();
        }
    }
}
