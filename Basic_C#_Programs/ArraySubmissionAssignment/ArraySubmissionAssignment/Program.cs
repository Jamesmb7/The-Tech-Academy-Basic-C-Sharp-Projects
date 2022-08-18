using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {

        string[] stringArray = { "James", "Jackie", "Jason", "Jill", "Bill" }; //Creates an string array under the variable stringArray and also assigns values to index 0-4. 

        int[] intArray = { 5, 15, 30, 45, 85 }; //Creates an integer array under the variable intArray and also assigns values to index 0-4. 

        List<string> stringList1 = new List<string>(); //Creates a string data type list using the variable stringList1
        stringList1.Add("James"); //adds data to the variable list stringList1
        stringList1.Add("Jackie");
        stringList1.Add("Jason");
        stringList1.Add("Jill");
        stringList1.Add("Bill");


        Console.WriteLine("Please select an index location of my String Array between numbers 0 and 4."); //Prints a statement asking for user input.

        int stringArraySelection = Convert.ToInt32(Console.ReadLine()); // Takes the user input and gives it's value to the integer stringArraySelection

        if (stringArraySelection > 4 || stringArraySelection < 0) //if or statement confining the answer to a value between 0 and 4
        {
            Console.WriteLine("Sorry this index doesn't exist, please pick a number between 0 and 4."); //prints the statement that the user input is an invalid index.
        }
        else //else statement
        {
            Console.WriteLine(stringArray[stringArraySelection]); //prints the value of the stringArray using the user input variable stringArraySelection
        }
        Console.WriteLine(); //adds a line break for organization. 

        Console.WriteLine("Please select an index location of my Integer Array between numbers 0 and 4.");//Prints a statement asking for user input.
        int intArraySelection = Convert.ToInt32(Console.ReadLine()); // Takes the user input and gives it's value to the integer stringArraySelection

        if (intArraySelection > 4 || intArraySelection < 0)//if or statement confining the answer to a value between 0 and 4
        {
            Console.WriteLine("Sorry this index doesn't exist, please pick a number between 0 and 4.");//prints the statement that the user input is an invalid index.
        }
        else//else statement
        {
            Console.WriteLine(intArray[intArraySelection]);//prints the value of the intArray using the user input variable intArraySelection
        }
        Console.WriteLine();//adds a line break for organization. 

        Console.WriteLine("Please select an index location of my String List between numbers 0 and 4.");//Prints a statement asking for user input.
        int stringListSelection = Convert.ToInt32(Console.ReadLine()); // Takes the user input and gives it's value to the integer stringArraySelection

        if (stringListSelection > 4 || stringListSelection < 0)//if or statement confining the answer to a value between 0 and 4
        {
            Console.WriteLine("Sorry this index doesn't exist, please pick a number between 0 and 4.");//prints the statement that the user input is an invalid index.
        }
        else//else statement
        {
            Console.WriteLine(stringList1[stringListSelection]);//prints the value of the stringList1 using the user input variable stringListSelection
        }


        Console.ReadLine(); //prevents the console from auto closing, allowing you to review the data.
    }
}
