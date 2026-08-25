using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace NEALibrary
{
    public static class SHA256Hasher
    {
        public static string CalculateHash(string input) 
        {
            input = input.Trim();
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputToByte = Encoding.UTF8.GetBytes(input); // Converts input to byte
                byte[] hashed = sha256.ComputeHash(inputToByte); // Calculates the hashed value
                return MakeString(hashed);
            }
        }

        private static string MakeString(byte[] hash)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hash)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
