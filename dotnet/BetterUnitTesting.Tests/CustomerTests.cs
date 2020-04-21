using System;
using System.Collections.Generic;
using System.Linq;

using AutoFixture.Xunit2;

using BetterUnitTesting.Customers;

using Shouldly;

using Xunit;

namespace BetterUnitTesting.Tests
{
    public class CustomerTestsIterationOne
    {

        [Theory, AutoData]
        public void ShouldReturnNullWhenNoCustomerFound(IEnumerable<Customer> customers)
        {
            var customerService = new CustomerService(customers);

            var result = customerService.GetCustomerById(Guid.Empty);

            // What does this *really* mean? What is the intent here?
            // Was no customer found, or did something go wrong and an exception silenty ignored?
            // It would be good if we had a way of indicating what we really mean.
            // AKA: signalling intent.
            result.ShouldBe(null);
        }
    }

    public class CustomerTestsIterationTwo
    {
        [Theory, AutoData]
        public void ShouldReturnNoneWhenNoCustomerFound(IEnumerable<Customer> customers)
        {
            var betterCustomerService = new BetterCustomerService(customers);

            var result = betterCustomerService.GetCustomerById(Guid.Empty);

            result.HasValue.ShouldBeFalse();
        }

        [Theory, AutoData]
        public void ShouldReturnSomeWhenCustomerFound(IEnumerable<Customer> customers)
        {
            var betterCustomerService = new BetterCustomerService(customers);
            Guid customerToGet = customers.First().Id;

            var result = betterCustomerService.GetCustomerById(customerToGet);

            result.HasValue.ShouldBeTrue();
            result.Exists(c => c.Id == customerToGet).ShouldBeTrue();
        }
    }
}