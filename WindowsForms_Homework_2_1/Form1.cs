using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Homework_2_1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            FindFileForm findFileForm = new FindFileForm(this);

            findFileForm.Show();

        }

        public void UpdateFoundListBox(List<FileInfo> files)
        {
            foundFilesListBox.Items.Clear();

            foreach (FileInfo f in files)
            {
                foundFilesListBox.Items.Add(f.Name);
            }
        }


    }
}
