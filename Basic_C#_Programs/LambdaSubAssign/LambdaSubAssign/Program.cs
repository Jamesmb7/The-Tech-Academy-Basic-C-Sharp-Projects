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
            List<string> employeesfName = new List<string>() { "Joe", "James", "John", "Dalton", "Levi", "Andrew", "Joe", "Tom", "Darrel", "Neil" };
            List<string> employeeJoe = new List<string>();
            string hello = "Joe";

            Employee fname = new Employee();
            Employee lname = new Employee();
            Employee id = new Employee();


            foreach (string name in employeesfName)
            {
                if (employeesfName.Contains("Joe"))
                {
                    employeeJoe.Add("Joe");
                }
                
            }
            Console.WriteLine(employeeJoe);
            Console.ReadLine();

            //List<string> newlist = fname.FirstName.Where(x => x == "Joe").ToList();
            //int newID = id.Where(x => x > 5).Sum();

        }
    }
}
