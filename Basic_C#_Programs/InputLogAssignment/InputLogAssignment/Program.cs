using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputLogAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite number?");
            var favNumber = Convert.ToString(Console.ReadLine());
            File.WriteAllText(@"E:\Tech_Academy\The-Tech-Academy-Basic-C-Sharp-Projects\Basic_C#_Programs\InputLogAssignment\InputLogAssignment\favNumber.txt", favNumber);
            Console.WriteLine("So, your favorite number is {0}?", favNumber);
            Console.ReadLine();
        }
    }
}
