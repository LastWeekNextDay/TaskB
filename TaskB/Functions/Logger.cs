using System.Globalization;
using System.IO;

namespace TaskB.Functions
{
    public static class Logger
    {
        public static string LogFilePath { get; set; }

        public static void Log(string message, string filePath)
        {
            // Write the message to the file, including time and date
            // ReSharper disable once LocalizableElement
            File.AppendAllText(filePath,
                $"----------\n{System.DateTime.Now.ToString(CultureInfo.CurrentCulture)}:\n {message}\n----------\n");
        }

        public static void Log(string message)
        {
            // Write the message to the file, including time and date
            // ReSharper disable once LocalizableElement
            File.AppendAllText(LogFilePath,
                $"----------\n{System.DateTime.Now.ToString(CultureInfo.CurrentCulture)}:\n {message}\n----------\n");
        }
    }
}