namespace SMS
{
    public class OneZeroNumbers : IPhoneNumberRule
    {
        public bool IsApplyable(string number)
        {
            return number.Substring(0, 2).CompareTo("00") != 0 && number.ToCharArray()[0] == '0';
        }

        public string RefineNumber(string number)
        {
            return number.Substring(1, number.Length - 1);
        }
    }
}
