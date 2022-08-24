using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubVoidMethod
{
    class Program
    {
        static void Main(string[] args) //
        {
            Methods obj1 = new Methods(); //instantiates the method creating an object
            int a = 5; //gives a value to a
            int b = 10; //gives a value to b

            obj1.twoIntegers(a, b); //calls the method and passes in 2 variables
            obj1.twoIntegers(a: 5, b: 15); //calls the method and passes in 2 variables by name
            Console.ReadLine(); //prevents the program from instantly closing after work is complete.
        }
    }
}
