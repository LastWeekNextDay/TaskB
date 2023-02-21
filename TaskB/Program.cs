using System;
using System.Windows.Forms;
using TaskB.Functions;
using TaskB.Windows;

namespace TaskB
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // set the LOG_FILE_PATH of Logger as current directory + log.txt
            Logger.LogFilePath = Environment.CurrentDirectory + "\\log.txt";
            // set some available file types
            GlobalVar.AvailableFiletypes = new[] { ".txt", ".cfg", ".csv", ".ini", ".log", ".xml" };

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}