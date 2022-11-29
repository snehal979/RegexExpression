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
        const string First_Name = "^[a-zA-Z]{3,}";
        public void Test(string input)
        {
            if (Regex.IsMatch(input, First_Name))
                Console.WriteLine("First name matches");
            else
                Console.WriteLine("First name regex failed");
        }
    }
}
