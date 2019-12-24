using System.Collections.Generic;

namespace SMS.Tests
{
    public class MockRegRepository
    {
        public string Title { get; private set; }

        private Dictionary<string, Result> dictionary;

        public MockRegRepository(string title)
        {
            Title = title;
            dictionary = new Dictionary<string, Result>();
        }

        public Result GetResult(string item)
        {
            if (dictionary.ContainsKey(item))
                return dictionary[item];
            return null;
        }

        public bool IsRegistered(string phoneNumber)
        {
            return dictionary.ContainsKey(phoneNumber);
        }

        public void RegisterResult(string phoneNumber, Result result)
        {
            dictionary.Add(phoneNumber, result);
        }
    }
}