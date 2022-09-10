using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?"); //asks a question
            try //begins a try catch block
            {
                int age = Convert.ToInt32(Console.ReadLine()); //takes the user answer to the question
                if (age > 0) //creates an if statement inside the try/catch block
                {
                    int currentYear = DateTime.Now.Year; //grabs the current year
                    Console.WriteLine(currentYear); //prints the current year
                    var dob = currentYear - age; //takes the current year and subtracts the user input of their age from it
                    Console.WriteLine("So you were born in {0}.", dob); //writes a console message of your birth date using the prior info provided
                    Console.ReadLine();//readline prevents the program from auto closing.
                }
                else //this is hit if the above code doesn't fit the parameters of age > 0
                {
                    Console.WriteLine("Please enter positive numbers only");//console message that will appear if the else block is hit
                    Console.ReadLine();//readline prevents the program from auto closing.
                }
                
            }
            catch //this will be hit if the above code has any errors, this is a basic exception and covers most/all other non-specific exceptions. 
            {
                Console.WriteLine("You broke it");
                Console.ReadLine();//readline prevents the program from auto closing.
            }
            
        }
    }
}
