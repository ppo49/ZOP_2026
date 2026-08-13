using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BCrypt.Net;
using System.Threading.Tasks;

namespace projekat_2026.Core
{
    public class AuthService
    {
        public string HashPassword(string plainPassword)
        {
            return BCrypt.Net.BCrypt.HashPassword(plainPassword);
        }

        public bool VerifyPassword(string plainPassword, string storedHash)
        {
            return BCrypt.Net.BCrypt.Verify(plainPassword, storedHash);
        }
    }
}
