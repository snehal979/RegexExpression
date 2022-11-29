namespace RegexExpression
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("regex Experssion");
            Console.WriteLine("-------------");
            Validation Code = new Validation();
           
            string input = "91 9887328492";
            Code.Test(input);



            Console.ReadLine();
        }
    }
}