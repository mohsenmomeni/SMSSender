using SMS.Exceptions;
using SMS.PhoneValidation;
using System;
using System.Linq;

namespace SMS
{
    public abstract class MobilePhone
    {
        protected abstract string CountryCode { get; }
        protected abstract int PhonesNumbersLength { get; }
        protected int CountryCodeLength => this.CountryCode.Length;

        public bool IsValid(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                throw new ArgumentException();
            if (!OnlyContainsDigit(phoneNumber) || !PlusIsAtFirst(phoneNumber))
                return false;            
            return RemoveCountryCodeIfHas(ApplyRules(phoneNumber)).Length == PhonesNumbersLength;
        }

        public string RefineNumber(string entry)
        {
            if (string.IsNullOrWhiteSpace(entry))
                throw new ArgumentException();
            string result = RemoveNonDigits(entry);
            if (!IsValid(result))
            {
                throw new PhoneNumberInvalidException(entry);
            }
            return RemoveCountryCodeIfHas(ApplyRules(result));
        }

        public string RefineNumberAndAddCountryCode(string entry)
        {
            return AddCountryCode(RefineNumber(entry));
        }

        public string AddCountryCode(string phoneNumber)
        {
            if (!IsValid(phoneNumber))
            {
                throw new PhoneNumberInvalidException(phoneNumber);
            }
            return string.Format("{0}{1}", CountryCode, phoneNumber);
        }

        private string RemoveNonDigits(string entry)
        {
            var result = string.Empty;
            foreach (var item in entry)
            {
                if (IsDigitChar(item))
                {
                    result += item;
                }
            }

            return result;
        }

        protected bool OnlyContainsDigit(string phonenumber)
        {
            foreach (var character in phonenumber)
            {
                if (!IsDigitChar(character))
                {
                    return false;
                }
            }
            return true;
        }

        public string ApplyRules(string phoneNumber)
        {
            var refinedPhoneNumber = (new PhoneNumberFirstRuleExaminer()).ApplyRules(phoneNumber);
            return refinedPhoneNumber;
        }

        protected string RemoveCountryCodeIfHas(string entry)
        {
            if (ContainsCountryCode(entry))
            {
                return RemoveCountryCode(entry);
            }
            return entry;
        }

        private string RemoveCountryCode(string entry)
        {
            return entry.Substring(CountryCodeLength,
                                    entry.Length - CountryCodeLength);
        }

        private bool ContainsCountryCode(string entry)
        {
            return entry.Length == (CountryCodeLength + PhonesNumbersLength)
                            && entry.Substring(0, CountryCodeLength).CompareTo(CountryCode) == 0;
        }

        private bool IsDigitChar(char ch)
        {
            var allDigitEqual =
                           new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "+" };
            if (!allDigitEqual.Contains(ch.ToString()))
            {
                return false;
            }
            return true;
        }

        private bool PlusIsAtFirst(string phoneNumber)
        {
            if (phoneNumber.IndexOf('+') > 0)
                return false;
            return true;
        }
    }
}
