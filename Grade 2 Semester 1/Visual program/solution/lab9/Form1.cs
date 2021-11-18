using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace lab9
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("server=BATSUKH\\SQLEXPRESS; Integrated Security=SSPI; database=edu;");


        public Form1()
        {
            InitializeComponent();
            
        }

        public void refreshData()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * from DBO.STUDENT", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["SID"].ToString(), reader["CODE"].ToString(), 
                                        reader["LASTNAME"].ToString(), reader["FIRSTNAME"].ToString(),
                                        reader["GENDER"].ToString(), reader["ADDRESS"].ToString(),
                                        reader["BIRTHDATE"].ToString());
            }

            //dataGridView1.Sort();

            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonBefore_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Selected == true)
                {
                    if (i == 0)
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
                    else
                        dataGridView1.Rows[i - 1].Selected = true;
                    break;
                }
            }
        }

        private int searchStudent()
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM STUDENT WHERE CODE = '"+textBoxCode.Text+"'", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            int result = -1;

            if (reader.Read())
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    if (reader["CODE"].ToString().Equals(textBoxCode.Text))
                        result = i;

            conn.Close();

            return result;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (!textBoxCode.Text.Equals(null))
            {
                int result = searchStudent();
                if (result != -1)
                    dataGridView1.Rows[result].Selected = true;
                else
                    MessageBox.Show("tanii haisan oyutan oldsongui");
            }
            else
            {
                MessageBox.Show("Code oo oruulna uu");
            }
        }

        private void buttonAfter_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Selected == true)
                {
                    if (i + 1 == dataGridView1.Rows.Count)
                        dataGridView1.Rows[0].Selected = true;
                    else
                        dataGridView1.Rows[i + 1].Selected = true;
                    break;
                }
            }
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Selected = true;
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxCode_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^([bB]{1})([0-9]{9})$");
            string errorMsg = "Зөвхөн нэр оруулна уу!!!";

            if (!regex.IsMatch(textBoxCode.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textBoxCode, errorMsg);
            }
        }

        Regex rx = new Regex("^([a-zA-Z]{1,20})$");
        ErrorProvider errorProvider = new ErrorProvider();

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

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLastName_Validating(object sender, CancelEventArgs e)
        {
            vld(e, textBoxLastName);
        }

        private void textBoxLastName_Validated(object sender, EventArgs e)
        {
            nonvld(textBoxLastName);
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxFirstName_Validated(object sender, EventArgs e)
        {
            nonvld(textBoxFirstName);
        }

        private void textBoxFirstName_Validating(object sender, CancelEventArgs e)
        {
            vld(e, textBoxFirstName);
        }

        private void textBoxFrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = null;
            textBoxFirstName.Text = null;
            textBoxLastName.Text = null;
            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;
            textBoxFrom.Text = null;
        }

        private void updateStudent()
        {
            conn.Open();

            string str = "UPDATE STUDENT SET " +
                "FIRSTNAME = '" + textBoxFirstName.Text.ToUpper() + "', " +
                "LASTNAME = '" + textBoxLastName.Text.ToUpper() + "', " +
                "GENDER = '" + ((radioButtonMale.Checked) ? "EREGTEI" : "EMEGTEI") + "', " +
                "ADDRESS = '" + textBoxFrom.Text.ToUpper() + "', " +
                "BIRTHDATE = '" + dateTimePicker.Value.ToString("yyyy/MM/dd") + "'" +
                "WHERE CODE = '"+textBoxCode.Text+"'";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int result = searchStudent();
            if (result != -1)
            {
                if (textBoxCode.Text != "" && textBoxFirstName.Text != "" && textBoxLastName.Text != ""
                    && textBoxFrom.Text != "" && textBoxFrom.Text != ""
                    && (radioButtonFemale.Checked || radioButtonMale.Checked))
                {
                    updateStudent();
                    MessageBox.Show("Amjilttai shinclegdlee");
                    refreshData();
                    buttonDelete_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Oyutan burtgelgui baina");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int index = -1;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                if (dataGridView1.Rows[i].Selected)
                    index = i;

            if (index == -1)
                return;

            textBoxCode.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            textBoxFirstName.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            textBoxLastName.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();

            if (dataGridView1.Rows[index].Cells[4].Value.ToString().CompareTo("EREGTEI") == 1)
                radioButtonMale.Checked = true;
            else
                radioButtonFemale.Checked = true;
            
            textBoxFrom.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
            dateTimePicker.Value = Convert.ToDateTime(dataGridView1.Rows[index].Cells[6].Value.ToString());
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void insertStudent()
        {
            conn.Open();
           
            string str = "INSERT INTO STUDENT VALUES('"+textBoxFirstName.Text.ToUpper()+"', '"+textBoxLastName.Text.ToUpper()+"', " +
                "'"+((radioButtonMale.Checked) ? "EREGTEI" : "EMEGTEI")+"', '"+textBoxFrom.Text.ToUpper()+"', " +
                "'"+textBoxCode.Text.ToUpper()+"', '"+dateTimePicker.Value.ToString("yyyy/MM/dd")+"')";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            int result = searchStudent();
            if (result == -1)
            {
                if(textBoxCode.Text != "" && textBoxFirstName.Text != "" && textBoxLastName.Text != ""
                    && textBoxFrom.Text != "" && textBoxFrom.Text != ""
                    && (radioButtonFemale.Checked || radioButtonMale.Checked))
                {
                    insertStudent();
                    MessageBox.Show("Amjilttai nemegdlee");
                    refreshData();
                    buttonDelete_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Ene oyutan burtgeltei baina");
            }
        }

        private void deleteFromStudent()
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM STUDENT WHERE CODE = '"+textBoxCode.Text+"'", conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxCode.Text != "")
            {
                if (searchStudent() != -1)
                {
                    deleteFromStudent();
                    refreshData();
                    MessageBox.Show("Amjilltai ustlaa");
                    buttonDelete_Click(sender, e);
                }
                else
                    MessageBox.Show("Oyutan oldsongui");
            }
            else
                MessageBox.Show("Ustgah oyutaniihaa code iig oruulna uu");
        }
    }
}
