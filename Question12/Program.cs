using System;
namespace Question12
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                System.Console.WriteLine("Enter the full path of a file");
                string fullpath = Console.ReadLine(); 
                List<string> files = File.ReadAllLines(fullpath).ToList();
                foreach (var item in files)
                {
                    System.Console.Write(item);
                }
            }
            catch (System.Exception ex)
            {
                 System.Console.WriteLine(ex.Message);
            }
            //System.Console.WriteLine();
            finally
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Thanks");
            }
                     
        }
    }
}
