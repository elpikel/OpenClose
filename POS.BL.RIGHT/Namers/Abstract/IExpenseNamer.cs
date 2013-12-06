using POS.BL.RIGHT.Model.Abstract;

namespace POS.BL.RIGHT.Namers.Abstract
{
    public interface IExpenseNamer
    {
        string GetName(Expense expense);
    }
}