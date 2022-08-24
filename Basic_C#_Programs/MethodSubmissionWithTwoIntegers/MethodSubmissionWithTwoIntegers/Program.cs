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
            Methods obj1 = new Methods(); //creates an object from the methods class.
            int b; //creates a variable integer b for use later in code.
            int result; //creates a variable integer called result to be used later in code.
            Console.WriteLine("Please give me a number between 1 and 9."); //asks a question
            int a = Convert.ToInt32(Console.ReadLine()); //gets user input and converts it to an integer, saving that input as variable a
            Console.WriteLine("Thank you. Pick another number between 1 and 9. --optional"); //asks another question
            //int b = Convert.ToInt32(Console.ReadLine());

            if (int.TryParse(Console.ReadLine(), out b)) //
                result = obj1.twoIntegers(b); //

            
            Console.WriteLine(obj1.twoIntegers(a, b)); //takes variable a and b and uses the twoIntegers method.
            Console.ReadLine();
        }
    }
}
