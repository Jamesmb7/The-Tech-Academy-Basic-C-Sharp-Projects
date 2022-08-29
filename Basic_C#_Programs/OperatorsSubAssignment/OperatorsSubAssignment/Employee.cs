using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubAssignment
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator == (Employee One, Employee Two  )
        {
            return One.Id == Two.Id; 
        }

        public static bool operator != (Employee One, Employee Two )
        {
            return One.Id != Two.Id;
        }
    }
}
