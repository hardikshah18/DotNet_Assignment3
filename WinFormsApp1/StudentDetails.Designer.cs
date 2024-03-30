namespace Assignment3
{
    partial class StudentDetails
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
            dgvStudentDetails = new DataGridView();
            StudentID = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            CLassName = new DataGridViewTextBoxColumn();
            Grade = new DataGridViewTextBoxColumn();
            btnAddStudent = new Button();
            btnUpdateStudent = new Button();
            btnDeleteStudent = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudentDetails).BeginInit();
            SuspendLayout();
            // 
            // dgvStudentDetails
            // 
            dgvStudentDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgvStudentDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentDetails.Columns.AddRange(new DataGridViewColumn[] { StudentID, FirstName, LastName, Age, Gender, CLassName, Grade });
            dgvStudentDetails.Location = new Point(5, 6);
            dgvStudentDetails.Name = "dgvStudentDetails";
            dgvStudentDetails.ReadOnly = true;
            dgvStudentDetails.RowHeadersWidth = 51;
            dgvStudentDetails.Size = new Size(929, 525);
            dgvStudentDetails.TabIndex = 0;
            dgvStudentDetails.CellContentClick += dgvStudentDetails_CellContentClick;
            // 
            // StudentID
            // 
            StudentID.HeaderText = "StudentID";
            StudentID.MinimumWidth = 6;
            StudentID.Name = "StudentID";
            StudentID.ReadOnly = true;
            StudentID.Width = 125;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "FirstName";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            FirstName.Width = 125;
            // 
            // LastName
            // 
            LastName.HeaderText = "LastName";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            LastName.Width = 125;
            // 
            // Age
            // 
            Age.HeaderText = "Age";
            Age.MinimumWidth = 6;
            Age.Name = "Age";
            Age.ReadOnly = true;
            Age.Width = 125;
            // 
            // Gender
            // 
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            Gender.Width = 125;
            // 
            // CLassName
            // 
            CLassName.HeaderText = "ClassName";
            CLassName.MinimumWidth = 6;
            CLassName.Name = "CLassName";
            CLassName.ReadOnly = true;
            CLassName.Width = 125;
            // 
            // Grade
            // 
            Grade.HeaderText = "Grade";
            Grade.MinimumWidth = 6;
            Grade.Name = "Grade";
            Grade.ReadOnly = true;
            Grade.Width = 125;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(952, 69);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(173, 59);
            btnAddStudent.TabIndex = 1;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnUpdateStudent
            // 
            btnUpdateStudent.Location = new Point(952, 255);
            btnUpdateStudent.Name = "btnUpdateStudent";
            btnUpdateStudent.Size = new Size(173, 59);
            btnUpdateStudent.TabIndex = 2;
            btnUpdateStudent.Text = "Update Student";
            btnUpdateStudent.UseVisualStyleBackColor = true;
            btnUpdateStudent.Click += btnUpdateStudent_Click;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.Location = new Point(952, 446);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(173, 59);
            btnDeleteStudent.TabIndex = 3;
            btnDeleteStudent.Text = "Delete Student";
            btnDeleteStudent.UseMnemonic = false;
            btnDeleteStudent.UseVisualStyleBackColor = true;
            btnDeleteStudent.Click += btnDeleteStudent_Click;
            // 
            // StudentDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 573);
            Controls.Add(btnDeleteStudent);
            Controls.Add(btnUpdateStudent);
            Controls.Add(btnAddStudent);
            Controls.Add(dgvStudentDetails);
            Name = "StudentDetails";
            Text = "StudentDetails";
            Load += StudentDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudentDetails).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvStudentDetails;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn CLassName;
        private DataGridViewTextBoxColumn Grade;
        private Button btnAddStudent;
        private Button btnUpdateStudent;
        private Button btnDeleteStudent;
    }
}