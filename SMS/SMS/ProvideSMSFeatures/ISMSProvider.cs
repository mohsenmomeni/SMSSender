namespace SMS
{
    public interface ISMSProvider
    {
        Result SendSimple(SimpleMessage simpleMessage);
        string Inbox();
    }
}
