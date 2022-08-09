using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperatorSubAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int weeks = 52; //Creates a variable integer for the amount of weeks in a year. 
            Console.WriteLine("Anonymous Income Comparison Program"); //Opens the program with the message "Anonymous Income Comparison Program"
            Console.WriteLine(Environment.NewLine); // Creates a line break in console or organization purposes.
            Console.WriteLine("Person 1"); //Prints "Person 1" in console so person 1 knows to enter the next question information. 
            Console.WriteLine("What is your Hourly Rate?"); // Asks Person 1 their question
            int hr1 = Convert.ToInt32(Console.ReadLine()); //Takes the answer to the first question, records it into variable integer hr1 and converts it from a string to an integer so readline works. 
            Console.WriteLine("How many hours did you work this week?"); //Asks the second question.
            int hwpw1 = Convert.ToInt32(Console.ReadLine()); //Takes the answer to the second question, records it into variable integer hwpw1 and converts it from a string to an integer so readline works. 
            Console.WriteLine(Environment.NewLine); // Creates a line break in console or organization purposes.
            Console.WriteLine("Person 2"); //Prints "Person 2" in console so person 2 knows to enter the next question information.
            Console.WriteLine("What is your Hourly Rate?"); //Asks person 2 question 1. 
            int hr2 = Convert.ToInt32(Console.ReadLine()); //Takes the answer to the first question, records it into variable integer hr2 and then converts it from a string to an integer so readline works. 
            Console.WriteLine("How many hours did you work this week?");
            int hwpw2 = Convert.ToInt32(Console.ReadLine()); //Takes the answer to the second question, records it into variable integer hwpw2 and then converts it from a string to an integer so readline works. 
            Console.WriteLine(Environment.NewLine); // Creates a line break in console or organization purposes.
            Console.WriteLine("Annual Salary of Person 1:"); //Prints "Annual Salary of Person 1" to display Person 1s salary.
            Console.WriteLine(hr1 * hwpw1 * weeks); //Takes the variables hr1, hwpw1, and weeks and multiplies them all together to display Person 1s Salary.
            //Console.ReadLine(); Putting this here woud pause the program at this point until a user action forces it further. Hitting enter would display the person 2 salary for example. 
            Console.WriteLine(Environment.NewLine); // Creates a line break in console or organization purposes.
            Console.WriteLine("Annual Salary of Person 2:"); //Prints "Annual Salary of Person 2" to display Person 2s Salary.
            Console.WriteLine(hr2 * hwpw2 * weeks); //Takes the variables hr2, hwpw2, and weeks and multiplies them all together to display the Person 2s Salary.
            //Console.ReadLine(); Putting this here woud pause the program at this point until a user action forces it further. Hitting enter would display the person 2 salary for example. 
            Console.WriteLine(Environment.NewLine); // Creates a line break in console or organization purposes.
            Console.WriteLine("Does Person 1 make more than person 2?"); //Prints the question "Does Person 1 make more than person 2?"
            Console.WriteLine(hr1 * hwpw1 * weeks > hr2 * hwpw2 * weeks); //Takes all variables for person 1 and multiplies them together, then takes all variables for person 2 and multiplies them together, then compares the two to see
            //if person 1 makes more than person 2. It will display true if person 1 > person 2. It will display false if person 1 < person 2. 
            Console.ReadLine(); // Prevents the program from auto closing, allowing you time to read and look at all of the printed data. 
        }
    }
}
