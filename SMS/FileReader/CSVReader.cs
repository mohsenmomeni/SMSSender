using System.Collections.Generic;
using System.IO;

namespace SMS.Win.Reader
{
    public class CSVReader : IFileReader
    {
        public string Path { get; private set; }

        public string Filter => "CSV files (*.CSV)|*.CSV|All files (*.*)|*.*";

        public List<string> Read()
        {
            List<string> numbers = new List<string>();
            using (var reader = new StreamReader(Path))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    numbers.Add(values[0]);
                }
            }
            return numbers;
        }

        public void SetPath(string path)
        {
            Path = path;
        }
    }
}
