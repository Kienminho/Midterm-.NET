using DTO.Entity;
using DTO.Response;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class SchedulesAccess
    {
        private readonly DataAccess _dataAccess;
        
        public SchedulesAccess(DataAccess dataAccess)
        {
            _dataAccess = dataAccess;

        }

        public async Task<List<ScheduleResponse>> GetSchedules()
        {
            var list = from p in _dataAccess.Repository<Schedule>()
                .Include(c => c.Car)
                .Include(c => c.Customer)
                       select new ScheduleResponse
                       {
                           ScheduleId = p.ScheduleId,
                           FromDate = p.FromDate,
                           ToDate = p.ToDate,
                           carName = p.Car.CarName,
                           customerName = p.Customer.FullName,
                           numberPhone = p.Customer.PhoneNumber,
                           Status = p.Status,
                       };
            return  await list.ToListAsync();
        }

        public async Task<bool> addSchedule(DateTime from, DateTime to, Car car, Customer c, Booking b)
        {
            Guid id = Guid.NewGuid();
            Schedule schedule = new Schedule
            {
                ScheduleId = id,
                FromDate = from,
                ToDate = to,
                Car = car,
                Customer = c,
                BookingId = b.BookingId,
                Status = "Đang cho thuê"

            };
            _dataAccess.Repository<Schedule>().Add(schedule);
            var res = await _dataAccess.SaveChangesAsync();

            return res > 0;
        }

        public async Task<bool> DeleteSchedule(Guid id)
        {
            var schedule = _dataAccess.Repository<Schedule>().FirstOrDefault(s => s.ScheduleId == id);
            if (schedule == null) throw new Exception("Not found Schedule");
            _dataAccess.Repository<Schedule>().Remove(schedule);
            var res = await _dataAccess.SaveChangesAsync();
            return res > 0;
        }

        public async Task<bool> UpdateSchedule(Guid id, string status, string carName)
        {
            var schedule = _dataAccess.Repository<Schedule>().FirstOrDefault(s => s.ScheduleId == id);
            if (schedule == null) throw new Exception("Not found Schedule");
            schedule.Status = status;
            var res = await _dataAccess.SaveChangesAsync();
            return res > 0;
        }
    }
}
