using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Entity
{
    public class Account
    {
        public Guid Id { get; set; }
        public string PhoneNumber { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }

        public string gender { get; set; }
        public string address { get; set; }

        public virtual ICollection<Role> Roles { get; set; }

    }
}
