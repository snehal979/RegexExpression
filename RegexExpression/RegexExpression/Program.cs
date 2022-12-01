namespace RegexExpression
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("regex Experssion");
            Console.WriteLine("-------------");
            Validation Code = new Validation();
           
            string input = "abc@brigde.bl.co.in";  //abc.xyz@bl.co.in
            Code.Test(input);



            Console.ReadLine();
        }
    }
}