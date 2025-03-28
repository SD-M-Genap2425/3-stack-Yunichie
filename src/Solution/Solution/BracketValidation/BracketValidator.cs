using System.IO;

namespace Solution.BracketValidation
{
    public class BracketValidator
    {
        public BracketValidator()
        {
        }

        public bool ValidasiEkspresi(string ekspresi)
        {
            Stack stack = new Stack();

            foreach (char i in ekspresi)
            {
                if (i == '(' || i == '{' || i == '[') stack.Push(i);
                else if (i == ')' || i == '}' || i == ']')
                {
                    char kurungBuka = stack.Pop();
                    if ((i == ')' && kurungBuka != '(') ||
                        (i == '}' && kurungBuka != '{') ||
                        (i == ']' && kurungBuka != '['))
                    {
                        return false;
                    }
                }
            }

            if (!stack.IsEmpty()) return false;
            else return true;
        }
    }
}