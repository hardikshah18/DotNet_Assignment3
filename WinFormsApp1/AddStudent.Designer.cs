namespace Assignment3
{
    partial class AddStudent
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
            lblStudentID = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblAge = new Label();
            lblGender = new Label();
            lblCLassName = new Label();
            lblGrade = new Label();
            txtBoxStudentID = new TextBox();
            txtBoxFirstName = new TextBox();
            txtBoxLastName = new TextBox();
            txtBoxAge = new TextBox();
            txtBoxGender = new TextBox();
            txtBoxClassName = new TextBox();
            txtBoxGrade = new TextBox();
            btnAddStudent = new Button();
            SuspendLayout();
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Location = new Point(125, 57);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(86, 20);
            lblStudentID.TabIndex = 0;
            lblStudentID.Text = "Student ID :";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(124, 113);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(87, 20);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name :";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(119, 172);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(86, 20);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name :";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(161, 229);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(43, 20);
            lblAge.TabIndex = 3;
            lblAge.Text = "Age :";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(141, 290);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(64, 20);
            lblGender.TabIndex = 4;
            lblGender.Text = "Gender :";
            // 
            // lblCLassName
            // 
            lblCLassName.AutoSize = true;
            lblCLassName.Location = new Point(118, 344);
            lblCLassName.Name = "lblCLassName";
            lblCLassName.Size = new Size(93, 20);
            lblCLassName.TabIndex = 5;
            lblCLassName.Text = "Class Name :";
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Location = new Point(148, 398);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(56, 20);
            lblGrade.TabIndex = 6;
            lblGrade.Text = "Grade :";
            // 
            // txtBoxStudentID
            // 
            txtBoxStudentID.Location = new Point(230, 50);
            txtBoxStudentID.Name = "txtBoxStudentID";
            txtBoxStudentID.Size = new Size(125, 27);
            txtBoxStudentID.TabIndex = 7;
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.Location = new Point(230, 106);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(125, 27);
            txtBoxFirstName.TabIndex = 8;
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.Location = new Point(230, 165);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(125, 27);
            txtBoxLastName.TabIndex = 9;
            // 
            // txtBoxAge
            // 
            txtBoxAge.Location = new Point(230, 222);
            txtBoxAge.Name = "txtBoxAge";
            txtBoxAge.Size = new Size(125, 27);
            txtBoxAge.TabIndex = 10;
            // 
            // txtBoxGender
            // 
            txtBoxGender.Location = new Point(230, 283);
            txtBoxGender.Name = "txtBoxGender";
            txtBoxGender.Size = new Size(125, 27);
            txtBoxGender.TabIndex = 11;
            // 
            // txtBoxClassName
            // 
            txtBoxClassName.Location = new Point(230, 337);
            txtBoxClassName.Name = "txtBoxClassName";
            txtBoxClassName.Size = new Size(125, 27);
            txtBoxClassName.TabIndex = 12;
            // 
            // txtBoxGrade
            // 
            txtBoxGrade.Location = new Point(230, 391);
            txtBoxGrade.Name = "txtBoxGrade";
            txtBoxGrade.Size = new Size(125, 27);
            txtBoxGrade.TabIndex = 13;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(182, 473);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(173, 59);
            btnAddStudent.TabIndex = 14;
            btnAddStudent.Text = "Save";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 598);
            Controls.Add(btnAddStudent);
            Controls.Add(txtBoxGrade);
            Controls.Add(txtBoxClassName);
            Controls.Add(txtBoxGender);
            Controls.Add(txtBoxAge);
            Controls.Add(txtBoxLastName);
            Controls.Add(txtBoxFirstName);
            Controls.Add(txtBoxStudentID);
            Controls.Add(lblGrade);
            Controls.Add(lblCLassName);
            Controls.Add(lblGender);
            Controls.Add(lblAge);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblStudentID);
            Name = "AddStudent";
            Text = "AddStudent";
            Load += AddStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentID;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblAge;
        private Label lblGender;
        private Label lblCLassName;
        private Label lblGrade;
        private TextBox txtBoxStudentID;
        private TextBox txtBoxFirstName;
        private TextBox txtBoxLastName;
        private TextBox txtBoxAge;
        private TextBox txtBoxGender;
        private TextBox txtBoxClassName;
        private TextBox txtBoxGrade;
        private Button btnAddStudent;
    }
}