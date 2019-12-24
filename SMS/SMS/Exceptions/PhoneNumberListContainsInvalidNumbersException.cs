using System;
using System.Collections.Generic;

namespace SMS.Exceptions
{
    public class PhoneNumberListContainsInvalidNumbersException : ApplicationException
    {
        public List<string> InvalidNumbers { get; private set; }

        public string InvalidNumbersTogether
        {
            get
            {
                string all = string.Empty;
                foreach (var item in InvalidNumbers)
                {
                    all += item + "\t";
                }
                return all;
            }
        }

        public override string Message => string.Format("Phone number: {0} is not valid.", InvalidNumbersTogether);

        public PhoneNumberListContainsInvalidNumbersException(List<string> invalidNumbers)
        {
            this.InvalidNumbers = invalidNumbers;
        }
    }
}
