using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubVoidandStatic
{
    class Methods
    {
        public void divided(int a) //creates a method called divided
        {
            int result = a / 2; // math equation to take user in put and divide by 2
            Console.WriteLine(a + " divided by 2 = " + result); //writes to console 
        }

        public void divided(int e, int f) //overload the method called divided, adding an additional integer to allow overloading.
        {
            int result = (e + f) / 2; //math equation to take user input and divide by 2
            Console.WriteLine(e + " " + f + " divided by 2 = " + result); //writes to console
        }

        public int addition1(int a, out int b) //uses out in the method for using an output parameter (requires at least 1 input, int a for example)
        {
            b = 2; //assigns a value to b
            int d = a + b; //does a math equation with int a and b and assigns that value to d
            return d; //returns the value of d.
        }

        public static int something(int g, int h) //creates a static method (think of a car, it has 4 wheels, that never changes. 3 wheels woulnd't be a car, 2 wheels wouldn't be a car etc.)
        {
            int y = g * h; // math equation using the assigned variables. 
            return y; //returns the value of the math equation
        }
    }   
}
