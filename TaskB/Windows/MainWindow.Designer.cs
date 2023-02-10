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
            this.MultithreadCheckBox = new System.Windows.Forms.CheckBox();
            this.RuntimeLabel = new System.Windows.Forms.Label();
            this.RuntimeTimeTextLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.numericUpDownBefore = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAfter = new System.Windows.Forms.NumericUpDown();
            this.LabelBefore = new System.Windows.Forms.Label();
            this.LabelAfter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAfter)).BeginInit();
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
            this.DirectorySelector.Click += new System.EventHandler(this.DirectorySelector_Click);
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
            this.FiletypeSelector.Click += new System.EventHandler(this.FiletypeSelector_Click);
            // 
            // StringLabel
            // 
            this.StringLabel.Location = new System.Drawing.Point(12, 108);
            this.StringLabel.Name = "StringLabel";
            this.StringLabel.Size = new System.Drawing.Size(121, 23);
            this.StringLabel.TabIndex = 2;
            this.StringLabel.Text = "Search for string:";
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
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // MultithreadCheckBox
            // 
            this.MultithreadCheckBox.Location = new System.Drawing.Point(12, 282);
            this.MultithreadCheckBox.Name = "MultithreadCheckBox";
            this.MultithreadCheckBox.Size = new System.Drawing.Size(345, 24);
            this.MultithreadCheckBox.TabIndex = 7;
            this.MultithreadCheckBox.Text = "Multithreading";
            this.MultithreadCheckBox.UseVisualStyleBackColor = true;
            // 
            // RuntimeLabel
            // 
            this.RuntimeLabel.Location = new System.Drawing.Point(392, 408);
            this.RuntimeLabel.Name = "RuntimeLabel";
            this.RuntimeLabel.Size = new System.Drawing.Size(65, 23);
            this.RuntimeLabel.TabIndex = 8;
            this.RuntimeLabel.Text = "Runtime:";
            // 
            // RuntimeTimeTextLabel
            // 
            this.RuntimeTimeTextLabel.Location = new System.Drawing.Point(691, 408);
            this.RuntimeTimeTextLabel.Name = "RuntimeTimeTextLabel";
            this.RuntimeTimeTextLabel.Size = new System.Drawing.Size(79, 23);
            this.RuntimeTimeTextLabel.TabIndex = 9;
            this.RuntimeTimeTextLabel.Text = "0";
            this.RuntimeTimeTextLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(392, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(378, 374);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // numericUpDownBefore
            // 
            this.numericUpDownBefore.Location = new System.Drawing.Point(13, 350);
            this.numericUpDownBefore.Name = "numericUpDownBefore";
            this.numericUpDownBefore.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownBefore.TabIndex = 11;
            this.numericUpDownBefore.ValueChanged += new System.EventHandler(this.numericUpDownBefore_ValueChanged);
            // 
            // numericUpDownAfter
            // 
            this.numericUpDownAfter.Location = new System.Drawing.Point(237, 350);
            this.numericUpDownAfter.Name = "numericUpDownAfter";
            this.numericUpDownAfter.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownAfter.TabIndex = 12;
            this.numericUpDownAfter.ValueChanged += new System.EventHandler(this.numericUpDownAfter_ValueChanged);
            // 
            // LabelBefore
            // 
            this.LabelBefore.Location = new System.Drawing.Point(12, 318);
            this.LabelBefore.Name = "LabelBefore";
            this.LabelBefore.Size = new System.Drawing.Size(161, 20);
            this.LabelBefore.TabIndex = 13;
            this.LabelBefore.Text = "Characters before";
            // 
            // LabelAfter
            // 
            this.LabelAfter.Location = new System.Drawing.Point(237, 315);
            this.LabelAfter.Name = "LabelAfter";
            this.LabelAfter.Size = new System.Drawing.Size(128, 23);
            this.LabelAfter.TabIndex = 14;
            this.LabelAfter.Text = "Characters after";
            this.LabelAfter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "TaskB";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAfter)).EndInit();
            this.ResumeLayout(false);
        }

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