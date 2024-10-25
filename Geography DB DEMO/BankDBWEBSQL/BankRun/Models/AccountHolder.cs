using System;
using System.Collections.Generic;

namespace BankRun.Models
{
    public partial class AccountHolder
    {
        public AccountHolder()
        {
            Accounts = new HashSet<Account>();
        }

        public AccountHolder(string firstName, string lastName, string ssn)
        {
            FirstName = firstName;
            LastName = lastName;
            Ssn = ssn;
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Ssn { get; set; } = null!;

        public virtual ICollection<Account> Accounts { get; set; }

        public string GetInfo()
        {
            string personalInfo = $"Id:{Id}\n --{FirstName[0]}. {LastName} : {Ssn}\n";
            string accountData = "";
            decimal? balance = 0m;
            if (Accounts.Count() > 0)
            {
                for (int i = 0; i < Accounts.Count(); i++)
                {
                    accountData += $"{i + 1}) {Accounts.ToArray()[i].Balance:F2} lv\n";
                    balance += Accounts.ToArray()[i].Balance;
                }
            }

            return personalInfo + accountData + $"Total Funds {balance:F2} lv.";
        }

    }
}

