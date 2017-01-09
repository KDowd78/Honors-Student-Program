namespace Honors_Student_GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCCID = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGPAoverall = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGPAinst = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTermHours = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.cboFinancialAid = new System.Windows.Forms.ComboBox();
            this.cboFirstGen = new System.Windows.Forms.ComboBox();
            this.lblReadDate = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtReadScore = new System.Windows.Forms.TextBox();
            this.dtpReadDate = new System.Windows.Forms.DateTimePicker();
            this.dtpMathDate = new System.Windows.Forms.DateTimePicker();
            this.txtMathScore = new System.Windows.Forms.TextBox();
            this.lblMathDate = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cboAcademicStanding = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtInstructor = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCourseTitle = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDisplayStats = new System.Windows.Forms.Button();
            this.loadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnSaveStudent = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboRace = new System.Windows.Forms.ComboBox();
            this.chkReadDate = new System.Windows.Forms.CheckBox();
            this.chkMathDate = new System.Windows.Forms.CheckBox();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(12, 12);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(140, 45);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "New Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveStudent.Location = new System.Drawing.Point(12, 63);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(140, 45);
            this.btnRemoveStudent.TabIndex = 1;
            this.btnRemoveStudent.Text = "Remove Student";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFile.Location = new System.Drawing.Point(12, 165);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(140, 45);
            this.btnLoadFile.TabIndex = 3;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(12, 267);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(140, 45);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 318);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 45);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "CCRI ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(279, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Race:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Age:";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(177, 151);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 26);
            this.txtAge.TabIndex = 9;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(173, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(279, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "Financial Aid:";
            // 
            // cboCCID
            // 
            this.cboCCID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCCID.FormattingEnabled = true;
            this.cboCCID.Location = new System.Drawing.Point(177, 35);
            this.cboCCID.Name = "cboCCID";
            this.cboCCID.Size = new System.Drawing.Size(206, 28);
            this.cboCCID.TabIndex = 7;
            this.cboCCID.SelectedIndexChanged += new System.EventHandler(this.cboCCID_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(279, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 55;
            this.label7.Text = "GPA Overall:";
            // 
            // txtGPAoverall
            // 
            this.txtGPAoverall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGPAoverall.Location = new System.Drawing.Point(283, 267);
            this.txtGPAoverall.Name = "txtGPAoverall";
            this.txtGPAoverall.Size = new System.Drawing.Size(100, 26);
            this.txtGPAoverall.TabIndex = 14;
            this.txtGPAoverall.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGPAoverall_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(173, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 53;
            this.label8.Text = "GPA Inst:";
            // 
            // txtGPAinst
            // 
            this.txtGPAinst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGPAinst.Location = new System.Drawing.Point(177, 267);
            this.txtGPAinst.Name = "txtGPAinst";
            this.txtGPAinst.Size = new System.Drawing.Size(100, 26);
            this.txtGPAinst.TabIndex = 13;
            this.txtGPAinst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGPAinst_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(279, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 59;
            this.label9.Text = "Term Hours:";
            // 
            // txtTermHours
            // 
            this.txtTermHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTermHours.Location = new System.Drawing.Point(283, 324);
            this.txtTermHours.Name = "txtTermHours";
            this.txtTermHours.Size = new System.Drawing.Size(100, 26);
            this.txtTermHours.TabIndex = 16;
            this.txtTermHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTermHours_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(173, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 57;
            this.label10.Text = "First Gen:";
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "N/A"});
            this.cboGender.Location = new System.Drawing.Point(177, 208);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(100, 28);
            this.cboGender.TabIndex = 11;
            // 
            // cboFinancialAid
            // 
            this.cboFinancialAid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFinancialAid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFinancialAid.FormattingEnabled = true;
            this.cboFinancialAid.Items.AddRange(new object[] {
            "Yes",
            "No",
            "N/A"});
            this.cboFinancialAid.Location = new System.Drawing.Point(283, 208);
            this.cboFinancialAid.Name = "cboFinancialAid";
            this.cboFinancialAid.Size = new System.Drawing.Size(100, 28);
            this.cboFinancialAid.TabIndex = 12;
            // 
            // cboFirstGen
            // 
            this.cboFirstGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFirstGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFirstGen.FormattingEnabled = true;
            this.cboFirstGen.Items.AddRange(new object[] {
            "Yes",
            "No",
            "N/A"});
            this.cboFirstGen.Location = new System.Drawing.Point(177, 324);
            this.cboFirstGen.Name = "cboFirstGen";
            this.cboFirstGen.Size = new System.Drawing.Size(100, 28);
            this.cboFirstGen.TabIndex = 15;
            // 
            // lblReadDate
            // 
            this.lblReadDate.AutoSize = true;
            this.lblReadDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadDate.Location = new System.Drawing.Point(676, 14);
            this.lblReadDate.Name = "lblReadDate";
            this.lblReadDate.Size = new System.Drawing.Size(126, 20);
            this.lblReadDate.TabIndex = 65;
            this.lblReadDate.Text = "Read Test Date:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(400, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 20);
            this.label12.TabIndex = 63;
            this.label12.Text = "Read Score:";
            // 
            // txtReadScore
            // 
            this.txtReadScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReadScore.Location = new System.Drawing.Point(404, 37);
            this.txtReadScore.Name = "txtReadScore";
            this.txtReadScore.Size = new System.Drawing.Size(94, 26);
            this.txtReadScore.TabIndex = 17;
            this.txtReadScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReadScore_KeyPress);
            // 
            // dtpReadDate
            // 
            this.dtpReadDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReadDate.Location = new System.Drawing.Point(680, 37);
            this.dtpReadDate.Name = "dtpReadDate";
            this.dtpReadDate.Size = new System.Drawing.Size(285, 26);
            this.dtpReadDate.TabIndex = 18;
            // 
            // dtpMathDate
            // 
            this.dtpMathDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMathDate.Location = new System.Drawing.Point(680, 94);
            this.dtpMathDate.Name = "dtpMathDate";
            this.dtpMathDate.Size = new System.Drawing.Size(285, 26);
            this.dtpMathDate.TabIndex = 20;
            // 
            // txtMathScore
            // 
            this.txtMathScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMathScore.Location = new System.Drawing.Point(404, 94);
            this.txtMathScore.Name = "txtMathScore";
            this.txtMathScore.Size = new System.Drawing.Size(94, 26);
            this.txtMathScore.TabIndex = 19;
            this.txtMathScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMathScore_KeyPress);
            // 
            // lblMathDate
            // 
            this.lblMathDate.AutoSize = true;
            this.lblMathDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMathDate.Location = new System.Drawing.Point(676, 71);
            this.lblMathDate.Name = "lblMathDate";
            this.lblMathDate.Size = new System.Drawing.Size(123, 20);
            this.lblMathDate.TabIndex = 69;
            this.lblMathDate.Text = "Math Test Date:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(400, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 20);
            this.label14.TabIndex = 68;
            this.label14.Text = "Math Score:";
            // 
            // txtMajor
            // 
            this.txtMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMajor.Location = new System.Drawing.Point(404, 151);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(270, 26);
            this.txtMajor.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(400, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 20);
            this.label16.TabIndex = 72;
            this.label16.Text = "Major:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(676, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(151, 20);
            this.label15.TabIndex = 76;
            this.label15.Text = "Academic Standing:";
            // 
            // cboAcademicStanding
            // 
            this.cboAcademicStanding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAcademicStanding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAcademicStanding.FormattingEnabled = true;
            this.cboAcademicStanding.Items.AddRange(new object[] {
            "Good Academic Standing",
            "Bad Academic Standing",
            "N/A"});
            this.cboAcademicStanding.Location = new System.Drawing.Point(680, 151);
            this.cboAcademicStanding.Name = "cboAcademicStanding";
            this.cboAcademicStanding.Size = new System.Drawing.Size(285, 28);
            this.cboAcademicStanding.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(676, 186);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 20);
            this.label17.TabIndex = 80;
            this.label17.Text = "Department:";
            // 
            // txtInstructor
            // 
            this.txtInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstructor.Location = new System.Drawing.Point(404, 208);
            this.txtInstructor.Name = "txtInstructor";
            this.txtInstructor.Size = new System.Drawing.Size(270, 26);
            this.txtInstructor.TabIndex = 23;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(400, 185);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 20);
            this.label18.TabIndex = 78;
            this.label18.Text = "Instructor:";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.Location = new System.Drawing.Point(680, 209);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(285, 26);
            this.txtDepartment.TabIndex = 24;
            // 
            // txtGrade
            // 
            this.txtGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrade.Location = new System.Drawing.Point(404, 324);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(75, 26);
            this.txtGrade.TabIndex = 27;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(400, 301);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 20);
            this.label19.TabIndex = 82;
            this.label19.Text = "Grade:";
            // 
            // txtCourseID
            // 
            this.txtCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseID.Location = new System.Drawing.Point(680, 268);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(285, 26);
            this.txtCourseID.TabIndex = 26;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(676, 246);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 20);
            this.label20.TabIndex = 86;
            this.label20.Text = "Course ID:";
            // 
            // txtCourseTitle
            // 
            this.txtCourseTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseTitle.Location = new System.Drawing.Point(404, 267);
            this.txtCourseTitle.Name = "txtCourseTitle";
            this.txtCourseTitle.Size = new System.Drawing.Size(270, 26);
            this.txtCourseTitle.TabIndex = 25;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(400, 244);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(97, 20);
            this.label21.TabIndex = 84;
            this.label21.Text = "Course Title:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(177, 94);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(206, 26);
            this.txtName.TabIndex = 8;
            // 
            // btnDisplayStats
            // 
            this.btnDisplayStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayStats.Location = new System.Drawing.Point(12, 216);
            this.btnDisplayStats.Name = "btnDisplayStats";
            this.btnDisplayStats.Size = new System.Drawing.Size(140, 45);
            this.btnDisplayStats.TabIndex = 4;
            this.btnDisplayStats.Text = "Display Statistics";
            this.btnDisplayStats.UseVisualStyleBackColor = true;
            this.btnDisplayStats.Click += new System.EventHandler(this.btnDisplayStats_Click);
            // 
            // loadFileDialog
            // 
            this.loadFileDialog.FileName = "honorsstudentfile test";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(12, 114);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(140, 45);
            this.btnSaveChanges.TabIndex = 2;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnSaveStudent
            // 
            this.btnSaveStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveStudent.Location = new System.Drawing.Point(616, 322);
            this.btnSaveStudent.Name = "btnSaveStudent";
            this.btnSaveStudent.Size = new System.Drawing.Size(168, 28);
            this.btnSaveStudent.TabIndex = 28;
            this.btnSaveStudent.Text = "Add Student";
            this.btnSaveStudent.UseVisualStyleBackColor = true;
            this.btnSaveStudent.Click += new System.EventHandler(this.btnSaveStudent_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(790, 322);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(175, 28);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboRace
            // 
            this.cboRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRace.FormattingEnabled = true;
            this.cboRace.Items.AddRange(new object[] {
            "White",
            "Hispanic",
            "Asian",
            "Black",
            "N/A"});
            this.cboRace.Location = new System.Drawing.Point(283, 149);
            this.cboRace.Name = "cboRace";
            this.cboRace.Size = new System.Drawing.Size(100, 28);
            this.cboRace.TabIndex = 87;
            // 
            // chkReadDate
            // 
            this.chkReadDate.AutoSize = true;
            this.chkReadDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReadDate.Location = new System.Drawing.Point(504, 39);
            this.chkReadDate.Name = "chkReadDate";
            this.chkReadDate.Size = new System.Drawing.Size(173, 24);
            this.chkReadDate.TabIndex = 92;
            this.chkReadDate.Text = "Read Date Available";
            this.chkReadDate.UseVisualStyleBackColor = true;
            this.chkReadDate.CheckedChanged += new System.EventHandler(this.chkReadDate_CheckedChanged);
            // 
            // chkMathDate
            // 
            this.chkMathDate.AutoSize = true;
            this.chkMathDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMathDate.Location = new System.Drawing.Point(504, 96);
            this.chkMathDate.Name = "chkMathDate";
            this.chkMathDate.Size = new System.Drawing.Size(170, 24);
            this.chkMathDate.TabIndex = 93;
            this.chkMathDate.Text = "Math Date Available";
            this.chkMathDate.UseVisualStyleBackColor = true;
            this.chkMathDate.CheckedChanged += new System.EventHandler(this.chkMathDate_CheckedChanged);
            // 
            // txtTerm
            // 
            this.txtTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerm.Location = new System.Drawing.Point(485, 324);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(125, 26);
            this.txtTerm.TabIndex = 94;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(481, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 20);
            this.label11.TabIndex = 95;
            this.label11.Text = "Term:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 371);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.chkMathDate);
            this.Controls.Add(this.chkReadDate);
            this.Controls.Add(this.cboRace);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveStudent);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnDisplayStats);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtCourseTitle);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtInstructor);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cboAcademicStanding);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtMajor);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dtpMathDate);
            this.Controls.Add(this.txtMathScore);
            this.Controls.Add(this.lblMathDate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dtpReadDate);
            this.Controls.Add(this.txtReadScore);
            this.Controls.Add(this.lblReadDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboFirstGen);
            this.Controls.Add(this.cboFinancialAid);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTermHours);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGPAoverall);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGPAinst);
            this.Controls.Add(this.cboCCID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.btnRemoveStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Name = "frmMain";
            this.Text = "Honors Student";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCCID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGPAoverall;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGPAinst;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTermHours;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.ComboBox cboFinancialAid;
        private System.Windows.Forms.ComboBox cboFirstGen;
        private System.Windows.Forms.Label lblReadDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtReadScore;
        private System.Windows.Forms.DateTimePicker dtpReadDate;
        private System.Windows.Forms.DateTimePicker dtpMathDate;
        private System.Windows.Forms.TextBox txtMathScore;
        private System.Windows.Forms.Label lblMathDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMajor;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboAcademicStanding;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtInstructor;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtCourseTitle;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnDisplayStats;
        private System.Windows.Forms.OpenFileDialog loadFileDialog;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnSaveStudent;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboRace;
        private System.Windows.Forms.CheckBox chkReadDate;
        private System.Windows.Forms.CheckBox chkMathDate;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.Label label11;
    }
}

