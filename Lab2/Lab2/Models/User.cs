using System;
using System.Collections.Generic;

namespace Lab2.Models
{
    public partial class User
    {
        public User()
        {
            Accounts = new HashSet<Account>();
        }

        public int UserId { get; set; }
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
