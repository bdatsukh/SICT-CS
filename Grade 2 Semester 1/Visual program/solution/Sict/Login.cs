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
using System.Data.SqlClient;
using System.Threading;

namespace Sict
{
    public partial class Login : Form
    {
        SqlConnection sql;

        public Login()
        {
            InitializeComponent();
            try
            {
                sql = new SqlConnection("Data Source=BATSUKH\\SQLEXPRESS;Initial Catalog=Sict;Integrated Security=True");
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }
       
        bool b = true;
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[bB]{1}[0-9]{9}$");
            if (regex.IsMatch(textBoxUsername.Text))
            {
                sql.Open();

                SqlCommand cmd = new SqlCommand("SELECT PASSWORD, ID FROM STUDENT WHERE CODE = '"+textBoxUsername.Text+"'", sql);
                SqlDataReader reader = cmd.ExecuteReader();
                   
                if (reader.Read() && textBoxPassword.Text.Equals(reader["PASSWORD"].ToString()))
                {
                    Must.ID = Convert.ToInt32(reader["ID"].ToString());
                    reader.Close();
                    sql.Close();
                    Must form = new Must();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    labelText.ForeColor = b ? Color.FromArgb(8, 21, 232) : Color.Red;
                    b = !b;
                    sql.Close();
                    labelText.Text = "Оюутны код эсвэл нууц үг буруу байна.";
                }
            }
            else
            {
                labelText.ForeColor = b ? Color.FromArgb(8, 21, 232) : Color.Red;
                b = !b;
                labelText.Text = "Оюутны код буруу байна.";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
