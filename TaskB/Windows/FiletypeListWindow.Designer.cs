using System.ComponentModel;

namespace TaskB
{
    partial class FiletypeListWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.CANCELButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(331, 361);
            this.checkedListBox.TabIndex = 0;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(41, 388);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(116, 50);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "SELECT";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CANCELButton
            // 
            this.CANCELButton.Location = new System.Drawing.Point(205, 388);
            this.CANCELButton.Name = "CANCELButton";
            this.CANCELButton.Size = new System.Drawing.Size(112, 50);
            this.CANCELButton.TabIndex = 2;
            this.CANCELButton.Text = "CANCEL";
            this.CANCELButton.UseVisualStyleBackColor = true;
            this.CANCELButton.Click += new System.EventHandler(this.CANCELButton_Click);
            // 
            // FiletypeListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 450);
            this.Controls.Add(this.CANCELButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.checkedListBox);
            this.Name = "FiletypeListWindow";
            this.Text = "FiletypeListWindow";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CANCELButton;

        #endregion
    }
}