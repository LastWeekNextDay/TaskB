using System;
using System.IO;
using System.Collections.Generic;

namespace TaskB
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