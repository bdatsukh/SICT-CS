using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textFlightNum.Clear();
            textName.Clear();
            textPass.Clear();
            listBoxFrom.ClearSelected();
            listBoxTo.ClearSelected();
            listBox.ClearSelected();
            checkedListBox1.ClearSelected();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.GetItemChecked(0) && checkedListBox1.GetItemChecked (1))
            {
                MessageBox.Show("Shaa"); 
                return;
            }

            if (listBoxFrom.SelectedIndex.Equals(-1) || listBoxTo.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Очих эсвэл явах чиглэл сонгоогүй байна. Сонгон уу!");
                return;
            }

            if (listBoxFrom.SelectedItem.Equals(listBoxTo.SelectedItem))
            {
                MessageBox.Show("Очих чиглэл, явах чиглэл ижил байна. Засна уу!");
            }
            else
            {
                MessageBox.Show("Таны нислэг амжилттай бүртгэгдлээ");
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
