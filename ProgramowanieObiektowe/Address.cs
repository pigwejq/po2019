namespace Finances
{
    namespace Employees
    {
        public class Address
        {
            private string Street;// { get; set; }
            private string City;// { get; set; }
            private int PostalCode;// { get; set; }

            public Address(string street, string city, int postalCode)
            {
                Street = street;
                City = city;
                PostalCode = postalCode;
            }
            public string GetAddress()
            {
                return $"{Street}\n{PostalCode} {City}";
            }
        }
    }
}
