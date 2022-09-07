using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSub
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datetime = new DateTime(); //appends datetime function
            var currentTime = DateTime.Now; //sets a variable for the current date/time.
            Console.WriteLine(currentTime); //prints the current date/time using above variable
            Console.WriteLine("Please pick a number between 1 and 10"); //asks a question for the user
            var userInput = Convert.ToInt32(Console.ReadLine()); //takes the users answer and puts that value into a variable for later use
            var currentTime2 = currentTime.AddHours(userInput); //uses the users value and adds it onto the hours of the current time.
            Console.WriteLine("It will be {0} after adding {1} hours!",currentTime2, userInput); //completes this program by telling the user if they add x amounts of hours what time it will be in said hours.
            Console.ReadLine(); //allows you to view the data inputs without the console closing. 
        }
    }
}
