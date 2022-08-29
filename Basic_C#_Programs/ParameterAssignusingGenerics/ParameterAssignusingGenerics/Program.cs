using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterAssignusingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> things = new Employee<string>();
            Employee<int> things2 = new Employee<int>();

            things.Things = new List<string> { "James", "Jackie", "Jackson" };
            things2.Things = new List<int> { 1, 2, 3, };

            for (int i = 0; i < things.Things.Count; i++)
            {
                Console.WriteLine(things.Things[i]);
            }
            for (int i = 0; i < things2.Things.Count; i++)
            {
                Console.WriteLine(things2.Things[i]);
            }
            Console.ReadLine();
        }
    }
}
