using System;



class Program
{
    static void Main(string[] args)
    {
        int num1 = 4; //Makes num1 = 4
        int num2 = 6; //Makes num2 = 6
        int total = num1 + num2; //Creates variable "total" and that adds num1 and num2 together
        Console.WriteLine(total);   //Takes the variable "total" and writes the data in console. 
        Console.ReadLine(); //Delays the console from instant closing and allows you to read the above data. 

        int num3 = 2;
        int num4 = 4;
        int difference = num2 - num4;
        Console.WriteLine(difference);
        Console.ReadLine();

        int num5 = 8;
        int num6 = 16;
        int multi = num5 * num6;
        Console.WriteLine(multi);
        Console.ReadLine();

        int num7 = 8;
        int num8 = 4;
        int divided = num7 / num8;
        Console.WriteLine(divided);
        Console.ReadLine();

        string name = "James";
        string lname = "Bennett";
        string fullname = name + lname;
        Console.WriteLine(fullname);
        Console.ReadLine();

    }
}

