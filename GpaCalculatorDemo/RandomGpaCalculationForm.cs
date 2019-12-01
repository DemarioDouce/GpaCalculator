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
    public partial class RandomGpaCalculationForm : Form
    {
        GpaCalculator GpaCalculator;

        public RandomGpaCalculationForm(GpaCalculator parent)
        {
            InitializeComponent();
            GpaCalculator = parent;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will close down the GPA Calculator. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("The application has been closed successfully.", "Application Closed!", MessageBoxButtons.OK);
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                this.Activate();
            }
        }

        private void BtnCalculateGPA_Click(object sender, EventArgs e)
        {
            int CreditUnit1, CreditUnit2, CreditUnit3, CreditUnit4, CreditUnit5;
            int Score1, Score2, Score3, Score4, Score5;

            CreditUnit1 = int.Parse(TbxCu1.Text);
            CreditUnit2 = int.Parse(TbxCu2.Text);
            CreditUnit3 = int.Parse(TbxCu3.Text);
            CreditUnit4 = int.Parse(TbxCu4.Text);
            CreditUnit5 = int.Parse(TbxCu5.Text);

            Score1 = int.Parse(TbxS1.Text);
            Score2 = int.Parse(TbxS2.Text);
            Score3 = int.Parse(TbxS3.Text);
            Score4 = int.Parse(TbxS4.Text);
            Score5 = int.Parse(TbxS5.Text);

            int cpg = point(Score1) * CreditUnit1 + point(Score2) * CreditUnit2 + point(Score3) * CreditUnit3 + point(Score4) * CreditUnit4 + point(Score5) * CreditUnit5;
            int tu = CreditUnit1 + CreditUnit2 + CreditUnit3 + CreditUnit4 + CreditUnit5;

            int ggpa = cpg / tu;

            string grade1 = GPA(ggpa);

            LblGrade1.Text = Grade(Score1);
            LblGrade2.Text = Grade(Score2);
            LblGrade3.Text = Grade(Score3);
            LblGrade4.Text = Grade(Score4);
            LblGrade5.Text = Grade(Score5);

            LblPoint1.Text = Convert.ToString(point(Score1) * CreditUnit1);
            LblPoint2.Text = Convert.ToString(point(Score2) * CreditUnit2);
            LblPoint3.Text = Convert.ToString(point(Score3) * CreditUnit3);
            LblPoint4.Text = Convert.ToString(point(Score4) * CreditUnit4);
            LblPoint5.Text = Convert.ToString(point(Score5) * CreditUnit5);

            LblCuPo.Text = Convert.ToString(tu);
            LblGraPoAve.Text = Convert.ToString(ggpa);
            LblOvGrPo.Text = grade1;

        }

        int point(int mark)
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
            else if (mark >= 70 && mark < 80)
            {

                p = 4;
            }
            else if (mark >= 80 && mark <= 100)
            {

                p = 5;
            }

            return p;

        }

        string Grade(int mark)
        {

            string p = "";

            if (mark < 40)
            {
                p = "F";
            }
            else if (mark >= 40 && mark < 50)
            {

                p = "E";
            }
            else if (mark >= 50 && mark < 60)
            {

                p = "D";
            }
            else if (mark >= 60 && mark < 70)
            {

                p = "C";
            }
            else if (mark >= 70 && mark < 80)
            {

                p = "B";
            }
            else if (mark >= 80 && mark <= 100)
            {

                p = "A";
            }

            return p;
        }

        string GPA(int mark)
        {
            string p = "";

            if (mark >= 0 && mark < 2)
            {
                p = "FAIL";
            }
            else if (mark >= 2 && mark < 3)
            {

                p = "PASS";
            }
            else if (mark >= 3 && mark < 4)
            {

                p = "CREDIT";
            }
            else if (mark >= 4 && mark <= 5)
            {

                p = "DISTINCTION";
            }

            return p;
        }

        private void BtnClearCalculator_Click(object sender, EventArgs e)
        {
            TbxCc1.Clear();
            TbxCc2.Clear();
            TbxCc3.Clear();
            TbxCc4.Clear();
            TbxCc5.Clear();

            TbxCu1.Clear();
            TbxCu2.Clear();
            TbxCu3.Clear();
            TbxCu4.Clear();
            TbxCu5.Clear();

            TbxS1.Clear();
            TbxS2.Clear();
            TbxS3.Clear();
            TbxS4.Clear();
            TbxS5.Clear();

            LblGrade1.Text = "";
            LblGrade2.Text = "";
            LblGrade3.Text = "";
            LblGrade4.Text = "";
            LblGrade5.Text = "";

            LblPoint1.Text = "";
            LblPoint2.Text = "";
            LblPoint3.Text = "";
            LblPoint4.Text = "";
            LblPoint5.Text = "";

            LblCuPo.Text = "";
            LblGraPoAve.Text = "";
            LblOvGrPo.Text = "";


        }
    }
}
