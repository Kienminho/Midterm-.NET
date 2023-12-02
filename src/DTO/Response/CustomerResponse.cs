using DTO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Response
{
    public class CustomerResponse : Customer
    {
        public Guid CustomerId { get; set; }
        public string? FullName { get; set; }
        public string? Address { get; set; }

        public string? CCCD { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Gender { get; set; }
    }
}
