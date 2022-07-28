using System;
namespace Question7
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
               System.Console.WriteLine("Enter number"); 
               int num = int.Parse(Console.ReadLine());
               if (num < 0)
               {
                   throw new InvalidNumberException("Invalid number");
               }
               else
               {
                   double numsq = Math.Sqrt(num);
                   System.Console.WriteLine(numsq);
               }
           }
            catch (InvalidNumberException ex)
            {
                 System.Console.WriteLine(ex.Message);
            }
            catch (System.FormatException e)
            {
                System.Console.WriteLine("Invalid number");
            }
            finally
            {
                System.Console.WriteLine("Good bye");
            }
        }
    }
}