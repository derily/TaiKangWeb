using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace TaiKang.Utillity
{
    public class Md5
    {
        public static string Encryption(string orinal)
        {
            byte[] bytes = Encoding.Default.GetBytes(orinal);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(bytes);
            return BitConverter.ToString(output).Replace("-", "").ToLower();
        }
    }
}
