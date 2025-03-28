using Solution.BracketValidation;
using Solution.BrowserHistory;
using Solution.Palindrome;

namespace Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Browser history
            HistoryManager halaman = new HistoryManager();
            halaman.KunjungiHalaman("google.com");
            halaman.KunjungiHalaman("gnu.org");
            Console.WriteLine(halaman.LihatHalamanSaatIni());
            halaman.Kembali();

            // Bracket validator
            BracketValidator bracket = new BracketValidator();
            string ekspresiValid = "[{}](){}";
            string ekspresiInvalid = "(]";

            Console.WriteLine($"Ekspresi '{ekspresiValid}' valid? {bracket.ValidasiEkspresi(ekspresiValid)}");
            Console.WriteLine($"Ekspresi '{ekspresiInvalid}' valid? {bracket.ValidasiEkspresi(ekspresiInvalid)}");

            //Palindrome Checker
            string expr = "Kasur ini rusak";
            string expr2 = "Hello, World";
            Console.WriteLine($"Ekspresi '{expr}' palindrom? {PalindromeChecker.CekPalindrom(expr)}");
            Console.WriteLine($"Ekspresi '{expr2}' palindrom? {PalindromeChecker.CekPalindrom(expr2)}");
        }
    }
}