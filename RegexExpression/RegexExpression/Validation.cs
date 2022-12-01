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
        const string Name = "^[a-zA-Z]{3,}";
        const string Email = "^[a-zA-Z0-9]+[.+-_]{0,1}[a-zA-Z0-9]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        const string Password = "^[a-z]{8,}([0-9A-Z]{1,})+[.]$";
        public void TestName(string input)
        {
            if (Regex.IsMatch(input, Name))
                Console.WriteLine("First/last name matches");
            else
                Console.WriteLine("First/last name regex failed");
        }
       
        public void TestEmail(string input)
        {
            if (Regex.IsMatch(input, Email))
                Console.WriteLine("Email  matches");
            else
                Console.WriteLine("Email regex failed");
        }
       
        public void TestPassword(string input)
        {
            if (Regex.IsMatch(input, Password))
                Console.WriteLine("Password  matches");
            else
                Console.WriteLine("Password regex failed");
        }
    }
}
