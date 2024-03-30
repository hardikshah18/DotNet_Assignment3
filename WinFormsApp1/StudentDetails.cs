using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Assignment3
{

    public partial class StudentDetails : Form
    {
        private List<Student> students;
        private const string studentFilePath = "D:\\HARDIK SHAH ITs\\SEM 2\\.Net\\Assignment 3\\students.txt";

        private StudentDB studentDB;

        public StudentDetails()
        {
            InitializeComponent();
            studentDB = new StudentDB(); 
            students = new List<Student>();
            LoadStudents();
        }


        private void StudentDetails_Load(object sender, EventArgs e)
        {
        }

        private void LoadStudents()
        {
            students = studentDB.ReadStudentsFromFile(studentFilePath); 

            if (students != null)
            {
                dgvStudentDetails.Rows.Clear();
                foreach (var student in students)
                {
                    dgvStudentDetails.Rows.Add(student.StudentID, student.FirstName, student.LastName,
                        student.Age, student.Gender, student.ClassName, student.Grade);
                }
            }
            else
            {
                MessageBox.Show("No student data loaded.");
            }
        }

        private void dgvStudentDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent(students); 
            addStudent.ShowDialog();
            LoadStudents();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudentDetails.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedIndex = dgvStudentDetails.SelectedRows[0].Index;

            int studentID = Convert.ToInt32(dgvStudentDetails.Rows[selectedIndex].Cells[0].Value);

            Student studentToRemove = students.Find(s => s.StudentID == studentID);
            students.Remove(studentToRemove);

            studentDB.WriteStudentsToFile(students);

            LoadStudents();
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudentDetails.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedIndex = dgvStudentDetails.SelectedRows[0].Index;
            int studentID = Convert.ToInt32(dgvStudentDetails.Rows[selectedIndex].Cells[0].Value);

            Student studentToUpdate = students.Find(s => s.StudentID == studentID);

            AddStudent addStudent = new AddStudent(studentToUpdate);
            addStudent.ShowDialog();

            studentDB.UpdateStudent(studentToUpdate.StudentID, studentToUpdate); 
            LoadStudents();
        }


    }
}

