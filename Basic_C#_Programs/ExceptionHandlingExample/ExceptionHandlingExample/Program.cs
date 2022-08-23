using System;



class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Pick a number");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number.");
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dividing the two...");
            int numberThree = numberOne / numberTwo;
            Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
            Console.ReadLine();
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please type whole numbers only. Ex. 1, 2, 3 etc. ");
            //Console.WriteLine(ex.Message); This would print the exact error message given by the software used. You could also make your own error message print (probably easier for users not in tech field).
            return; //This is put here to show the use for finally. Without readline in finally this return would not allow readline to be reached. Since finally is there, even with this return ending the program finally is reached and readline works.
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by 0.");
        }
        catch(Exception ex)
        {
            Console.WriteLine("ex.Message");
        }
        finally
        {
            Console.ReadLine(); //Putting this inside of finally during a try/catch method, it guarantees that what is in this block of code will be executed regardless of what's in the above code. 
        }
        







        //Started with this code, entered 8 and jessie to get a format error. Then created the above try+catch code.
        //Console.WriteLine("Pick a number");
        //int numberOne = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Pick a second number.");
        //int numberTwo = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Dividing the two...");
        //int numberThree = numberOne / numberTwo;
        //Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
        //Console.ReadLine();
    }
}
