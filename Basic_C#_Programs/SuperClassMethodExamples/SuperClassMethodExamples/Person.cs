using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClassMethodExamples
{
    class Person
    {
        public string FirstName { get; set; } //Sets a property called FirstName
        public string LastName { get; set; } //Sets a property called LastName

        public void SayName() //Creates a method
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName); //Writes to console.
        }
    }
}
