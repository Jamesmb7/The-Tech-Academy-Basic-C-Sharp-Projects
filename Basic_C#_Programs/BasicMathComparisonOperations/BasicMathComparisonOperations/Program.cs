using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMathComparisonOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine("Five plus Ten = " + total.ToString());
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //int quotient = 100 / 5;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int quotients = 100 / 17;
            //Console.WriteLine(quotients);
            //Console.ReadLine(); this will be rounded to just 5 since it's an int.

            //double quotient = 100.0 / 17.0; 
            //Console.WriteLine(quotient);
            //Console.ReadLine(); With a decimal it tells the compoiler it's no longer an integer it will give a decimal. 

            //int remainder = 10 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine(); This will come up as 0, as 10 / 2 will not have a remainder. "%" is for remaineder or to know if something can be divided into another number. Called a MODULUS!

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine(); This will come up as 1, as 11 / 2 will have remainders stating it's odd and not even. useful for having a function work every other time etc.

            //int num1 = 200 / 3;
            //Console.WriteLine(num1);
            //Console.ReadLine(); Again this will display 66, due to being int only.

            //double num1 = 200.0 / 3.0;
            //Console.WriteLine(num1);
            //Console.ReadLine(); This will display as 66.666667 or close, as double is more accurate and denotes using decimal points. 

            //bool trueOrFalse = 12 > 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine(); Will Return True

            //bool trueOrFalse = 12 < 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine(); Will Return False

            int roomTemperature = 70;
            int currentTemperature = 72;

            //bool isWarm = currentTemperature > roomTemperature;
            //Console.WriteLine(isWarm);
            //Console.ReadLine(); Will return True.

            //bool isWarm = currentTemperature >= roomTemperature; Can also be changed to <=. 
            //Console.WriteLine(isWarm);
            //Console.ReadLine(); Will Return True

            //bool isWarm = currentTemperature == roomTemperature;
            //Console.WriteLine(isWarm);
            //Console.ReadLine(); Will return false, as == is asking if the two are equal. They are not hence returning false. 

            //bool isWarm = currentTemperature != roomTemperature;
            //Console.WriteLine(isWarm);
            //Console.ReadLine(); Would return true, as "!=" is asking if something "is not" equal. In this case the variables are not equal so it would return true. 
        }
    }
}
