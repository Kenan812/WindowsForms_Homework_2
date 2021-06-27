using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Homework_2_2
{
    public partial class EditForm : Form
    {
        List<Product> products = new List<Product>();

        public EditForm(List<Product> listOfProducts)
        {
            InitializeComponent();

            products = listOfProducts;

            PrepareEditForm();
        }

        private void PrepareEditForm()
        {
            foreach (Product item in products)
            {
                storeItemsListbox.Items.Add($"Name: {item.Name}  Description: {item.Description}  Price: {item.Price}");
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            GettingProductInfoForm gettingProductInfoForm = new GettingProductInfoForm(products);

            DialogResult d = gettingProductInfoForm.ShowDialog();

            if (d == DialogResult.OK)
                storeItemsListbox.Items.Add(products[products.Count - 1]);
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (storeItemsListbox.SelectedIndex >= 0 && storeItemsListbox.SelectedIndex <= storeItemsListbox.Items.Count)
                {
                    int selectedIndex = storeItemsListbox.SelectedIndex;

                    GettingProductInfoForm gettingProductInfoForm = new GettingProductInfoForm(products);

                    DialogResult d = gettingProductInfoForm.ShowDialog();

                    if (d == DialogResult.OK)
                    {
                        products.RemoveAt(selectedIndex);
                        storeItemsListbox.Items.RemoveAt(storeItemsListbox.SelectedIndex);
                        storeItemsListbox.Items.Insert(selectedIndex, $"Name: {products[products.Count - 1].Name}  Description: {products[products.Count - 1].Description}  Price: {products[products.Count - 1].Price}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Message: {ex.Message}\n\nStack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
