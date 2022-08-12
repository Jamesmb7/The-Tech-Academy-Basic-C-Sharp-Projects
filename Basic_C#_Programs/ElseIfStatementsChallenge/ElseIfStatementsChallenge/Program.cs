using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElseIfStatementsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "James";

            if (name == "Jackie")
            {
                Console.WriteLine("Your name is Jackie");
            }
            else if (name == "James")
            {
                Console.WriteLine("Your name is James");
            }
            else if (name == "David")
            {
                Console.WriteLine("Your name is David");
            }
            Console.ReadLine();
        }
    }
}
