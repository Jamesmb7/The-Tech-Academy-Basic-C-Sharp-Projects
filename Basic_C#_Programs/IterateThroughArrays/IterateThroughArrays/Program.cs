using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        //string[] names = { "Jesse", "James", "John", "Jackson" }; //Created a string Array with 4 names in it.

        //Console.WriteLine("Hello, Please type your name. Thanks!"); //Asks the user to input their name.

        //string clientName = Convert.ToString(Console.ReadLine()); //Assigns that user input to a variable called clientName


        //for (int i = 0; i < names.Length; i++) //While the index (i) is < the length of the string array, i++, or add 1 to the index.
        //{
        //    names[i] += clientName; //add onto the end of the array whatever the user input for the variable clientName is.
        //    Console.WriteLine(names[i]); //Writes/displays all values of the Array in order. 
        //}

        //for (int i = 0; i < 3; i++) // This used to be infinite because it was i-- but I changed it to i++. 
        //{
        //    Console.WriteLine(i); //displays the index of this array. Was infinite until fixed. 
        //}

        //for (int i = 0; i < 4; i++) //Uses the < syntax to travel through the array, increasing from 0 as long as the array index is less than 4.
        //{
        //    Console.WriteLine(names[i]); //Prints the value at all index locations that are less than 4. 
        //}

        //for (int i = 0; i <= 2; i++) //uses the <= syntax to trave through the array, increasing from 0 as long as the array index is less than or equal to 2. 
        //{
        //    Console.WriteLine(names[i]); //Prints the value at all index locations that are less than and/or equal to 2.
        //}


        //List<string> namesList = new List<string> { "James", "John", "Amy", "Jackson", "Brenda", "Kyle", "Chuck" }; //Creates a list with all unique names
        //Console.WriteLine("Please search for a name!"); //Asks the user to input a name they would like to search for

        //bool helpme = false;     
        //int exitloop = 0;

        //while (!helpme)
        //{
        //    string clientSearch = Console.ReadLine(); //Stores the user input into a variable called clientSearch
        //    int indexv = 0;
        //    foreach (string name in namesList) //name = value at each index in list namesList
        //    {
        //        if (clientSearch == name) 
        //        {
        //            Console.WriteLine("The value of your name is at " +indexv + ".");
        //            exitloop++;
        //            break;
        //        }
        //        indexv++;
        //    }
        //    if (exitloop == 0)
        //    {
        //        Console.WriteLine("This name is not on the list.");
        //        Console.WriteLine("Please search for a name!");
        //    }         
        //}
        //Console.ReadLine();


        //List<string> namesList2 = new List<string> { "James", "John", "Amy", "Jackson", "Brenda", "Kyle", "Chuck", "James" }; //Creates a list with all unique names
        //Console.WriteLine("Please search for a name!"); //Asks the user to input a name they would like to search for

        //bool helpme2 = false;
        //int exitloop2 = 0;

        //while (!helpme2)
        //{
        //    string clientSearch = Console.ReadLine(); //Stores the user input into a variable called clientSearch
        //    int indexv = 0;
        //    foreach (string name in namesList2) //name = value at each index in list namesList
        //    {
        //        if (clientSearch == name)
        //        {
        //            Console.WriteLine("The value of your name is at " + indexv + ".");
        //            exitloop2++;                 
        //        }
        //        indexv++;
        //    }
        //    if (exitloop2 != 0)
        //    {
        //        exitloop2--;
        //    }
        //    if (exitloop2 == 0)
        //    {
        //        Console.WriteLine("This name is not on the list.");               
        //    }           
        //}
        //Console.ReadLine();


        List<string> namesList3 = new List<string> { "Mason", "Jackson", "Jackson", "Brent", "Bradley", "Neil" };
        List<string> compareList = new List<string> { };

        bool startLoop = false;
        int indexv = 0;


        while (!startLoop)
        {
            foreach (string name in namesList3)
            {              
                if (!compareList.Contains(name) && namesList3.Contains(name))
                {
                    compareList.Add(name);
                    Console.WriteLine(indexv + " is not a duplicate.");
                }
                else if (compareList.Contains(name) && namesList3.Contains(name))
                {
                    Console.WriteLine(indexv + " is a duplicate!");
                }
                indexv++;
            }
            if (compareList.Count <= namesList3.Count)
            {
                startLoop = true;
            }
            Console.ReadLine();
        }
    }   
}

