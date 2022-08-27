using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSub_Assign
{
    public class Employee : Person //Inherits from Person Class
    {
        public override void SayName() //Allows override of abstract class to call method SayName
        {
            Console.WriteLine(firstName + " " + lastName); //inputs data for testing
        }
    }
}
