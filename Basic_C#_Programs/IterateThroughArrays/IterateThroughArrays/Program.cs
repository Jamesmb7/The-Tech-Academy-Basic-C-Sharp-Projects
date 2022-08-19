using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        string[] names = { "Jesse", "James", "John", "Jackson" }; //Created a string Array with 4 names in it.

        Console.WriteLine("Hello, Please type your name. Thanks!"); //Asks the user to input their name.

        string clientName = (Console.ReadLine()); //Assigns that user input to a variable called clientName


        for (int i = 0; i < names.Length; i++) //While the index (i) is < the length of the string array, i++, or add 1 to the index.
        {
            names[i] += clientName; //add onto the end of the array whatever the user input for the variable clientName is.
            Console.WriteLine(names[i]); //Writes/displays all values of the Array in order. 
        }

        for (int i = 0; i < 3; i++) // This used to be infinite because it was i-- but I changed it to i++. 
        {
            Console.WriteLine(i); //displays the index of this array. Was infinite until fixed. 
        }

        for (int i = 0; i < 4; i++) //Uses the < syntax to travel through the array, increasing from 0 as long as the array index is less than 4.
        {
            Console.WriteLine(names[i]); //Prints the value at all index locations that are less than 4. 
        }

        for (int i = 0; i <= 2; i++) //uses the <= syntax to trave through the array, increasing from 0 as long as the array index is less than or equal to 2. 
        {
            Console.WriteLine(names[i]); //Prints the value at all index locations that are less than and/or equal to 2.
        }


        List<string> namesList = new List<string> { "James", "John", "Amy", "Jackson", "Brenda", "Kyle", "Chuck" }; //Creates a list with all unique names
        Console.WriteLine("Please search for a name!"); //Asks the user to input a name they would like to search for

        bool helpme = false;
        int exitloop = 0;

        while (!helpme)
        {
            string clientSearch = Console.ReadLine(); //Stores the user input into a variable called clientSearch
            int indexv1 = 0;
            foreach (string name in namesList) //name = value at each index in list namesList
            {
                if (clientSearch == name) //States that if the clientSearch user input is the same as the value (name) in the nameList string do the following curly bracket code
                {
                    Console.WriteLine("The value of your name is at " + indexv1 + "."); //Will write a statement with the value of indexv1's value.
                    exitloop++; // adds 1 to exitloop variable.
                    break; //breaks the program preventing it from continuing to loop. 
                }
                indexv1++; //adds 1 to the value of indexv1.
            }
            if (exitloop == 0) //This happens if the above if statement is not true, this states taht if exitloop is equal to the value of 0 do the following code
            {
                Console.WriteLine("This name is not on the list."); //writes a statement
                Console.WriteLine("Please search for a name!"); //re-asks the question for the loop console.readline to get user input again above. 
            }
            else
            {
                helpme = true;
            }
        }
        Console.ReadLine();


        List<string> namesList2 = new List<string> { "James", "John", "Amy", "Jackson", "Brenda", "Kyle", "Chuck", "James" }; //Creates a list with all unique names
        Console.WriteLine("Please search for a cool name!"); //Asks the user to input a name they would like to search for

        string userinputs = Console.ReadLine();

        for (int i = 0; i < namesList2.Count; i++)
        {
            if (!namesList2.Contains(userinputs))
            {
                Console.WriteLine("This name is not in the list.");
                break;
            }
            else if (userinputs == namesList2[i])
            {
                Console.WriteLine(namesList2[i] + " is at index " + i);
            }
        }
        Console.ReadLine();


        //bool helpme2 = false; //sets a bool value to false, so later in the code (if needed) we can find a stopping point and attach a bool value of true to stop the loop. 
        //int exitloop2 = 0; //sets an integer exitloop2 value at 0.

        //while (!helpme2) //this says while the variable helpme2 is not false (! = opposite of current value) do the following code
        //{
        //    string clientSearch = Console.ReadLine(); //Stores the user input into a variable called clientSearch
        //    int indexv2 = 0; //sets indexv2 value of 0. 
        //    foreach (string name in namesList2) //name = value at each index in list namesList
        //    {
        //        if (clientSearch == name) //if loop. States that if clientSearch(user input) is the same value as one of the names in the list, do the following code.
        //        {
        //            Console.WriteLine("The value of your name is at " + indexv2 + "."); //prints a statement and shows the value of indexv2 currently.
        //            exitloop2++; //adds 1 to exitloop2 value                   
        //        }
        //        indexv2++;//adds 1 to indexv2 value              
        //    }          
        //    if (exitloop2 != 0) //this happens if the above code does not = true, this states that if exitloop2 is not equal to 0 do the following
        //    {
        //        exitloop2 = 0; //This subtracts 1 value from the exitloop2 value.
        //    }
        //    if (exitloop2 == 0) // this happens if the above code is not = true, this states that if exitloop 2 is equal to 0, do the following
        //    {
        //        Console.WriteLine("This name is not on the list."); //this prints a statement.
        //        //break; do I need some form of a break here? **** Instructor Question *****
        //    }
        //}
        //Console.ReadLine();


        List<string> namesList3 = new List<string> { "Mason", "Jackson", "Jackson", "Brent", "Bradley", "Neil" }; //creates a list
        List<string> compareList = new List<string> { }; //creates a second, empty list


        foreach (string name in namesList3) //foreach loop, string name = the value of text in the list above (namesList3) Ex. Mason, Jackson, Brent, etc.
        {
            if (!compareList.Contains(name) && namesList3.Contains(name)) //If statement showing that if compareList(the empty one) does not contain the value of (name) and namesList3 does contain the value of name, do the following code.
            {
                compareList.Add(name); //this will add that missing name from namesList3 to compareList.
                Console.WriteLine(name + " is not a duplicate."); //this will print a statement saying the value at indexv is not a duplicate (that value represents the (name) value as well, just with a number instead of the string name.
            }
            else if (compareList.Contains(name) && namesList3.Contains(name)) //else if statement, if the above is not true, this statement code kicks in. This states if both lists have the same name do the following code
            {
                Console.WriteLine(name + " is a duplicate!"); //This will take the indexv value and print that it is a duplicate. This is basically comparing the lists and pointing out the location of duplicates. 
            }
        }
        Console.ReadLine();




        //bool startLoop = false; //bool value to eventually end a loop (if needed later).
        //int indexv = 0; //sets a value for indexv to 0.


        //while (!startLoop) //starts a while loop as long as startloop is not equal to true.
        //{
        //    foreach (string name in namesList3) //foreach loop, string name = the value of text in the list above (namesList3) Ex. Mason, Jackson, Brent, etc.
        //    {
        //        if (!compareList.Contains(name) && namesList3.Contains(name)) //If statement showing that if compareList(the empty one) does not contain the value of (name) and namesList3 does contain the value of name, do the following code.
        //        {
        //            compareList.Add(name); //this will add that missing name from namesList3 to compareList.
        //            Console.WriteLine(name + " is not a duplicate."); //this will print a statement saying the value at indexv is not a duplicate (that value represents the (name) value as well, just with a number instead of the string name.
        //        }
        //        else if (compareList.Contains(name) && namesList3.Contains(name)) //else if statement, if the above is not true, this statement code kicks in. This states if both lists have the same name do the following code
        //        {
        //            Console.WriteLine(name + " is a duplicate!"); //This will take the indexv value and print that it is a duplicate. This is basically comparing the lists and pointing out the location of duplicates. 
        //        }
        //        indexv++; //this adds 1 to the indexv value. 
        //    }
        //    if (compareList.Count <= namesList3.Count) //This if statement happens after the prior "if, else if" statements fail, taking the new list and comparing it's size to the original list
        //    {
        //        startLoop = true; //this allows you to stop the loop once the new list(compareList) has the same amount of indices as the old list (namesList3)
        //    }
        //    Console.ReadLine(); //prevents the program from instant closing, allowing you to review all of the data. 
        //}

    }   
}

