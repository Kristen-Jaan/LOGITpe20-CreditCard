using System;

namespace CreditCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            Console.WriteLine("Enter your ID Code: ");
            string usersID = Console.ReadLine();
            if(Validate(usersID))
            {
              HelloUser(usersID);
              Console.WriteLine("Enter your credit card number: ");
                string Credit = Console.ReadLine();
                ValidateCredit(Credit);
                Console.WriteLine("Enter your CVV: ");
                string CVV = Console.ReadLine();
                ValidateCVV(CVV);

            }
            
            
            
            
            
            

           
        }
        public static bool Validate(string IDCode)
        {
            if(IDCode.Length == 11)
            {
                try
                {
                    long.Parse(IDCode);
                    return true;
                }
                catch(Exception NO)
                {
                    Console.WriteLine(NO);
                    return false;
                }
                

            }
            else
            {
                Console.WriteLine("Your card has been declined.");
                return false;
            }
        }
        public static void HelloUser(string IdCode)
        {
            int firstnum = Int32.Parse(IdCode[0].ToString());
            if(firstnum == 1 || firstnum == 3 || firstnum == 5)
            {
                Console.WriteLine("Hello, Sir");
            }
            else if(firstnum == 2 || firstnum == 4 || firstnum == 6)
            {
                Console.WriteLine("Hello, Madam");
            }
        }  
        public static bool ValidateCredit(string Credit)
        {
            if(Credit.Length == 16)
            {
                try
                {
                    long.Parse(Credit);
                    return true;
                }
                catch(Exception NO)
                {
                    Console.WriteLine(NO);
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Your card has been declined.");
                return false;
            }
        }
        public static bool ValidateCVV(string CVV)
        {
            if(CVV.Length == 3)
            {
                try
                {
                    long.Parse(CVV);
                    Console.WriteLine("Your card has been accepted.");
                    return true;
                }
                catch(Exception NO)
                {
                    Console.WriteLine(NO);
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Your card has been declined.");
                return false;
            }
        }
        
               
            
        
    }
}
