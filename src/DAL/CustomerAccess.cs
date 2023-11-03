
using DTO.Entity;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class CustomerAccess
    {
        private readonly DataAccess _dataAccess;

        public CustomerAccess(DataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<List<Customer>> getListCustomer()
        {
            var query = from customer in _dataAccess.Repository<Customer>()
                        select new Customer
                        {
                            CustomerId = customer.CustomerId,
                            FullName = customer.FullName,
                            PhoneNumber = customer.PhoneNumber,
                            Address = customer.Address
                        };

            var list = await query.ToListAsync();
            return list;
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
        public async Task<Customer> addCustomer(string name, string phoneNumber, string address) {
            Guid customerId = Guid.NewGuid();
            Customer newCustomer = new Customer
            {
                CustomerId=customerId,
                FullName=name,
                Address = address,
                PhoneNumber=phoneNumber
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

            var res = await _dataAccess.SaveChangesAsync();
            return res > 0;
        }



    }
}
