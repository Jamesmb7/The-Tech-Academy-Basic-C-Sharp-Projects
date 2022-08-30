using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubAssign
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>() //Employee employee = new Employee (but as a list) using the Employee class as a data type
            {
                new Employee(){Id = 0, FirstName = "Joe", LastName = "Swanson"},
                new Employee(){Id = 1, FirstName = "Jack", LastName = "Hanes"},
                new Employee(){Id = 2, FirstName = "Aaron", LastName = "Rodgers"},
                new Employee(){Id = 3, FirstName = "Mason", LastName = "Kase"},
                new Employee(){Id = 4, FirstName = "Neil", LastName = "Jordan"},
                new Employee(){Id = 5, FirstName = "Blake", LastName = "Griffin"},
                new Employee(){Id = 6, FirstName = "Joe", LastName = "Jackson"},
                new Employee(){Id = 7, FirstName = "James", LastName = "Bennett"},
                new Employee(){Id = 8, FirstName = "Frank", LastName = "Helps"},
                new Employee(){Id = 9, FirstName = "Dalton", LastName = "Smith"},
            };
            List<Employee> joeList = new List<Employee>();

            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joeList.Add(employee);
                }
            }
            foreach (Employee employee in joeList)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.Id);
            }

            Console.WriteLine();

            List<Employee> joeList2 = employees.FindAll(x => x.FirstName == "Joe").ToList();
            foreach (Employee employee in joeList2)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.Id);
            }

            Console.WriteLine();

            List<Employee> idList = employees.Where(x => x.Id > 5).ToList();
            foreach (Employee employee in idList)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.Id);
            }
            Console.ReadLine();



            //foreach (Employee name in employees) This is wrong**
            //{
            //    if (employees.Contains("Joe"))
            //    {
            //        employeeJoe.Add("Joe");
            //    }

            //}
            //Console.WriteLine(employeeJoe);
            //Console.ReadLine();



        }
    }
}
