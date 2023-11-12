using DTO.Entity;

namespace DAL
{
    public class SchedulesAccess
    {
        private readonly DataAccess _dataAccess;
        public SchedulesAccess(DataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<bool> addSchedule(DateTime from, DateTime to, Car car, Customer c)
        {
            Guid id = Guid.NewGuid();
            Schedule schedule = new Schedule
            {
                ScheduleId = id,
                FromDate = from,
                ToDate = to,
                Car = car,
                Customer = c,
                Status = "Chưa hoàn thành"

            };
            _dataAccess.Repository<Schedule>().Add(schedule);
            var res = await _dataAccess.SaveChangesAsync();

            return res > 0;
        }
    }
}
