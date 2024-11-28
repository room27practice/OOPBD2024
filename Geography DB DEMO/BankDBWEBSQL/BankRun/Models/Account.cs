using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankRun.Models
{
    public partial class Account
    {
        //private static int identityCounter = 1;
        //static Account()
        //{
        //    //using (var db = new BankDBContext())
        //    //{
        //    //    if (!db.Accounts.Any())
        //    //    {
        //    //        return;
        //    //    }
        //    //    identityCounter = db.Accounts.Select(ac => ac.Id).Max() + 1;
        //    //}
        //}
        public Account()
        {
            //Id = identityCounter;
            //identityCounter++;
        }
        public Account(decimal? balance):this()
        {
            Balance = balance;
        }
      //  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = 0;
        public int AccountHolderId { get; set; }
        public decimal? Balance { get; set; }

        public virtual AccountHolder AccountHolder { get; set; } = null!;
    }
}
