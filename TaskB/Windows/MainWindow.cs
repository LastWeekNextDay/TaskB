using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskB.Addables;

namespace TaskB
{
    public partial class MainWindow : Form
    {
        private bool IsSearching { get; set; }
        private string FolderPath { get; set; }
        private string[] SelectedFiletypes { get; set; }

        private string[] FullFiletypeList { get; set; }

        private void SearchButton_Function_Check_and_Init()
        {
            // Check if folder path is empty
            if (FolderPath == "")
            {
                MessageBox.Show("Please select a folder to search in.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Check if FileType is empty
            if (SelectedFiletypes.Length == 0)
            {
                MessageBox.Show("Please select a file type to search for.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Check if string box text is empty or only spaces
            if (string.IsNullOrWhiteSpace(StringBox.Text))
            {
                MessageBox.Show("Please enter a string to search for.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Check if before and after values are not less than 0
            if (numericUpDownBefore.Value < 0 || numericUpDownAfter.Value < 0)
            {
                MessageBox.Show("Please enter a value greater than or equal to 0 for before and after.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Clear the flow layout panel
            if (flowLayoutPanel1 != null)
            {
                flowLayoutPanel1.Controls.Clear();
            }
        }

        private void SearchButton_Function_Search()
        {
            // Check if is searching
            if (IsSearching)
            {
                // if True, return
                return;
            }
            else
            {
                // if False, set to true
                IsSearching = true;
            }

            // Start timer
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

            // Create an empty string array for files
            string[] files = Array.Empty<string>();

            // Create a list that holds the filename and the string that was found
            List<(string, string)> results = new List<(string, string)>();

            // Create variable for number of found string
            int foundCount = 0;

            // Check if multithreading is checked
            if (MultithreadCheckBox.Checked)
            {
                // Create a list of threads
                List<System.Threading.Thread> threads = new List<System.Threading.Thread>();

                // Loop through all filetypes
                foreach (string filetype in SelectedFiletypes)
                {
                    // Create a new thread
                    System.Threading.Thread thread = new System.Threading.Thread(() =>
                    {
                        // Add all files with the current file type to the files array
                        files = files.Concat(Directory.GetFiles(FolderPath, $"*{filetype}", SearchOption.TopDirectoryOnly))
                            .ToArray();
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

                // Clear the list of threads
                threads.Clear();

                // Assign numericUpDownBefore, numericUpDownAfter and text of stringbox to variables
                int before = (int)numericUpDownBefore.Value;
                int after = (int)numericUpDownAfter.Value;
                string stringBoxText = StringBox.Text;

                // Loop through all files
                foreach (string file in files)
                {
                    // Create a new thread
                    System.Threading.Thread thread = new System.Threading.Thread(() =>
                    {
                        // Read from file and check if returned string is not empty
                        if (FileReader.ReadFileAndReturnString(file, stringBoxText, before, after) != "")
                        {
                            // Add the filename and string to the results list
                            results.Add((file, stringBoxText));
                        }
                    });

                    // Start the thread
                    thread.Start();

                    // Add the thread to the list of threads
                    threads.Add(thread);
                }

                // Wait for threads to finish
                foreach (System.Threading.Thread thread in threads)
                {
                    thread.Join();
                }

                // Clear the list of threads
                threads.Clear();
            }
            else
            {
                // Loop through all file types
                foreach (string filetype in SelectedFiletypes)
                {
                    // Add all files with the current file type to the files array
                    files = files.Concat(Directory.GetFiles(FolderPath, $"*{filetype}", SearchOption.TopDirectoryOnly))
                        .ToArray();
                }

                // Loop through all files
                foreach (string file in files)
                {
                    // Check if returned string is not empty
                    if (FileReader.ReadFileAndReturnString(file, StringBox.Text, (int)numericUpDownBefore.Value,
                            (int)numericUpDownAfter.Value) != "")
                    {
                        // Add the filename and string to the results list
                        results.Add((file, StringBox.Text));
                    }
                }
            }

            // Go through all results, create FoundInFilePanel using result info and add to flow layout panel
            foreach ((string, string) result in results)
            {
                // Add the panel to the flow layout panel
                flowLayoutPanel1.Controls.Add(new FoundInFilePanel(result.Item1, result.Item2));

                // Add 1 to foundCount
                foundCount++;
            }

            // Stop timer
            stopwatch.Stop();

            // Change runtime time text to show time taken
            RuntimeTimeTextLabel.Text = $"{stopwatch.ElapsedMilliseconds} ms";
            
            // Change found count text to show number of found strings
            countFoundLabel.Text = foundCount.ToString();

            // Set IsSearching to false
            IsSearching = false;
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void DirectorySelector_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            FolderPath = folderBrowserDialog.SelectedPath;
            DirectorySelector.Text = FolderPath;
        }

        private void FiletypeSelector_Click(object sender, EventArgs e)
        {
            FiletypeListWindow filetypeListWindow = new FiletypeListWindow(FullFiletypeList, SelectedFiletypes);
            if (filetypeListWindow.ShowDialog() == DialogResult.OK)
            {
                // Get checked items from file type list window
                SelectedFiletypes = filetypeListWindow.ReturnCheckedItems();
                // Change text of field to show selected file types or if none selected, show "None"
                FiletypeSelector.Text = SelectedFiletypes.Length > 0 ? string.Join(", ", SelectedFiletypes) : "None";
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Set default values
            FolderPath = "";
            SelectedFiletypes = Array.Empty<string>();
            IsSearching = false;
            // Find FileTypes.txt in the project folder
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName,
                "FileTypes.txt");
            // Read all the lines of FileTypes.txt that start with a dot and write them to fullFiletypeList
            FullFiletypeList = File.ReadAllLines(path).Where(x => x.StartsWith(".")).ToArray();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchButton_Function_Check_and_Init();

            SearchButton_Function_Search();
        }

        private void numericUpDownBefore_ValueChanged(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void numericUpDownAfter_ValueChanged(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }
    }
}