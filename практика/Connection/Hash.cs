using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace практика.Connection
{
    class Hash
    {

        /// <summary>
        /// Создает хэш-код для вводимого значения
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Хэш-код</returns>
        public static string HashValue(string value)
        {
            var md5 = MD5.Create();

            byte[] valueBytes = Encoding.ASCII.GetBytes(value);
            byte[] valueHash = md5.ComputeHash(valueBytes);

            var sb = new StringBuilder();

            foreach (var b in valueHash) sb.Append(b.ToString("X2"));

            return sb.ToString();
        }
    }
}
