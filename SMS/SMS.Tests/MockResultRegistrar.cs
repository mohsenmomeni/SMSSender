using System.Collections.Generic;
using System.Linq;

namespace SMS.Tests
{
    public class MockResultRegistrar : IResultRegistrar
    {
        public List<MockRegRepository> MockRegRepositories { get; private set; }

        public MockResultRegistrar()
        {
            MockRegRepositories = new List<MockRegRepository>();
        }

        private MockRegRepository FindByTitle(string title)
        {
            return MockRegRepositories.FirstOrDefault(o => o.Title == title);
        }

        public bool IsRegistered(string title, string phoneNumber)
        {
            var rep = FindByTitle(title);
            if (rep == null)
                rep = Initialize(title);
            return rep.IsRegistered(phoneNumber);
        }

        public void RegisterResult(string title, string phoneNumber, Result result)
        {
            var rep = FindByTitle(title);
            if (rep == null)
                rep = Initialize(title);
            rep.RegisterResult(phoneNumber, result);
        }

        private MockRegRepository Initialize(string title)
        {
            var m = new MockRegRepository(title);
            MockRegRepositories.Add(m);
            return m;
        }
    }
}