using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsSubAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the day of the week starting with a capital letter, thank you!");           
            try
            {
                string userInput = Console.ReadLine();
                DaysOfTheWeek weekDay = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput);
                Console.WriteLine(weekDay);
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
        }

        
            public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}

