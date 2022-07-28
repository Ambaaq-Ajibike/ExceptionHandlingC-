using System;
namespace Question11
{
    public class FileParseException : Exception
    {
        public FileParseException(string filename, int line, string message) : base (message)
        {

        }
    }
}