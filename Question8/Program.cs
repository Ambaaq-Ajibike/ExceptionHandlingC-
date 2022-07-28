using System;
namespace Question8
{
    class Program
    {
        public static void Main(string[] args)
        {
             ReadNumber();
        }
          static void ReadNumber()
        {
            try
            {
                int a = 0;
                for (int i = 0; i < 10; i ++)
                {
                    System.Console.WriteLine("enter num");
                    int nums = int.Parse(Console.ReadLine());
                    if(a >= nums)
                    {
                        throw new GreaterThanException("The previous number is greater or equal to the present number");
                    }
                    a = nums;
                }
            }
            catch (GreaterThanException e)
            {
               System.Console.WriteLine(e.Message);
            }
            catch (System.FormatException ex)
            {
               System.Console.WriteLine(ex.Message);
            }           
                    
        }
    }
}