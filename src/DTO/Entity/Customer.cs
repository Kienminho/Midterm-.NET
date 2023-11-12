using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Entity
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string? FullName { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Gender { get; set; }

        //relationshop one to many with entity bookings
        public virtual ICollection<Booking>? Bookings { get; set; }
        public virtual ICollection<Schedule>? Schedules { get; set; }
    }
}
