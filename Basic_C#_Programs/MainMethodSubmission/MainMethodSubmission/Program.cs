using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmission
{
    class Program
    {
        static void Main(string[] args)            
        { 
            int x = 5;
            decimal y = 35m;
            string z = "5";
            Methods obj1 = new Methods();

            Console.WriteLine(obj1.Addition(x));
            Console.WriteLine(obj1.Subtraction(y));
            Console.WriteLine("I need a number for a string-to-int conversion! What's a cool number?");
            Console.WriteLine(obj1.multiply(z));


            Console.ReadLine();
        }
    }
}
