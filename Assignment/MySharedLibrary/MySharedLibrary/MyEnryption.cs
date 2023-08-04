using System;
using System.Security.Cryptography;
using System.Text;

namespace MySharedLibrary
{
    public class MyEncryption
    {

        public static bool IsValidEmailAddress(string email)
        {
            return !string.IsNullOrEmpty(email) && email.Contains("@");
        }

        public static bool IsValidUsername(string username)
        {
            return !string.IsNullOrEmpty(username) && username.Length >= 4 && username.Length <= 20;
        }

        public static bool IsValidPassword(string password)
        {
            return !string.IsNullOrEmpty(password) && password.Length >= 8;
        }
    }
}
