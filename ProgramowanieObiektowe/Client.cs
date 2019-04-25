namespace Finances
{
    namespace Employees
    {
        class Client:Person
        {
            public Client(string name, string surname, int phoneNumber) : base(name, surname, phoneNumber)
            {

            }
            public Client(string name, string surname, int phoneNumber, Address address) : base(name, surname, phoneNumber, address)
            {
                
            }
        }
    }
}
