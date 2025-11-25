using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Курсова
{
    internal class Logger
    {
        private const string LogPath = "us_book.txt";

        public static void Log(string user, string action)
        {
            var line = $"{DateTime.Now};{user};{action}";
            File.AppendAllLines(LogPath, new[] { line });
        }
    }
}
