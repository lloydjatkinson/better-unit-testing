using System;
using System.Collections.Generic;

namespace BetterUnitTesting.Customers
{
    public sealed class Customer : IEquatable<Customer>
    {
        public Guid Id { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public DateTimeOffset DateOfBirth { get; }

        public Email EmailAddress { get; }

        public string FavouriteColour { get; }

        public Customer(Guid id, string firstName, string lastName, DateTimeOffset dateOfBirth, Email emailAddress, string favouriteColour)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            EmailAddress = emailAddress;
            FavouriteColour = favouriteColour;
        }

        public void Deconstruct(out Guid id, out string firstName, out string lastName, out DateTimeOffset dateOfBirth, out Email emailAddress, out string favouriteColour)
        {
            id = Id;
            firstName = FirstName;
            lastName = LastName;
            dateOfBirth = DateOfBirth;
            emailAddress = EmailAddress;
            favouriteColour = FavouriteColour;
        }

        public override string ToString()
        {
            return $"{Id}, {FirstName} {LastName}, {DateOfBirth}, {EmailAddress}, {FavouriteColour}";
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Customer);
        }

        public bool Equals(Customer other)
        {
            return other != null &&
                   Id.Equals(other.Id) &&
                   FirstName == other.FirstName &&
                   LastName == other.LastName &&
                   DateOfBirth.Equals(other.DateOfBirth) &&
                   EqualityComparer<Email>.Default.Equals(EmailAddress, other.EmailAddress) &&
                   FavouriteColour == other.FavouriteColour;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, FirstName, LastName, DateOfBirth, EmailAddress, FavouriteColour);
        }

        public static bool operator ==(Customer left, Customer right)
        {
            return EqualityComparer<Customer>.Default.Equals(left, right);
        }

        public static bool operator !=(Customer left, Customer right)
        {
            return !(left == right);
        }
    }
}