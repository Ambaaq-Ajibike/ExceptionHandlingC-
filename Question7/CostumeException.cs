using System;
namespace Question7
{
    public class InvalidNumberException : Exception
    {
        public InvalidNumberException(string message) : base(message)
        {
            
        }
    }
}