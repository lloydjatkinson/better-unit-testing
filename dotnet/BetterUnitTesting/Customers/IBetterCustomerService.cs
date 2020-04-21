using System;

using Optional;

namespace BetterUnitTesting.Customers
{
    public interface IBetterCustomerService
    {
        Option<Customer> GetCustomerById(Guid id);
    }
}
