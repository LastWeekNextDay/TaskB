using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TaskB.Windows
{
    public partial class FiletypeListWindow : Form
    {
        public FiletypeListWindow(IEnumerable<string> fileTypes, IEnumerable<string> selectedFileTypes)
        {
            InitializeComponent();
            // Add file types to checkedListBox
            // ReSharper disable once CoVariantArrayConversion
            checkedListBox.Items.AddRange(fileTypes.ToArray());
            // Check all selected file types
            foreach (var selectedFileType in selectedFileTypes)
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
                MessageBox.Show(@"Please select at least one file type.", @"No file types selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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