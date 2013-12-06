using POS.BL.RIGHT.Model.Abstract;

namespace POS.BL.RIGHT.Model
{
    public class CarRentalExpense : Expense
    {
        public CarRentalExpense(int amount) : base(amount)
        {
        }

        public override bool IsOverage()
        {
            return false;
        }

        public override bool IsMeal()
        {
            return false;
        }
    }
}