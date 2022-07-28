using System;
namespace Question9
{
    public class EmptyFileException : Exception
    {
        public EmptyFileException(string message) : base(message)
        {

        }
    }
}