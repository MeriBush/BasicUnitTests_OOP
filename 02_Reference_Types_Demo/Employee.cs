using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Reference_Types_Demo
{
    public class Employee
    {
        //Properties
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int YearsExperience { get; set; }

        //Methods
        public string GetFullName()
        {
            string fullName = FirstName + " " + LastName;
            return fullName;
        }
    }
}
