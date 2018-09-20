using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_OOP_Defining__Classes_Exercise_2
{
    public class Customer
    {
        //Constructor
                        //vvvv everything inside the () below are variables called "parameters"
        public Customer(int id, string lastName, string firstName, int years)
        {
        ID = id;
        LastName = lastName;
        FirstName = firstName;
        Years = years;
        }

        //Properties
        private int _customerID;      //propfull tab tab
        public int ID
        {
            get
            {
                return _customerID;
            }
            set
            {
                if(value <= 0)
                {
                    throw new Exception("Customer ID cannot be negative or zero.");
                }
                _customerID = value;
            }
        }


        //Property Last Name
        private string _lastName;
        public string LastName
        {
            get => _lastName; 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("You must enter a valid last name.");

                _lastName = value;
            }
        }



        //Property First Name
        private string _firstName;
        public string FirstName
        {
            get => _firstName;  //No need for the return keyword... it is implicit with the fat arrow aka lambda

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("You must enter a customer name.");

                _firstName = value;
            }
        }



        //Property Years
        private int _years;
        public int Years
        {
            get
            {
                return _years;
            }
            set
            {
                if(value < 0)
                {
                    throw new Exception("Please enter a number equal to or higher than zero.");
                }
                _years = value;
            }
        }

    

        //Methods
        public string SendCustomerMessage()
        {
            string message = "Default message";

            if (Years >= 1 && Years < 5)
                message = "Thank you for being a member!";

            if(Years >= 5)
                message = "Thank you for being a Gold Level member!";
            
            return message;
        }
    }
}
