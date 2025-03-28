using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Solution.Palindrome
{
    public static class PalindromeChecker
    {
        public static bool CekPalindrom(string input)
        {
            input = input.ToLower();
            StringBuilder n = new StringBuilder();

            foreach (char c in input)
            {
                if (c >= 'a' && c <= 'z') n.Append(c);
            }

            string normalisasi = n.ToString();

            if (normalisasi.Length <= 1) return true;

            Stack<char> stack = new Stack<char>();
            int tengah = normalisasi.Length / 2;

            for (int i = 0; i < tengah; i++) stack.Push(normalisasi[i]);

            int mulaiPengecekan = normalisasi.Length % 2 == 0 ? tengah : tengah + 1;

            for (int i = mulaiPengecekan; i < normalisasi.Length; i++)
            {
                if (stack.Pop() != normalisasi[i]) return false;
            }
            return true;
        }
    }
}