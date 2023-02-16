using System.IO;

namespace TaskB
{
    public static class Logger
    {
        public static void Log(string message, string filePath)
        {
            // Write the message to the file, including time and date
            File.AppendAllText(filePath, $"----------\n{System.DateTime.Now}:\n {message}----------\n");
        }
    }
}