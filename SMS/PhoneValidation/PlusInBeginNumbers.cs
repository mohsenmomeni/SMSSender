namespace SMS
{
    public class PlusInBeginNumbers : IPhoneNumberRule
    {
        public bool IsApplyable(string number)
        {
            return number.ToCharArray()[0] == '+';
        }

        public string RefineNumber(string number)
        {
            return number.Substring(1, number.Length - 1);

        }
    }
}
