using DTO.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StaffAccess
    {
        private readonly DataAccess _dataAccess;

        public StaffAccess(DataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<List<Account>> getListStaff()
        {
            var query = await _dataAccess.Repository<Account>()
                .Include(a => a.Roles)
                .Where(a => a.Roles.Any(r => r.RoleName == "staff"))
                .ToListAsync();
            return query.ToList();

        }

    }
}
