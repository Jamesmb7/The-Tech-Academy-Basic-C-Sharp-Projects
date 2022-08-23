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
                Console.WriteLine(intList[i] / userNumber);
            }
        }
        catch(FormatException ex)
        {
            Console.WriteLine("Use the right format doofus.");
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine("Can't divide by zero doofus.");
        }
        catch(Exception ex)
        {
            Console.WriteLine("ex.Message");
        }
        finally
        {
            Console.WriteLine("Doofus, you have emerged.");
            Console.ReadLine();
        }
    }
}

