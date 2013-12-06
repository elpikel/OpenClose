using POS.BL.Types;

namespace POS.BL.Models
{
    public class Expense
    {
        public ExpenseType Type { get; set; }
        public int Amount { get; set; }

        public Expense(ExpenseType type, int amount)
        {
            Type = type;
            Amount = amount;
        }
    }
}