using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatementChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 4; //selects the case
            switch (day) //begins the switch statement and varifies what the day is
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default: //used to set a condition if no other conditions are met aka if I changed the int day to 8, there are only 7 cases/days in a week so it would go to default reply below.
                    Console.WriteLine("There aren't even this many days in a week!");
                    break;
                            
                    
            }
            Console.ReadLine();
        }
    }
}
