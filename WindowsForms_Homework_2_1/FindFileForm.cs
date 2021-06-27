using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsForms_Homework_2_1
{
    public partial class FindFileForm : Form
    {
        Form1 form1 = new Form1();

        public FindFileForm(Form1 f)
        {
            InitializeComponent();

            form1 = f;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo d = new DirectoryInfo(folderPathTextBox.Text);

                List<FileInfo> files = d.GetFiles(maskTextBox.Text).ToList();

                form1.UpdateFoundListBox(files);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Message: {ex.Message}\n\nStack Trace{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
