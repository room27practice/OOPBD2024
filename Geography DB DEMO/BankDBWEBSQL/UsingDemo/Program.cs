using BankRun;
using BankRun.Models;

namespace UsingDemo
{
    internal class Program
    {
        static void Main()
        {
            List<Account> allAccounts = null;

            Account acc1 = new Account(76.94m) { AccountHolderId = 1 };

            using (var db = new BankDbContext())
            {
                allAccounts = db.Accounts.ToList();
                db.Accounts.Add(acc1);
                db.SaveChanges();
            }

            foreach (var acc in allAccounts)
            {
                Console.WriteLine(acc.Balance);
            }
        }
    }
}