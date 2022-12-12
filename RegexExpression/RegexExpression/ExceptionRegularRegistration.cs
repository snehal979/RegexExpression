using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexExpression
{
    public class ExceptionRegularRegistration :Exception
    {
        public enum RegularRegistrationType
        {
            INVALID_NAME,
            INVALID_PASSWORD,
            INVALID_Mobile,
            INVALID_Email,
        }
        public RegularRegistrationType type;
        public ExceptionRegularRegistration(RegularRegistrationType type, string input) : base(input)
        {
            this.type = type;
        }
    }
}
