using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1
{
    public class Phone
    {
        //Constructor
        public Phone(string maker, string model, decimal value)
        {
            Maker = maker;  //maker = user input
            Model = model;  //model = user input
            Value = value;  //value = user input
        }

        //Properties
        public string Maker { get; set; }
        public string Model { get; set; }
        public decimal Value { get; set; }

        //Method
    }
}
