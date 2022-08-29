using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Number amt1;
            amt1.Amount = 15;
            
            Console.WriteLine(amt1.Amount);
            Console.ReadLine();
        }

        struct Number
        {
            public decimal Amount;
        }
        
    }
}
