using System;
using System.Collections.Generic;

namespace DB_DEMO_1.Models
{
    public partial class Manufacturer
    {
        public Manufacturer()
        {
            Candies = new HashSet<Candy>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Address { get; set; }

        public virtual ICollection<Candy> Candies { get; set; }
    }
}
