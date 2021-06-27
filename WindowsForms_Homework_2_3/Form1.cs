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

namespace WindowsForms_Homework_2_3
{
    public partial class Form1 : Form
    {
        Text text = new Text();
        
        public Form1()
        {
            InitializeComponent();

            textBox.Enabled = false;
            editFileButton.Enabled = false;
        }

        private void loadFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = string.Empty;
            openFileDialog.Filter = "All files(*.*) |*.*|Text files(*.txt) |*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFileDialog.FileName);
                textBox.Text = streamReader.ReadToEnd();
                text.Message = textBox.Text;
                streamReader.Close();
            }

            editFileButton.Enabled = true;
        }

        private void editFileButton_Click(object sender, EventArgs e)
        {

            EditFileForm editFileForm = new EditFileForm(this);

            editFileForm.Show();
        }

        public void EditTextBox(string text)
        {
            textBox.Text = text;
        }

        public string GetTextBoxText()
        {
            return textBox.Text;
        }
    }
}
