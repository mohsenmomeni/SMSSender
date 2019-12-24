namespace SMS
{
    public class TwoZeroPhoneNumbers : IPhoneNumberRule
    {
        public bool IsApplyable(string number)
        {
            return number.Substring(0, 2).CompareTo("00") == 0;
        }

        public string RefineNumber(string number)
        {
            return number.Substring(2, number.Length - 2);
        }
    }
}
