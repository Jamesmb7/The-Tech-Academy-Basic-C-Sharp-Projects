using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in your first name.");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome back {uName}. Today is {date}."; //reminder \n puts on a new line. {uName} etc calls the variable/string and it's data the easy way. 
            Console.WriteLine(msg);

            string path = @"E:\Tech_Academy\The-Tech-Academy-Basic-C-Sharp-Projects\Basic_C#_Programs\Scores\Scores\studentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path); //Grabes the files from the PATH (hence the reason path is here) and takes the data from said file puts it into array.
            double tScore = 0.0;

            Console.WriteLine("\nStudent Scores: \n");
            foreach(string line in lines) {
                Console.WriteLine("\n" + line);
                double score = Convert.ToDouble(line);
                tScore += score;
            }

            double avgScore = tScore / lines.Length;
            Console.WriteLine("\nTotal of " + lines.Length + " student scores. \tAverage score: " + avgScore);

            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadLine();
        }
    }
}
