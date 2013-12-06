using System.Collections.Generic;
using POS.BL.RIGHT.Model.Abstract;

namespace POS.BL.RIGHT.Model
{
    public class ExpenseReport
    {
        public List<Expense> Expenses;
        public int Total { get; private set; }
        public int MealExpenses { get; private set; }

        public ExpenseReport()
        {
            Expenses = new List<Expense>();
            Total = 0;
            MealExpenses = 0;
        } 

        public void SumExpenses()
        {
            foreach (var expense in Expenses)
            {
                Sum(expense);
            }
        }

        private void Sum(Expense expense)
        {
            if(expense.IsMeal())
            {
                MealExpenses += expense.Amount;
            }
            Total += expense.Amount;
        }
    }
}