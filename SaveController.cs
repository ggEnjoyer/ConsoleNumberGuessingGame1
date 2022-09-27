using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNumberGuessingGame1
{
    static class SaveController
    {
        public static void AddResult(int i)
        {
            using (var fs = new FileStream("results.txt", FileMode.Append))
            {
                byte[] buffer = Encoding.Default.GetBytes(i.ToString() + '\n');
                fs.Write(buffer, 0, buffer.Length);
            }
        }
        public static string ReadResults()
        {
            using (var fs = new FileStream("results.txt", FileMode.OpenOrCreate))
            {
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                return Encoding.Default.GetString(buffer);
            }
        }
        public static List<int> DecodeSave(string s)
        {
            try
            {
                var ss = s[0];
            }
            catch
            {
                return new List<int>() { -1 };
            }
            string decodeString = "";
            List<int> list = new();
            foreach (char c in s)
            {
                if (c >= '0' && c <= '9')
                {
                    decodeString += c;
                }
                else if(c == '\n')
                {
                    list.Add(Convert.ToInt32(decodeString));
                    decodeString = "";
                }
            }
            return list;
        }
    }
}
