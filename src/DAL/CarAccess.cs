using DTO.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CarAccess
    {
        private readonly DataAccess _dataAccess;

        public CarAccess(DataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<List<Car>> getAllCar()
        {
            List<Car> list = await _dataAccess.Repository<Car>().ToListAsync();
            return list;
        }

        public async Task<Car> getCar(Guid id)
        {
            Car car = await _dataAccess.Repository<Car>().FirstOrDefaultAsync(c => c.CarId ==id);
            return car;
        }
    }
}
