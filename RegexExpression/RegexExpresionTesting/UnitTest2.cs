using RegexExpression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexExpresionTesting
{
    [TestClass]
    public class UnitTest2
    {
        /// <summary>
        /// Validation of Email Parametrizun
        /// </summary>
        [TestMethod]
        
        
        public void CheckGiven_Email_Validation_usingParamerterisum()
        {
            string input = "abc@xyzhg.com";
            EmailRefactor emailRefactor = new EmailRefactor(input);

            string output = emailRefactor.TestEmail_Refector();
            Assert.AreEqual("Email  matches", output);
        }

       
        

    }
}
