using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SMS.Win.Registrar
{
    public class FileResultRegistrar : IResultRegistrar
    {       
        public bool IsRegistered(string title, string phoneNumber)
        {
            List<string> all = new List<string>();
            if (File.Exists(title))
            {
                all = File.ReadAllLines(title).ToList();
            }
            return all.Contains(phoneNumber);
        }

        public void RegisterResult(string title, string phoneNumber, Result result)
        {
            File.AppendAllText(title, phoneNumber + "\r\n");
        }       
    }
}
