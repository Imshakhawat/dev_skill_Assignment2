using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class Membership
    {

        public const string UsernameError = "Username must be provided";
        public const string EmailError = "Email must be provided";
        public const string PasswordError = "Password must be provided";
        public static string Validate(string username, string email, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                return UsernameError;
            if (string.IsNullOrWhiteSpace(email))
                return EmailError;
            if (string.IsNullOrWhiteSpace(password))
                return PasswordError;

            return string.Empty;
        }
    }
}
