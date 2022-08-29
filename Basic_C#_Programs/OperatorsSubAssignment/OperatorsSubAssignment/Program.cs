using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(); //instantiates an employee
            Employee employee2 = new Employee(); //instantiates a 2nd employee

            employee1.Id = 5; //gives a value to employee1 ID
            employee2.Id = 5; //gives a value to employee2 ID

            Console.WriteLine(employee1 == employee2); //writes the comparison to console to be a true or false bool arguement. 
            Console.ReadLine(); //lets you view the data without console closing.
        }
    }
}
