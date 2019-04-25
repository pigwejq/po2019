using System.Collections.Generic;
namespace Finances
{
    namespace Employees
    {
        public class Person
        {
            private string Name;
            private string Surname;
            private int PhoneNumber;
            private List<Address> PersonAddresses = new List<Address>();

            public Person(string name, string surname, int phoneNumber)
            {
                Name = name;
                Surname = surname;
                PhoneNumber = phoneNumber;
            }

            public Person(string name, string surname, int phoneNumber, Address address)
            {
                Name = name;
                Surname = surname;
                PhoneNumber = phoneNumber;
                PersonAddresses.Add(address);
            }

            public string GetName() { return Name; }
            //public void SetName(string name) { Name = name; } przecież nikt nie zmienia imienia
            public string GetSurename() { return Surname; }
            public void SetSurname(string surname) { Surname = surname; }
            public int GetPhoneNumber() { return PhoneNumber; }
            public void SetPhoneNumber(int phoneNumber) { PhoneNumber = phoneNumber; }

            public void AddAddress(string street, string city, int postalCode)
            {
                PersonAddresses.Add(new Address(street, city, postalCode));
            }
            public void AddAddress(Address address)
            {
                PersonAddresses.Add(address);
            }
            public void ChangeAddress(Address oldAddress, Address newAddress)
            {
                PersonAddresses.Remove(oldAddress);
                PersonAddresses.Add(newAddress);
            }

            public string GetPersonalInformations()
            {
                return $"{Name} {Surname} | {PhoneNumber} \nAddresses: \n{PersonAddresses}";
            }
        }
    }
}
