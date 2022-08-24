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
            Methods obj1 = new Methods(); //instantiates the class and creates an object
            Console.WriteLine("Please enter a number"); //asks a question
            int a = Convert.ToInt32(Console.ReadLine()); //assigns user input valute to a, converted into an integer
            obj1.divided(a); // calls the method on the value a


            int z = Methods.something(5, 6); //calls the method something and adds values to it.
            Console.WriteLine(z); //displays the result of method something with the values above, using int z

            Console.ReadLine();
        }
    }
}
