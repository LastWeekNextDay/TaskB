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
        private string FolderPath { get; set; }
        private string[] Filetype { get; set; }

        private string[] FullFiletypeList { get; set; }
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
            FiletypeListWindow filetypeListWindow = new FiletypeListWindow(FullFiletypeList, Filetype);
            if (filetypeListWindow.ShowDialog() == DialogResult.OK)
            {
                // Get checked items from file type list window
                Filetype = filetypeListWindow.ReturnCheckedItems();
                // Change text of field to show selected file types or if none selected, show "None"
                FiletypeSelector.Text = Filetype.Length > 0 ? string.Join(", ", Filetype) : "None";
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Set default values
            FolderPath = "";
            Filetype = Array.Empty<string>();
            // Find FileTypes.txt in the project folder
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "FileTypes.txt");
            // Read all the lines of FileTypes.txt that start with a dot and write them to fullFiletypeList
            FullFiletypeList = File.ReadAllLines(path).Where(x => x.StartsWith(".")).ToArray();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            // Check if folder path is empty
            if (FolderPath == "")
            {
                MessageBox.Show("Please select a folder to search in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if FileType is empty
            if (Filetype.Length == 0)
            {
                MessageBox.Show("Please select a file type to search for.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if string box text is empty or only spaces
            if (string.IsNullOrWhiteSpace(StringBox.Text))
            {
                MessageBox.Show("Please enter a string to search for.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if before and after values are not less than 0
            if (numericUpDownBefore.Value < 0 || numericUpDownAfter.Value < 0)
            {
                MessageBox.Show("Please enter a value greater than or equal to 0 for before and after.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Clear the flow layout panel
            if (flowLayoutPanel1 != null)
            {
                flowLayoutPanel1.Controls.Clear();
            }
            
            // Create an empty string array for files
            string[] files = Array.Empty<string>();
            
            // Check if multithread is checked
            if (MultithreadCheckBox.Checked){
                // Start timer
                System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
                stopwatch.Start();
                // Loop through all file types
                foreach (string filetype in Filetype)
                {
                    // Create a new thread for each file type
                    Task.Run(() =>
                    {
                        // Add all files with the current file type to the files array
                        files = files.Concat(Directory.GetFiles(FolderPath, $"*{filetype}", SearchOption.TopDirectoryOnly)).ToArray();
                    });
                }
                // Wait for threads to finish
                Task.WaitAll();
                // Loop through all files
                foreach (string file in files)
                {
                    // Check if returned string is not empty
                    if (FileReader.ReadFileAndReturnString(file, StringBox.Text, (int)numericUpDownBefore.Value,
                            (int)numericUpDownAfter.Value) != "")
                    {
                        // Create a new FoundInFilePanel
                        FoundInFilePanel foundInFilePanel = new FoundInFilePanel(file,
                            FileReader.ReadFileAndReturnString(file, StringBox.Text, (int)numericUpDownBefore.Value,
                                (int)numericUpDownAfter.Value));
                        // add the panel to the flow layout panel
                        flowLayoutPanel1.Controls.Add(foundInFilePanel);
                    }
                }
                // Wait for threads to finish
                //Task.WaitAll();
                // Stop timer
                stopwatch.Stop();
                // Change runtime time text to show time taken as "time ms"
                RuntimeTimeTextLabel.Text = $"{stopwatch.ElapsedMilliseconds} ms";
                
            }  
            else
            {
                // Start timer
                System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
                stopwatch.Start();
                // Loop through all file types
                foreach (string filetype in Filetype)
                {
                    // Add all files with the current file type to the files array
                    files = files.Concat(Directory.GetFiles(FolderPath, $"*{filetype}", SearchOption.TopDirectoryOnly)).ToArray();
                }
                // Loop through all files
                foreach (string file in files)
                {
                    // Check if returned string is not empty
                    if (FileReader.ReadFileAndReturnString(file, StringBox.Text, (int)numericUpDownBefore.Value,
                            (int)numericUpDownAfter.Value) != "")
                    {
                        // Create a new FoundInFilePanel
                        FoundInFilePanel foundInFilePanel = new FoundInFilePanel(file,
                            FileReader.ReadFileAndReturnString(file, StringBox.Text, (int)numericUpDownBefore.Value,
                                (int)numericUpDownAfter.Value));
                        // add the panel to the flow layout panel
                        flowLayoutPanel1.Controls.Add(foundInFilePanel);
                    }
                }
                // Stop timer
                stopwatch.Stop();
                // Change runtime time text to show time taken as "time ms"
                RuntimeTimeTextLabel.Text = $"{stopwatch.ElapsedMilliseconds} ms";
            }
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