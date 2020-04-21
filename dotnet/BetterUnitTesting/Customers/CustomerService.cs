using System;
using System.Collections.Generic;
using System.Linq;

namespace BetterUnitTesting.Customers
{
    public class CustomerService : ICustomerService
    {
        private readonly IEnumerable<Customer> _customers;

        public CustomerService(IEnumerable<Customer> customers)
        {
            _customers = customers;
        }

        public Customer GetCustomerById(Guid id)
        {
            return _customers.FirstOrDefault(c => c.Id == id);
        }
    }
}