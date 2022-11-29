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
        const string Phone_Num = "^+91[ ][0-9]{10}";
        public void Test(string input)
        {
            if (Regex.IsMatch(input, Phone_Num))
                Console.WriteLine("phone number  matches");
            else
                Console.WriteLine("phone number failed");
        }
    }
}
