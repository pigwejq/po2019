using System.Collections.Generic;
namespace Finances
{
    namespace Employees
    {
        public class Employee : Person
        {
            public string Position { get; set; }
            public static decimal HolidayBonus { get; set; } = 1000;
            public enum ContractTypes { FullTime, PartTime, Contract }
            public ContractTypes Contract { get; set; }
            private Wage EmployeeWage;
            public Wage EmployeeWage
            {
                get;
            }
            public List<Operation> Operations { get; set; } = new List<Operation>();

            public Employee(string name, string surname, int phoneNumber, string position) : base(name, surname, phoneNumber)
            {
                Position = position;
            }

            public Employee(string name, string surname, int phoneNumber, string position, Address address) : base(name, surname, phoneNumber, address)
            {
                Position = position;
            }

            public void AddOperation(string label, string type, decimal value)
            {
                Operations.Add(new Operation(label, type, value));
            }
        }
    }
}
