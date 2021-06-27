namespace WindowsForms_Homework_2_2
{
    partial class EditForm
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
            this.storeItemsListbox = new System.Windows.Forms.ListBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // storeItemsListbox
            // 
            this.storeItemsListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeItemsListbox.FormattingEnabled = true;
            this.storeItemsListbox.ItemHeight = 20;
            this.storeItemsListbox.Location = new System.Drawing.Point(12, 12);
            this.storeItemsListbox.MultiColumn = true;
            this.storeItemsListbox.Name = "storeItemsListbox";
            this.storeItemsListbox.Size = new System.Drawing.Size(1240, 424);
            this.storeItemsListbox.TabIndex = 1;
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(12, 454);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(119, 50);
            this.addProductButton.TabIndex = 2;
            this.addProductButton.Text = "Add Product";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(361, 454);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(119, 50);
            this.returnButton.TabIndex = 3;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(186, 454);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(119, 50);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 516);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.storeItemsListbox);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox storeItemsListbox;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button editButton;
    }
}