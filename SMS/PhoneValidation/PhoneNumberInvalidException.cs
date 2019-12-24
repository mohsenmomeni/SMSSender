using System;

namespace SMS.Exceptions
{
    public class PhoneNumberInvalidException : ApplicationException
    {
        private string entryNumber;

        public override string Message => string.Format("Phone number: {0} is not valid.", entryNumber);

        public PhoneNumberInvalidException(string entry)
        {
            this.entryNumber = entry;
        }

    }
}
