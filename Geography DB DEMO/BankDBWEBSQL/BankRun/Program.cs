using BankRun.Models;
using Microsoft.EntityFrameworkCore;

namespace BankRun
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Do you like to create new AccountHolders Y/N");
            string command = Console.ReadLine();
            while (command.ToLower().StartsWith('y'))
            {
                CreateNewAccountHolder();
                Console.WriteLine("Do you like to create new AccountHolders Y/N");
                command = Console.ReadLine();
            }

            Thread.Sleep(2000);
            Console.WriteLine("Listing All Account Holders and their Accounts");
            AccountHolder[] holders = null;

            using (var db = new BankDBContext())
            {
                holders = db.AccountHolders.Include(h => h.Accounts).ToArray();
            }

            foreach (var h in holders)
            {
                string data = h.GetInfo();
                Console.WriteLine(data);
                Console.WriteLine();
                Thread.Sleep(1000);
            }
        }

        private static void CreateNewAccountHolder()
        {
            Console.WriteLine("--Create NEW BANK Holder--");
            Console.WriteLine();

            Console.WriteLine("Input Holder FirstName:");
            string f_name = Console.ReadLine();
            Console.WriteLine("Input Holder LastName:");
            string l_name = Console.ReadLine();

            Console.WriteLine("Input Holder SSN:");
            string ssn = Console.ReadLine();

            AccountHolder newAccountHolder = new AccountHolder(f_name, l_name, ssn);

            List<Account> accountsOfHolder = new List<Account>();

            Console.WriteLine("Type all account banalces, or type End to finish!");

            while (true)
            {
                string input = Console.ReadLine(); //баланс или End
                if (input.ToLower() == "end")
                {
                    break;
                }
                var newAccount = new Account(decimal.Parse(input));
                accountsOfHolder.Add(newAccount);
            }
            newAccountHolder.Accounts = accountsOfHolder;

            using (var db = new BankDBContext())
            {
                db.AccountHolders.Add(newAccountHolder);
                db.SaveChanges();
            }
        }
    }
}