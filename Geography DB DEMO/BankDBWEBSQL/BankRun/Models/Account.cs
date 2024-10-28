using System;
using System.Collections.Generic;

namespace BankRun.Models
{
    public partial class Account
    {
        private static int identityCounter = -1;
        static Account()
        {
            using (var db = new BankDBContext())
            {
                identityCounter = db.Accounts.Select(ac => ac.Id).Max() + 1;
            }
        }
        public Account()
        {
            Id = identityCounter;
            identityCounter++;
        }
        public Account(decimal? balance):this()
        {
            Balance = balance;
        }
        public int Id { get; set; }
        public int AccountHolderId { get; set; }
        public decimal? Balance { get; set; }

        public virtual AccountHolder AccountHolder { get; set; } = null!;
    }
}
