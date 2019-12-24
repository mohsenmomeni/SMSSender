using SMS;

namespace AtiehSMSFacilitator
{
    public class AtiehSMSConfiguration : ISMSConfiguration
    {
        private string username = "mohsen";
        public string Username => username;

        private string pass = "momeni";
        public string Password => pass;

        private string number = "9820001111";
        public string SourceNo => number;

        private string url = "ws.adpdigital.com";
        // private string url = "95.130.240.51";
        public string Address => url;

        public void ChangeConfig(string username, string pass, string sourceNo, string url)
        {
            this.username = username;
            this.pass = pass;
            this.number = sourceNo;
            this.url = url;
        }
    }
}
