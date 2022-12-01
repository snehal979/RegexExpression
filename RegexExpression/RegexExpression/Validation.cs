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
        const string Email = "^[a-zA-Z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}+[.][a-z]){2}{0,1}$"; 
        public void Test(string input)
        {
            if (Regex.IsMatch(input, Email))
                Console.WriteLine("Email  matches");
            else
                Console.WriteLine("Email regex failed");
        }
    }
}
