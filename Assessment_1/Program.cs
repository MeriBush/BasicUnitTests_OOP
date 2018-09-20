using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Komodo Insurance!");
            Console.WriteLine("Please enter the maker of your device: ");
            string maker = Console.ReadLine();

            Console.WriteLine("Please enter the model of your device: ");
            string model = Console.ReadLine();

            Console.WriteLine("Please enter the approximate value of your device: ");
            string valueString = Console.ReadLine();
            decimal valueDec = decimal.Parse(valueString);

            /*Console.WriteLine("You have entered: " + " " + Make + " " + Model + " " + ValueDec);
            Console.Read();*/

            Phone phone = new Phone(maker, model, valueDec);

            Console.WriteLine($"{phone.Maker} {phone.Model} {phone.Value}");

            //Another Option:
            Console.WriteLine($"Here are the details of your device:\n" +
                $"Maker: {phone.Maker} \n" +
                $"Model: {phone.Model} \n" +
                $"Value: {phone.Value} \n");
  
            Console.Read();
        }
    }
}
