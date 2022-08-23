using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main(string[] args)
    {
        List<int> intList = new List<int> { 4, 8, 16, 32, 64 }; //Creates a list of integers
        Console.WriteLine("Please pick a number to divide the list by!"); //asks a question
        
        try
        {
            int userNumber = Convert.ToInt32(Console.ReadLine()); //Takes user input for the above question
            for (int i = 0; i < intList.Count; i++) //for statement 
            {
                Console.WriteLine(intList[i] / userNumber); //takes the value at integer i in the intlist and divides that by the user input. 
            }
        }
        catch(FormatException ex)//catch statement to display format errors and print it in console. (trying to divide by a string etc.)
        {
            Console.WriteLine("Use the right format doofus.");           
        }
        catch(DivideByZeroException ex) //catch statement to display an attempted divide by zero (not possible)
        {
            Console.WriteLine("Can't divide by zero doofus.");
        }
        catch(Exception ex) //general exception catch incase something was missed above
        {
            Console.WriteLine("ex.Message");
        }
        finally
        {
            Console.WriteLine("Doofus, you have emerged."); //in finally will show when you have finished this loop (basically)
            Console.ReadLine();//keeps the console window open long enough to review data
        }
    }
}

