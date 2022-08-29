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
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            employee1.Id = 5;
            employee2.Id = 5;

            Console.WriteLine(employee1 == employee2);
            Console.ReadLine();
        }
    }
}
