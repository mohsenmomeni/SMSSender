namespace SMS
{
    public interface IResultRegistrar
    {
        bool IsRegistered(string title, string phoneNumber);
        void RegisterResult(string title, string phoneNumber, Result result);       
    }
}