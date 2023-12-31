﻿using DTO.Entity;
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
                            CreatedDate = c.CreatedDate,
                            Status = c.Status
                        })
                        .OrderBy(c => c.CreatedDate.Date)
                        .ThenBy(c => c.CreatedDate.TimeOfDay)
                        .ToListAsync();
            return query;
        }

        public async Task<Booking> addBooking(DateTime from, DateTime to, double totalPrice, Car car, Customer c)
        {
            Guid id = Guid.NewGuid();
            Booking booking = new Booking
            {
                BookingId = id,
                FromDate = from,
                ToDate = to,
                TotalCosts = totalPrice,
                Status = "Đang cho thuê",
                Car = car,
                CreatedDate = DateTime.Now,
                Customer = c
            };
            _dataAccess.Repository<Booking>().Add(booking);
            await _dataAccess.SaveChangesAsync();

            return booking;
        }

        public async Task<bool> UpdateStatusBooking(Guid id, double newMoney, string status)
        {
            var booking = _dataAccess.Repository<Booking>().FirstOrDefault(b => b.BookingId == id);
            if (booking == null) throw new Exception("Not found!");
            booking.TotalCosts += newMoney;
            booking.Status = status;
            booking.ToDate = DateTime.Now;
            var res = await _dataAccess.SaveChangesAsync();
            return res > 0;
        }
    }
}
