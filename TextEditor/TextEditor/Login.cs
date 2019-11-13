using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace TextEditor
{
    public partial class Login : Form
    {
        // List data structures to be loaded with data from file database
        private List<User> usersInfo = new List<User>();

        public Login()
        {
            InitializeComponent();
            loadUsers();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (isValidAccount(usernameTxt.Text, passwordTxt.Text))
            {
                this.Hide();
                // Get the user object in the database
                User selectedUser = usersInfo.Where(a => a.getUsername() == usernameTxt.Text).ToList()[0];

                // Use the user object as the record
                TextEditor userTextEdit = new TextEditor(selectedUser);
                userTextEdit.Show();
            }
            else {
                usernameTxt.Clear();
                passwordTxt.Clear();
                MessageBox.Show("Invalid Credential... Try Again!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            Register registerPortal = new Register();
            registerPortal.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //// check if the account is valid and already registered in the database
        public bool isValidAccount(string username, string password)
        {
            loadUsers();
            foreach (User test in usersInfo) {
                if (username == test.getUsername() && password == test.getpassWord()) {
                    return true;
                }
            }
            return false;
        }

        // Load the data from login.txt into the List data structures
        public void loadUsers()
        {
            // Clear the database before loading up in case there is a new user after getting back from 'Register' module
            usersInfo.Clear();
            // Load the user info into the list database
            string[] lines = File.ReadAllLines("login.txt");
            foreach (string account in lines)
            {
                string[] splits = account.Split(',');
                usersInfo.Add(new User(splits[0], splits[1], splits[2], splits[3], splits[4], splits[5]));
            }
        }


    }
}
