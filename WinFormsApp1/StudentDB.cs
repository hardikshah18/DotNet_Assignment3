using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Assignment3
{
    public class StudentDB
    {
        private const string studentFilePath = "D:\\HARDIK SHAH ITs\\SEM 2\\.Net\\Assignment 3\\students.txt";

        public List<Student> ReadStudentsFromFile(string fileName)
        {
            List<Student> studentList = new List<Student>();
            try
            {
                string[] lines = File.ReadAllLines(fileName);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 7)
                    {
                        Student student = new Student
                        {
                            StudentID = Convert.ToInt32(parts[0]),
                            FirstName = parts[1],
                            LastName = parts[2],
                            Age = Convert.ToInt32(parts[3]),
                            Gender = parts[4],
                            ClassName = parts[5],
                            Grade = Convert.ToInt32(parts[6])
                        };
                        studentList.Add(student);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading student data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; 
            }
            return studentList;
        }

        public void WriteStudentsToFile(List<Student> students)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(studentFilePath))
                {
                    foreach (Student student in students)
                    {
                        string studentData = $"{student.StudentID},{student.FirstName},{student.LastName},{student.Age},{student.Gender},{student.ClassName},{student.Grade}";
                        writer.WriteLine(studentData);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing student data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateStudent(int studentID, Student updatedStudent)
        {
            List<Student> students = ReadStudentsFromFile(studentFilePath);
            if (students == null || students.Count == 0)
            {
                MessageBox.Show("No students found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validate age
            if (!int.TryParse(updatedStudent.Age.ToString(), out int studentid))
            {
                MessageBox.Show("Please enter a valid age.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate age
            if (!int.TryParse(updatedStudent.Age.ToString(), out int age))
            {
                MessageBox.Show("Please enter a valid age.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate grade
            if (!int.TryParse(updatedStudent.Grade.ToString(), out int grade))
            {
                MessageBox.Show("Please enter a valid grade.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int index = students.FindIndex(s => s.StudentID == studentID);
            if (index != -1)
            {
                students[index] = updatedStudent; // Update the student in the list
                WriteStudentsToFile(students); // Write the updated list back to the file
            }
        }


        public void AddStudent(List<Student> students, Student newStudent)
        {
            if (students == null)
            {
                students = new List<Student>(); // Initialize the list if it's null
            }
            if (!int.TryParse(newStudent.StudentID.ToString(), out int studentID))
            {
                MessageBox.Show("Please enter a valid student ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate age
            if (!int.TryParse(newStudent.Age.ToString(), out int age))
            {
                MessageBox.Show("Please enter a valid age.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate grade
            if (!int.TryParse(newStudent.Grade.ToString(), out int grade))
            {
                MessageBox.Show("Please enter a valid grade.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            students.Add(newStudent);
            WriteStudentsToFile(students); // Write students after addition
        }
    }
}
