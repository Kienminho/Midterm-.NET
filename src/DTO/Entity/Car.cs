using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Entity
{
    public class Car
    {
        public Guid CarId { get; set; }
        public string CarName { get; set; }
        public string CarType { get; set; }
        public string Brand { get; set; }
        public string Status { get; set; }

        //phí thuê xe
        public double RentalFee { get; set; }

        //relationship one to many with entity Booking
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
