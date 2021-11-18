using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class JuiceBarForm : Form
    {
        private decimal itemPriceDecimal, totalOrderDecimal, totalSalesDecimal;
        private int drinksInteger, ordersInteger;

        public JuiceBarForm()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Fruit(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            // Add the current item price and quantity to the order.
            if (noSizeRadioButton.Checked)
            {
                MessageBox.Show("You must select a drink size.", "Missing required entry");
            }
            else
            {
                try
                {
                    int quantityInteger = int.Parse(quantityTextBox.Text);
                    if (quantityInteger != 0)
                    {
                        drinksInteger += quantityInteger;
                        totalOrderDecimal += itemPriceDecimal * quantityInteger;
                        orderCompleteButton.Enabled = true;
                        // Reset defaults for next item.
                        noSizeRadioButton.Checked = true;
                        fruitJuiceRadioButton.Checked = true;
                        vitaminPackCheckBox.Checked = false;
                        energyBoosterCheckBox.Checked = false;
                        ladiesCheckBox.Checked = false;
                        itemPriceTextBox.Clear();
                        quantityTextBox.Text = "1";
                    }
                    else
                    {
                        MessageBox.Show("Please enter a quantity.", "Missing Required Entry");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid quantity.", "Data Entry Error");
                    quantityTextBox.Focus();
                    quantityTextBox.SelectAll();
                }
            }
        }

        private void orderCompleteButton_Click(object sender, EventArgs e)
        {
            // Order is complete, add to summary and clear order.
            // Check if the last item was added to the total.
            if (itemPriceTextBox.Text != "")
            {
                DialogResult responseDialogResult;
                string messageString = "Current Item not recorded. Add to order?";
                responseDialogResult = MessageBox.Show(messageString,
                "Verify Last Drink Purchase",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (responseDialogResult == DialogResult.Yes)
                {
                    addToOrderButton_Click(sender, e);
                }
            }
            // Display amount due.
            string dueString = "Amount Due " + totalOrderDecimal.ToString("C");
            MessageBox.Show(dueString, "Order Complete");
            // Add to summary totals.
            ordersInteger++;
            totalSalesDecimal += totalOrderDecimal;
            // Reset buttons and total for new order.
            summaryButton.Enabled = true;
            orderCompleteButton.Enabled = false;
            totalOrderDecimal = 0m;
        }

        private void quantityTextbox_Click(object sender, EventArgs e)
        {

        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            // Display the summary information in a message box.    
            string summaryString = "Drinks Sold: " + drinksInteger.ToString()
                + "\n\n" + "Number of Orders: "
                + ordersInteger.ToString()
                + "\n\n" + "Total Sales: "
                + totalSalesDecimal.ToString("C");
            MessageBox.Show(summaryString, "Juice Bar Sales Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            FoodForm objEmp = new FoodForm();
            objEmp.Show();
            this.Hide();
        }

        private void twelveOunceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Calculate and display the price for the selected item.
            // Handles all check boxes and radio buttons.
            int extrasInteger = 0;
            if (twelveOunceRadioButton.Checked)
            {
                itemPriceDecimal = 3m;
            }
            else if (sixteenOunceRadioButton.Checked)
            {
                itemPriceDecimal = 3.5m;
            }
            else if (twentyOunceRadioButton.Checked)
            {
                itemPriceDecimal = 4m;
            }
            extrasInteger = 0;
            if (vitaminPackCheckBox.Checked)
            {
                extrasInteger++;
            }
            if (energyBoosterCheckBox.Checked)
            {
                extrasInteger++;
            }
            if (ladiesCheckBox.Checked)
            {
                extrasInteger++;
            }
            itemPriceDecimal += extrasInteger * .5m; // 50 cents for each extra.
            itemPriceTextBox.Text = itemPriceDecimal.ToString("C");
        }
    }
}
