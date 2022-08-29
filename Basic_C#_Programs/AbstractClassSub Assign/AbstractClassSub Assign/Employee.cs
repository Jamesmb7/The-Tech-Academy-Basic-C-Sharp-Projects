using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSub_Assign
{
    public class Employee : Person, IQuittable //Inherits from Person Class
    {
        public override void SayName() //Allows override of abstract class to call method SayName
        {
            Console.WriteLine(firstName + " " + lastName); //inputs data for testing
        }
        public void Quit() //calls the method Quit from the IQuittable Interface, also for note you use the method name here not the name of the actual Interface *took me way too long to notice that mistake haha*
        {
            Console.WriteLine("Employee Quit"); //Needed for the employee class to agree with the inheritance of an Interface
        }
    }
}
