
using DTO.Entity;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Reflection;

namespace DAL
{
    public class CustomerAccess
    {
        private readonly DataAccess _dataAccess;

        public CustomerAccess(DataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<List<Customer>> GetCustomers(string keywords = null)
        {
            var query = from c in _dataAccess.Repository<Customer>()
                        select new Customer
                        {
                            CustomerId = c.CustomerId,
                            FullName = c.FullName,
                            Address = c.Address,
                            PhoneNumber = c.PhoneNumber,
                            Gender = c.Gender
                        };

            // Apply search condition if the parameter is provided
            if (!string.IsNullOrEmpty(keywords))
            {
                query = query.Where(c =>
                    c.FullName.Contains(keywords) || c.PhoneNumber.Contains(keywords));
            }

            var result = await query.ToListAsync();

            return result;
        }

        //delete customer
        public async Task<bool> deleteCustomer(Guid id)
        {
            var query = await _dataAccess.Repository<Customer>().FirstOrDefaultAsync(x => x.CustomerId == id);
            _dataAccess.Repository<Customer>().Remove(query);
            var isDeleted = await _dataAccess.SaveChangesAsync();

            return isDeleted >0;


        }

        //add customer
        public async Task<Customer> addCustomer(string name, string phoneNumber, string address, string gender) {
            Guid customerId = Guid.NewGuid();
            Customer newCustomer = new Customer
            {
                CustomerId=customerId,
                FullName=name,
                Address = address,
                PhoneNumber=phoneNumber,
                Gender=gender
            
            };
             _dataAccess.Repository<Customer>().Add(newCustomer);
            await _dataAccess.SaveChangesAsync();

            return newCustomer;

        }

        //update customer
        public async Task<bool> updateCustomer(Customer customer)
        {
            var existCustomer = await _dataAccess.Repository<Customer>()
                                .FirstOrDefaultAsync(c => c.CustomerId == customer.CustomerId);
            existCustomer.FullName = customer.FullName;
            existCustomer.Address = customer.Address;
            existCustomer.PhoneNumber = customer.PhoneNumber;
            existCustomer.Gender = customer.Gender;

            var res = await _dataAccess.SaveChangesAsync();
            return res > 0;
        }

        public async Task<Customer> getCustomerByName(string name)
        {
            Customer customer = await _dataAccess.Repository<Customer>().FirstOrDefaultAsync(p => p.FullName == name);
            return customer;
        }



    }
}
