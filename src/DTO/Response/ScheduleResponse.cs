using DTO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Response
{
    public class ScheduleResponse
    {
        public Guid ScheduleId { get; set; }

        //ngày bắt đầu lịch trình
        public DateTime FromDate { get; set; }
        //ngày kết thúc lịch trình
        public DateTime ToDate { get; set; }

        //relationshop many to one with car
        public string? carName { get; set; }

        //relationshop many to one with customer
        public string? customerName { get; set; }

        public string? numberPhone { get; set; }

        public string? Status { get; set; }
    }
}
