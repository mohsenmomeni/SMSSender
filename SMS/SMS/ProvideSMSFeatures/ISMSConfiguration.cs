namespace SMS
{
    public interface ISMSConfiguration
    {
        string Username { get; }
        string Password { get; }
        string SourceNo { get; }
        string Address { get; }

        void ChangeConfig(string username, string pass, string sourceNo, string Url);
    }
}
