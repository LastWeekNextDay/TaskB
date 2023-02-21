using System;
using System.Windows.Forms;

namespace TaskB.Addables
{
    public sealed partial class FoundPanel : UserControl
    {
        public string FileName { get; set; }
        public string FoundString { get; set; }
        public event EventHandler OpenFileClicked;
        
        public FoundPanel(string filename, string foundString)
        {
            InitializeComponent();
            Dock = DockStyle.Top;
            
        }
        
        private void openFileButton_Click(object sender, EventArgs e)
        {
            OpenFileClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}