using System;
using System.Linq;
using System.Windows.Forms;

namespace TaskB
{
    public partial class FiletypeListWindow : Form
    {
        private string[] _fileTypes;
        public FiletypeListWindow(string[] fileTypes, string[] selectedFileTypes)
        {
            InitializeComponent();
            // Assign fileTypes to FileTypes
            _fileTypes = fileTypes;
            // Add file types to checkedListBox
            checkedListBox.Items.AddRange(_fileTypes);
            // Check all selected file types
            foreach (string selectedFileType in selectedFileTypes)
            {
                checkedListBox.SetItemChecked(checkedListBox.Items.IndexOf(selectedFileType), true);
            }
        }
        
        private void CANCELButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            // If no file types selected, do not close window
            if (checkedListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one file type.", "No file types selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
        
        public string[] ReturnCheckedItems()
        {
            return checkedListBox.CheckedItems.Cast<string>().ToArray();
        }
    }
}