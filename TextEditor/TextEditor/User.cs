namespace TextEditor
{
    // This class is created to handle the users database in object-oriented way
    public class User
    {
        private string _firstName, _lastName, _userName, _passWord, _userType, _DOB;
        public User(string userName, string passWord, string userType, string firstName, string lastName, string DOB)
        {
            _firstName = firstName;
            _lastName = lastName;
            _userName = userName;
            _passWord = passWord;
            _userType = userType;
            _DOB = DOB;
        }

        // Accessor to the user attributes
        public string getUsername() {return _userName;}

        public string getFirstName() {return _firstName;}

        public string getLastName() {return _lastName;}

        public string getUserType() {return _userType;}

        public string getpassWord(){ return _passWord; }

        public string getDOB() { return _DOB; }
    }
}
