namespace RegexExpression
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("regex Experssion");
            Console.WriteLine("hint 1. name(first/last) 2.email 3.password");
            Validation Code = new Validation();
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("enter the first name");//"Snehal"
                    string firstName = Console.ReadLine();
                    Code.TestName(firstName);
                    Console.WriteLine("--------------");
                    Console.WriteLine("enter the last name");//"Bansod"
                    string lastName = Console.ReadLine();
                    Code.TestName(lastName);
                    break;

                    case 2:
                    Console.WriteLine("enter the Email");//"abc@xyzhg.com";
                    string Email = Console.ReadLine(); 
                    Code.TestEmail(Email);
                    /*1. abc@yahoo.com, -valid
                   • 2. abc-100@yahoo.com,
                   • 3. abc.100@yahoo.com
                   • 2. abc111@abc.com,
                   • 4. abc-100@abc.net,
                   • 5. abc.100@abc.com.au
                   • 6. abc@1.com, - Invalid
                   • 7. abc@gmail.com.com
                   • 8. abc+100@gmail.com */
                    break;

                case 3:
                    Console.WriteLine("Enter the password");//"snehalnaeD4."
                    string passWord = Console.ReadLine();
                    Code.TestPassword(passWord);
                    break;
            }


            Console.ReadLine();
        }
    }
   
}