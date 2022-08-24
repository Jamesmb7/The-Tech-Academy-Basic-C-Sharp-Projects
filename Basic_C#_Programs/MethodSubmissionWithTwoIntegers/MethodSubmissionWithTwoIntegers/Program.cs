using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionWithTwoIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods obj1 = new Methods();
            int b;
            int result;
            Console.WriteLine("Please give me a number between 1 and 9.");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you. Pick another number between 1 and 9. --optional");
            //int b = Convert.ToInt32(Console.ReadLine());

            if (int.TryParse(Console.ReadLine(), out b))
                result = obj1.twoIntegers(b);

            
            Console.WriteLine(obj1.twoIntegers(a, b));
            Console.ReadLine();
        }
    }
}
