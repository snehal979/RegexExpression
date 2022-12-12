using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexExpression
{
    public class EmailRefactor
    {
        const string Email = "^[a-zA-Z0-9]+[.+-_]{0,1}[a-zA-Z0-9]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        
        private string emailAdd;

        public EmailRefactor(string emailAdd)
        {
           this.emailAdd = emailAdd;
        }
        public string TestEmail_Refector()
        {
            if (Regex.IsMatch(emailAdd, Email))
                return "Email  matches";
            else
                return "Email regex failed";
        }
    }
}
