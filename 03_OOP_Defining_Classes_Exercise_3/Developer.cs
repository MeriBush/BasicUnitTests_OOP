using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_OOP_Defining_Classes_Exercise_3
{
    public class Developer
    {
        //Field (is this a type of list?
        public List<Developer> _developerList = new List<Developer>();


        //Constructor
        public Developer(int developerID, string lastName, bool hasAccount)
        {
            DeveloperID = developerID;
            LastName = lastName;
            HasAccount = hasAccount;
        }

        //Properties
        public int DeveloperID { get; set; }
        public string LastName { get; set; }
        public bool HasAccount { get; set; }

        //Methods
        public void AddDeveloperToList(Developer developer)
        {
            _developerList.Add(developer);
        }
    }
}
