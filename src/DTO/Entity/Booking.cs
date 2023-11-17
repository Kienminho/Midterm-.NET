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
        public virtual Car? Car { get; set; }

        //relationship one to many with entity Customer
        public virtual Customer? Customer { get; set; }

        public virtual Schedule? Schedule { get; set; }

    }
}
