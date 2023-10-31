using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DTO.Entity;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class AccountAccess
    {
        private readonly DataAccess _dataAccess;
        public AccountAccess(DataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<int> CheckLogin(String phonenumber, String password)
        {
            if (_dataAccess == null)
            {
                throw new ArgumentNullException(nameof(_dataAccess), "DataAccess is not initialized.");
            }
            var query = _dataAccess.Repository<Account>()
                        .Where(u => u.PhoneNumber == phonenumber);
            var user = await query.FirstOrDefaultAsync();
            if (user == null) 
            {
                return 0;
            }

            // check password if user already exists
            if(!string.Equals(user.Password, password))
            {
                return -1;
            }    

            return 1;
        }
    }
}
