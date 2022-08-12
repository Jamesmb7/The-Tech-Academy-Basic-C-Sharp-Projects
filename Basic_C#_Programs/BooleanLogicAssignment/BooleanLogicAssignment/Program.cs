using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?"); //Asks a question.
            int age = Convert.ToInt32(Console.ReadLine()); //Converts data type to integer so console.Readline() works
            Console.WriteLine(Environment.NewLine); //Creates a linebreak in console for organizaion.
            Console.WriteLine("Have you ever had a DUI? Please answer with true or false."); //Asks a question.
            bool dui = Convert.ToBoolean(Console.ReadLine()); //Converts data type to boolean so console.Readline() works
            Console.WriteLine(Environment.NewLine); //Creates a linebreak in console for organizaion.
            Console.WriteLine("How many speeding tickets do you have? Just provide a number, thanks!"); //Asks a question.
            int ticket = Convert.ToInt32(Console.ReadLine()); //Converts data type to integer so console.Readline() works
            Console.WriteLine(Environment.NewLine); //Creates a linebreak in console for organizaion.
            Console.WriteLine("Qualified?"); //Asks a question.
            bool qualified1 = age > 15; //Sets a boolean variable rule to be used in calculating if someone is qualified or not.
            bool qualified2 = dui != true; //Sets a boolean variable rule to be used in calculating if someone is qualified or not.
            bool qualified3 = ticket <= 3; //Sets a boolean variable rule to be used in calculating if someone is qualified or not.
            Console.WriteLine(qualified1 && qualified2 && qualified3); //Takes the boolean variable rules with the && (and) operator to answer the question of "Qualified?" ensuring the person meets all requirements. 
            Console.ReadLine(); //Prevents the program from closing on it's own allowing time for you to view the data.

        }
    }
}
