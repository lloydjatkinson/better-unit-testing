using System;

namespace BetterUnitTesting.Customers
{
    public interface ICustomerService
    {
        public Customer GetCustomerById(Guid id);
    }
}
