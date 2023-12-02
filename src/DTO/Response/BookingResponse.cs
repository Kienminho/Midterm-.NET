using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Response
{
    public class BookingResponse
    {
        public Guid BookingId { get; set; }

        //ngày bắt đầu thuê xe  
        public DateTime FromDate { get; set; }

        //Ngày trả xe
        public DateTime ToDate { get; set; }

        //tổng phí thuê xe
        public double TotalCosts { get; set; }

        public string? NameCar { get; set; }

        public string? Brand { get; set; }

        public string? FullName { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Address { get; set; }
        public DateTime CreatedDate { get; set; }

        //trạng thái đơn hàng
        public String? Status { get; set; }
    }
}
