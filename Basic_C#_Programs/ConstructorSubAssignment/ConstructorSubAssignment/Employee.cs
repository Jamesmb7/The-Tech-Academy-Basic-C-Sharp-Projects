using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubAssignment
{
    public class Employee
    {
        public int id; //properties
        public string name; //properties

        public Employee(int id, string name)//main constructor
        {
            this.id = id; //Assigns value to id.
            this.name = name; //Assigns value to name.
        }

        public Employee() : this(12, "Joe")//chain
        {
        }

        public Employee(int id) : this(id, "Howdy")//chain
        {
        }

        public Employee(string name) :this(0, name)//chain
        {
        }
    }
}
