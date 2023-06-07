using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;

namespace практика.Connection
{
    class Crypt
    {
        public static string EncryptE(string str, string keyCrypt)
        {
            return Convert.ToBase64String(EncryptE(Encoding.UTF8.GetBytes(str), keyCrypt));
        }

        private static byte[] EncryptE(byte[] data, string key)
        {
            using (SymmetricAlgorithm sa = Rijndael.Create())
            {
                sa.Key = new PasswordDeriveBytes(key, null).GetBytes(16);
                sa.IV = new byte[16]; // Здесь используется нулевой IV, но в реальном приложении следует использовать случайно сгенерированный IV
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(data, 0, data.Length);
                        cs.FlushFinalBlock();
                    }
                    return ms.ToArray();
                }
            }
        }

        public static string CreatePasswordE(int length, string emailKey)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=?&/";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }

            return res.ToString();
        }


        public static string EncryptP(string str, string keyCrypt)
        {
            return Convert.ToBase64String(EncryptP(Encoding.UTF8.GetBytes(str), keyCrypt));
        }

        private static byte[] EncryptP(byte[] data, string key)
        {
            using (SymmetricAlgorithm sa = Rijndael.Create())
            {
                sa.Key = new PasswordDeriveBytes(key, null).GetBytes(16);
                sa.IV = new byte[16]; // Здесь используется нулевой IV, но в реальном приложении следует использовать случайно сгенерированный IV
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(data, 0, data.Length);
                        cs.FlushFinalBlock();
                    }
                    return ms.ToArray();
                }
            }
        }



        public static string CreatePasswordP(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=?&/";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }

            return res.ToString();
        }
    }
}
