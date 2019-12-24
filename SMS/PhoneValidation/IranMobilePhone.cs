namespace SMS
{
    public class IranMobilePhone : MobilePhone
    {
        protected override int PhonesNumbersLength => 10;

        protected override string CountryCode => "98";
    }
}
