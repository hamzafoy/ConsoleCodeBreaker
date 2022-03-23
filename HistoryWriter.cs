using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ConsoleCodeBreaker_Opponent;

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
        public void WriteToFile(int[] pegRow, int guessCount)
        {
            string documentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(documentPath, "ConsoleCodeBreakerLogs.txt"), true))
            {
                outputFile.WriteLine($"Computer's Code: [ {pegRow[0]} {pegRow[1]} {pegRow[2]} {pegRow[3]} ], # of Guesses to Break: {guessCount}");
            }
        }
    }
}
