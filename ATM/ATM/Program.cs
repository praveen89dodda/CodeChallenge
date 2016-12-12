using System;
using CommonInterfaces;
using CommonMethods;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter transaction type:");
            string option = Console.ReadLine();
            Console.WriteLine("Please enter account Type: ");
            string accountType = Console.ReadLine();
            

            IAccount account = Account.GetAccount(accountType);
            if (account == null)
            {
                Console.WriteLine(" This particular account type ' {0} ' not implemented", accountType);
            }
            else
            {
                switch (option.ToLower())
                {
                    case "withdraw":
                        account.WithDraw();
                        break;
                    case "deposit":
                        account.Deposit();
                        break;
                    case "balance":
                        account.Balance();
                        break;
                    default: Console.WriteLine("This particular operation '{0}' not implemented", option);
                        break;

                }
            }
            
                

            Console.ReadKey();
        }
    }
}
