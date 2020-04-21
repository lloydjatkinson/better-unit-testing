using System;
using System.Collections.Generic;
using System.Linq;

using Optional;

namespace BetterUnitTesting.Customers
{
    public class BetterCustomerService : IBetterCustomerService
    {
        private readonly IEnumerable<Customer> _customers;

        public BetterCustomerService(IEnumerable<Customer> customers)
        {
            _customers = customers;
        }

        public Option<Customer> GetCustomerById(Guid id)
        {
            var customer = _customers.FirstOrDefault(c => c.Id == id).SomeNotNull();

            return customer;
        }
    }
}
