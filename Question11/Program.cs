using System;
using System.IO;
using System.Linq;
namespace Question11
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                System.Console.WriteLine("Enter full file path");
                string filepath = Console.ReadLine();
                System.Console.WriteLine("Enter the file name");
                string filename = Console.ReadLine();
                 int a = 0;
                 string message = "does not contain integer";
                foreach (var item in filepath)
                {
                    a ++;
                    if(item.Any(char.IsDigit))
                    {
                        throw new FileParseException($" filename: {filename}Line: {a} message: {message}");
                    }
                }          
            }
            catch(FileParseException e)
            {
                System.Console.WriteLine(e.Message);
            }
            catch (System.Exception ex)
            {
                 System.Console.WriteLine(ex.Message);
            }
                
        }
    }
}