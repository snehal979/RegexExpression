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
        const string Last_Name = "^[a-zA-Z]{3,}";
        public void Test(string input)
        {
            if (Regex.IsMatch(input, Last_Name))
                Console.WriteLine("Last name matches");
            else
                Console.WriteLine("Last name regex failed");
        }
    }
}
