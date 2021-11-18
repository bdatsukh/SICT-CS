using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{

    public partial class Form1 : Form
    {

        DataTable table = new DataTable();

        public Form1()
        {
            InitializeComponent();

            table.Columns.Add("Улс", typeof(string));
            table.Columns.Add("Хүн ам", typeof(long));
            table.Columns.Add("Тив", typeof(string));
        }

        Countries[] cc = new Countries[10];

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int ctr = 0; ctr < cc.Length; ctr++)
            {
                cc[ctr] = new Countries();
            }
            cc[0].Country = "Bangladesh";
            cc[0].Population = 156594962;
            cc[0].Continent = "Asia";
            cc[1].Country = "Brazil";
            cc[1].Population = 200361925;
            cc[1].Continent = "America";
            cc[2].Country = "China";
            cc[2].Population = 1357380000;
            cc[2].Continent = "Asia";
            cc[3].Country = "India";
            cc[3].Population = 1252139596;
            cc[3].Continent = "Asia";
            cc[4].Country = "Indonesia";
            cc[4].Population = 249865631;
            cc[4].Continent = "Asia";
            cc[5].Country = "Japan";
            cc[5].Population = 127338621;
            cc[5].Continent = "Asia";
            cc[6].Country = "Nigeria";
            cc[6].Population = 173615345;
            cc[6].Continent = "Africa";
            cc[7].Country = "Pakistan";
            cc[7].Population = 182142594;
            cc[7].Continent = "Asia";
            cc[8].Country = "Russian Federation";
            cc[8].Population = 143499861;
            cc[8].Continent = "Europe";
            cc[9].Country = "United States";
            cc[9].Population = 316128839;
            cc[9].Continent = "America";

            search();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    sortAsc();
                    break;
                case 1:
                    SortDes();
                    break;
                case 2:
                    max3();
                    break;
                default:
                    break;
            }

            total();
        }


        private void sortAsc()
        {
            var info = from i in cc orderby i.Population select i;
            table.Clear();
            foreach (var intr in info)
            {
                table.Rows.Add(intr.Country, intr.Population,
               intr.Continent);
            }
            dataGridView1.DataSource = table;
        }

        private void SortDes()
        {
            var info = from i in cc orderby i.Population descending select i;
            table.Clear();
            foreach (var intr in info)
            {
                table.Rows.Add(intr.Country, intr.Population,
                intr.Continent);
            }
            dataGridView1.DataSource = table;
        }

        private void max3()
        {
            var info = from i in cc orderby i.Population descending select i;
            table.Clear();

            int j = 0;
            foreach (var intr in info)
            {
                if (j == 3)
                    break;
                table.Rows.Add(intr.Country, intr.Population,
                intr.Continent);
                j++;
            }

            dataGridView1.DataSource = table;
        }

        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void total()
        {
            if (dataGridView1.Rows.Count <= 0)
                return;

            double sum = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Equals(dataGridView1.Rows[dataGridView1.Rows.Count - 1]))
                    break;

                sum += Convert.ToDouble(row.Cells[1].Value.ToString());
            }

            label.Text = sum.ToString();
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search();
            total();
        }

        private void search()
        {
            string str = textBox1.Text;

            var info = from i in cc where ((i.Country.ToLower().Contains(str.ToLower())) || (i.Continent.ToLower().Contains(str.ToLower())) || (i.Population.ToString().Contains(str))) select i;
            table.Clear();

            foreach (var intr in info)
            {
                table.Rows.Add(intr.Country, intr.Population,
                intr.Continent);
            }

            dataGridView1.DataSource = table;
        }
    }

    class Countries
    {
        public Countries()
        {
        }
        public Countries(string name, long population, string continent)
        {
            this.Country = name;
            this.Population = population;
            this.Continent = continent;
        }
        public string Country
        {
            get;
            set;
        }
        public long Population
        {
            get;
            set;
        }
        public string Continent
        {
            get;
            set;
        }
    }
}
