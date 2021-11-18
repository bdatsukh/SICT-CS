using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FoodForm : Form
    {
        string food = "Хоол: ", desert = "Зууш: ", sale = "Хямдрал: "; 
        int countFood = 0, countDesert = 0;
        float amount = 0;

        public FoodForm()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void FoodForm_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(food + "\n" + desert + "\nДүн: " + amount);
            food = "";
            desert = "";
            amount = 0;
            countFood = 0;
            countDesert = 0;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FoodForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            foodFunc(checkBoxTsuivan, (comboBoxTsuivan.SelectedIndex.Equals(0)) ? labelTsuivan : labelTsuivanHagas, textBoxTsuivan);
            foodFunc(checkBoxTeptel, (comboBoxTeptel.SelectedIndex.Equals(0)) ? labelTeptel : labelTeptelHagas, textBoxTeptel);
            foodFunc(checkBoxGul, (comboBoxGul.SelectedIndex.Equals(0)) ? labelGul : labelGulHagas, textBoxGul);
            foodFunc(checkBoxHar, (comboBoxHar.SelectedIndex.Equals(0)) ? labelHar : labelHarHagas, textBoxHar);
            foodFunc(checkBoxBituu, (comboBoxBituu.SelectedIndex.Equals(0)) ? labelBituu : labelBituuHagas, textBoxBituu);

            desertFunc(checkBoxNiislel, labelNiislel, textBoxNiislel);
            desertFunc(checkBoxBaitsaa, labelBaitsaa, textBoxBaitsaa);
            desertFunc(checkBoxLuuvan, labelLuuvan, textBoxLuuvan);

            saleFunc();

            MessageBox.Show("Дүн: " + amount);
        }

        public void foodFunc(CheckBox check, Label label, TextBox textBox)
        {
            if (check.Checked)
            {
                food += (" " + check.Text);
                amount += (float)(Convert.ToInt32(label.Text) * Convert.ToInt32(textBox.Text));
                countFood += Convert.ToInt32(textBox.Text);
            }

            check.Checked = false;
            textBox.Text = "";
        }

        public void desertFunc(CheckBox check, Label label, TextBox textBox)
        {
            if (check.Checked)
            {
                desert += (" " + check.Text);
                amount += (float)(Convert.ToInt32(label.Text) * Convert.ToInt32(textBox.Text));
                countDesert += Convert.ToInt32(textBox.Text);
            }

            check.Checked = false;
            textBox.Text = "";
        }

        public void saleFunc()
        {
            float percent;

            if (amount >= 100000)
            {
                percent = 0.90f;
            }
            else if (countFood >=2 && countDesert >= 2) 
            {
                percent = 0.95f;
            }
            else if (countFood >= 2 && countDesert == 1)
            {
                percent = 0.97f;
            }
            else
            {
                percent = 0.0f;
            }

            amount *= percent;
        }
    }
}
