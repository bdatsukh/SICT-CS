using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Windows.Forms.VisualStyles;

namespace Lab7
{
    public partial class Form1 : Form
    {
        Regex rx = new Regex("^([a-zA-Z]{1,20})$");
        ErrorProvider errorProvider = new ErrorProvider();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker.Value.ToString("yyyy");
            int nas = 2020 - Int32.Parse(date);
            int d = Int32.Parse(textBoxDate.Text);
            if (16 <= nas && nas <= 20)
            {
                if (2018 <= d && d <= 2020)
                {
                    double onoo = Int32.Parse(textBoxMat.Text) * 0.7 + Int32.Parse(textBoxPhysics.Text) * 0.3;
                    if (onoo >= 550)
                    {
                        MessageBox.Show("Суралцах эрх авж болно.");
                    }
                    else
                    {
                        MessageBox.Show("Эеш-ийн оноо хүрэхгүй байна.");
                    }
                }
                else
                {
                    MessageBox.Show("Эеш-ийн оноо хүчингүй байна.");
                }
            }
            else
            {
                MessageBox.Show("Таны нас хүрэхгүй байна.");
            }
        }

        private void textBoxCode_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^([bB]{1})([0-9]{9})$");

            if (!regex.IsMatch(textBoxCode.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textBoxCode, "Оюутны код буруу байна!!!");
            }
        }

        private void textBoxCode_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxCode, "");
        }

        private void nonvld(TextBox textBox)
        {
            errorProvider.SetError(textBox, "");
        }

        private void vld(CancelEventArgs e, TextBox textBox)
        {
            string errorMsg = "Зөвхөн нэр оруулна уу!!!";

            if (!rx.IsMatch(textBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textBox, errorMsg);
            }
        }

        private void textBoxUrag_Validated(object sender, EventArgs e)
        {
            nonvld(textBoxUrag);
        }

        private void textBoxUrag_Validating(object sender, CancelEventArgs e)
        {
            vld(e, textBoxUrag);
        }

        private void textBoxOvog_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOvog_Validating(object sender, CancelEventArgs e)
        {
            vld(e, textBoxOvog);
        }

        private void textBoxOvog_Validated(object sender, EventArgs e)
        {
            nonvld(textBoxOvog);
        }

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            vld(e, textBoxName);
        }

        private void textBoxName_Validated(object sender, EventArgs e)
        {
            nonvld(textBoxName);
        }

        private void textBoxSchool_Validating(object sender, CancelEventArgs e)
        {
            vld(e, textBoxSchool);
        }

        private void textBoxSchool_Validated(object sender, EventArgs e)
        {
            nonvld(textBoxSchool);
        }

        private void textBoxFrom_Validating(object sender, CancelEventArgs e)
        {
            vld(e, textBoxFrom);
        }

        private void textBoxFrom_Validated(object sender, EventArgs e)
        {
            nonvld(textBoxFrom);
        }

        private void textBoxMat_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[0-9]{3}$");

            if (regex.IsMatch(textBoxMat.Text) && 200 <= Int32.Parse(textBoxMat.Text) && Int32.Parse(textBoxMat.Text) >= 800)
            {
                string errorMsg = "Эеш-ийн оноо буруу байна!!!";
                e.Cancel = true;
                errorProvider.SetError(textBoxMat, errorMsg);
            }
        }

        private void textBoxMat_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxMat, "");
        }

        private void textBoxPhysics_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[0-9]{3}$");

            if (regex.IsMatch(textBoxPhysics.Text) && 200 <= Int32.Parse(textBoxPhysics.Text) && Int32.Parse(textBoxPhysics.Text) >= 800)
            {
                string errorMsg = "Эеш-ийн оноо буруу байна!!!";
                e.Cancel = true;
                errorProvider.SetError(textBoxPhysics, errorMsg);
            }
        }

        private void textBoxPhysics_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxPhysics, "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker.Value.ToString());
        }
    }
}
