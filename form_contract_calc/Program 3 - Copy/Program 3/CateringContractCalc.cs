//Program 3
//CIS 199-50
//Due Date: 11/9/2024
//By: Helen Le
//This program uses array sequential search, parallel arrays, and range matching
//to create a calculate that outputs the final price of a catering contract
//for a business's events. There are unique catering companies with unique discount rates,
//unique businesses with unique contract prices and unique contract times with
//additional discounts.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_3
{
    public partial class contractCalculatorForm : Form
    {
        public contractCalculatorForm()
        {
            InitializeComponent();
        }

        //When clicked,the user will receive the final price of the catering contract
        //based off of user input.
        private void calculateBtn_Click(object sender, EventArgs e)
        {
            string[] catererNames = { "Hill Catering Co.", "Food in a Flash", "Sally's Sandwiches", "Perry's Pierogis" }; //Array of names of catering companies
            double[] catererDiscounts = { .30, .20, .12, .05 }; //Array of discount rates based on catering company

            string[] businessNames = { "John's Books", "Office Supplies", "J.B. Car Parts", "Gevalia Coffee", "Ceylon Tea", "My Footwear" }; //Array of business names
            double[] contractPrices = { 500, 489, 412, 350, 325, 279 }; //Array of contract prices based on business names

            int[] contractYearsLowLimits = { 0, 2, 5, 8 }; //Array of contract years based on the low limits of ranges
            int[] additionalDiscounts = { 0, 30, 40, 50 }; //Array of additional discounts based on contract years

            int contractYears; //User's entered contract years
            int contractYearsDiscount = 0; //Additional discount based off of contract length
            double finalPrice; //Final price after discounts
            double catererDiscount = 0; //Discount rate based on caterer chosen
            double contractPrice = 0; //Contract price based on business chosen
            bool catererFound = false; //Checks if caterer was found in array
            bool businessFound = false; //Checks if business was found in array
            bool yearsFound = false; //Checks if contract years was found in array

            if (catererComboBox.SelectedIndex >= 0) //Ensures caterer is selected
            {
                if (businessComboBox.SelectedIndex >= 0) //Ensures business is selected
                {
                    if (int.TryParse(contractYearsTxt.Text, out contractYears) && contractYears >= 0) //Ensures contract years input is valid
                    {
                        for (int i = 0; i < catererNames.Length && !catererFound; i++) //Looks through array for selected caterer
                        {
                            if (catererComboBox.Text == catererNames[i])
                            {
                                catererFound = true;
                                catererDiscount = catererDiscounts[i]; //Sets caterer discount based on selected caterer
                            }
                        }

                        for (int i = 0; i < businessNames.Length && !businessFound; i++) //Looks through array for selected business
                        {
                            if (businessComboBox.Text == businessNames[i])
                            {
                                businessFound = true;
                                contractPrice = contractPrices[i]; //Sets contract price based on selected business
                            }
                        }

                        //FROM CLASS VIDEO and used to validate contract length entered
                        int sub = contractYearsLowLimits.Length - 1; //Initialized to be last index of contract years low limits array and used to find additional discount based on contract years
                        while (sub >= 0 && contractYears < contractYearsLowLimits[sub])
                        {
                            --sub;
                        }

                        if (sub >= 0) //Checks if valid discount was found
                        {
                            yearsFound = true;
                        }

                        if (yearsFound) //Calculates final price given that all criteria is valid
                        {
                            contractYearsDiscount = additionalDiscounts[sub]; //Sets contract years discount based on given years

                            if (catererFound && businessFound)
                            {
                                finalPrice = contractPrice - (contractPrice * catererDiscount) - contractYearsDiscount;
                                
                                finalPriceOutputLbl.Text = $"${finalPrice:F2}"; //Final price output
                            }

                        }
                    }
                    else //Displays if invalid contract years
                    {
                        MessageBox.Show("Please provide valid contract years"); 
                    }
                    
                } 
                else //Displays if invalid business
                {
                    MessageBox.Show("Please select a business");
                }
            }
            else //Displays if invalid caterer
            {
                MessageBox.Show("Please select a caterer");
            }
        }
    }
}