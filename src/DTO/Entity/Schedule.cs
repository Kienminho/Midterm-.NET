using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Entity
{
    public class Schedule
    {
        public Guid ScheduleId { get; set; }

        //ngày bắt đầu lịch trình
        public DateTime FromDate { get; set; }
        //ngày kết thúc lịch trình
        public DateTime ToDate { get; set; }

        //relationshop many to one with car
        public int CarId { get; set; }
        public virtual Car Car { get; set; }

        //relationshop many to one with customer
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
