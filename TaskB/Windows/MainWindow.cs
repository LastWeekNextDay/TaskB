using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using TaskB.Addables;
using TaskB.Functions;

namespace TaskB.Windows
{
    public partial class MainWindow : Form
    {
        private SearchButtonFunctions _searchButtonFunctions;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void DirectorySelector_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK) return;
            _searchButtonFunctions.FolderPath = folderBrowserDialog.SelectedPath;
            DirectorySelector.Text = _searchButtonFunctions.FolderPath;
        }

        private void FiletypeSelector_Click(object sender, EventArgs e)
        {
            // Create new FiletypeListWindow with file types from FileTypes.txt and selected file types
            var filetypeListWindow = new FiletypeListWindow(GlobalVar.AvailableFiletypes,
                _searchButtonFunctions.SelectedFiletypes);
            // Show window
            if (filetypeListWindow.ShowDialog() != DialogResult.OK) return;
            // Change text of field to show selected file types or if none selected, show "None"
            FiletypeSelector.Text = filetypeListWindow.ReturnCheckedItems().Length > 0
                ? string.Join(", ", filetypeListWindow.ReturnCheckedItems())
                : "None";
            // Assign selected file types to _searchButtonFunctions.SelectedFiletypes
            _searchButtonFunctions.SelectedFiletypes = filetypeListWindow.ReturnCheckedItems().ToList();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Initialize SearchButtonFunctions
            _searchButtonFunctions = new SearchButtonFunctions
            {
                IsSearching = false
            };
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            // Check if is searching
            if (_searchButtonFunctions.IsSearching)
            {
                // if True, return
                return;
            }

            // Assign string box text to stringToSearch
            _searchButtonFunctions.StringToSearch = StringBox.Text;

            // Assign before and after values to variables
            _searchButtonFunctions.CharactersBefore = (int)numericUpDownBefore.Value;
            _searchButtonFunctions.CharactersAfter = (int)numericUpDownAfter.Value;

            // Validate for search
            var validation = _searchButtonFunctions.Validate();

            // if validation is not ok, show error message and return
            if (!validation.Item1)
            {
                MessageBox.Show(validation.Item2, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Set to searching
            _searchButtonFunctions.IsSearching = true;

            // Clear the flow layout panel
            flowLayoutPanel1?.Controls.Clear();

            // Set search button text to "Searching..."
            SearchButton.Text = @"Searching...";

            // Start timer
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            // Create variable for number of found string
            var foundCount = 0;

            // Check if multithreading is checked
            if (MultithreadCheckBox.Checked)
            {
                // Search using multithreading then assign return value to results
                var results = _searchButtonFunctions.Search_MultiThread();

                // Log the current time
                Logger.Log($"Search finished in {stopwatch.ElapsedMilliseconds.ToString()}ms");

                // Go through all results, create FoundInFilePanel using result info and add to flow layout panel
                foreach (var result in results)
                {
                    // Add the panel to the flow layout panel
                    flowLayoutPanel1?.Controls.Add(new FoundInFilePanel(result.Item1, result.Item2));

                    // Add 1 to foundCount
                    foundCount++;
                }
            }
            else
            {
                // Search using single thread then assign return value to results
                var results = _searchButtonFunctions.Search_SingleThread();

                // Log the current time
                Logger.Log($"Search finished in {stopwatch.ElapsedMilliseconds.ToString()}ms");

                // Go through all results, create FoundInFilePanel using result info and add to flow layout panel
                foreach (var result in results)
                {
                    // Add the panel to the flow layout panel
                    flowLayoutPanel1?.Controls.Add(new FoundInFilePanel(result.Item1, result.Item2));

                    // Add 1 to foundCount
                    foundCount++;
                }
            }
            
            // Create dummy label to add to flow layout panel to make sure the last panel is not cut off
            Label dummyLabel = new Label();
            dummyLabel.Width = 0;
            dummyLabel.Height = 0;
            dummyLabel.Margin = new Padding(0, 0, 0, 0);

            flowLayoutPanel1?.Controls.Add(dummyLabel);
            flowLayoutPanel1?.SetFlowBreak(dummyLabel, true);

            // Stop timer
            stopwatch.Stop();

            // Change runtime time text to show time taken
            RuntimeTimeTextLabel.Text = $@"{stopwatch.ElapsedMilliseconds.ToString()} ms";

            // Change found count text to show number of found strings
            countFoundLabel.Text = foundCount.ToString();

            // Set IsSearching to false
            _searchButtonFunctions.IsSearching = false;

            // Set search button text to "Search"
            SearchButton.Text = @"Search";
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