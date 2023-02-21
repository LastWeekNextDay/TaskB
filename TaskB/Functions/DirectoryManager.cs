using System.IO;

namespace TaskB.Functions
{
    public static class DirectoryManager
    {
        public static string[] ReturnFilesInDirectoryOfFiletype(string directory, string filetype)
        {
            string[] fileList = Directory.GetFiles(directory, "*" + filetype);
            return fileList;
        }
    }
}