using System;
using System.Collections.Generic;

namespace BankRun.Models
{
    public partial class Account
    {
        public int Id { get; set; }
        public int AccountHolderId { get; set; }
        public decimal? Balance { get; set; }

        public virtual AccountHolder AccountHolder { get; set; } = null!;
    }
}
