using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubVoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods obj1 = new Methods();
            int a = 5;
            int b = 10;

            Console.WriteLine(obj1.twoIntegers(a, b));
            Console.ReadLine();
        }
    }
}
