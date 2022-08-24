using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubVoidandStatic
{
    class Methods
    {
        public void divided(int a)
        {
            int result = a / 2;
            Console.WriteLine(a + " divided by 2 = " + result);
        }

        public void divided(int e, int f)
        {
            int result = (e + f) / 2;
            Console.WriteLine(e + " " + f + " divided by 2 = " + result);
        }

        public int addition1(int a, out int b)
        {
            b = 2;
            int d = a + b;
            return d;
        }

        public static int something(int g, int h)
        {
            int y = g * h;
            return y;
        }
    }   
}
