using DAL;
using System.ComponentModel;
using QuanlyOto.Common;
using DTO.Response;
using DTO.Entity;
using System.Collections.Generic;

namespace QuanlyOto
{
    public partial class AdminForm : Form
    {
        private readonly BookingsAccess _bookingsAccess;
        private readonly ActionAccess _actionAccess;
        private readonly CarAccess _carAccess;
        private readonly SchedulesAccess _scheduleAccess;
        private BindingList<Car> car;
        private BindingList<ScheduleResponse> schedules;
        private List<BookingResponse> listBookings;
        private DataGridViewRow rowSelected = null;
        //tổng doanh thu
        double totalRevenue = 0;
        double numberOfRentals = 0;
        double newAmount = 0;
        public AdminForm(BookingsAccess bookingsAccess, ActionAccess actionAccess, CarAccess carAccess, SchedulesAccess scheduleAccess)
        {
            InitializeComponent();
            listBookings = new List<BookingResponse>();
            _bookingsAccess = bookingsAccess;
            _actionAccess = actionAccess;
            _carAccess = carAccess;
            _scheduleAccess = scheduleAccess;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            statistic_Click(sender, e);

        }

        private void btn_thongKe_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = folderDialog.SelectedPath;
                    string fileName = $"{DateTime.Now.ToString("yyyy_MM_dd")}.xlsx";
                    string filePath = Path.Combine(folderPath, fileName);

