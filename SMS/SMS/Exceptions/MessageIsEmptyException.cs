using System;

namespace SMS.Exceptions
{
    public class MessageIsEmptyException : ApplicationException
    {
        public override string Message => "Message is Null or Empty";
    }
}