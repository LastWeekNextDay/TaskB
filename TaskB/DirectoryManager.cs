using System;
using System.IO;
using System.Collections.Generic;

namespace TaskB
{
    public class DirectoryManager
    {
        public string SelectedDirectory { get; set; }
        public string[] FileList { get; set; }

        DirectoryManager()
        {
            SelectedDirectory = "";
        }
        
        public void SearchForFiletype(string filetype)
        {
            FileList = Directory.GetFiles(SelectedDirectory, "*" + filetype);
        }
    }
}