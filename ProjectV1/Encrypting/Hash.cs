using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace ProjectV1.Encrypting
{
    class Hash
    {
        public string Hashing(String input_data)
        {
            SHA1 sha1 = SHA1.Create();
            byte[] hashed_data = sha1.ComputeHash(Encoding.Default.GetBytes(input_data));
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < hashed_data.Length; i++)
            {
                stringBuilder.Append(hashed_data[i].ToString());
            }
            return stringBuilder.ToString();
        }
    }
}
