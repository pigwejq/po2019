using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
    namespace Employees
    {
        class Manager : Employee
        {
            public Manager(string name, string surname, int phoneNumber, string position) : base(name, surname, phoneNumber, position)
            {

            }
        }
    }
}
