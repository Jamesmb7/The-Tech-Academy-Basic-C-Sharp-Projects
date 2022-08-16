using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileStatementAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my favorite color!"); //asks a question.
            string guess = Convert.ToString(Console.ReadLine()); //takes the question and forces it into a string, then applies that answer to the variable "guess".
            bool isGuessed = guess == "blue"; //states that the variable guess has to = "blue" to be correct, isGuessed will take that information and decide if it's a true or false statement.

            do //do while loop start. Allows you to guess the answser to the question above on your first try and allows the following full switch statement to run. 
            {
                switch (guess) //starts a switch statement using case/break.
                {
                    case "blue": //sets this case to blue, or the right answer for this question.
                        Console.WriteLine("You chose the color blue! Good job!"); //console reply telling that you got the answer correct.
                        isGuessed = true; //tells the program this is the correct answer, or "true" in boolean as stated above guess == "blue". 
                        break; //ends case "blue" if correct.
                    default: //Every other answer would be incorrect, default allows that option for a loop so people can continue guessing.
                        Console.WriteLine("You chose " + guess + "." + " Please guess another color!"); //Informs the user what they chose and tells them to try again.
                        Console.WriteLine("Guess my favorite color!"); //asks the question again.
                        guess = Convert.ToString(Console.ReadLine()); //takes the user answer to the question and inserts it as a value for the variable guess.
                        break; //ends the default case.
                }
            }
            while (!isGuessed); //is saying while the variable isGuessed is not true, do the following.
            {
                Console.ReadLine(); //prevents instant closing of the cmd menu.
            }

            



                //while (!isGuessed)
                //{
                //    switch (guess)
                //    {
                //        case "blue":
                //            Console.WriteLine("You chose the color blue! Good job!");
                //            isGuessed = true;
                //            break;
                //        default:
                //            Console.WriteLine("You chose " + guess + "." + " Please guess another color!");
                //            Console.WriteLine("Guess my favorite color!");
                //            guess = Convert.ToString(Console.ReadLine());
                //            break;
                //    }
                //}
                //Console.ReadLine();
        }
    }
}
