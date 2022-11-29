using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexExpression
{
    public class Validation
    {
        const string Password = "[a-z][A-Z]{1,}";
        public void Test(string input)
        {
            if (Regex.IsMatch(input, Password))
                Console.WriteLine("Password  matches");
            else
                Console.WriteLine("Password regex failed");
        }
    }
}
