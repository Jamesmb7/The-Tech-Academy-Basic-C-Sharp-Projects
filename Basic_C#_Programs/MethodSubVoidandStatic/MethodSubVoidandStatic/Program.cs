using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubVoidandStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods obj1 = new Methods();
            Console.WriteLine("Please enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            obj1.divided(a);


            int z = Methods.something(5, 6);

            Console.ReadLine();
        }
    }
}
