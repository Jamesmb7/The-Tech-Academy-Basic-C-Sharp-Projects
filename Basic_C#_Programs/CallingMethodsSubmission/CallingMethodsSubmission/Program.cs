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

            Methods obj1 = new Methods(); //creates an object of the Methods class and names the object obj1
            Console.WriteLine(obj1.Addition(choiceOne)); //Calling addition method through obj1 object and passing in choiceOne
            Console.WriteLine(obj1.Subtraction(choiceOne));
            Console.WriteLine(obj1.Multiply(choiceOne));
            Console.ReadLine();
        }
    }
}
