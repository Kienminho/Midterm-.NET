using DTO.Entity;
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


        public Task<bool> ReadExcel(string filePath)
        {
            List<Car> cars = new List<Car>();

            FileInfo fileInfo = new FileInfo(filePath);

            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
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

                    var res = _dataAccess.Repository<Car>().Add(car);
                    cars.Add(car);
                }
            }

            return true;
        }
    }
}
