using System;
using System.IO;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;

namespace QuizLibrary
{
    public static class Encoder
    {
        public static byte[] GetByteArray(String str) => Encoding.UTF8.GetBytes(str);

        public static String GetString(byte[] buf) => Encoding.UTF8.GetString(buf, 0, buf.Length);

        public static String GetHash(String str)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
            {
                byte[] buffer = algorithm.ComputeHash(GetByteArray(str));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < buffer.Length; i++)
                    builder.Append(buffer[i].ToString("x2"));

                return builder.ToString();
            }
        }

        public static Image GetImage(String base64ImageRepresentation)
        {
            using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(base64ImageRepresentation)))
                return Image.FromStream(memoryStream);
        }

        public static String GetBase64String(String path)
        {
            byte[] imageArray = File.ReadAllBytes(path);
            return Convert.ToBase64String(imageArray);
        }
    }
}
