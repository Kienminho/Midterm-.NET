using DTO.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DAL
{
    public class CarAccess
    {
        private readonly DataAccess _dataAccess;

        public CarAccess(DataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<List<Car>> getAllCar(string keywords = null, bool isActive = true)
        {
            var list = from c in _dataAccess.Repository<Car>()
                       select new Car
                       {
                           CarId = c.CarId,
                           CarName = c.CarName,
                           CarType = c.CarType,
                           Brand = c.Brand,
                           Status = c.Status,
                           RentalFee = c.RentalFee,
                       };
            if (!isActive) list = list.Where(c => c.Status != "Unavailable");   

            if(!string.IsNullOrEmpty(keywords))
            {
                list = list.Where(c =>
                   c.CarName.Contains(keywords) || c.CarType.Contains(keywords) || c.Brand.Contains(keywords));
            }
            
            return await list.ToListAsync();
        }

        public async Task<Car> getCar(Guid id)
        {
            Car car = await _dataAccess.Repository<Car>().FirstOrDefaultAsync(c => c.CarId == id);
            return car;
        }

        public async Task<Car> getCarByName(string name)
        {
            Car car = await _dataAccess.Repository<Car>().FirstOrDefaultAsync(c => c.CarName == name);
            return car;
        }

        public async Task<Car> AddCar(string name, string type, string brand, string status, double price)
        {
            Guid carId = Guid.NewGuid();
            Car car = new Car
            {
                CarId = carId,
                CarName = name,
                CarType = type,
                Brand = brand,
                RentalFee = price,
                Status = status
            };

            _dataAccess.Repository<Car>().Add(car);
            await _dataAccess.SaveChangesAsync();
            return car;
        }

        public async Task<bool> DeleteCar(Guid id)
        {
            var query = _dataAccess.Repository<Car>().FirstOrDefault(c => c.CarId == id);
            if (query != null)
                _dataAccess.Repository<Car>().Remove(query);
            var res = await _dataAccess.SaveChangesAsync();
            return res > 0;
        }

        public async Task<bool> UpdateCar(Car c)
        {
            var query = _dataAccess.Repository<Car>().FirstOrDefault(car => car.CarId == c.CarId);

            if (query == null) return false;
            if (string.IsNullOrEmpty(c.CarName) && string.IsNullOrEmpty(c.CarType) 
                && string.IsNullOrEmpty(c.Brand) && (c.RentalFee == 0)) {
                query.Status = c.Status;
            }
            else
            {
                query.CarName = c.CarName;
                query.CarType = c.CarType;
                query.Brand = c.Brand;
                query.Status = c.Status;
                query.RentalFee = c.RentalFee;
            }
            var res = await _dataAccess.SaveChangesAsync();
            return res >0;

        }
    }
}
