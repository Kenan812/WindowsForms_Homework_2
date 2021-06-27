using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsForms_Homework_2_2
{
    public partial class Form1 : Form
    {
        public List<Product> products = new List<Product>();

        EditForm editForm;

        public Form1()
        {
            products.Add(new Product("NVIDIA® GeForce RTX 3070", "Upto NVIDIA® GeForce RTX™ 3070 8GB GDDR6", 1000));
            products.Add(new Product("SSD 512GB", "SSD 512GB", 1500));
            products.Add(new Product("HDD 2TB", "HDD 2TB", 1000));
            products.Add(new Product("Intel® Core™ i7", "11th Generation Intel® Core™ i7 11800H (8-Core, 24MB L3 Cache, up to 4.6GHz with Turbo Boost)", 1000));
            products.Add(new Product("Intel® Core™ i9", "11th Generation Intel® Core™ i9 11800H (8-Core, 24MB L3 Cache, up to 4.6GHz with Turbo Boost)", 1500));

            InitializeComponent();

            AddProducts();

            priceTextBox.Enabled = false;
            totalPriceTextBox.Enabled = false;

        }

        private void AddProducts()
        {
            foreach (Product item in products)
            {
                productsListBox.Items.Add(item.Name);
            }
        }

        private void productsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productsListBox.SelectedIndex >= 0 && productsListBox.SelectedIndex < productsListBox.Items.Count)
                priceTextBox.Text = products[productsListBox.SelectedIndex].Price.ToString();

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (productsListBox.SelectedItem != null)
                {
                    selectedProductsListBox.Items.Add(productsListBox.SelectedItem);


                    foreach (Product p in products)
                    {
                        if (p.Name == productsListBox.SelectedItem.ToString())
                            totalPriceTextBox.Text = (Int32.Parse(totalPriceTextBox.Text) + p.Price).ToString();
                    }


                    priceTextBox.Text = "0";


                    for (int i = 0; i < products.Count; i++)
                    {
                        if (products[i].Name == productsListBox.SelectedItem.ToString())
                            products.RemoveAt(i);
                    }

                    productsListBox.Items.RemoveAt(productsListBox.SelectedIndex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Message: {ex.Message}\n\nStack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void payButton_Click(object sender, EventArgs e)
        {
            totalPriceTextBox.Text = "0";

            selectedProductsListBox.Items.Clear();
        }


        private void editButton_Click(object sender, EventArgs e)
        {
            editForm = new EditForm(products);
            editForm.ShowDialog();

            productsListBox.Items.Clear();

            foreach (Product p in products)
            {
                productsListBox.Items.Add(p.Name);
            }
        }
    }
}
