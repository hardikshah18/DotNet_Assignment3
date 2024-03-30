using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Diagnostics;

namespace Assignment3
{
    public partial class AddStudent : Form
    {
        List<Student> students;
        private const string studentFilePath = "D:\\HARDIK SHAH ITs\\SEM 2\\.Net\\Assignment 3\\students.txt";
        private Student studentToUpdate;

        public AddStudent()
        {
            InitializeComponent();
        }
        public AddStudent(List<Student> students)
        {
            InitializeComponent();
            this.students = students; // Store the reference to the students list
        }

        public AddStudent(Student studentToUpdate = null)
        {
            InitializeComponent();
            this.studentToUpdate = studentToUpdate;

            if (studentToUpdate != null)
            {
                LoadExistingStudent(studentToUpdate);
                btnAddStudent.Text = "Update";
            }
        }

        public void LoadExistingStudent(Student selectedStudent)
        {
            if (studentToUpdate != null)
            {
                txtBoxStudentID.Text = studentToUpdate.StudentID.ToString();
                txtBoxFirstName.Text = studentToUpdate.FirstName;
                txtBoxLastName.Text = studentToUpdate.LastName;
                txtBoxAge.Text = studentToUpdate.Age.ToString();
                txtBoxGender.Text = studentToUpdate.Gender;
                txtBoxClassName.Text = studentToUpdate.ClassName;
                txtBoxGrade.Text = studentToUpdate.Grade.ToString();
            }
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(txtBoxStudentID.Text);
                string firstName = txtBoxFirstName.Text;
                string lastName = txtBoxLastName.Text;
                int age = Convert.ToInt32(txtBoxAge.Text);
                string gender = txtBoxGender.Text;
                string className = txtBoxClassName.Text;
                int grade = Convert.ToInt32(txtBoxGrade.Text);

                // Check for negative age or grade
                if (age < 0 || grade < 0)
                {
                    throw new ArgumentException("Age and grade cannot be negative.");
                }

                Student newStudent = new Student
                {
                    StudentID = studentID,
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    Gender = gender,
                    ClassName = className,
                    Grade = grade
                };

                StudentDB studentDB = new StudentDB();
                if (studentToUpdate == null)
                {
                    studentDB.AddStudent(students, newStudent); // Use the passed students list
                    MessageBox.Show("Student data added successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    studentDB.UpdateStudent(studentToUpdate.StudentID, newStudent);
                    MessageBox.Show("Student data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid integer values for Student ID, Age, and Grade.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
    }
    }
 }


