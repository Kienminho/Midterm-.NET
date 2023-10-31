using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Entity
{
    public class Booking
    {
        public Guid BookingId { get; set; }

        //ngày bắt đầu thuê xe  
        public DateTime FromDate { get; set; }

        //Ngày trả xe
        public DateTime ToDate { get; set; }

        //tổng phí thuê xe
        public double TotalCosts { get; set; }

        //trạng thái đơn hàng
        public String Status { get; set; }

        //relationship one to many with entity Car
        public int CardId { get; set; }
        public virtual Car Car { get; set; }

        //relationship one to many with entity Customer
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }




    }
}
