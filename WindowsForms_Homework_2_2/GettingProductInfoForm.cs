using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsForms_Homework_2_2
{
    public partial class GettingProductInfoForm : Form
    {
        List<Product> listOfProducts;
        Product p;

        public GettingProductInfoForm(List<Product> products)
        {
            InitializeComponent();

            listOfProducts = products;
            p = null;
        }

        public GettingProductInfoForm(Product product)
        {
            InitializeComponent();

            p = product;
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (listOfProducts != null)
                {
                    Product newProduct = new Product();

                    if (priceTextBox.Text != String.Empty)
                        newProduct.Price = Int32.Parse(priceTextBox.Text);

                    if (nameTextBox.Text != String.Empty)
                        newProduct.Name = nameTextBox.Text;

                    if (descriptionTextBox.Text != String.Empty)
                        newProduct.Description = descriptionTextBox.Text;

                    listOfProducts.Add(newProduct);
                }
                else if (p != null)
                {
                    if (priceTextBox.Text != String.Empty)
                        p.Price = Int32.Parse(priceTextBox.Text);

                    if (nameTextBox.Text != String.Empty)
                        p.Name = nameTextBox.Text;

                    if (descriptionTextBox.Text != String.Empty)
                        p.Description = descriptionTextBox.Text;
                }


                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Message: {ex.Message}\n\nStack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.No;
                this.Close();
            }

        }
    }
}
