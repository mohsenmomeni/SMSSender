using System.Collections.Generic;

namespace SMS.Win.Reader
{
    public interface IFileReader
    {
        string Filter { get; }
        void SetPath(string path);
        List<string> Read();
    }
}
