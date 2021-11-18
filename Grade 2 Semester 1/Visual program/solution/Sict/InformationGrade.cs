using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Sict
{
    class InformationGrade
    {
        public string lessonCode { get; set; }
        public string lessonName { get; set; }
        public int lessonCredit { get; set; }

        public string teacherCode { get; set; }
        public string teacherName { get; set; }

        public int score { get; set; }
        public string letter { get; set; }
        public double scoreQuality { get; set; }
        public int scoreFromTeacher { get; set; }
        public int scoreFromExam { get; set; }

        public int studentID { get; set; }
        public int season { get; set; }
        public int dateview { get; set; }


        public InformationGrade(SqlDataReader reader)
        {
            build(reader);
        }

        private void build(SqlDataReader reader)
        {
            lessonCode = reader["CODE"].ToString();
            lessonName = reader["NAME"].ToString();
            lessonCredit = Convert.ToInt32(reader["CREDIT"].ToString());
            scoreFromTeacher = Convert.ToInt32(reader["TEACHERSCORE"].ToString());
            scoreFromExam = Convert.ToInt32(reader["EXAMSCORE"].ToString());
            score = Convert.ToInt32(reader["SCORE"].ToString());
            letter = Student.gradeToABC(score);
            scoreQuality = Student.gradeToGAP(score);
            teacherCode = reader["TEACHERCODE"].ToString();
            teacherName = reader["LASTNAME"].ToString().Substring(0, 1) + "." + reader["FIRSTNAME"].ToString();
            season = Convert.ToInt32(reader["SEASON"].ToString());
            dateview = Convert.ToInt32(reader["DATEVIEW"].ToString());
        }

    }

    class Student 
    {
        public int ID { get; set; }
        public string code { get; set; }
        public string surname { get; set; }
        public string lastname { get; set; }
        public string firstname { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string register { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string datebirth { get; set; }
        public int grade { get; set; }
        public string dateenrolled { get; set; }
        private string password { get; set; }
        public string major { get; set; }
        public string department { get; set; }
        public string image { get; set; }

        public ArrayList lesson;
        public ArrayList gpaSeason;
        public double GPA;
        public int totalCredit;

        SqlConnection sql;

        public Student(int ID)
        {
            try
            {
                sql = new SqlConnection("Data Source=BATSUKH\\SQLEXPRESS;Initial Catalog=Sict;Integrated Security=True");
                lesson = new ArrayList();
                gpaSeason = new ArrayList();
                GPA = 0;
                totalCredit = 0;
                this.ID = ID;
                build();
                gradeBuild();
                calculateCreditGPA();
                calculateSeasonGPA();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void build()
        {
            
            try
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand("EXEC BUILDSTUDENT '" + ID + "'", sql);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    code = reader["CODE"].ToString();
                    surname = reader["SURNAME"].ToString();
                    lastname = reader["LASTNAME"].ToString();
                    firstname = reader["FIRSTNAME"].ToString();
                    age = Convert.ToInt32(reader["AGE"].ToString());
                    gender = reader["GENDER"].ToString();
                    register = reader["REGISTER"].ToString();
                    phone = reader["PHONE"].ToString();
                    email = reader["EMAIL"].ToString();
                    datebirth = reader["DATEBIRTH"].ToString();
                    grade = Convert.ToInt32(reader["GRADE"].ToString());
                    dateenrolled = reader["DATEENROLLED"].ToString();
                    password = reader["PASSWORD"].ToString();
                    major = reader["MAJOR"].ToString();
                    department = reader["DEPARTMENT"].ToString();
                    image = reader["IMAGE"].ToString();
                    reader.Close();
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);   
            }
            finally
            {
                sql.Close();
            }
        }

        private void gradeBuild()
        {
            try
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand("EXEC BUILDGRADE '" + ID + "'", sql);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lesson.Add(new InformationGrade(reader));
                }

                reader.Close();
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                sql.Close();
            }
        }

        private void calculateCreditGPA()
        {
            int sum = 0;
            for (int i = 0; i < lesson.Count; i++)
            {
                sum += ((InformationGrade)lesson[i]).lessonCredit;
                GPA += (gradeToGAP(((InformationGrade)lesson[i]).score) * ((InformationGrade)lesson[i]).lessonCredit);
            }

            GPA /= sum;
            totalCredit = sum;
        }

        private void calculateSeasonGPA()
        {
            int minDate = date(1);
            int ssn = season(1, minDate);

            for (int j = 0; j < (date(2) - date(1) + 1) * 2; j++)
            {
                int credit = 0;
                double gpa = 0;

                for (int i = 0; i < lesson.Count; i++)
                {
                    if (((InformationGrade)lesson[i]).dateview == minDate && ((InformationGrade)lesson[i]).season == ssn)
                    {
                        credit += ((InformationGrade)lesson[i]).lessonCredit;
                        gpa += (gradeToGAP(((InformationGrade)lesson[i]).score) * ((InformationGrade)lesson[i]).lessonCredit);
                    }
                }

                gpa /= credit;
                string str = minDate + "-" + (minDate + 1) + " " + ssn; 
                gpaSeason.Add(new chartInfo(str, gpa));

                if (ssn == 1)
                    ssn++;
                else
                {
                    minDate++;
                    ssn--;
                }
                if (minDate > date(2) || (minDate == date(2) && ssn > season(2, minDate)))
                    return;
            }
        }

        public int season(int n, int date)
        {
            switch (n) 
            {
                // min
                case 1:
                    {
                        int season = 2;
                        for (int i = 0; i < lesson.Count; i++)
                        {
                            if (date == ((InformationGrade)lesson[i]).dateview && ((InformationGrade)lesson[i]).season < season)
                            {
                                season = ((InformationGrade)lesson[i]).season;
                            }
                        }
                        return season;
                    }
                // max
                case 2:
                    {
                        int season = 0;
                        for (int i = 0; i < lesson.Count; i++)
                        {
                            if (date == ((InformationGrade)lesson[i]).dateview && ((InformationGrade)lesson[i]).season > season)
                            {
                                season = ((InformationGrade)lesson[i]).season;
                            }
                        }
                        return season;
                    }
                default:
                    return 0;
            }
        }

        public int date(int n)
        {
            switch (n)
            {
                // min
                case 1:
                    {
                        int date = 9999;
                        for (int i = 0; i < lesson.Count; i++)
                        {
                            if (((InformationGrade)lesson[i]).dateview < date)
                            {
                                date = ((InformationGrade)lesson[i]).dateview;
                            }
                        }
                        return date;
                    }
                // max
                case 2:
                    {
                        int date = 0;
                        for (int i = 0; i < lesson.Count; i++)
                        {
                            if (((InformationGrade)lesson[i]).dateview > date)
                            {
                                date = ((InformationGrade)lesson[i]).dateview;
                            }
                        }
                        return date;
                    }
                default:
                    return 0;
            }
        }


        public static double gradeToGAP(int n)
        {
            if (96 <= n && n <= 100) return 4;
            else if (91 <= n && n <= 95) return 3.7;
            else if (88 <= n && n <= 90) return 3.4;
            else if (84 <= n && n <= 87) return 3.0;
            else if (81 <= n && n <= 83) return 2.7;
            else if (78 <= n && n <= 80) return 2.4;
            else if (74 <= n && n <= 77) return 2.0;
            else if (71 <= n && n <= 73) return 1.7;
            else if (68 <= n && n <= 70) return 1.3;
            else if (64 <= n && n <= 67) return 1.0;
            else if (60 <= n && n <= 63) return 0.7;
            else return 0;
        }
        public static string gradeToABC(int n)
        {
            if (96 <= n && n <= 100) return "A";
            else if (91 <= n && n <= 95) return "-A";
            else if (88 <= n && n <= 90) return "+B";
            else if (84 <= n && n <= 87) return "B";
            else if (81 <= n && n <= 83) return "-B";
            else if (78 <= n && n <= 80) return "+C";
            else if (74 <= n && n <= 77) return "C";
            else if (71 <= n && n <= 73) return "-C";
            else if (68 <= n && n <= 70) return "+D";
            else if (64 <= n && n <= 67) return "D";
            else if (60 <= n && n <= 63) return "D";
            else return "F";
        }
    }

    class chartInfo
    {
        public string season { get; set; }
        public double gpa { get; set; }

        public chartInfo(string season, double gpa)
        {
            this.season = season;
            this.gpa = gpa;
        }
    }
}

