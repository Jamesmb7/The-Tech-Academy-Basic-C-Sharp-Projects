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
                new Employee(){Id = 0, FirstName = "Joe", LastName = "Swanson"}, //Gives value to properties in list, same for all 9 below
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
            List<Employee> joeList = new List<Employee>(); //creates a new empty list

            foreach (Employee employee in employees) //foreach loop using the Employee data type and employee variable
            {
                if (employee.FirstName == "Joe") //targets the employee variable(list) then targets the FirstName property to look for a value ==(equal to) "Joe".
                {
                    joeList.Add(employee); //If the value is ==(equal to) "Joe" the if statement adds that employee to your new empty list called joeList.
                }
            }
            foreach (Employee employee in joeList) //foreach loop using the Employee data type and employee variable inside joeList(list)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.Id); //Console Writes the employee in joeList and targets it's first name, last name, and id all to console.writeline.
            }

            Console.WriteLine(); //adds a space in the console to better organize between lists.
            //This block of code directly below could also use a Where statement instead of FindAll, it will still solve the problem asked. ***Personal Note***
            List<Employee> joeList2 = employees.FindAll(x => x.FirstName == "Joe").ToList(); //Uses a lambda expression to find all employees with the first name "Joe"(targeting the first name with.FirstName) and add those employees to your new empty list joeList2.
            foreach (Employee employee in joeList2) //foreach loop to target the employee in joeList2
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.Id); //console prints the data in joeList2
            }

            Console.WriteLine(); //adds a space in the console to better organize between lists.

            List<Employee> idList = employees.Where(x => x.Id > 5).ToList(); //Uses a lambda expression to find all employee's with an ID > 5 then add those employees to a new list(idList) by using a where statement. 
            foreach (Employee employee in idList)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.Id); //console prints the data in idList
            }
            Console.ReadLine(); //adds a space in the console to better organize between lists.


            
            
            /*                      ***This is/was wrong, Personal Reminder***
             *                      
            foreach (Employee name in employees) Not looking for a name, we're looking for the actual employee (all data in list for specific person)
            {
                if (employees.Contains("Joe")) Not just a contains moment we're looking to target a FirstName of "Joe".
                {
                    employeeJoe.Add("Joe"); "Looking to add an employee, not just the name "Joe" and must also target FirstName property. 
                }

            }
            Console.WriteLine(employeeJoe);
            Console.ReadLine();
            */



        }
    }
}
