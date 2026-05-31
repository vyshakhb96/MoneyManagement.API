using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManagement.Domain.Entities
{
    public class Budget
    {
        public long Id { get; set; }

        public decimal BudgetAmount { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        public long UserId { get; set; }

        public User User { get; set; }
    }
}
