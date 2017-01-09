using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace Honors_Student_GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private HonorsStudentDictionary studentDictionary = new HonorsStudentDictionary();
        private HonorsStudentWrite studentWrite = new HonorsStudentWrite();
        private bool addingStudent = false;
        private bool changesMade = false;
        private bool loadedFile = false;

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnSaveChanges.Enabled = false;
            studentWrite.ReadFile(studentDictionary);
            FillCombo();
            DeactivateUI();
            btnSaveStudent.Enabled = false;
            btnCancel.Enabled = false;

            txtAge.ShortcutsEnabled = false;
            txtGPAinst.ShortcutsEnabled = false;
            txtGPAoverall.ShortcutsEnabled = false;
            txtTermHours.ShortcutsEnabled = false;
            txtReadScore.ShortcutsEnabled = false;
            txtMathScore.ShortcutsEnabled = false;
            dtpMathDate.Enabled = false;
            dtpReadDate.Enabled = false;
            chkMathDate.Enabled = false;
            chkReadDate.Enabled = false;
        }

        public static void showDupeNum(int dupes)
        {
            MessageBox.Show("Number of duplicate entries: " + dupes, "Duplicates");
        }

        private void FillCombo()
        {
            cboCCID.Items.Clear();
            foreach (HonorsStudent student in studentDictionary.AllStudents)
            {
                cboCCID.Items.Add(student.ccriID);
                cboCCID.Text = student.ccriID;
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            ActivateUI();
            ClearFields();
            btnSaveStudent.Enabled = true;
            btnCancel.Enabled = true;
            addingStudent = true;
            btnAddStudent.Enabled = false;
            btnRemoveStudent.Enabled = false;
            btnLoadFile.Enabled = false;
        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            if (addingStudent == true)
            {
                try
                {
                    btnRemoveStudent.Text = "Remove Student";
                    if (cboCCID.Text != string.Empty || txtName.Text != string.Empty)
                    {
                        DateTime readDate = dtpReadDate.Value;
                        DateTime mathDate = dtpMathDate.Value;

                        HonorsStudent newStudent = new HonorsStudent();
                        newStudent.ccriID = cboCCID.Text;
                        newStudent.name = txtName.Text;
                        newStudent.age = txtAge.Text;

                        if (cboRace.Text != "N/A")
                        {
                            newStudent.race = cboRace.Text;
                        }
                        else
                        {
                            newStudent.race = String.Empty;
                        }

                        if (cboGender.Text != "N/A")
                        {
                            newStudent.gender = cboGender.Text;
                        }
                        else
                        {
                            newStudent.gender = String.Empty;
                        }

                        if (cboFinancialAid.Text != "N/A")
                        {
                            newStudent.financialAid = cboFinancialAid.Text;
                        }
                        else
                        {
                            newStudent.financialAid = String.Empty;
                        }

                        if (cboFirstGen.Text != "N/A")
                        {
                            newStudent.firstGen = cboFirstGen.Text;
                        }
                        else
                        {
                            newStudent.firstGen = String.Empty;
                        }

                        if (cboAcademicStanding.Text != "N/A")
                        {
                            newStudent.academicStanding = cboAcademicStanding.Text;
                        }
                        else
                        {
                            newStudent.academicStanding = String.Empty;
                        }

                        newStudent.GPAint = txtGPAinst.Text;
                        newStudent.GPAoverall = txtGPAoverall.Text;
                        newStudent.termHours = txtTermHours.Text;
                        newStudent.readScore = txtReadScore.Text;
                        if (chkReadDate.Checked)
                        {
                            newStudent.readTestDate = readDate.ToString("MM/dd/yyyy");
                        }
                        else
                        {
                            newStudent.readTestDate = String.Empty;
                        }
                        newStudent.mathScore = txtMathScore.Text;
                        if (chkMathDate.Checked)
                        {
                            newStudent.mathTestDate = mathDate.ToString("MM/dd/yyyy");
                        }
                        else
                        {
                            newStudent.mathTestDate = String.Empty;
                        }
                        newStudent.major = txtMajor.Text;
                        newStudent.instructor = txtInstructor.Text;
                        newStudent.department = txtDepartment.Text;
                        newStudent.courseTitle = txtCourseTitle.Text;
                        newStudent.courseID = txtCourseID.Text;
                        newStudent.grade = txtGrade.Text;
                        newStudent.term = txtTerm.Text;

                        studentDictionary.AddStudent(newStudent);
                        FillCombo();
                        ClearFields();
                        DeactivateUI();

                        btnAddStudent.Text = "Add Student";

                        btnAddStudent.Enabled = true;
                        btnSaveStudent.Enabled = false;
                        btnRemoveStudent.Enabled = true;
                        btnCancel.Enabled = false;

                        btnSaveChanges.Enabled = true;
                        FillCombo();
                        btnAddStudent.Enabled = true;
                        btnLoadFile.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Missing Name or CCRI ID", "Error");
                    }
                }
                catch
                {
                    MessageBox.Show("Duplicate Entry", "Error");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
            DeactivateUI();
            FillCombo();
            btnCancel.Enabled = false;
            btnSaveStudent.Enabled = false;
            btnAddStudent.Enabled = true;
            btnRemoveStudent.Enabled = true;
            btnLoadFile.Enabled = true;
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            DialogResult dlgResults;
            dlgResults = MessageBox.Show("Remove " + txtName.Text + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dlgResults == System.Windows.Forms.DialogResult.Yes)
            {
                studentDictionary.RemoveStudent(cboCCID.Text);
                ClearFields();
                FillCombo();
                changesMade = true;
                btnSaveChanges.Enabled = true;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnSaveChanges.Enabled)
            {
                DialogResult dlgResults;
                dlgResults = MessageBox.Show("Changes have not been saved, would you like to save them?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dlgResults == DialogResult.No)
                {
                    
                }
                else if (dlgResults == DialogResult.Yes)
                {
                    studentWrite.WriteFile(studentDictionary);
                }
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cboCCID_SelectedIndexChanged(object sender, EventArgs e)
        {
            HonorsStudent student;
            student = studentDictionary.FindStudentByID(cboCCID.Text);
            if (student == null)
            {
                MessageBox.Show("ID Not found", "Error");
            }
            else
            {
                txtName.Text = student.name;
                txtAge.Text = student.age;

                if (student.race != String.Empty)
                {
                    cboRace.Text = student.race;
                }
                else
                {
                    cboRace.Text = "N/A";
                }

                if (student.gender != String.Empty)
                {
                    cboGender.Text = student.gender;
                } 
                else 
                {
                    cboGender.Text = "N/A";
                }

                if (student.financialAid != String.Empty)
                {
                    cboFinancialAid.Text = student.financialAid;
                }
                else
                {
                    cboFinancialAid.Text = "N/A";
                }

                if (student.firstGen != String.Empty)
                {
                    cboFirstGen.Text = student.firstGen;
                }
                else
                {
                    cboFirstGen.Text = "N/A";
                }

                if (student.academicStanding != String.Empty)
                {
                    cboAcademicStanding.Text = student.academicStanding;
                }
                else
                {
                    cboAcademicStanding.Text = "N/A";
                }

                txtGPAinst.Text = student.GPAint;
                txtGPAoverall.Text = student.GPAoverall;
                txtTermHours.Text = student.termHours;
                txtReadScore.Text = student.readScore;
                txtMathScore.Text = student.mathScore;
                txtMajor.Text = student.major;
                txtInstructor.Text = student.instructor;
                txtDepartment.Text = student.department;
                txtCourseTitle.Text = student.courseTitle;
                txtCourseID.Text = student.courseID;
                txtGrade.Text = student.grade;
                txtTerm.Text = student.term;

                if (student.readTestDate != String.Empty)
                {
                    DateTime readDate = Convert.ToDateTime(student.readTestDate);
                    dtpReadDate.Value = readDate;
                    chkReadDate.Checked = true;
                    dtpReadDate.Visible = true;
                    lblReadDate.Visible = true;
                }
                else
                {
                    chkReadDate.Checked = false;
                    dtpReadDate.Visible = false;
                    lblReadDate.Visible = false;
                }

                if (student.mathTestDate != String.Empty)
                {
                    DateTime mathDate = Convert.ToDateTime(student.mathTestDate);
                    dtpMathDate.Value = mathDate;
                    chkMathDate.Checked = true;
                    dtpMathDate.Visible = true;
                    lblMathDate.Visible = true;
                }
                else
                {
                    chkMathDate.Checked = false;
                    dtpMathDate.Visible = false;
                    lblMathDate.Visible = false;
                }
            }
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            if (loadFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                System.IO.StreamReader(loadFileDialog.FileName);
                studentWrite.ReadLoadedFile(studentDictionary, sr);
                sr.Close();
                FillCombo();
                btnSaveChanges.Enabled = true;
                loadedFile = true;
            }
        }

        private void ClearFields()
        {
            cboCCID.Text = string.Empty;
            txtName.Clear();
            txtAge.Clear();
            cboRace.Text = string.Empty;
            cboGender.Text = string.Empty;
            cboFinancialAid.Text = string.Empty;
            txtGPAinst.Clear();
            txtGPAoverall.Clear();
            cboFirstGen.Text = string.Empty;
            txtTermHours.Clear();
            txtReadScore.Clear();
            txtMathScore.Clear();
            txtMajor.Clear();
            cboAcademicStanding.Text = string.Empty;
            txtInstructor.Clear();
            txtDepartment.Clear();
            txtCourseTitle.Clear();
            txtCourseID.Clear();
            txtGrade.Clear();
            txtTerm.Clear();
        }

        private void DeactivateUI()
        {
            cboCCID.DropDownStyle = ComboBoxStyle.DropDownList;
            txtName.ReadOnly = true;
            txtAge.ReadOnly = true;
            cboRace.Enabled = false;
            cboGender.Enabled = false;
            cboFinancialAid.Enabled = false;
            txtGPAinst.ReadOnly = true;
            txtGPAoverall.ReadOnly = true;
            cboFirstGen.Enabled = false;
            txtTermHours.ReadOnly = true;
            txtReadScore.ReadOnly = true;
            txtMathScore.ReadOnly = true;
            dtpReadDate.Enabled = false;
            dtpMathDate.Enabled = false;
            txtMajor.ReadOnly = true;
            cboAcademicStanding.Enabled = false;
            txtInstructor.ReadOnly = true;
            txtDepartment.ReadOnly = true;
            txtCourseTitle.ReadOnly = true;
            txtCourseID.ReadOnly = true;
            txtGrade.ReadOnly = true;
            dtpMathDate.Enabled = false;
            dtpReadDate.Enabled = false;
            chkMathDate.Enabled = false;
            chkReadDate.Enabled = false;
            txtTerm.ReadOnly = true;
        }

        private void ActivateUI()
        {
            cboCCID.DropDownStyle = ComboBoxStyle.DropDown;
            txtName.ReadOnly = false;
            txtAge.ReadOnly = false;
            cboRace.Enabled = true;
            cboGender.Enabled = true;
            cboFinancialAid.Enabled = true;
            txtGPAinst.ReadOnly = false;
            txtGPAoverall.ReadOnly = false;
            cboFirstGen.Enabled = true;
            txtTermHours.ReadOnly = false;
            txtReadScore.ReadOnly = false;
            txtMathScore.ReadOnly = false;
            txtMajor.ReadOnly = false;
            cboAcademicStanding.Enabled = true;
            txtInstructor.ReadOnly = false;
            txtDepartment.ReadOnly = false;
            txtCourseTitle.ReadOnly = false;
            txtCourseID.ReadOnly = false;
            txtGrade.ReadOnly = false;
            chkMathDate.Enabled = true;
            chkReadDate.Enabled = true;
            lblMathDate.Visible = false;
            lblReadDate.Visible = false;
            dtpMathDate.Visible = false;
            dtpReadDate.Visible = false;
            chkMathDate.Checked = false;
            chkReadDate.Checked = false;
            txtTerm.ReadOnly = false;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (btnSaveChanges.Enabled)
            {
                DialogResult dlgResults;
                dlgResults = MessageBox.Show("Are you sure you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dlgResults == DialogResult.No)
                {

                }
                else if (dlgResults == DialogResult.Yes)
                {
                    studentWrite.WriteFile(studentDictionary);
                }
            }
            btnSaveChanges.Enabled = false;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHelp helpForm = new frmHelp();
            Form fc = Application.OpenForms["frmHelp"];

            if (fc != null)
            {
                fc.Close();
            }

            helpForm.Show();
        }


        private void btnDisplayStats_Click(object sender, EventArgs e)
        {
            if (File.Exists("honorsstudentfile.csv"))
            {
                frmStats frm = new frmStats();
                Form fc = Application.OpenForms["frmStats"];

                if (fc != null)
                {
                    fc.Close();
                }

                frm.Show();
            }
            else
            {
                MessageBox.Show("No student information found.", "Error");
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGPAinst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtGPAoverall_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtTermHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtReadScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtMathScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkReadDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReadDate.Checked)
            {
                dtpReadDate.Visible = true;
                lblReadDate.Visible = true;
                dtpReadDate.Enabled = true;
            }
            else
            {
                dtpReadDate.Visible = false;
                lblReadDate.Visible = false;
                dtpReadDate.Enabled = false;
            }
        }

        private void chkMathDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMathDate.Checked)
            {
                dtpMathDate.Visible = true;
                lblMathDate.Visible = true;
                dtpMathDate.Enabled = true;
            }
            else
            {
                dtpMathDate.Visible = false;
                lblMathDate.Visible = false;
                dtpMathDate.Enabled = false;
            }
        }

    }
}