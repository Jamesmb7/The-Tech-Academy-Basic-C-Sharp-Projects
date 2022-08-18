using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {

        string[] stringArray = { "James", "Jackie", "Jason", "Jill", "Bill" };

        int[] intArray = { 5, 15, 30, 45, 85 };

        List<string> stringList1 = new List<string>();
        stringList1.Add("James");
        stringList1.Add("Jackie");
        stringList1.Add("Jason");
        stringList1.Add("Jill");
        stringList1.Add("Bill");


        Console.WriteLine("Please select an index location of my String Array between numbers 0 and 4.");

        int stringArraySelection = Convert.ToInt32(Console.ReadLine());

        if (stringArraySelection > 4 || stringArraySelection < 0)
        {
            Console.WriteLine("Sorry this index doesn't exist, please pick a number between 0 and 4.");
        }
        else
        {
            Console.WriteLine(stringArray[stringArraySelection]);
        }
        Console.WriteLine();

        Console.WriteLine("Please select an index location of my Integer Array between numbers 0 and 4.");
        int intArraySelection = Convert.ToInt32(Console.ReadLine());

        if (intArraySelection > 4 || intArraySelection < 0)
        {
            Console.WriteLine("Sorry this index doesn't exist, please pick a number between 0 and 4.");
        }
        else
        {
            Console.WriteLine(intArray[intArraySelection]);
        }
        Console.WriteLine();

        Console.WriteLine("Please select an index location of my String List between numbers 0 and 4.");
        int stringListSelection = Convert.ToInt32(Console.ReadLine());

        if (stringListSelection > 4 || stringListSelection < 0)
        {
            Console.WriteLine("Sorry this index doesn't exist, please pick a number between 0 and 4.");
        }
        else
        {
            Console.WriteLine(stringList1[stringListSelection]);
        }


        Console.ReadLine();
    }
}
