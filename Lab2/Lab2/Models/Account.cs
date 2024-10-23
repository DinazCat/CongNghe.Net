using System;
using System.Collections.Generic;

namespace Lab2.Models
{
    public partial class Account
    {
        public int AccountId { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Role { get; set; } = null!;

        public virtual User? User { get; set; }
    }
}
