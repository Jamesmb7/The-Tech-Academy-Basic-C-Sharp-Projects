using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperatorSubAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int weeks = 52;
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your Hourly Rate?");
            int hr1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours did you work this week?");
            int hwpw1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Person 2");
            Console.WriteLine("What is your Hourly Rate?");
            int hr2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours did you work this week?");
            int hwpw2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Annual Salary of Person 1:");
            Console.WriteLine(hr1 * hwpw1 * weeks);
            Console.ReadLine();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Annual Salary of Person 2:");
            Console.WriteLine(hr1 * hwpw2 * weeks);
            Console.ReadLine();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Does Person 1 make more than person 2?");
            Console.WriteLine(hr1 * hwpw2 * weeks > hr2 * hwpw2 * weeks);
            Console.ReadLine();
        }
    }
}
