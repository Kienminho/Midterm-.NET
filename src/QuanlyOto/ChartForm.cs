using DAL;
using DTO.Entity;
using DTO.Response;
using OxyPlot;
using OxyPlot.Annotations;
using OxyPlot.Axes;
using OxyPlot.Series;
using System.Globalization;

namespace QuanlyOto
{
    public partial class ChartForm : Form
    {
        private readonly BookingsAccess _bookingsAccess;
        private readonly List<BookingResponse> _bookings;

        public ChartForm(BookingsAccess bookingsAccess, List<BookingResponse> bookings)
        {
            InitializeComponent();
            _bookingsAccess = bookingsAccess;
            _bookings = bookings;
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            plotView_SalesByMonth.Model = CreateSalesByDayOfMonthModel();
            plotViewCarsSoldByType.Model = CreateSalesByCarTypeModel();
        }

        PlotModel CreateSalesByDayOfMonthModel()

        {
            var model = new PlotModel
            {
                Title = $"Doanh thu từng ngày trong tháng {DateTime.Now.Month}",
            };

            var dateAxis = new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Day of the Month",
                LabelField = "DateLabel"
            };

            var valueAxis = new LinearAxis { Position = AxisPosition.Left, Title = "Total Sales" };

            model.Axes.Add(dateAxis);
            model.Axes.Add(valueAxis);

            var salesByDayOfMonthSeries = new LineSeries { Title = $"Total Sales by Day - {DateTime.Now:MMM yyyy}" };

            var salesByDayOfMonth = _bookings
                .GroupBy(b => b.FromDate.Day)
                .OrderBy(group => group.Key)
                .Select(group => new
                {
                    DateLabel = group.Key.ToString(),
                    TotalSales = group.Sum(sale => sale.TotalCosts)
                });


            foreach (var salesData in salesByDayOfMonth)
            {
                salesByDayOfMonthSeries.Points.Add(new DataPoint(double.Parse(salesData.DateLabel) - 1, salesData.TotalSales));
            }

            for (int i = 1; i <= DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month); i++)
            {
                dateAxis.Labels.Add(i.ToString());
            }

            model.Series.Add(salesByDayOfMonthSeries);

            return model;
        }

        PlotModel CreateSalesByCarTypeModel()
        {
            var model = new PlotModel { Title = "Sales by Car Type" };

            var categoryAxis = new CategoryAxis { Position = AxisPosition.Bottom, Title = "Car Type" };
            var valueAxis = new LinearAxis { Position = AxisPosition.Left, Title = "Sales Quantity" };

            model.Axes.Add(categoryAxis);
            model.Axes.Add(valueAxis);

            var salesByCarTypeSeries = new LineSeries { MarkerType = MarkerType.Circle, MarkerSize = 4, MarkerStroke = OxyColors.Black };
            
            var groupedBookings = _bookings
                    .GroupBy(b => b.Brand)
                    .OrderBy(group => group.Key)
                    .Select(group => new
                    {
                        CarType = group.Key,
                        TotalSalesQuantity = group.Count()
                    });
            int index = 1;

            foreach (var booking in groupedBookings)
            {
                categoryAxis.Labels.Add($"{index}-{booking.CarType}");
                salesByCarTypeSeries.Points.Add(new DataPoint(index-1, booking.TotalSalesQuantity));

                index++;
            }

            model.Series.Add(salesByCarTypeSeries);

            return model;
        }
    }
}
