using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ElevateEvansvilleUI.Extensions
{
    public class Security
    {
        public static string HashPassword(string password)
        {
            byte[] hashedPassword;
            using (SHA512 sha512 = SHA512.Create())
            {
                hashedPassword = sha512.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
            return BitConverter.ToString(hashedPassword).Replace("-", "");
        }
    }
}
