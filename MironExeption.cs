using System;
namespace Lab.MironGurevich
{
    public class MironException : SystemException
    {
        public MironException(string message) : base(message) { }
    }
}