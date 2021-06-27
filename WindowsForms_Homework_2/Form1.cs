using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Homework_2
{
    public partial class Form1 : Form
    {
        private double hotDogTotalCost = 0;
        private double hamburgerTotalCost = 0;
        private double frenchFriesTotalCost = 0;
        private double cocaColaTotalCost = 0;

        public double DailyIncome { get; set; }

        Timer timer = new Timer();

        bool dateOrTime = false;
        Timer changeDateAndTime = new Timer();


        public Form1()
        {
            InitializeComponent();

            DailyIncome = 0;
            timer.Tick += ShowDialogBox;

            colorPanel.Visible = false;
            colorPanel.Enabled = false;

            PrepareProgram();
        }


        void ShowDialogBox(object sender, EventArgs e)
        {
            timer.Stop();
            DialogResult dialogResult = MessageBox.Show("Ready to pay?", "Clear Form", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                DailyIncome += Double.Parse(clientTotalCostTextBox.Text);
                PrepareProgram();
                timer.Stop();
            }
            else
            {
                timer.Start();
            }
        }


        private void PrepareProgram()
        {
            #region Refuelling

            petrolPricePerLitrTextBox.Enabled = false;

            totalRefuellingCostTextBox.Enabled = false;
            totalRefuellingCostTextBox.Text = "0.00";


            lirtesInputTextBox.Enabled = false;
            costInputTextBox.Enabled = false;

            lirtesInputTextBox.Text = String.Empty;
            costInputTextBox.Text = String.Empty;


            petrolChoiceComboBox.SelectedItem = petrolChoiceComboBox.Items[0];
            petrolPricePerLitrTextBox.Text = "1.00";


            litresInputRadioButton.Checked = false;
            costInputRadioButton.Checked = false;

            #endregion


            #region Mini Cafe

            hotDogCheckBox.Checked = false;
            hamburgerCheckBox.Checked = false;
            frenchFriesCheckBox.Checked = false;
            cocaColaCheckBox.Checked = false;

            totalFoodCostTextBox.Enabled = false;

            hotDogPriceTextBox.Text = "4.00";
            hamburgerPriceTextBox.Text = "5.40";
            frenchFriesPriceTextBox.Text = "7.20";
            cocaColaPriceTextBox.Text = "4.40";

            hotDogPriceTextBox.Enabled = false;
            hamburgerPriceTextBox.Enabled = false;
            frenchFriesPriceTextBox.Enabled = false;
            cocaColaPriceTextBox.Enabled = false;


            hotDogCountTextBox.Text = String.Empty;
            hamburgerCountTextBox.Text = String.Empty;
            frenchFriesCountTextBox.Text = String.Empty;
            cocaColaCountTextBox.Text = String.Empty;

            hotDogCountTextBox.Enabled = false;
            hamburgerCountTextBox.Enabled = false;
            frenchFriesCountTextBox.Enabled = false;
            cocaColaCountTextBox.Enabled = false;

            #endregion


            #region Total Cost

            clientTotalCostTextBox.Text = "0.00";

            #endregion


            #region StatusStrip

            changeDateAndTime.Tick += dateAndTimeStatusLabel_ChangeText;
            changeDateAndTime.Interval = 2000;
            changeDateAndTime.Start();

            helloToolStripMenuItem.Text = DateTime.Now.DayOfWeek.ToString();

            #endregion

        }


        #region Refuelling


        private void litresInputRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (litresInputRadioButton.Checked == true)
            {
                lirtesInputTextBox.Enabled = true;
                lirtesInputTextBox.Text = "10.00";

                costInputTextBox.Enabled = false;
                costInputTextBox.Text = String.Empty;
            }
        }

        private void costInputRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (costInputRadioButton.Checked == true)
            {
                costInputTextBox.Enabled = true;
                costInputTextBox.Text = "10.00";

                lirtesInputTextBox.Enabled = false;
                lirtesInputTextBox.Text = String.Empty;
            }
        }

        private void petrolChoiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (petrolChoiceComboBox.SelectedItem.ToString() == "AI 92")
                petrolPricePerLitrTextBox.Text = "1.00";
            else if (petrolChoiceComboBox.SelectedItem.ToString() == "AI 96(Premium)")
                petrolPricePerLitrTextBox.Text = "1.40";
            else if (petrolChoiceComboBox.SelectedItem.ToString() == "E-15")
                petrolPricePerLitrTextBox.Text = "1.80";
            else if (petrolChoiceComboBox.SelectedItem.ToString() == "Diesel")
                petrolPricePerLitrTextBox.Text = "0.80";
        }

        private void lirtesInputTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double refuellingCost = Double.Parse(lirtesInputTextBox.Text) * Double.Parse(petrolPricePerLitrTextBox.Text);

                totalRefuellingCostTextBox.Text = refuellingCost.ToString();
            }
            catch (Exception)
            { }
        }

        private void costInputTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double refuellingCost = Double.Parse(costInputTextBox.Text);

                totalRefuellingCostTextBox.Text = costInputTextBox.Text;
            }
            catch (Exception)
            { }
        }


        #endregion



        #region Mini Cafe


        private void hotDogCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                hotDogCountTextBox.Enabled = !hotDogCountTextBox.Enabled;

                if (hotDogCountTextBox.Enabled == false && hotDogCountTextBox.Text != String.Empty)
                {
                    hotDogCountTextBox.Text = String.Empty;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show($"Message: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show($"Stack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hotDogCountTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                totalFoodCostTextBox.Text = (Double.Parse(totalFoodCostTextBox.Text) - hotDogTotalCost).ToString();

                double foodCost = Double.Parse(totalFoodCostTextBox.Text);


                if (hotDogCountTextBox.Text != String.Empty)
                {
                    hotDogTotalCost = Double.Parse(hotDogCountTextBox.Text) * Double.Parse(hotDogPriceTextBox.Text);
                    foodCost += hotDogTotalCost;
                }

                else
                {
                    hotDogTotalCost = 0;
                }


                if (foodCost == 0)
                    totalFoodCostTextBox.Text = "0.00";
                else
                    totalFoodCostTextBox.Text = foodCost.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Message: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show($"Stack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hamburgerCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                hamburgerCountTextBox.Enabled = !hamburgerCountTextBox.Enabled;

                if (hamburgerCountTextBox.Enabled == false && hamburgerCountTextBox.Text != String.Empty)
                {
                    hamburgerCountTextBox.Text = String.Empty;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show($"Message: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show($"Stack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hamburgerCountTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                totalFoodCostTextBox.Text = (Double.Parse(totalFoodCostTextBox.Text) - hamburgerTotalCost).ToString();

                double foodCost = Double.Parse(totalFoodCostTextBox.Text);


                if (hamburgerCountTextBox.Text != String.Empty)
                {
                    hamburgerTotalCost = Double.Parse(hamburgerCountTextBox.Text) * Double.Parse(hamburgerPriceTextBox.Text);
                    foodCost += hamburgerTotalCost;
                }

                else
                {
                    hamburgerTotalCost = 0;
                }

                foodCost = Math.Round(foodCost, 2);

                if (foodCost == 0)
                    totalFoodCostTextBox.Text = "0.00";
                else
                    totalFoodCostTextBox.Text = foodCost.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Message: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show($"Stack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frenchFriesCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                frenchFriesCountTextBox.Enabled = !frenchFriesCountTextBox.Enabled;

                if (frenchFriesCountTextBox.Enabled == false && frenchFriesCountTextBox.Text != String.Empty)
                {
                    frenchFriesCountTextBox.Text = String.Empty;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show($"Message: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show($"Stack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frenchFriesCountTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                totalFoodCostTextBox.Text = (Double.Parse(totalFoodCostTextBox.Text) - frenchFriesTotalCost).ToString();

                double foodCost = Double.Parse(totalFoodCostTextBox.Text);


                if (frenchFriesCountTextBox.Text != String.Empty)
                {
                    frenchFriesTotalCost = Double.Parse(frenchFriesCountTextBox.Text) * Double.Parse(frenchFriesPriceTextBox.Text);
                    foodCost += frenchFriesTotalCost;
                }

                else
                {
                    frenchFriesTotalCost = 0;
                }

                foodCost = Math.Round(foodCost, 2);

                if (foodCost == 0)
                    totalFoodCostTextBox.Text = "0.00";
                else
                    totalFoodCostTextBox.Text = foodCost.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Message: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show($"Stack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cocaColaCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                cocaColaCountTextBox.Enabled = !cocaColaCountTextBox.Enabled;

                if (cocaColaCountTextBox.Enabled == false && cocaColaCountTextBox.Text != String.Empty)
                {
                    cocaColaCountTextBox.Text = String.Empty;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show($"Message: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show($"Stack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cocaColaCountTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                totalFoodCostTextBox.Text = (Double.Parse(totalFoodCostTextBox.Text) - cocaColaTotalCost).ToString();

                double foodCost = Double.Parse(totalFoodCostTextBox.Text);


                if (cocaColaCountTextBox.Text != String.Empty)
                {
                    cocaColaTotalCost = Double.Parse(cocaColaCountTextBox.Text) * Double.Parse(cocaColaPriceTextBox.Text);
                    foodCost += cocaColaTotalCost;
                }

                else
                {
                    cocaColaTotalCost = 0;
                }

                foodCost = Math.Round(foodCost, 2);

                if (foodCost == 0)
                    totalFoodCostTextBox.Text = "0.00";
                else
                    totalFoodCostTextBox.Text = foodCost.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Message: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show($"Stack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion



        #region Total Cost


        private void countTotalPriceButton_Click(object sender, EventArgs e)
        {
            if (totalRefuellingCostTextBox.Text != "0.00" || totalFoodCostTextBox.Text != "0.00")
                clientTotalCostTextBox.Text = (Double.Parse(totalRefuellingCostTextBox.Text) + Double.Parse(totalFoodCostTextBox.Text)).ToString();
        }

        private void clientTotalCostTextBox_TextChanged(object sender, EventArgs e)
        {
            timer.Interval = 3000;
            timer.Start();
        }


        #endregion



        #region Date And Time

        private void dateAndTimeStatusLabel_ChangeText(object sender, EventArgs e)
        {
            if (dateOrTime)
            {
                dateAndTimeStatusLabel.Text = $"{DateTime.Now.Date.Day}/{DateTime.Now.Date.Month}/{DateTime.Now.Date.Year}";
                dateOrTime = !dateOrTime;
            }
            else
            {
                dateAndTimeStatusLabel.Text = $"{DateTime.Now.TimeOfDay.Hours}:{DateTime.Now.TimeOfDay.Minutes}:{DateTime.Now.TimeOfDay.Seconds}";
                dateOrTime = !dateOrTime;
            }
        }

        #endregion



        #region Settings

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorPanel.Visible = true;
            colorPanel.Enabled = true;
        }

        private void saveColorButton_Click(object sender, EventArgs e)
        {
            colorPanel.Visible = false;
            colorPanel.Enabled = false;
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(redTrackBar.Value * 25, greenTrackBar.Value * 25, blueTrackBar.Value * 25);
        }

        #endregion


        #region Change Language


        private void SetLocalization(string lang)
        {
            settingsToolStripMenuItem.Text = Resource1.ResourceManager.GetString(lang + "_settings");
            changeColorToolStripMenuItem.Text = Resource1.ResourceManager.GetString(lang + "_changeColor");
            RefuellingGroupBox.Text = Resource1.ResourceManager.GetString(lang + "_refuelling");
            label1.Text = Resource1.ResourceManager.GetString(lang + "_petrol");
            litresInputRadioButton.Text = Resource1.ResourceManager.GetString(lang + "_amount");
            costInputRadioButton.Text = Resource1.ResourceManager.GetString(lang + "_cost");
            GasolineCostGroupBox.Text = Resource1.ResourceManager.GetString(lang + "_cost");
            MiniCafeGroupBox.Text = Resource1.ResourceManager.GetString(lang + "_cost");
            label5.Text = Resource1.ResourceManager.GetString(lang + "_l");
            MiniCafeGroupBox.Text = Resource1.ResourceManager.GetString(lang + "_miniCafe");
            hotDogCheckBox.Text = Resource1.ResourceManager.GetString(lang + "_hotDog");
            hamburgerCheckBox.Text = Resource1.ResourceManager.GetString(lang + "_hamburger");
            frenchFriesCheckBox.Text = Resource1.ResourceManager.GetString(lang + "_frenchFries");
            cocaColaCheckBox.Text = Resource1.ResourceManager.GetString(lang + "_cocaCola");
            label7.Text = Resource1.ResourceManager.GetString(lang + "_price");
            label9.Text = Resource1.ResourceManager.GetString(lang + "_count");
            TotalCostGroupBox.Text = Resource1.ResourceManager.GetString(lang + "_totalCost");
            countTotalPriceButton.Text = Resource1.ResourceManager.GetString(lang + "_countTotalPrice");
            russianToolStripMenuItem.Text = Resource1.ResourceManager.GetString(lang + "_russian");
            englishToolStripMenuItem.Text = Resource1.ResourceManager.GetString(lang + "_english");
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetLocalization("en");
        }

        private void russianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetLocalization("ru");
        }


        #endregion


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show($"Today's income: {DailyIncome}", "Income", MessageBoxButtons.OK);
        }


    }
}
