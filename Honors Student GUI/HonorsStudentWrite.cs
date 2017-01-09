using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Honors_Student_GUI
{
    public class HonorsStudentWrite
    {
        public void ReadFile(HonorsStudentDictionary studentDictionary)
        {
            StreamReader infile;
            char delimiter = ',';
            string line;
            string[] fields = new string[22];

            if (File.Exists("honorsstudentfile.csv"))
            {
                infile = File.OpenText("honorsstudentfile.csv");
                while (!infile.EndOfStream)
                {
                    line = infile.ReadLine();
                    fields = line.Split(delimiter);
                    HonorsStudent student = new HonorsStudent();
                    student.ccriID = fields[0];
                    student.name = fields[1];
                    student.termHours = fields[2];
                    student.race = fields[3];
                    student.GPAint = fields[4];
                    student.GPAoverall = fields[5];
                    student.age = fields[6];
                    student.gender = fields[7];
                    student.firstGen = fields[8];
                    student.financialAid = fields[9];
                    student.readScore = fields[10];
                    student.readTestDate = fields[11];
                    student.mathScore = fields[12];
                    student.mathTestDate = fields[13];
                    student.academicStanding = fields[14];
                    student.major = fields[15];
                    student.courseID = fields[16];
                    student.courseTitle = fields[17];
                    student.grade = fields[18];
                    student.instructor = fields[19];
                    student.department = fields[20];
                    student.term = fields[21];
                    studentDictionary.AddStudent(student);
                }
                infile.Close();
            }
        }

        public void ReadLoadedFile(HonorsStudentDictionary studentDictionary, StreamReader file)
        {
            StreamReader infile = file;

            char delimiter = ',';
            string line;
            string[] fields;

            string id;
            bool exists = false;
            int dupeCounter = 0;

            while (!infile.EndOfStream)
            {
                line = infile.ReadLine();
                fields = line.Split(delimiter);
                foreach (HonorsStudent aStudent in studentDictionary.AllStudents)
                {
                    id = aStudent.ccriID;
                    if (fields[0] == aStudent.ccriID)
                    {
                        exists = true;
                    }
                }

                if (exists != true)
                {
                    HonorsStudent student = new HonorsStudent();
                    student.ccriID = fields[0];
                    student.name = fields[1];
                    student.termHours = fields[2];
                    student.race = fields[3];
                    student.GPAint = fields[4];
                    student.GPAoverall = fields[5];
                    student.age = fields[6];
                    student.gender = fields[7];
                    student.firstGen = fields[8];
                    student.financialAid = fields[9];
                    student.readScore = fields[10];
                    student.readTestDate = fields[11];
                    student.mathScore = fields[12];
                    student.mathTestDate = fields[13];
                    student.academicStanding = fields[14];
                    student.major = fields[15];
                    student.courseID = fields[16];
                    student.courseTitle = fields[17];
                    student.grade = fields[18];
                    student.instructor = fields[19];
                    student.department = fields[20];
                    if (fields.Length == 21)
                    {
                        student.term = string.Empty;
                    }
                    else if (fields.Length == 22)
                    {
                        student.term = fields[21];
                    }
                    studentDictionary.AddStudent(student);
                }
                else
                {
                    dupeCounter++;
                }

                exists = false;
            }

            if (dupeCounter > 0)
            {
                frmMain.showDupeNum(dupeCounter);
            }

            infile.Close();
        }

        public void WriteFile(HonorsStudentDictionary studentDict)
        {
            StreamWriter outfile;
            outfile = File.CreateText("honorsstudentfile.csv");
            foreach (HonorsStudent student in studentDict.AllStudents)
            {
                outfile.Write(student.ccriID);
                outfile.Write(",");
                outfile.Write(student.name);
                outfile.Write(",");
                outfile.Write(student.termHours);
                outfile.Write(",");
                outfile.Write(student.race);
                outfile.Write(",");
                outfile.Write(student.GPAint);
                outfile.Write(",");
                outfile.Write(student.GPAoverall);
                outfile.Write(",");
                outfile.Write(student.age);
                outfile.Write(",");
                outfile.Write(student.gender);
                outfile.Write(",");
                outfile.Write(student.firstGen);
                outfile.Write(",");
                outfile.Write(student.financialAid);
                outfile.Write(",");
                outfile.Write(student.readScore);
                outfile.Write(",");
                outfile.Write(student.readTestDate);
                outfile.Write(",");
                outfile.Write(student.mathScore);
                outfile.Write(",");
                outfile.Write(student.mathTestDate);
                outfile.Write(",");
                outfile.Write(student.academicStanding);
                outfile.Write(",");
                outfile.Write(student.major);
                outfile.Write(",");
                outfile.Write(student.courseID);
                outfile.Write(",");
                outfile.Write(student.courseTitle);
                outfile.Write(",");
                outfile.Write(student.grade);
                outfile.Write(",");
                outfile.Write(student.instructor);
                outfile.Write(",");
                outfile.Write(student.department);
                outfile.Write(",");
                outfile.Write(student.term);
                outfile.WriteLine();
            }
            outfile.Close();
        }
    }
}
