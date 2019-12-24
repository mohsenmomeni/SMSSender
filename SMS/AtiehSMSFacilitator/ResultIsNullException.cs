using System;

namespace SMS
{
    public class ResultIsNullException : ApplicationException
    {
        public override string Message => "Result is not a valid one.";
    }
}