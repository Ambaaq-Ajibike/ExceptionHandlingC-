using System;
namespace Question8
{
    public class GreaterThanException : Exception
    {
       public GreaterThanException(string message) : base(message)
       {
           
       }
    }
}