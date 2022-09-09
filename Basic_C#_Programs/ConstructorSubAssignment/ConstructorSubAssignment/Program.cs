using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myName = "James";
            var fastFood = "Sonic";

            Employee employee1 = new Employee(); //instantiating the constructors
            Console.WriteLine(employee1.name + " " + employee1.id);
            Employee employee2 = new Employee(5, "Hello");
            Console.WriteLine(employee2.name + " " + employee2.id);
            Employee employee3 = new Employee(7);
            Console.WriteLine(employee3.name + " " + employee3.id);
            Employee employee4 = new Employee("Jack");
            Console.WriteLine(employee4.name + " " + employee4.id);
            Console.ReadLine();


        }
    }
}
