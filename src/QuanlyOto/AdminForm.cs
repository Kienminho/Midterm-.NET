using DAL;
using System.Windows.Forms;
using QuanlyOto.Common;
using DTO.Response;


namespace QuanlyOto
{
    public partial class AdminForm : Form
    {
        private readonly BookingsAccess _bookingsAccess;
        private readonly ActionAccess _actionAccess;
        private List<BookingResponse> listBookings;
        //tổng doanh thu
        double totalRevenue = 0;
        double numberOfRentals = 0;
        public AdminForm(BookingsAccess bookingsAccess, ActionAccess actionAccess)
        {
            InitializeComponent();
            listBookings = new List<BookingResponse>();
            _bookingsAccess = bookingsAccess;
            _actionAccess = actionAccess;
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

        void carManagement_Click(object sender, EventArgs e)
        {

        }

        void scheduleManagement_Click(object sender, EventArgs e)
        {

        }

        private void btn_chart_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChartForm chartForm = new ChartForm(_bookingsAccess, listBookings);
             chartForm.Show();
        }
    }
}