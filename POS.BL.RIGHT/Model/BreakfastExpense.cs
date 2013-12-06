using POS.BL.RIGHT.Model.Abstract;

namespace POS.BL.RIGHT.Model
{
    public class BreakfastExpense : Expense
    {
        public BreakfastExpense(int amount) : base(amount)
        {
        }

        public override bool IsOverage()
        {
            return Amount > 1000;
        }

        public override bool IsMeal()
        {
            return true;
        }
    }
}