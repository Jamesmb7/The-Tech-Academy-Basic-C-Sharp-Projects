using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSub_Assign
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); //instantiates Employee class as employee    
            IQuittable quittable = new Employee(); //instantiates IQuittable interface as quittable using the Employee class? ***Is this a correct interpretation? Instructor Question***
            employee.firstName = "Sample"; //gives the property firstName the data "Sample"
            employee.lastName = "Student"; //gives the property lastName the data "Student"

            quittable.Quit();
            employee.SayName(); //runs the method sayName(); defined in the Employee class
            Console.ReadLine(); //allows you to see the data. 
        }
    }
}
