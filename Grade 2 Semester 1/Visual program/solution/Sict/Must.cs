using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sict
{
    public partial class Must : Form
    {
        static Student student;
        public static int ID = 0;
        public static int date, season;

        public Must()
        {
            InitializeComponent();
            student = new Student(ID);
            loadTabInfo();
            loadStudentInformation();
            loadDataGridViewMax();
            loadGraph();
        }

        private void loadGraph()
        {
            for (int i = 0; i < student.gpaSeason.Count; i++)
            {
                double gpa = ((chartInfo)student.gpaSeason[i]).gpa;
                string season = ((chartInfo)student.gpaSeason[i]).season;
                Color color = new Color();

                chart.Series["GPA"].Points.Add(gpa);

                if (gpa >= 2.8)
                    color = Color.Green;
                else
                    color = Color.Blue;

                chart.Series["GPA"].Points[i].Color = color;
                chart.Series["GPA"].Points[i].LabelForeColor = color;
                chart.Series["GPA"].Points[i].MarkerColor = color;
                chart.Series["GPA"].Points[i].AxisLabel = season;
                chart.Series["GPA"].Points[i].LegendText = season;
                chart.Series["GPA"].Points[i].Label = gpa.ToString("#.###");
            }
        }

        private void loadTabInfo()
        {
            labelSchool.Text = "МХТС";
            labelDepartment.Text = student.department;
            labelMajor.Text = student.major;
            labelCode.Text = student.code;
            labelName.Text = student.lastname.Substring(0, 1) + "." + student.firstname;
            labelRegister.Text = student.register;
            labelCredit.Text = student.totalCredit.ToString();
            labelGAP.Text = student.GPA.ToString("#.###");
            pictureBox1.Image = Image.FromFile(student.image);
        }
        
        private void loadStudentInformation()
        {
            labelStudentCode.Text = student.code;
            labelStudentSurname.Text = student.surname;
            labelStudentLastname.Text = student.lastname;
            labelStudentFirstname.Text = student.firstname;
            labelStudentAge.Text = student.age.ToString();
            labelStudentGender.Text = student.gender;
            labelStudentRegister.Text = student.register;
            labelStudentPhone.Text = student.phone;
            labelStudentEmail.Text = student.email;
            labelStudentDateBirth.Text = student.datebirth;
            labelStudentDateIn.Text = student.dateenrolled;
            labelStudentMajor.Text = student.major;
        }

        private void loadTabGrade()
        {
            for (int i = 0; i < student.lesson.Count; i++)
            {
                dataGridView1.Rows.Add();
            }
        }

        private void loadDataGridView(int date, int season)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < student.lesson.Count; i++)
            {
                if (((InformationGrade)student.lesson[i]).dateview == date && ((InformationGrade)student.lesson[i]).season == season)
                {
                    dataGridView1.Rows.Add(((InformationGrade)student.lesson[i]).lessonCode, ((InformationGrade)student.lesson[i]).lessonName, ((InformationGrade)student.lesson[i]).lessonCredit,
                        ((InformationGrade)student.lesson[i]).scoreFromTeacher, ((InformationGrade)student.lesson[i]).scoreFromExam, ((InformationGrade)student.lesson[i]).score,
                        ((InformationGrade)student.lesson[i]).letter, ((InformationGrade)student.lesson[i]).scoreQuality * ((InformationGrade)student.lesson[i]).lessonCredit,
                        ((InformationGrade)student.lesson[i]).teacherCode, ((InformationGrade)student.lesson[i]).teacherName);
                }
            }

            int credit = 0;
            double gpa = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                credit += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.ToString());
                gpa += Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value.ToString());
            }
            gpa /= credit;

            dataGridView1.Rows.Add( "", "Нийт кредит: ", credit, "", "", "", "Үн.Голч: ", gpa.ToString("#.###"), "", "");
            labelDateView.Text = date.ToString() + "-" + (date + 1).ToString() + "оны хичээлийн жил. " + season.ToString() + "-р улирал. ";
        }
        

        private void Must_Load(object sender, EventArgs e)
        {

        }

        private void Must_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Та хаягаасаа гарахдаа итгэлтэй байна уу?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }


        private void Must_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (MessageBox.Show("Та гарахдаа итгэлтэй байна уу?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
                Application.Exit();
            //}
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            loadDataGridViewMax();
        }

        private void loadDataGridViewMax()
        {
            date = student.date(2);
            season = student.season(2, date);

            loadDataGridView(date, season);
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            loadDataGridViewMin();   
        }

        private void loadDataGridViewMin()
        {
            date = student.date(1);
            season = student.season(1, date);

            loadDataGridView(date, season);
        }



        private void buttonBefore_Click(object sender, EventArgs e)
        {
            if (season == 2)
            {
                season--;
            }
            else
            {
                season++;
                date--;
            }

            if (date < student.date(1) || (date == student.date(1) && season < student.season(1, date)))
            {
                loadDataGridViewMax();
                return;
            }

            loadDataGridView(date, season);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            ForReport report = new ForReport();
            report.Show();
        }

        private void хэвлэхToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ForReport report = new ForReport();
            report.Show();
        }

        private void үнэлгээнийГолчХэвлэхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart.Printing.PrintPreview();
        }

        private void хувийнМэдээлэлХэвлэхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintInformation form = new PrintInformation();
            form.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAfter_Click(object sender, EventArgs e)
        {
            if (season == 1)
            {
                season++;
            }
            else
            {
                date++;
                season--;
            }

            if (date > student.date(2) || (date == student.date(2) && season > student.season(2, date)))
            {
                loadDataGridViewMin();
                return;
            }

            loadDataGridView(date, season);
        }
    }
}