using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClassMethodExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); //creates the employee object instantiating from the Employee class
            employee.FirstName = "Sample"; //Uses the inheritence of Person from the Employee Class to assign "Sample" to FirstName
            employee.LastName = "Student"; //Uses the inheritence of Person from the Employee Class to assign "Student" to LastName

            employee.SayName(); //Calls the method SayName() from the Person class which is inherited by the Employee class
            Console.ReadLine(); //Prevents auto closing of console.

        }
    }
}
