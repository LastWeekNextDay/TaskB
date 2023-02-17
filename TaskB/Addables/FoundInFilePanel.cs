using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TaskB.Addables
{
    public partial class FoundInFilePanel : UserControl
    {
        public FoundInFilePanel(string fileName, string stringFound)
        {
            InitializeComponent();
            
            AutoScroll = true;

            // Create a label for "File Name"
            Label lblFileName = new Label();
            lblFileName.Text = fileName;
            lblFileName.Dock = DockStyle.Top;
            lblFileName.BorderStyle = BorderStyle.FixedSingle;
            lblFileName.ForeColor = Color.Black;
            lblFileName.AutoSize = false;
            lblFileName.Size = new Size(100, 50);

            // Create a label for "STRING FOUND"
            Label lblStringFound = new Label();
            lblStringFound.Text = stringFound;
            lblStringFound.Dock = DockStyle.Bottom;
            lblStringFound.TextAlign = ContentAlignment.MiddleCenter;
            lblStringFound.AutoSize = false;
            lblStringFound.Size = new Size(100, 50);

            // Create a button for "OPEN FILE"
            Button btnOpenFile = new Button();
            btnOpenFile.Text = "OPEN FILE";
            btnOpenFile.Dock = DockStyle.Bottom;
            btnOpenFile.Click += (sender, e) => { System.Diagnostics.Process.Start(fileName); };

            // Create a panel to hold the labels and button
            Panel pnlContainer = new Panel();
            pnlContainer.Controls.Add(lblFileName);
            pnlContainer.Controls.Add(lblStringFound);
            pnlContainer.Controls.Add(btnOpenFile);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.BackColor = Color.White;
            pnlContainer.BorderStyle = BorderStyle.FixedSingle;
            pnlContainer.ForeColor = Color.Black;

            // Add the panel to the form
            Controls.Add(pnlContainer);
            
            // set minimum size
            MinimumSize = new Size(250, 150);
            // set maximum size
            MaximumSize = new Size(250, 150);
        }

        public FoundInFilePanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}