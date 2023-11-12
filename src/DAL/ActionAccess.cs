using DTO.Entity;
using DTO.Response;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;

namespace DAL
{
    public class ActionAccess
    {
        private readonly DataAccess _dataAccess;
        public ActionAccess(DataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<List<Car>> ReadExcel(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);

            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Assuming data is in the first worksheet

                int rowCount = worksheet.Dimension.Rows;

                for (int row = 2; row <= rowCount; row++) // Assuming the data starts from the second row
                {
                    Car car = new Car
                    {
                        CarId = Guid.Parse(worksheet.Cells[row, 1].Value.ToString()),
                        CarName = worksheet.Cells[row, 2].Value.ToString(),
                        CarType = worksheet.Cells[row, 3].Value.ToString(),
                        Brand = worksheet.Cells[row, 4].Value.ToString(),
                        Status = worksheet.Cells[row, 5].Value.ToString(),
                        RentalFee = double.Parse(worksheet.Cells[row, 6].Value.ToString())
                    };

                    _dataAccess.Repository<Car>().Add(car);
                }
                await _dataAccess.SaveChangesAsync();
            }
            var res = await _dataAccess.Repository<Car>().ToListAsync();
            return res;
        }

        public bool ExportToExcel(string filePath, List<BookingResponse> bookingList, double totalRevenue, double numberOfRentals)
        {
            FileInfo excelFile = new FileInfo(filePath);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage(excelFile))
            {
                
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add($"{DateTime.Now.ToString("yyyy_MM_dd_hhmmss")}_BookingData");

                // Add headers and set background color
                worksheet.Cells["A1:I1"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                worksheet.Cells["A1:I1"].Style.Font.Bold = true;
                worksheet.Cells["A1:I1"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                worksheet.Cells["A1:I1"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Orange);
               

                // Add headers
                worksheet.Cells["A1"].Value = "Mã đơn đăt xe";
                worksheet.Cells["B1"].Value = "Từ ngày";
                worksheet.Cells["C1"].Value = "Đến ngày";
                worksheet.Cells["D1"].Value = "Giá đặt cọc";
                worksheet.Cells["E1"].Value = "Tên xe";
                worksheet.Cells["F1"].Value = "Khách hàng";
                worksheet.Cells["G1"].Value = "Số điện thoại";
                worksheet.Cells["H1"].Value = "Địa chỉ";
                worksheet.Cells["I1"].Value = "Trạng thái";

                worksheet.Row(1).Height = 30;
                // Add data
                int row = 2;
                foreach (var booking in bookingList)
                {
                    worksheet.Row(row).Height = 20;

                    worksheet.Cells[$"A{row}"].Value = booking.BookingId;
                    worksheet.Cells[$"B{row}"].Value = booking.FromDate.ToString("dd/MM/yyyy");
                    worksheet.Cells[$"C{row}"].Value = booking.ToDate.ToString("dd/MM/yyyy");
                    worksheet.Cells[$"D{row}"].Value = booking.TotalCosts;
                    worksheet.Cells[$"E{row}"].Value = booking.NameCar;
                    worksheet.Cells[$"F{row}"].Value = booking.FullName;
                    worksheet.Cells[$"G{row}"].Value = booking.PhoneNumber;
                    worksheet.Cells[$"H{row}"].Value = booking.Address;
                    worksheet.Cells[$"I{row}"].Value = booking.Status;

                    row++;
                }
                worksheet.Cells[$"A{row + 1}"].Value = "Tổng doanh thu";
                worksheet.Cells[$"A{row + 1}"].Style.Font.Bold = true;
                worksheet.Cells[$"C{row + 1}"].Value = totalRevenue;

                worksheet.Cells[$"A{row + 2}"].Value = "Số lượt thuê";
                worksheet.Cells[$"A{row + 2}"].Style.Font.Bold = true;
                worksheet.Cells[$"C{row + 2}"].Value = numberOfRentals;

                // AutoFit columns
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                package.Save();
            }

            return true;
        }

        public bool ExportCustomerToExcel(string filePath, List<Customer> customers)
        {
            FileInfo excelFile = new FileInfo(filePath);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage(excelFile))
            {

                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add($"{DateTime.Now.ToString("yyyy_MM_dd_hhmmss")}_CustomerData");

                // Add headers and set background color
                worksheet.Cells["A1:E1"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                worksheet.Cells["A1:E1"].Style.Font.Bold = true;
                worksheet.Cells["A1:E1"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                worksheet.Cells["A1:E1"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Orange);


                // Add headers
                worksheet.Cells["A1"].Value = "Mã khách hàng";
                worksheet.Cells["B1"].Value = "Tên đầy đủ";
                worksheet.Cells["C1"].Value = "Địa chỉ";
                worksheet.Cells["D1"].Value = "Số điện thoại";
                worksheet.Cells["E1"].Value = "Giới tính";

                worksheet.Row(1).Height = 30;
                // Add data
                int row = 2;
                foreach (var c in customers)
                {
                    worksheet.Row(row).Height = 20;

                    worksheet.Cells[$"A{row}"].Value = c.CustomerId;
                    worksheet.Cells[$"B{row}"].Value = c.FullName;
                    worksheet.Cells[$"C{row}"].Value = c.Address;
                    worksheet.Cells[$"D{row}"].Value = c.PhoneNumber;
                    worksheet.Cells[$"E{row}"].Value = c.Gender;

                    row++;
                }

                // AutoFit columns
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                package.Save();
            }

            return true;
        }
    }
}
