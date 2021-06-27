using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Homework_2_3
{
    public partial class EditFileForm : Form
    {
        Form1 form1 = new Form1();

        public EditFileForm(Form1 f1)
        {
            InitializeComponent();

            form1 = f1;

            textBox.Text = f1.GetTextBoxText();
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            form1.EditTextBox(textBox.Text);
            this.Close();
        }
    }
}
