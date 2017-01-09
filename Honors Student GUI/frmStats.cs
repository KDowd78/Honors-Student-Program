using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Honors_Student_GUI
{
    public partial class frmStats : Form
    {
        public frmStats()
        {
            InitializeComponent();
        }

        private HonorsStudentDictionary studentDictionary = new HonorsStudentDictionary();
        private HonorsStudentWrite studentWrite = new HonorsStudentWrite();

        private int numMale;
        private int numFemale;
        private int numRaceWhite;
        private int numRaceHispanic;
        private int numRaceBlack;
        private int numRaceAsian;
        private int numFinancialAidYes;
        private int numFinancialAidNo;
        private int numAcademicStandingGood;
        private int numAcademicStandingBad;
        private int numFirstGenYes;
        private int numFirstGenNo;
        private double overallGPAAverage;
        private double readScoreAverage;
        private double mathScoreAverage;
        private int ageAverage;
        private int studentCount = 0;

        private void frmStats_Load(object sender, EventArgs e)
        {

            studentWrite.ReadFile(studentDictionary);

            AccumulateValues();

            SetGenderGraph();
            SetRaceGraph();
            SetFinancialAidGraph();
            SetAcademicStandingGraph();
            SetFirstGenGraph();

            overallGPAAverage = Math.Truncate(overallGPAAverage * 100) / 100;
            readScoreAverage = Math.Truncate(readScoreAverage * 100) / 100;
            mathScoreAverage = Math.Truncate(mathScoreAverage * 100) / 100;

            txtAverageOverallGPA.Text = overallGPAAverage.ToString();
            txtAverageRead.Text = readScoreAverage.ToString();
            txtAverageMath.Text = mathScoreAverage.ToString();
            txtAverageAge.Text = ageAverage.ToString();
            txtNumberofStudents.Text = studentCount.ToString();
        }

        public void SetGenderGraph()
        {
            chartGenderBar.Series["Gender"].IsVisibleInLegend = false;
            chartGenderBar.Series["Gender"].IsValueShownAsLabel = true;
            chartGenderBar.ChartAreas[0].AxisY.Maximum = 100;
            chartGenderBar.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chartGenderBar.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chartGenderBar.Series["Gender"].LabelForeColor = ColorTranslator.FromHtml("#000000");
            chartGenderBar.Series["Gender"].Points.AddXY("Male", numMale);
            chartGenderBar.Series["Gender"].Points.AddXY("Female", numFemale);

            chartGenderPie.Series["Gender"].Points.AddXY("Male", numMale);
            chartGenderPie.Series["Gender"].Points.AddXY("Female", numFemale);
        }

        public void SetRaceGraph()
        {
            chartRaceBar.Series["Race"].IsVisibleInLegend = false;
            chartRaceBar.Series["Race"].IsValueShownAsLabel = true;
            chartRaceBar.ChartAreas[0].AxisY.Maximum = 100;
            chartRaceBar.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chartRaceBar.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chartRaceBar.Series["Race"].Points.AddXY("White", numRaceWhite);
            chartRaceBar.Series["Race"].Points.AddXY("Hispanic", numRaceHispanic);
            chartRaceBar.Series["Race"].Points.AddXY("Black", numRaceBlack);
            chartRaceBar.Series["Race"].Points.AddXY("Asian", numRaceAsian);

            chartRacePie.Series["Race"].Points.AddXY("White", numRaceWhite);
            chartRacePie.Series["Race"].Points.AddXY("Hispanic", numRaceHispanic);
            chartRacePie.Series["Race"].Points.AddXY("Black", numRaceBlack);
            chartRacePie.Series["Race"].Points.AddXY("Asian", numRaceAsian);
        }

        public void SetFinancialAidGraph()
        {
            chartFinancialAidBar.Series["FinancialAid"].IsVisibleInLegend = false;
            chartFinancialAidBar.Series["FinancialAid"].IsValueShownAsLabel = true;
            chartFinancialAidBar.ChartAreas[0].AxisY.Maximum = 100;
            chartFinancialAidBar.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chartFinancialAidBar.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chartFinancialAidBar.Series["FinancialAid"].Points.AddXY("Yes", numFinancialAidYes);
            chartFinancialAidBar.Series["FinancialAid"].Points.AddXY("No", numFinancialAidNo);

            chartFinancialAidPie.Series["FinancialAid"].Points.AddXY("Yes", numFinancialAidYes);
            chartFinancialAidPie.Series["FinancialAid"].Points.AddXY("No", numFinancialAidNo);
        }

        public void SetAcademicStandingGraph()
        {
            chartAcademicStandingBar.Series["AcademicStanding"].IsVisibleInLegend = false;
            chartAcademicStandingBar.Series["AcademicStanding"].IsValueShownAsLabel = true;
            chartAcademicStandingBar.ChartAreas[0].AxisY.Maximum = 100;
            chartAcademicStandingBar.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chartAcademicStandingBar.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chartAcademicStandingBar.Series["AcademicStanding"].Points.AddXY("Good", numAcademicStandingGood);
            chartAcademicStandingBar.Series["AcademicStanding"].Points.AddXY("Bad", numAcademicStandingBad);

            chartAcademicStandingPie.Series["AcademicStanding"].Points.AddXY("Good", numAcademicStandingGood);
            chartAcademicStandingPie.Series["AcademicStanding"].Points.AddXY("Bad", numAcademicStandingBad);
        }

        public void SetFirstGenGraph()
        {
            chartFirstGenerationBar.Series["FirstGenStudent"].IsVisibleInLegend = false;
            chartFirstGenerationBar.Series["FirstGenStudent"].IsValueShownAsLabel = true;
            chartFirstGenerationBar.ChartAreas[0].AxisY.Maximum = 100;
            chartFirstGenerationBar.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chartFirstGenerationBar.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chartFirstGenerationBar.Series["FirstGenStudent"].Points.AddXY("Yes", numFirstGenYes);
            chartFirstGenerationBar.Series["FirstGenStudent"].Points.AddXY("No", numFirstGenNo);

            chartFirstGenerationPie.Series["FirstGenStudent"].Points.AddXY("Yes", numFirstGenYes);
            chartFirstGenerationPie.Series["FirstGenStudent"].Points.AddXY("No", numFirstGenNo);
        }

        public void AccumulateValues()
        {
            double totalOverallGPA = 0;
            double totalReadScore = 0;
            double totalMathScore = 0;
            int totalAge = 0;

            foreach (HonorsStudent student in studentDictionary.AllStudents)
            {
                if (student.GPAoverall != String.Empty)
                {
                    totalOverallGPA += Convert.ToDouble(student.GPAoverall);
                }

                if (student.readScore != String.Empty)
                {
                    totalReadScore += Convert.ToDouble(student.readScore);
                }

                if (student.mathScore != String.Empty)
                {
                    totalMathScore += Convert.ToDouble(student.mathScore);
                }

                if (student.age != String.Empty)
                {
                    totalAge += Convert.ToInt16(student.age);
                }

                if (student.gender == "Male")
                {
                    numMale++;
                }
                else if (student.gender == "Female")
                {
                    numFemale++;
                }

                if (student.race == "White")
                {
                    numRaceWhite++;
                } 
                else if (student.race == "Asian") 
                {
                    numRaceAsian++;
                }
                else if (student.race == "Hispanic")
                {
                    numRaceHispanic++;
                }
                else if (student.race == "Black")
                {
                    numRaceBlack++;
                }

                if (student.financialAid == "Yes")
                {
                    numFinancialAidYes++;
                }
                else if (student.financialAid == "No")
                {
                    numFinancialAidNo++;
                }

                if (student.academicStanding == "Good Academic Standing")
                {
                    numAcademicStandingGood++;
                }
                else if (student.academicStanding == "Bad Academic Standing")
                {
                    numAcademicStandingBad++;
                }

                if (student.firstGen == "Yes")
                {
                    numFirstGenYes++;
                }
                else if (student.firstGen == "No")
                {
                    numFirstGenNo++;
                }

                studentCount++;
            }

            if (totalOverallGPA > 0)
            {
                overallGPAAverage = totalOverallGPA / studentCount;
            }

            if (totalReadScore > 0)
            {
                readScoreAverage = totalReadScore / studentCount;
            }

            if (totalMathScore > 0)
            {
                mathScoreAverage = totalMathScore / studentCount;
            }

            if (totalAge > 0)
            {
                ageAverage = totalAge / studentCount;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
