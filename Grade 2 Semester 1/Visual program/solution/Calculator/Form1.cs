using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double currTotal = 0.0;
        bool cbInReplace = false;
        string lastOperation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreateValue(string strCurrNum)
        {
            if (textValue.Text.Equals("0"))
                textValue.Text = "";
                                                                                    
            textValue.Text += strCurrNum;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            CreateValue("5");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            CreateValue("8");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            CreateValue("7");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            CreateValue("3");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            CreateValue("2");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            CreateValue("1");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            CreateValue("6");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            CreateValue("9");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            CreateValue("4");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            CreateValue("0");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            currTotal = Convert.ToDouble(textValue.Text);
            cbInReplace = true;
            lastOperation = "+";
            label.Text = String.Format("{0:0.#####}", currTotal);
            label.Text += lastOperation;
            textValue.Text = null;
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            currTotal = Convert.ToDouble(textValue.Text);
            cbInReplace = true;
            lastOperation = "-";
            label.Text = String.Format("{0:0.#####}", currTotal);
            label.Text += lastOperation;
            textValue.Text = null;
        }

        private void btnMulptiple_Click(object sender, EventArgs e)
        {
            currTotal = Convert.ToDouble(textValue.Text);
            cbInReplace = true;
            lastOperation = "*";
            label.Text = String.Format("{0:0.#####}", currTotal);
            label.Text += lastOperation;
            textValue.Text = null;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            currTotal = Convert.ToDouble(textValue.Text);
            cbInReplace = true;
            lastOperation = "/";
            label.Text = textValue.Text + " " + lastOperation;
            label.Text = String.Format("{0:0.#####}", currTotal);
            label.Text += lastOperation;
            textValue.Text = null;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
                switch (lastOperation)
                {
                    case "+":
                        currTotal += Convert.ToDouble(textValue.Text);
                        textValue.Text = currTotal.ToString();
                        break;
                    case "-":
                        currTotal -= Convert.ToDouble(textValue.Text);
                        textValue.Text = currTotal.ToString();
                        break;
                    case "/":
                        currTotal /= Convert.ToDouble(textValue.Text);
                        textValue.Text = currTotal.ToString();
                    break;
                    case "*":
                        currTotal *= Convert.ToDouble(textValue.Text);
                        textValue.Text = currTotal.ToString();
                        break;
                    default:
                        break;
                }

            label.Text = null;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textValue.Text = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textValue.Text = "0";
            double cdblCurrTotal = 0.0;
            bool cbInReplace = false;
            string lastOperation = "";
            label.Text = null;
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            if (!textValue.Text.Contains("."))
            {
                textValue.Text = textValue.Text + ".";
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            textValue.Text = Math.Sqrt(Convert.ToDouble(textValue.Text)).ToString();
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (!textValue.Text.Equals(""))
            {
                textValue.Text = textValue.Text.Substring(0, textValue.Text.Length - 1);
            }
        }

        private void btnMemoryClear_Click(object sender, EventArgs e)
        {

        }

        private void btnMemoryRecall_Click(object sender, EventArgs e)
        {

        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (!textValue.Text.Equals("") && !textValue.Text.Equals("0"))
            {
                if(textValue.Text.Substring(0, 1).Equals("-"))
                {
                    textValue.Text = textValue.Text.Substring(1, textValue.Text.Length - 1);
                }
                else
                {
                    textValue.Text = "-" + textValue.Text;
                }
            }
        }

        private void btnOneOverX_Click(object sender, EventArgs e)
        {
            textValue.Text = (1.0 / Convert.ToDouble(textValue.Text)).ToString();
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            //textValue.Text = ().ToString();
        }
    }
}