namespace TaskB
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DirectorySelector = new System.Windows.Forms.Label();
            this.FiletypeSelector = new System.Windows.Forms.Label();
            this.StringLabel = new System.Windows.Forms.Label();
            this.StringBox = new System.Windows.Forms.RichTextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.FoundList = new System.Windows.Forms.Label();
            this.MultithreadCheckbox = new System.Windows.Forms.CheckBox();
            this.RuntimeLabel = new System.Windows.Forms.Label();
            this.RuntimeTimeTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DirectorySelector
            // 
            this.DirectorySelector.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DirectorySelector.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DirectorySelector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DirectorySelector.Location = new System.Drawing.Point(12, 24);
            this.DirectorySelector.Name = "DirectorySelector";
            this.DirectorySelector.Size = new System.Drawing.Size(345, 23);
            this.DirectorySelector.TabIndex = 0;
            this.DirectorySelector.Text = "Select folder...";
            // 
            // FiletypeSelector
            // 
            this.FiletypeSelector.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FiletypeSelector.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FiletypeSelector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FiletypeSelector.Location = new System.Drawing.Point(12, 66);
            this.FiletypeSelector.Name = "FiletypeSelector";
            this.FiletypeSelector.Size = new System.Drawing.Size(345, 23);
            this.FiletypeSelector.TabIndex = 1;
            this.FiletypeSelector.Text = "Select filetype...";
            // 
            // StringLabel
            // 
            this.StringLabel.Location = new System.Drawing.Point(12, 108);
            this.StringLabel.Name = "StringLabel";
            this.StringLabel.Size = new System.Drawing.Size(121, 23);
            this.StringLabel.TabIndex = 2;
            this.StringLabel.Text = "Search for string:";
            this.StringLabel.Click += new System.EventHandler(this.StringLabel_Click);
            // 
            // StringBox
            // 
            this.StringBox.Location = new System.Drawing.Point(12, 134);
            this.StringBox.Name = "StringBox";
            this.StringBox.Size = new System.Drawing.Size(345, 130);
            this.StringBox.TabIndex = 4;
            this.StringBox.Text = "";
            // 
            // SearchButton
            // 
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.Location = new System.Drawing.Point(12, 395);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(345, 43);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // FoundList
            // 
            this.FoundList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.FoundList.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FoundList.ForeColor = System.Drawing.SystemColors.Window;
            this.FoundList.Location = new System.Drawing.Point(388, 25);
            this.FoundList.Name = "FoundList";
            this.FoundList.Size = new System.Drawing.Size(387, 413);
            this.FoundList.TabIndex = 6;
            // 
            // MultithreadCheckbox
            // 
            this.MultithreadCheckbox.Location = new System.Drawing.Point(12, 282);
            this.MultithreadCheckbox.Name = "MultithreadCheckbox";
            this.MultithreadCheckbox.Size = new System.Drawing.Size(121, 24);
            this.MultithreadCheckbox.TabIndex = 7;
            this.MultithreadCheckbox.Text = "Multithreading";
            this.MultithreadCheckbox.UseVisualStyleBackColor = true;
            // 
            // RuntimeLabel
            // 
            this.RuntimeLabel.Location = new System.Drawing.Point(207, 369);
            this.RuntimeLabel.Name = "RuntimeLabel";
            this.RuntimeLabel.Size = new System.Drawing.Size(65, 23);
            this.RuntimeLabel.TabIndex = 8;
            this.RuntimeLabel.Text = "Runtime:";
            // 
            // RuntimeTimeTextLabel
            // 
            this.RuntimeTimeTextLabel.Location = new System.Drawing.Point(278, 369);
            this.RuntimeTimeTextLabel.Name = "RuntimeTimeTextLabel";
            this.RuntimeTimeTextLabel.Size = new System.Drawing.Size(79, 23);
            this.RuntimeTimeTextLabel.TabIndex = 9;
            this.RuntimeTimeTextLabel.Text = "0";
            this.RuntimeTimeTextLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RuntimeTimeTextLabel);
            this.Controls.Add(this.RuntimeLabel);
            this.Controls.Add(this.MultithreadCheckbox);
            this.Controls.Add(this.FoundList);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.StringBox);
            this.Controls.Add(this.StringLabel);
            this.Controls.Add(this.FiletypeSelector);
            this.Controls.Add(this.DirectorySelector);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "TaskB";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.CheckBox MultithreadCheckbox;
        private System.Windows.Forms.Label RuntimeLabel;
        private System.Windows.Forms.Label RuntimeTimeTextLabel;

        private System.Windows.Forms.Label FoundList;

        private System.Windows.Forms.Button SearchButton;

        private System.Windows.Forms.Label FiletypeSelector;
        private System.Windows.Forms.RichTextBox StringBox;

        private System.Windows.Forms.Label StringLabel;

        private System.Windows.Forms.Label DirectorySelector;

        #endregion
    }
}