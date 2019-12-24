namespace SMS
{
    public interface IPhoneNumberRule
    {
        bool IsApplyable(string number);
        string RefineNumber(string number);
    }
}
