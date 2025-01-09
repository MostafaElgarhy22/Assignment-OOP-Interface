using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP_Interface.Q_2
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private readonly string storedUsername = "Mostafa";
        private readonly string storedPassword = "654321";
        private readonly string storedRole = "Admin";     // Only Admin Who Have Authentication for this role

        public bool AuthenticateUser(string username, string password)
        {
            return username == storedUsername && password == storedPassword;
        }

        public bool AuthorizeUser(string username, string role)
        {
            return username == storedUsername && role == storedRole;
        }
    }
}
