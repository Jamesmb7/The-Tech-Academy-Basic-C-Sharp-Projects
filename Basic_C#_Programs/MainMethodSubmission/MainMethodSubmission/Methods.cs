using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmission
{
    class Methods
    {
        public int Addition(int x) //creates a method in the Methods class
        {
            int result = x + 5; //creates an integer math equation
            return result; //returns the results of this equation
        }
        public int Subtraction(decimal y) //creates a method in the Methods class
        {
            int result =Convert.ToInt32(y - 5.5m); //converts a decimal to an integer and does a math equation math equation
            return result; //returns the results of this equation
        }
        public int multiply(string z) //creates a method in the Methods class
        {
            int result =Convert.ToInt32(z) * 5; //converts the string to an integer and does a math equation
            return result; //returns the results of this equation
        }
    }
}
