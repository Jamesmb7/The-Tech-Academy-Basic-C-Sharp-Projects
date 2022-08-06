using System;


namespace TechAcademyDR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy"); //Will Write the first line of "The Tech Academy"
            Console.WriteLine("Student Daily Report"); // Will Write a second line of "Student Daily Report"
            Console.WriteLine("What is your name?"); //This will appear on the Third line and ask "What is your name?"
            string yourName = Console.ReadLine(); //This will take the information from the above written question and input it as a string variable yourName.
            Console.WriteLine("Your Name is " + yourName + Environment.NewLine); //This takes the answer for "yourName" and attaches it to "Your name is" to answer the question in the console. It also creats a line break with Environment.NewLine.
            Console.WriteLine("What course are you on?"); //This asks the question "What course are you on?"
            string yourCourse = Console.ReadLine(); //This will take the string information and apply it to yourCourse variable.
            Console.WriteLine("The course you are on is " + yourCourse + Environment.NewLine); //This takes the variable yourCourse and attaches it to "The course you are on is" to answer the prior question. 
            Console.WriteLine("What page number?");//This asks a question
            string yourPage = Console.ReadLine(); //This takes the answer to the question
            Console.WriteLine("You are on page "+ yourPage + Environment.NewLine); //This puts your answer to the question with "You are on page" to answer the question. 
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");//This asks a question, didn't know if this was supposed to be bool or not after, didn't know how to console.readline print it if so.
            string needHelp = Console.ReadLine();//takes the answer of true or false.
            Convert.ToBoolean(needHelp);//takes your answer and converts it to boolean, true or false.
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");//Asks a question.
            string positiveExperiences = Console.ReadLine();//Allows you to answer the question.
            Console.WriteLine("Your positive experience(s) were: " + positiveExperiences + Environment.NewLine);//Attaches your answer to the original question above. 
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");//Asks a question
            string newFeedback = Console.ReadLine();//Allows you to answer the question.
            Console.WriteLine("Your feedback was: " + newFeedback + Environment.NewLine);//attaches your answer to the question above. 
            Console.WriteLine("How many Hours did you study today?");//Asks a question
            string hoursStudied = Console.ReadLine();//Allows you to answer the question
            Console.WriteLine("You studied " + hoursStudied + " hours today." + Environment.NewLine);//Attaches your answer to the question above. 
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");//Leaves you with a final line wishing you a good day!
            Console.ReadLine();//Prevents auto closing so you have time to read the final message. 
        }
    }
}
