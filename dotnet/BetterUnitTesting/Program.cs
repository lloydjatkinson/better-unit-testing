using System;
using System.Linq;

using BetterUnitTesting.Customers;

using Bogus;

namespace BetterUnitTesting
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                var fakeCustomers = new Faker<Customer>()
                    .CustomInstantiator(f => new Customer(
                        id: Guid.NewGuid(),
                        firstName: f.Name.FirstName(),
                        lastName: f.Name.LastName(),
                        dateOfBirth: f.Date.Past(),
                        emailAddress: new Email(f.Internet.Email()),
                        favouriteColour: f.Commerce.Color()
                    ))
                    .Generate(10);

                foreach (var customer in fakeCustomers.Take(10))
                {
                    Console.WriteLine(customer);
                }

                Console.ReadLine();
            }
        }
    }
}
