using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number between 1 and 10 to do some math!");
            int choiceOne = Convert.ToInt32(Console.ReadLine());

            Methods obj1 = new Methods();
            Console.WriteLine(obj1.Addition(choiceOne));
            Console.ReadLine();
        }

    }
}
