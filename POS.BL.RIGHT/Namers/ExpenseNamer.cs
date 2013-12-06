using POS.BL.RIGHT.Model;
using POS.BL.RIGHT.Model.Abstract;
using POS.BL.RIGHT.Namers.Abstract;

namespace POS.BL.RIGHT.Namers
{
    public class ExpenseNamer : IExpenseNamer
    {
        public string GetName(Expense expense)
        {
            if(expense is DinnerExpense)
            {
                return "Dinner";
            }
            
            if(expense is BreakfastExpense)
            {
                return "Breakfast";
            }
            
            if(expense is CarRentalExpense)
            {
                return "Car rental";
            }

            return "TILT";
        }
    }
}