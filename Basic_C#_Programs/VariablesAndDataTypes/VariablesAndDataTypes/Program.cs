using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a simple program
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();
            // To comment code ctrl+k+c will comment the full block of code highlighted, to uncomment ctrl+k+u

            //Console.WriteLine("What is your favorite number");
            //string favoriteNumber = Console.ReadLine();
            //Console.WriteLine("Your favorite number is: " + favoriteNumber);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number is: " + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemperature = -23;
            //char randomLetter = "X";
            char questionMark = '\u2103';

            decimal moneyInBank = 100.5m; //m isn't million, it's required when using decimal data type. 

            double heightInCentimeters = 211.30202092;

            float secondsLeft = 2.62f; //f is for float, similar to decimal it's required for float.

            short temperatureOnMars = -341;

            string myName = "James";

            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainingStatus);
            Console.ReadLine();

            //Console.WriteLine(questionMark);
            //Console.ReadLine();
        }
    }
}
