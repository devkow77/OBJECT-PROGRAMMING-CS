using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB9
{
    public partial class Form1: Form
    {
        private List<User> users = new List<User>();
        public Form1()
        {
            
            InitializeComponent();

            // Podpięcie zdarzeń do wszystkich pól tekstowych
            emailTextBox.TextChanged += InputFields_TextChanged;
            usernameTextBox.TextChanged += InputFields_TextChanged;
            passwordTextBox.TextChanged += InputFields_TextChanged;
            repeatPasswordTextBox.TextChanged += InputFields_TextChanged;

            progressBar.Maximum = 100;
            progressBar.Value = 0;

            // Utworzenie tabeli do wyświetlania użytkowników
            usersTable.RowCount = 1;
            usersTable.ColumnCount = 3;

            usersTable.Controls.Add(new Label() { Text = "Email", AutoSize = true }, 0, 0);
            usersTable.Controls.Add(new Label() { Text = "Username", AutoSize = true }, 1, 0);
            usersTable.Controls.Add(new Label() { Text = "Password", AutoSize = true }, 2, 0);
        }

        public class User
        {
            public string Email { get; }
            public string Username { get; }
            private string password;
            
            public User(string email, string username, string password)
            {
                Email = email;
                Username = username;
                this.password = password;
            }



            public override string ToString()
            {
                return $"Email: {Email} Username: {Username} Password: {password}";
            }
        }

        public bool isValidEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public void clearFields()
        {
            emailTextBox.Text = "";
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            repeatPasswordTextBox.Text = "";
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string repeatPassword = repeatPasswordTextBox.Text;

            try
            {
                if (email == "" || username == "" || password == "" || repeatPassword == "")
                {
                    throw new ArgumentNullException("All fields are required.");
                }
                else if (!isValidEmail(email)) throw new Exception("Invalid email format");
                else if (password != repeatPassword) throw new Exception("Passwords must be the same!");
                else
                {
                    foreach (User user in users)
                    {
                        if (user.Email == email || user.Username == username)
                        {
                            throw new Exception("Email or username already exists");
                        }
                    }

                    Console.WriteLine("User has been created!");
                    users.Add(new User(email, username, password));
                    clearFields();

                    int rowIndex = usersTable.RowCount;

                    // dodanie nowego usera do tabeli
                    usersTable.RowCount++;
                    usersTable.Controls.Add(new Label() { Text = email, AutoSize = true }, 0, rowIndex);
                    usersTable.Controls.Add(new Label() { Text = username, AutoSize = true }, 1, rowIndex);
                    usersTable.Controls.Add(new Label() { Text = password, AutoSize = true }, 2, rowIndex);
                }      
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }      
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void InputFields_TextChanged(object sender, EventArgs e)
        {
            int filled = 0;

            if (!string.IsNullOrWhiteSpace(emailTextBox.Text)) filled++;
            if (!string.IsNullOrWhiteSpace(usernameTextBox.Text)) filled++;
            if (!string.IsNullOrWhiteSpace(passwordTextBox.Text)) filled++;
            if (!string.IsNullOrWhiteSpace(repeatPasswordTextBox.Text)) filled++;

            progressBar.Value = filled * 25;
        }
    }
}
