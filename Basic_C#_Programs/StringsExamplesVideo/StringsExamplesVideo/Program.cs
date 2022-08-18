using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsExamplesVideo
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jesse";
            //string quote = "The man said, \\\"Hello\", Jesse. \n Hello on a new line. \n \t Hello on a tab.";
            //string fileName = "C:\\Users\\Jesse"; //File names need a double backslash exampled here. Or you could also do the @ sign in front of the "".
            //string fileName2 = @"C:\Users\Jesse";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper();
            //name = name.ToLower();



            //Console.WriteLine(name);
            //Console.ReadLine();

            //string name = "Jesse";
            //name = "Joe"; //This actually created a new string in memory with the value of Joe. 

            //StringBuilder sb = new StringBuilder();

            //sb.Append("My name is Jesse");


            //Console.WriteLine(sb);
            //Console.ReadLine();

            
            string name = "James"; //Creates a string variable named James
            string question = "What is your name?"; //Creates a string asking the question
            string mood = "Happy"; //Creates a string to show a specified mood.
            StringBuilder sb = new StringBuilder(); //Sets sb as a StringBuilder and then states it's creating a new StringBuilder.
            sb.Append("Hello, my name is " + name + ". " + question); //Appends (or adds) the data inside of the () to the stringbuilder sb. 
            Console.WriteLine(sb); //Console Writes the sb. 
            string name2 = Convert.ToString(Console.ReadLine()); //replies to the question with user input.
            Console.WriteLine("Nice to meet you, " + name2 + ". " + "I am " +mood + " to get to know you!"); //Concatenates (combines) the 3 strings together while taking the user input reply to name2 and presents a reply. 
            Console.ReadLine(); //prevents the console from instantly closing.
        }
    }
}
