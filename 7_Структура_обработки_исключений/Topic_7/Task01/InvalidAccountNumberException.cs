using System;
namespace Task01
{
    public class InvalidAccountNumberException : Exception
    {
        public InvalidAccountNumberException(string message) : base(message) { }
    }
}

