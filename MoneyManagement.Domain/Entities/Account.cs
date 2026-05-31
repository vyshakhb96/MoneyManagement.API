using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManagement.Domain.Entities
{
    public class Account
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public decimal Balance { get; set; }

        public long UserId { get; set; }

        public User User { get; set; }
    }
}
