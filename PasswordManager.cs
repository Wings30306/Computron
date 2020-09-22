using System;

namespace Computron
{
    class PasswordManager
    {
        private string Password
        { get; set; }

        public bool Hidden
        { get; private set; }

        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
        }

        public void Display()
        {
            if (Hidden)
            {
                string hiddenPassword = "";
                foreach (char c in Password)
                {
                    hiddenPassword += "*";
                }
                Console.WriteLine(hiddenPassword);
            }
            else
            {
                Console.WriteLine(Password);
            }
            
        }

        public bool ChangePassword(string oldPassword, string newPassword)
        {
            if (oldPassword.Equals(Password))
            {
                Password = newPassword;
                return true;
            }
            else
            {
                Console.WriteLine("Oops, your old passport didn't match the password saved!");
                return false;
            }
        }

        public void Reset()
        {
            Password = "";
            Hidden = false;
        }
    }
}