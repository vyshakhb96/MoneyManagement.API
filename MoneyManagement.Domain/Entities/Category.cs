using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManagement.Domain.Entities
{
    public class Category
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; } // Income or Expense

        public ICollection<Transaction> Transactions { get; set; }
    }
}
