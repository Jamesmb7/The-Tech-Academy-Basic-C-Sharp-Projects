using System;
using System.Collections.Generic;


    class Program
    {
        static void Main()
        {

        List<string> intList = new List<string>();
        intList.Add("Hello");
        intList.Add("World!");

        //Console.WriteLine(intList[1]);
        intList.ForEach(Console.WriteLine); //Writes everything in the list with variable "intList"
        Console.ReadLine();

        //byte[] byteArray = new byte[5000];

        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);
        //intList.Remove(10);

        //Console.WriteLine(intList[0]);
        //Console.ReadLine();




        //int[] numArray = new int[5]; //This says integer array CALLED numArray.
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 }; //this is the exact same as what's above just cleaner and easier to write.

        //int[] numArray2 = { 5, 2, 10, 200, 5000 };

        //numArray2[4] = 5001; 

        ////Console.WriteLine(numArray[3]);
        ////Console.WriteLine(numArray1[3]);
        //Console.WriteLine(numArray2[4]);
        //Console.ReadLine();
    }
    }

