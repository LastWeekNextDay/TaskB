namespace TaskB.Windows
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
            this.MultithreadCheckBox = new System.Windows.Forms.CheckBox();
            this.RuntimeLabel = new System.Windows.Forms.Label();
            this.RuntimeTimeTextLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.numericUpDownBefore = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAfter = new System.Windows.Forms.NumericUpDown();
            this.LabelBefore = new System.Windows.Forms.Label();
            this.LabelAfter = new System.Windows.Forms.Label();
            this.countFoundLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAfter)).BeginInit();
            this.SuspendLayout();
            // 
            // DirectorySelector
            // 
            this.DirectorySelector.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DirectorySelector.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DirectorySelector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DirectorySelector.Location = new System.Drawing.Point(9, 20);
            this.DirectorySelector.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DirectorySelector.Name = "DirectorySelector";
            this.DirectorySelector.Size = new System.Drawing.Size(259, 19);
            this.DirectorySelector.TabIndex = 0;
            this.DirectorySelector.Text = "Select folder...";
            this.DirectorySelector.Click += new System.EventHandler(this.DirectorySelector_Click);
            // 
            // FiletypeSelector
            // 
            this.FiletypeSelector.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FiletypeSelector.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FiletypeSelector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FiletypeSelector.Location = new System.Drawing.Point(9, 54);
            this.FiletypeSelector.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FiletypeSelector.Name = "FiletypeSelector";
            this.FiletypeSelector.Size = new System.Drawing.Size(259, 19);
            this.FiletypeSelector.TabIndex = 1;
            this.FiletypeSelector.Text = "Select filetype...";
            this.FiletypeSelector.Click += new System.EventHandler(this.FiletypeSelector_Click);
            // 
            // StringLabel
            // 
            this.StringLabel.Location = new System.Drawing.Point(9, 88);
            this.StringLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StringLabel.Name = "StringLabel";
            this.StringLabel.Size = new System.Drawing.Size(91, 19);
            this.StringLabel.TabIndex = 2;
            this.StringLabel.Text = "Search for string:";
            // 
            // StringBox
            // 
            this.StringBox.Location = new System.Drawing.Point(9, 109);
            this.StringBox.Margin = new System.Windows.Forms.Padding(2);
            this.StringBox.Name = "StringBox";
            this.StringBox.Size = new System.Drawing.Size(260, 106);
            this.StringBox.TabIndex = 4;
            this.StringBox.Text = "";
            // 
            // SearchButton
            // 
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.Location = new System.Drawing.Point(9, 321);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(259, 35);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // MultithreadCheckBox
            // 
            this.MultithreadCheckBox.Location = new System.Drawing.Point(9, 229);
            this.MultithreadCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.MultithreadCheckBox.Name = "MultithreadCheckBox";
            this.MultithreadCheckBox.Size = new System.Drawing.Size(259, 20);
            this.MultithreadCheckBox.TabIndex = 7;
            this.MultithreadCheckBox.Text = "Multithreading";
            this.MultithreadCheckBox.UseVisualStyleBackColor = true;
            // 
            // RuntimeLabel
            // 
            this.RuntimeLabel.Location = new System.Drawing.Point(294, 332);
            this.RuntimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RuntimeLabel.Name = "RuntimeLabel";
            this.RuntimeLabel.Size = new System.Drawing.Size(49, 19);
            this.RuntimeLabel.TabIndex = 8;
            this.RuntimeLabel.Text = "Runtime:";
            // 
            // RuntimeTimeTextLabel
            // 
            this.RuntimeTimeTextLabel.Location = new System.Drawing.Point(518, 332);
            this.RuntimeTimeTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RuntimeTimeTextLabel.Name = "RuntimeTimeTextLabel";
            this.RuntimeTimeTextLabel.Size = new System.Drawing.Size(59, 19);
            this.RuntimeTimeTextLabel.TabIndex = 9;
            this.RuntimeTimeTextLabel.Text = "0 ms";
            this.RuntimeTimeTextLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(294, 54);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(284, 271);
            this.flowLayoutPanel1.TabIndex = 10;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // numericUpDownBefore
            // 
            this.numericUpDownBefore.Location = new System.Drawing.Point(10, 284);
            this.numericUpDownBefore.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownBefore.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            this.numericUpDownBefore.Name = "numericUpDownBefore";
            this.numericUpDownBefore.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownBefore.TabIndex = 11;
            this.numericUpDownBefore.ValueChanged += new System.EventHandler(this.numericUpDownBefore_ValueChanged);
            // 
            // numericUpDownAfter
            // 
            this.numericUpDownAfter.Location = new System.Drawing.Point(178, 284);
            this.numericUpDownAfter.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownAfter.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            this.numericUpDownAfter.Name = "numericUpDownAfter";
            this.numericUpDownAfter.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownAfter.TabIndex = 12;
            this.numericUpDownAfter.ValueChanged += new System.EventHandler(this.numericUpDownAfter_ValueChanged);
            // 
            // LabelBefore
            // 
            this.LabelBefore.Location = new System.Drawing.Point(9, 258);
            this.LabelBefore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelBefore.Name = "LabelBefore";
            this.LabelBefore.Size = new System.Drawing.Size(121, 16);
            this.LabelBefore.TabIndex = 13;
            this.LabelBefore.Text = "Characters before";
            // 
            // LabelAfter
            // 
            this.LabelAfter.Location = new System.Drawing.Point(178, 256);
            this.LabelAfter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelAfter.Name = "LabelAfter";
            this.LabelAfter.Size = new System.Drawing.Size(96, 19);
            this.LabelAfter.TabIndex = 14;
            this.LabelAfter.Text = "Characters after";
            this.LabelAfter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // countFoundLabel
            // 
            this.countFoundLabel.Location = new System.Drawing.Point(294, 16);
            this.countFoundLabel.Name = "countFoundLabel";
            this.countFoundLabel.Size = new System.Drawing.Size(100, 23);
            this.countFoundLabel.TabIndex = 15;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.countFoundLabel);
            this.Controls.Add(this.LabelAfter);
            this.Controls.Add(this.LabelBefore);
            this.Controls.Add(this.numericUpDownAfter);
            this.Controls.Add(this.numericUpDownBefore);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.RuntimeTimeTextLabel);
            this.Controls.Add(this.RuntimeLabel);
            this.Controls.Add(this.MultithreadCheckBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.StringBox);
            this.Controls.Add(this.StringLabel);
            this.Controls.Add(this.FiletypeSelector);
            this.Controls.Add(this.DirectorySelector);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "TaskB";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAfter)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label countFoundLabel;

        private System.Windows.Forms.Label LabelAfter;

        private System.Windows.Forms.NumericUpDown numericUpDownBefore;
        private System.Windows.Forms.NumericUpDown numericUpDownAfter;
        private System.Windows.Forms.Label LabelBefore;

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

        private System.Windows.Forms.CheckBox MultithreadCheckBox;
        private System.Windows.Forms.Label RuntimeLabel;
        private System.Windows.Forms.Label RuntimeTimeTextLabel;

        private System.Windows.Forms.Button SearchButton;

        private System.Windows.Forms.Label FiletypeSelector;
        private System.Windows.Forms.RichTextBox StringBox;

        private System.Windows.Forms.Label StringLabel;

        private System.Windows.Forms.Label DirectorySelector;

        #endregion
    }
}