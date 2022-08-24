using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionWithTwoIntegers
{
    class Methods
    {
        public int twoIntegers(int a, [Optional] int b) //creates a method allowing 2 integers of data to be worked with
        {
            int result = a + b; //does addition with integer a and integer b and sets that value to the variable result
            return result; //returns the value of result
        }



        public int twoIntegers2(int a,int b = 5) //creates a method allowing 2 integers of data to be worked with
        {
            int result = a + b; //does addition with integer a and integer b and sets that value to the variable result
            return result; //returns the value of result
        }
    }
}
