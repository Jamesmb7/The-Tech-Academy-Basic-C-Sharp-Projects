using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubAssignment
{
    public class Employee
    {
        public int Id { get; set; } //creates a property
        public string FirstName { get; set; } //creates a property
        public string LastName { get; set; } //creates a property

        public static bool operator == (Employee One, Employee Two  ) //overloads the == operator so it checks 2 employee's id
        {
            return One.Id == Two.Id;  //compares the id values of employee One and employee Two
        }

        public static bool operator != (Employee One, Employee Two ) //overloads the != operator to check 2 employee's id, have to have comparison operators in pairs. 
        {
            return One.Id != Two.Id; //compares the id values of employee One and employee Two
        }
    }
}
