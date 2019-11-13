using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class Register : Form
    {
        // List data strutures to load the user data
        private List<User> usersInfo = new List<User>();

        public Register()
        {
            InitializeComponent();
            loadUsers();
        }

        //////////////////////////////////
        //// Form Component Events Handler ///
        ///////////////////////////////////

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            // Check whether the field is empty before validating every input
            if (isfieldNotEmpty())
            {
                // Input validation with its warning message if its invalid
                if (isUserNameUnique() && isDOBValid() && isPasswordValid())
                {
                    DialogResult result = MessageBox.Show("Is the entered info correct?", "Create Account", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        // Generate and reformat the input data for new account
                        string newAccount = usernameTxt.Text + "," +
                                            passwordTxt.Text + "," +
                                            userTypeBox.Text + "," +
                                            firstTxt.Text + "," +
                                            lastTxt.Text + "," +
                                            DOBdateTxt.Value.ToString("dd-MM-yyyy");

                        // Push and append the account detail into the user database
                        System.IO.File.AppendAllLines("login.txt", new[] { newAccount });
                        MessageBox.Show("Account is successfully created", "Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                }
            }
            else {
                MessageBox.Show("Please enter all the required details to proceed", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /////// Non-events reusable functions /////

        ///// Load the user database from text file into the List Data Strcuture
        public void loadUsers()
        {
            string[] lines = System.IO.File.ReadAllLines("login.txt");
            foreach (string account in lines)
            {
                string[] splits = account.Split(',');
                usersInfo.Add(new User(splits[0], splits[1], splits[2], splits[3], splits[4], splits[5]));
            }
        }

        //// Check if the inputted user name is unique
        public bool isUserNameUnique() {
            foreach (User userDetails in usersInfo)
            {
                if (usernameTxt.Text == userDetails.getUsername())
                {
                    usernameTxt.Clear();
                    MessageBox.Show("Username is already in used. Try another username", "Username", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            return true;
        }

        //// Check if the password match with confirm password and  pasword must be at least 8 character
        public bool isPasswordValid() {
            if (passwordTxt.Text == confirmPasswordTxt.Text && passwordTxt.Text.Length >= 8) {
                return true;
            }
            passwordTxt.Clear();
            confirmPasswordTxt.Clear();
            MessageBox.Show("The entered password is invalid/not match; The password must be minimum 8 characters long", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        ///// Check if the DOB is valid. Any date other than today date is invalid and must be reinputed
        public bool isDOBValid() {
            if (DOBdateTxt.Value.Date <= DateTime.Now) {
                return true;
            }
            MessageBox.Show("Please enter the valid DOB.", "Invalid Date of Birth", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        ///// Check if any of the given field is empty before proceeding validating the inputted field
        public bool isfieldNotEmpty() {
            // Check if the input is correct
            // Make sure the required field is not empty
            return !String.IsNullOrEmpty(usernameTxt.Text) &&
                   !String.IsNullOrEmpty(passwordTxt.Text) &&
                   !String.IsNullOrEmpty(confirmPasswordTxt.Text) &&
                   !String.IsNullOrEmpty(firstTxt.Text) &&
                   !String.IsNullOrEmpty(lastTxt.Text) &&
                   // Check if the given type is selected
                   userTypeBox.SelectedIndex > -1;
        }
    }
}
