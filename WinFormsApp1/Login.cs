using Assignment3;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        private const string userFilePath = "D:\\HARDIK SHAH ITs\\SEM 2\\.Net\\Assignment 3\\user.txt";

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtBoxUser.Text;
            string password = txtBoxPass.Text;

            if (IsValidUser(username, password))
            {
                StudentDetails studentDetails = new StudentDetails();
                studentDetails.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private bool IsValidUser(string username, string password)
        {
            try
            {
                string[] userCredentials = File.ReadAllLines(userFilePath);
                if (userCredentials.Length == 1)
                {
                    string[] parts = userCredentials[0].Split(',');
                    if (parts.Length == 2)
                    {
                        string storedUsername = parts[0];
                        string storedPassword = parts[1];

                        return (username == storedUsername && password == storedPassword);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading user credentials: " + ex.Message);
            }
            return false;
        }
    }
}
