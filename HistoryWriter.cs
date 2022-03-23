using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleCodeBreaker_HistoryWriter
{
    public sealed class HistoryWriter
    {
        private HistoryWriter()
        {

        }
        private static HistoryWriter _instance;
        public static HistoryWriter GetInstance()
        {
            if(_instance == null)
            {
                _instance = new HistoryWriter();
            }
            return _instance;
        }
        public void WriteToFile()
        {
            string[] lines = { "Test #1", "Test #2", "Test #3", "Test #4", "Test #5" };
            string documentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(documentPath, "TestFile.txt")))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }
        }
    }
}
