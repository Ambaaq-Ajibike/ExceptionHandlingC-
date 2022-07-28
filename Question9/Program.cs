using System;
using System.IO;
namespace Question9
{
    class Program
    {
        public static void Main(string[] args)
        {
            string myfile  = "Question9.txt";
            System.Console.WriteLine(ReadMyFile(myfile));
        }
        public static string ReadMyFile(string file)
        {
            try
            {
                string Fullfile = "C:\\Users\\ADMIN\\Desktop\\ExceptionHandlig\\Question9\\File\\Question9.txt";
                if(File.Exists(Fullfile))
                {
                    List<string> words = File.ReadAllLines(Fullfile).ToList();
                    words.Add("Aw va bro"); 
                    File.WriteAllLines(Fullfile, words);
                    if(words.Count == 0)
                    {
                        throw new EmptyFileException("The file is empty");
                    }
                    else
                    {
                        foreach (var item in words)
                        {
                            return item.ToString();
                        }
                    }                 
                }
                else
                {
                   string filepath = "C:\\Users\\ADMIN\\Desktop\\ExceptionHandlig\\Question9\\File";
                   Directory.CreateDirectory(filepath);
                   string filename = file;
                    string fullpath = Path.Combine(filepath, filename);
                    File.Create(fullpath);
                }
            }
            catch(EmptyFileException e)
            {
                System.Console.WriteLine(e.Message);
            }
            catch (System.Exception )
            {
                 System.Console.WriteLine("The is an empty file");
            }
            return null;
        }
    }
}