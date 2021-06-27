namespace WindowsForms_Homework_2_1
{
    partial class Form1
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
            this.foundFilesListBox = new System.Windows.Forms.ListBox();
            this.findButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // foundFilesListBox
            // 
            this.foundFilesListBox.FormattingEnabled = true;
            this.foundFilesListBox.ItemHeight = 20;
            this.foundFilesListBox.Location = new System.Drawing.Point(49, 36);
            this.foundFilesListBox.Name = "foundFilesListBox";
            this.foundFilesListBox.Size = new System.Drawing.Size(252, 324);
            this.foundFilesListBox.TabIndex = 0;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(372, 50);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(127, 52);
            this.findButton.TabIndex = 1;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.foundFilesListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox foundFilesListBox;
        private System.Windows.Forms.Button findButton;
    }
}

