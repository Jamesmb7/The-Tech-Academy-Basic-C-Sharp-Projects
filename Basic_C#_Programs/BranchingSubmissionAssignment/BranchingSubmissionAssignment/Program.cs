using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to Package Express. Please follow the instructions below."); // asks a question
            Console.WriteLine(); //adds space for organization in console.
            Console.WriteLine("How much does the package weight?"); //asks a question
            int pkgWeight = Convert.ToInt32(Console.ReadLine()); //takes the user input to the question and stores it in the integer pkgWeight.
            Console.WriteLine(); //adds space for organization in console.
            //string result = pkgWeight >= 51 ? "Package too heavy to be shipped via Package Express. Have a good day." : "What is the width of the package?";
            //Console.WriteLine(result);
            if (pkgWeight > 50) //starts an "if" statement on the pkgWeight being > or < 50. 
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else //else portion of the if/and statement
            {
                Console.WriteLine("What is the width of the package?");
            }
            int pkgWidth = Convert.ToInt32(Console.ReadLine()); //takes the user input from the else question and puts it into the integer variable pkgWidth
            Console.WriteLine(); //adds space for organization in console.
            Console.WriteLine("What is the height of the package?"); //asks a question
            int pkgHeight = Convert.ToInt32(Console.ReadLine()); //takes the user input from the above question and puts it into the integer variable pkgHeight
            Console.WriteLine(); //adds space for organization in console.
            Console.WriteLine("What is the length of the package?"); //asks a question
            int pkgLength = Convert.ToInt32(Console.ReadLine()); //takes the user input from the above question and puts it into the integer variable pkgLength
            Console.WriteLine(); //adds space for organization in console.
            if (pkgWidth + pkgHeight + pkgLength > 50) //beings the if/else statement for adding together width, height, and length and checking if they are > or < 50. 
            {
                Console.WriteLine("Package is too big to be shipped via Package Express");
            }
            else //else portion of this if/else statement.
            {
                Console.WriteLine("Your estimated total cost to ship this package would be:");
            }
            int totalDiminsion = (pkgHeight * pkgWidth * pkgLength * pkgWeight); //creates an int variable to multiply all values together.
            decimal divByHund = (totalDiminsion / 100); //creates a decimal variable to divide the totalDiminsion variable by 100. 
            Console.WriteLine(divByHund.ToString("C")); //takes the decimal variable divByHund and writes it's value in the console, as a dollar amount using .ToString("C"));
            Console.WriteLine("Thank you!"); //Leaves a final comment
            Console.ReadLine(); // Prevents console from auto closing allowing you to view all information.


            //I tried to do this project both using if/else statements and also using the ternary operator "?". The above 2 lines that are commented out go with the following commented out lines of code. Both should work
            //by swapping which parts of the code are commented out.


            //int addUP = (pkgWidth + pkgHeight + pkgLength);
            //string result2 = addUP >= 51 ? "Package is too big to be shipped via Package Express" : "Your estimated total cost to ship this package will be:";
            //Console.WriteLine(result2);
            //int totalDiminsion = (pkgHeight * pkgWidth * pkgLength * pkgWeight);
            //decimal divByHund = (totalDiminsion / 100);
            //Console.WriteLine(divByHund.ToString("C"));
            //Console.WriteLine("Thank you!");
            //Console.ReadLine();






        }
    }
}
