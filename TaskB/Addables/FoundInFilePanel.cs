using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TaskB.Addables
{
    public partial class FoundInFilePanel : UserControl
    {
        public FoundInFilePanel(string FileName, string StringFound)
        {
            InitializeComponent();

            // Create a label for "File Name"
            Label lblFileName = new Label();
            lblFileName.Text = FileName;
            lblFileName.Dock = DockStyle.Top;

            // Create a label for "STRING FOUND"
            Label lblStringFound = new Label();
            lblStringFound.Text = StringFound;
            lblStringFound.Dock = DockStyle.Left;
            lblStringFound.AutoSize = false;
            
            // Create a button for "OPEN FILE"
            Button btnOpenFile = new Button();
            btnOpenFile.Text = "OPEN FILE";
            btnOpenFile.Dock = DockStyle.Bottom;
            btnOpenFile.Click += (sender, e) => { System.Diagnostics.Process.Start(FileName); };

            // Create a panel to hold the labels and button
            Panel pnlContainer = new Panel();
            pnlContainer.Controls.Add(lblFileName);
            pnlContainer.Controls.Add(lblStringFound);
            pnlContainer.Controls.Add(btnOpenFile);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.BackColor = Color.White;
            pnlContainer.BorderStyle = BorderStyle.FixedSingle;
            

            // Add the panel to the form
            Controls.Add(pnlContainer);
            
            // set minimum size
            MinimumSize = new Size(378, 50);
            // set maximum size
            MaximumSize = new Size(378, 50);
        }

        public FoundInFilePanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}