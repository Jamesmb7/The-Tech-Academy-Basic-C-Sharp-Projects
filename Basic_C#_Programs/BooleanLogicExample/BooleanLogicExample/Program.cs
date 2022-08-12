using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(true && false); //boolean expression, && is the operator called "and" meaning are both of these true.
            Console.WriteLine(true && true);
            Console.WriteLine(false && false);

            Console.WriteLine(true || true); //Logical operator for "OR" || also means "OR" in c#, asking if one of the examples is true.
            Console.WriteLine(true || false);
            Console.WriteLine(false || false);

            Console.WriteLine(true == true); // equals operatore, must be the same. 
            Console.WriteLine(false == false);
            Console.WriteLine(true == false);

            Console.WriteLine(true != true); //not equal operator
            Console.WriteLine(true != false);
            Console.WriteLine(false != false);

            Console.WriteLine(true ^ true); //x or operator. Will evaluate to true if one or the other is true but not both. 
            Console.WriteLine(true ^ false);
            Console.WriteLine(false ^ false);

            Console.ReadLine();
        }
    }
}
