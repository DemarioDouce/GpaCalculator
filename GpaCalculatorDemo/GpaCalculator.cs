using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GpaCalculatorDemo
{
    public partial class GpaCalculator : Form
    {
        int RdoSemester;
        string ChkCampus;
        double GpaTotal;

        List<StudentDataClass> students = StudentDataClass.GetStudents();
        public GpaCalculator()
        {
            InitializeComponent();
            InitGui();
        }


        void InitGui()
        {
            SplashScreen Splashform = new SplashScreen();
            Splashform.ShowDialog();
            DgrdStudents.DataSource = students;
            CboFil.DataSource = new List<String>() { "All Students", "Semester 1 Students", "Semester 2 Students", "Semester 3 Students", "Semester 4 Students","Main Campus Students", "Other Campus Students", "Credits Less Than 4", "GPA & Credits Less Than 4" };
        }

        private void BtnAddRec_Click(object sender, EventArgs e)
        {
            GpaTotal = Convert.ToDouble(TbxCourse1.Text)  + Convert.ToDouble(TbxCourse2.Text)  + Convert.ToDouble(TbxCourse3.Text)  + Convert.ToDouble(TbxCourse4.Text)  / Convert.ToDouble(TbxCredits.Text);
           


            StudentDataClass NewStudent = new StudentDataClass(TbxFName.Text, TbxLName.Text, Convert.ToInt32(TbxStuId.Text), RdoSemester, ChkCampus, Convert.ToDouble(TbxCourse1.Text),
            Convert.ToDouble(TbxCourse2.Text), Convert.ToDouble(TbxCourse3.Text), Convert.ToDouble(TbxCourse4.Text), Convert.ToDouble(TbxCredits.Text), point(GpaTotal));

            
            students.Add(NewStudent);

            
            DgrdStudents.DataSource = null;

            DgrdStudents.DataSource = students;


            double point(double mark)
            {
                int p = 0;

                if (mark < 40)
                {
                    p = 0;
                }
                else if (mark >= 40 && mark < 50)
                {

                    p = 1;
                }
                else if (mark >= 50 && mark < 60)
                {

                    p = 2;
                }
                else if (mark >= 60 && mark < 70)
                {

                    p = 3;
                }
                else if (mark >= 70 && mark < 100000)
                {

                    p = 4;
                }

                return p;

            }

        }

        private void Rdo1_CheckedChanged(object sender, EventArgs e)
        {
            RdoSemester = 1;
        }

        private void Rdo2_CheckedChanged(object sender, EventArgs e)
        {
            RdoSemester = 2;
        }

        private void Rdo3_CheckedChanged(object sender, EventArgs e)
        {
            RdoSemester = 3;
        }

        private void Rdo4_CheckedChanged(object sender, EventArgs e)
        {
            RdoSemester = 4;
        }

        private void ChkMain_CheckedChanged(object sender, EventArgs e)
        {
            ChkCampus = "Main";
        }

        private void ChkOther_CheckedChanged(object sender, EventArgs e)
        {
            ChkCampus = "Other";
        }

        private void BtnClrInp_Click(object sender, EventArgs e)
        {
            TbxFName.Clear();
            TbxLName.Clear();
            TbxStuId.Clear();
            TbxCourse1.Clear();
            TbxCourse2.Clear();
            TbxCourse3.Clear();
            TbxCourse4.Clear();
            TbxCredits.Clear();
            Rdo1.Checked = false;
            Rdo2.Checked = false;
            Rdo3.Checked = false;
            Rdo4.Checked = false;
            ChkMain.Checked = false;
            ChkOther.Checked = false;

        }

        private void CboFil_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CboFil.Text)
            {
                case "All Students":
                    DgrdStudents.DataSource = null;
                    DgrdStudents.DataSource = students;
                    break;

                case "Semester 1 Students":
                    var qu1 = from s in students where s.Semester == 1 select s;
                    DgrdStudents.DataSource = qu1.ToList();
                    break;

                case "Semester 2 Students":
                    var qu2 = from s in students where s.Semester == 2 select s;
                    DgrdStudents.DataSource = qu2.ToList();
                    break;

                case "Semester 3 Students":
                    var qu3 = from s in students where s.Semester == 3 select s;
                    DgrdStudents.DataSource = qu3.ToList();
                    break;

                case "Semester 4 Students":
                    var qu4 = from s in students where s.Semester == 4 select s;
                    DgrdStudents.DataSource = qu4.ToList();
                    break;

                case "Main Campus Students":
                    var qu5 = from s in students where s.Campus == "Main" select s;
                    DgrdStudents.DataSource = qu5.ToList();
                    break;

                case "Other Campus Students":
                    var qu6 = from s in students where s.Campus == "Other" select s;
                    DgrdStudents.DataSource = qu6.ToList();
                    break;

                case "Credits Less Than 4":
                    var qu7 = from s in students where s.Credits < 4 select s;
                    DgrdStudents.DataSource = qu7.ToList();
                    break;

                case "GPA & Credits Less Than 4":
                    var qu8 = from s in students where s.Credits < 4 && s.GPA < 4 select s;
                    DgrdStudents.DataSource = qu8.ToList();
                    break;

                    

            }
        }

        private void BtnDelRec_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].FirstName == TbxFName.Text)
                {
                    students.Remove(students[i]);
                }
            }

            DgrdStudents.DataSource = null;

            DgrdStudents.DataSource = students;
        }

        private void BtnRanGpaCal_Click(object sender, EventArgs e)
        {
            RandomGpaCalculationForm form = new RandomGpaCalculationForm(this);
            form.Show();
        }


    }
}