                    bool isExport = _actionAccess.ExportToExcel(filePath, listBookings, totalRevenue, numberOfRentals);
                    if (isExport)
                        MessageBox.Show("Xuất báo cáo thành công.");
                }
            }
        }

        private void tc_admin_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tc_admin.SelectedIndex)
            {
                case 0:
                    // tab thống kê, doanh thua
                    statistic_Click(sender, e);
                    break;
                case 1:
                    // quản lý ô tô
                    carManagement_Click(sender, e);
                    break;
                case 2:
                    scheduleManagement_Click(sender, e);
                    break;
            }
        }

        async void statistic_Click(object sender, EventArgs e)
        {
            totalRevenue = 0;
            var bookings = await _bookingsAccess.getBookings();
            listBookings = bookings;
            foreach (var booking in bookings)
            {
                totalRevenue += booking.TotalCosts;
            }
            lb_totalRevenue.Text = Commons.formatStringVietNammes(totalRevenue);
            numberOfRentals = bookings.Count;
            lb_numberOfRentals.Text = numberOfRentals.ToString();
            dgw_DoanhThu.DataSource = bookings;
        }

        async void carManagement_Click(object sender, EventArgs e)
        {
            var list = await _carAccess.getAllCar();
            car = new BindingList<Car>(list);
            dgw_carManagement.DataSource = list;
            dgw_carManagement.Refresh();

        }

        async void scheduleManagement_Click(object sender, EventArgs e)
        {
            var scheduleList = await _scheduleAccess.GetSchedules();
            schedules = new BindingList<ScheduleResponse>(scheduleList);
            dgw_Schedule.DataSource = scheduleList;
            dgw_Schedule.Refresh();
        }

        private void btn_chart_Click(object sender, EventArgs e)
        {
            ChartForm chartForm = new ChartForm(_bookingsAccess, listBookings);
            chartForm.Show();
        }

        private void dgw_carManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                rowSelected = dgw_carManagement.Rows[e.RowIndex];

                tbx_ID.Text = rowSelected.Cells["CarId"].Value.ToString();
                tbx_nameCar.Text = rowSelected.Cells["CarName"].Value.ToString();
                tbx_typeCar.Text = rowSelected.Cells["CarType"].Value.ToString();
                tbx_brand.Text = rowSelected.Cells["Brand"].Value.ToString();
                tbx_statuts.Text = rowSelected.Cells["Status"].Value.ToString();
                tbx_price.Text = rowSelected.Cells["RentalFee"].Value.ToString();
            }
        }

        //thêm xe
        private async void btn_addCar_Click(object sender, EventArgs e)
        {
            DialogResult res = Commons.ConfirmAdd();
            if (res == DialogResult.OK)
            {
                string nameCar = tbx_nameCar.Text;
                string typeCar = tbx_typeCar.Text;
                string brand = tbx_brand.Text;
                string status = tbx_statuts.Text;
                string price = tbx_price.Text;
                if (string.IsNullOrEmpty(nameCar) || string.IsNullOrEmpty(typeCar) || string.IsNullOrEmpty(brand)
                    || string.IsNullOrEmpty(status) || string.IsNullOrEmpty(price))
                {
                    MessageBox.Show("Nhập đủ thông tin xe để thêm.");
                    return;
                }

                var c = await _carAccess.AddCar(nameCar, typeCar, brand, status, double.Parse(price));
                if (car != null)
                {
                    MessageBox.Show("Thêm thành công");
                    car.Add(c);
                    dgw_carManagement.DataSource = null;
                    dgw_carManagement.Rows.Clear();
                    dgw_carManagement.DataSource = car;
                    cleanData();



                }
            }
        }

        private void cleanData()
        {
            tbx_ID.Text = "";
            tbx_nameCar.Text = "";
            tbx_typeCar.Text = "";
            tbx_brand.Text = "";
            tbx_statuts.Text = "";
            tbx_price.Text = "";
            dgw_carManagement.Refresh();
        }

        private async void btn_deleteCar_Click(object sender, EventArgs e)
        {
            DialogResult res = Commons.ConfirmDelete();
            if (res == DialogResult.OK)
            {
                if (rowSelected != null)
                {
                    Guid id = new Guid(rowSelected.Cells["CarId"].Value.ToString());
                    // Delete the customer using your async method
                    bool isDeleted = await _carAccess.DeleteCar(id);

                    if (isDeleted)
                    {
                        MessageBox.Show("Xoá thành công");
                        Car carToDelete = (Car)rowSelected.DataBoundItem;
                        // Remove the customer from the BindingList
                        car.Remove(carToDelete);
                        dgw_carManagement.DataSource = null;
                        dgw_carManagement.DataSource = car;
                        cleanData();
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

        private async void btn_editCar_Click(object sender, EventArgs e)
        {
            DialogResult res = Commons.ConfirmUpdate();
            if (res == DialogResult.OK)
            {
                Guid id = new Guid(tbx_ID.Text);
                string nameCar = tbx_nameCar.Text;
                string typeCar = tbx_typeCar.Text;
                string brand = tbx_brand.Text;
                string status = tbx_statuts.Text;
                string price = tbx_price.Text;
                if (id == null || string.IsNullOrEmpty(nameCar) || string.IsNullOrEmpty(typeCar) || string.IsNullOrEmpty(brand)
                    || string.IsNullOrEmpty(status) || string.IsNullOrEmpty(price))
                {
                    MessageBox.Show("Nhập đủ thông tin xe để cập nhật.");
                    return;
                }

                Car c = new Car
                {
                    CarId = id,
                    CarName = nameCar,
                    CarType = typeCar,
                    Brand = brand,
                    Status = status,
                    RentalFee = double.Parse(price),
                };
                var isUpdated = await _carAccess.UpdateCar(c);

                if (!isUpdated)
                {
                    MessageBox.Show("Vui lòng thử lại.");
                    return;
                }
                MessageBox.Show("Sửa thành công");
                Car carToDelete = (Car)rowSelected.DataBoundItem;
                carToDelete.CarName = c.CarName;
                carToDelete.CarType = c.CarType;
                carToDelete.Brand = brand;
                carToDelete.Status = status;
                carToDelete.RentalFee = c.RentalFee;
                cleanData();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            cleanData();
        }

        private async void tb_search_TextChanged(object sender, EventArgs e)
        {
            string keywords = tb_search.Text ?? "";
            var cars = await _carAccess.getAllCar(keywords);
            dgw_carManagement.DataSource = null;
            dgw_carManagement.Rows.Clear();
            dgw_carManagement.Refresh();
            dgw_carManagement.DataSource = cars;
        }

        private void dgw_Schedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                rowSelected = dgw_Schedule.Rows[e.RowIndex];
            }
        }

        private async void btn_deleteSchedule_Click(object sender, EventArgs e)
        {
            DialogResult res = Commons.ConfirmDelete();
            if (res == DialogResult.OK)
            {
                if (rowSelected != null)
                {
                    Guid id = new Guid(rowSelected.Cells["ScheduleId"].Value.ToString());
                    // Delete the customer using your async method
                    bool isDeleted = await _scheduleAccess.DeleteSchedule(id);

                    if (isDeleted)
                    {
                        ScheduleResponse scheduleToDelete = (ScheduleResponse)rowSelected.DataBoundItem;
                        // Remove the customer from the BindingList
                        schedules.Remove(scheduleToDelete);
                        dgw_Schedule.DataSource = null;
                        dgw_Schedule.DataSource = schedules;
                        dgw_Schedule.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xoá khách hàng này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hàng để xoá.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btn_successSchedule_Click(object sender, EventArgs e)
        {
            DialogResult result = Commons.ConfirmSuccess();
            if (result == DialogResult.OK)
            {
                if (rowSelected != null)
                {
                    Guid id = new Guid(rowSelected.Cells["ScheduleId"].Value.ToString());
                    string status = rowSelected.Cells["Status"].Value.ToString();
                    string carName = rowSelected.Cells["carName"].Value.ToString();
                    DateTime toDate = DateTime.Parse(rowSelected.Cells["ToDate"].Value.ToString());
                    if (status == "Hoàn thành")
                    {
                        MessageBox.Show("Đơn hàng đã hoàn tất, không thể hoàn tất lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //update status car
                    var car = await _carAccess.getCarByName(carName);
                    int returnDate = (int)(DateTime.Now.Date - toDate.Date).TotalDays;
                    if(returnDate > 0)
                    {
                        newAmount = car.RentalFee * 1.5 * returnDate;  //số tiền chênh lệch nếu trả xe muộn
                        DialogResult r = Commons.ConfirmAdditionalPayment(newAmount);
                        if (r != DialogResult.OK) {
                            return;
                        }
                    }
                    var isUpdateCar = await _carAccess.UpdateCar(new Car { CarId = car.CarId, Status = "Available" });
                    var schedule = await _scheduleAccess.UpdateSchedule(id, "Hoàn thành");
                    var isUpdateBooking = await _bookingsAccess.UpdateStatusBooking(schedule.BookingId, newAmount, "Hoàn thành");
                    if (isUpdateBooking && isUpdateCar)
                    {
                        MessageBox.Show("Đơn hàng đã hoàn tất");
                        ScheduleResponse scheduleToUpdate = (ScheduleResponse)rowSelected.DataBoundItem;
                        scheduleToUpdate.Status = "Hoàn thành";
                        scheduleToUpdate.TotalFee += newAmount;
                        dgw_Schedule.Refresh();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hàng để xác nhận.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}