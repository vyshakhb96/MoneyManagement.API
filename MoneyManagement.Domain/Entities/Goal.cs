using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManagement.Domain.Entities
{
    public class Goal
    {
        public long Id { get; set; }

        public string GoalName { get; set; }

        public decimal TargetAmount { get; set; }

        public decimal CurrentAmount { get; set; }

        public DateTime TargetDate { get; set; }

        public long UserId { get; set; }

        public User User { get; set; }
    }
}
