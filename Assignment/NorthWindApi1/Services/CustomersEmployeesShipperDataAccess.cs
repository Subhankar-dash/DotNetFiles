using NorthWindApi1.Models;
using Microsoft.EntityFrameworkCore;
using NorthWindApi1.Services;

namespace NorthWindApi1.Services
{
    public class CustomersEmployeesShipperDataAccess : IDbAccessService<CustomersEmployeesShipper, int>
    {
        NorthWindContext context;
        public CustomersEmployeesShipperDataAccess(NorthWindContext context)
        {
            this.context = context;
        }

        public Task<CustomersEmployeesShipper> CreateAsync(CustomersEmployeesShipper entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CustomersEmployeesShipper>> GetAsync()
        {
           var result = context.CustomersEmployeesShippers.ToListAsync();
            return (IEnumerable<CustomersEmployeesShipper>)result;
        }

        public Task<CustomersEmployeesShipper> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        

        public Task<CustomersEmployeesShipper> UpdateAsync(int id, CustomersEmployeesShipper entity)
        {
            throw new NotImplementedException();
        }

       
    }
}
