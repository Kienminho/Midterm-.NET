using DTO.Entity;
using DTO.Response;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class BookingsAccess
    {
        private readonly DataAccess _dataAccess;
        public BookingsAccess(DataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        //BookingResponse
        public async Task<List<BookingResponse>> getBookings()
        {
            var query = await _dataAccess.Repository<Booking>()
                        .Select(c => new BookingResponse
                        {
                            BookingId = c.BookingId,
                            FromDate = c.FromDate,
                            ToDate = c.ToDate,
                            TotalCosts = c.TotalCosts,
                            NameCar = c.Car.CarName,
                            Brand = c.Car.Brand,
                            FullName = c.Customer.FullName,
                            PhoneNumber = c.Customer.PhoneNumber,
                            Address = c.Customer.Address,
                            Status = c.Status
                        })
                        
                        .ToListAsync();
            return query;
        }

        public async Task<bool> addBooking(DateTime from, DateTime to, double totalPrice, Car car, Customer c)
        {
            Guid id = Guid.NewGuid();
            Booking booking = new Booking
            {
                BookingId = id,
                FromDate = from,
                ToDate = to,
                TotalCosts = totalPrice,
                Status = "Hoàn thành",
                Car = car,
                Customer = c
            };
            _dataAccess.Repository<Booking>().Add(booking);
            var res = await _dataAccess.SaveChangesAsync();

            return res > 0;
        }
    }
}
