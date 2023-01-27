using AdaCredit.UI.Domain;
using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using static BCrypt.Net.BCrypt;
using AdaCredit.UI.UseCases;

namespace AdaCredit.UI.Data
{
    internal class UserRepository
    {
        private static List<User> _users = new List<User>();

        public static string GenerateSalt()
        {
            return new Faker().Random.Replace("$2a$10$***********************");
        }

        public static string GenerateHash(string cleanPassword, out string salt)
        {
            salt = GenerateSalt();
            var hashedPassword = HashPassword(cleanPassword, salt, false);

            return hashedPassword;
        }

        public static string Hash(string cleanPassword, string salt)
        {
            var hashedPassword = HashPassword(cleanPassword, salt, false);

            return hashedPassword;
        }

        public static bool IsUsernameUsed(List<Employee> employees, string username)
        {
            bool flag = employees.Any(e => e.User.Username == username);
                
            return flag;
        }

        public static string ChangePassword(string cleanPassword, out string salt)
        {
            string hashedPassword = GenerateHash(cleanPassword, out salt);

            return hashedPassword;
        }
    }
}
