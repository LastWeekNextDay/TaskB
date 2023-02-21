using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;

namespace TaskB.Functions
{
    public class SearchButtonFunctions
    {
        public bool IsSearching { get; set; }
        public string FolderPath { get; set; }
        public List<string> SelectedFiletypes { get; set; }
        public string StringToSearch { get; set; }
        public int CharactersBefore { get; set; }
        public int CharactersAfter { get; set; }

        public SearchButtonFunctions(string folderPath, List<string> selectedFiletypes, string stringToSearch,
            int charactersBefore, int charactersAfter)
        {
            FolderPath = folderPath;
            SelectedFiletypes = selectedFiletypes;
            StringToSearch = stringToSearch;
            CharactersBefore = charactersBefore;
            CharactersAfter = charactersAfter;
        }

        public SearchButtonFunctions()
        {
            SelectedFiletypes = new List<string>();
            FolderPath = "";
        }

        public BlockingCollection<Tuple<string, string>> Search_MultiThread()
        {
            // Create a thread-safe list that holds the filename and the string that was found
            BlockingCollection<Tuple<string, string>> results = new BlockingCollection<Tuple<string, string>>();

            // Create a thread-safe list of threads
            List<System.Threading.Thread> threads = new List<System.Threading.Thread>();

            // Loop through all filetypes
            foreach (string filetype in SelectedFiletypes)
            {
                // Create a new thread
                System.Threading.Thread thread = new System.Threading.Thread(() =>
                {
                    // Loop through found files of filetype
                    foreach (string file in Directory.GetFiles(FolderPath, $"*{filetype}"))
                    {
                        // Assign return value of FileReader.ReadFileAndReturnString to variable
                        string returnedString = FileReader.ReadFileAndReturnString(file, StringToSearch,
                            CharactersBefore, CharactersAfter);
                        // Check if file contains string
                        if (!string.IsNullOrEmpty(returnedString))
                        {
                            // Add the filename and string to the results list
                            results.Add(new Tuple<string, string>(file, returnedString));
                        }
                    }
                });

                // Start the thread
                thread.Start();

                // Add the thread to the list of threads
                threads.Add(thread);
            }

            // Wait for all threads to finish
            foreach (System.Threading.Thread thread in threads)
            {
                thread.Join();
            }

            // Return the results
            return results;
        }

        public List<Tuple<string, string>> Search_SingleThread()
        {
            // Create a list that holds the filename and the string that was found
            List<Tuple<string, string>> results = new List<Tuple<string, string>>();

            // Loop through all file types
            foreach (string filetype in SelectedFiletypes)
            {
                // Loop through found files of filetype
                foreach (string file in Directory.GetFiles(FolderPath, $"*{filetype}"))
                {
                    // Assign return value of FileReader.ReadFileAndReturnString to variable
                    string returnedString =
                        FileReader.ReadFileAndReturnString(file, StringToSearch, CharactersBefore, CharactersAfter);

                    // Check if file contains string
                    if (!string.IsNullOrEmpty(returnedString))
                    {
                        // Add the filename and string to the results list
                        results.Add(new Tuple<string, string>(file, returnedString));
                    }
                }
            }

            // Return the results
            return results;
        }

        public Tuple<bool, string> Validate()
        {
            // Set local variables
            var isOk = true;
            var errorMessage = "";

            if (FolderPath == "") // Check if folder path is empty
            {
                errorMessage = "Please select a folder to search in.";
                isOk = false;
            }
            else if (SelectedFiletypes.Count == 0) // Check if file types is empty
            {
                errorMessage = "Please select a file type to search for.";
                isOk = false;
            }
            else if (string.IsNullOrWhiteSpace(StringToSearch)) // Check if string to search is empty or only spaces
            {
                errorMessage = "Please enter a string to search for.";
                isOk = false;
            }
            else if
                (CharactersBefore < 0 || CharactersAfter < 0) // Check if before and after values are not less than 0
            {
                errorMessage = "Please enter a value greater than 0 for the characters before and after.";
                isOk = false;
            }

            // Return the error message and if there was an error
            return new Tuple<bool, string>(isOk, errorMessage);
        }
    }
}