namespace BetterUnitTesting.Customers
{
    public class Email
    {
        public string Address { get; }

        public Email(string address) => Address = address;

        public override string ToString() => Address;
    }
}
