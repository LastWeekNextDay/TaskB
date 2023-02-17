using System.IO;

namespace TaskB
{
    public static class Logger
    {
        public static string LOG_FILE_PATH { get; set; }
        public static void Log(string message, string filePath)
        {
            // Write the message to the file, including time and date
            File.AppendAllText(filePath, $"----------\n{System.DateTime.Now}:\n {message}\n----------\n");
        }
        
        public static void Log(string message)
        {
            // Write the message to the file, including time and date
            File.AppendAllText(LOG_FILE_PATH, $"----------\n{System.DateTime.Now}:\n {message}\n----------\n");
        }
    }
}