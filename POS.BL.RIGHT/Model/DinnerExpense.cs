using POS.BL.RIGHT.Model.Abstract;

namespace POS.BL.RIGHT.Model
{
    public class DinnerExpense : Expense
    {
        public DinnerExpense(int amount) : base(amount)
        {

        }

        public override bool IsOverage()
        {
            return Amount > 5000;
        }

        public override bool IsMeal()
        {
            return true;
        }
    }
}