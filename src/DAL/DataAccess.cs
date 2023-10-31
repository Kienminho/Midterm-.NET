using DTO.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccess
    {
        private readonly EntityContext _context;

        public DataAccess(EntityContext dbContext)
        {
            _context = dbContext;
        }

        public bool SaveAndReload<T>(T entity) where T : class
        {
            try
            {
                if (_context.SaveChanges() > 0)
                {
                    _context.Entry(entity).Reload();
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SaveChanges()
        {
            try
            {
                return _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public DbSet<T> Repository<T>() where T : class
        {
            return _context.Set<T>();
        }

    }
}
