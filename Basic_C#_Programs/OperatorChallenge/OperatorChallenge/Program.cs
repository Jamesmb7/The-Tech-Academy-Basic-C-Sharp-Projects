using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            if (1 != 2)
            {
                Console.WriteLine("All is right with the universe.");
            }
            else
            {
                Console.WriteLine("We live in a wild world today!");
            }

            Console.WriteLine(Environment.NewLine);

            int age = 19;

            if (age < 21)
            {
                Console.WriteLine("No, you may not purchase that bottle of wine.");
            }
            else
            {
                Console.WriteLine("Sure, that will be $23.71.");
            }

            Console.WriteLine(Environment.NewLine);

            if (age <= 20)
            {
                Console.WriteLine("No you may not purchase that bottle of wine.");
            }
            else
            {
                Console.WriteLine("There you go!");
            }

            Console.WriteLine(Environment.NewLine);

            if (age >= 25)
            {
                Console.WriteLine("Sure, you're more than welcome to rent this car! Let me get the paperwork!");
            }
            else
            {
                Console.WriteLine("No, sorry. You're still too young to rent a car from us.");
            }

            Console.WriteLine(Environment.NewLine);

            int packageWeight = 50;
            int packageLength = 25;

            if (packageWeight > 40 && packageLength > 20)
            {
                Console.WriteLine("This package is too big to ship.");
            }
            else
            {
                Console.WriteLine("Sure, this package is perfect size for shipping!");
            }

            Console.WriteLine(Environment.NewLine);

            string role = "admin";
            if (role == "admin" || role == "administrator")
            {
                Console.WriteLine("You may have access to the entire software system.");
            }

            Console.WriteLine(Environment.NewLine);

            int num5 = 8;
            int num6 = 15;

            string result = num5 > num6 ? "Num5 is Greater Than Num6" : "Num6 is Greater Than Num5";
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
