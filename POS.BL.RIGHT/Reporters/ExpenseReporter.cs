using System;
using POS.BL.RIGHT.Model;
using POS.BL.RIGHT.Model.Abstract;
using POS.BL.RIGHT.Namers.Abstract;
using POS.BL.RIGHT.Printers.Abstract;

namespace POS.BL.RIGHT.Reporters
{
    public class ExpenseReporter
    {
        private readonly ExpenseReport _report;
        private readonly IExpenseNamer _expenseNamer;
        private IReportPrinter _printer;

        public ExpenseReporter(ExpenseReport report, IExpenseNamer expenseNamer)
        {
            _report = report;
            _expenseNamer = expenseNamer;
        }

        public void PrintReport(IReportPrinter printer)
        {
            _printer = printer;
            _report.SumExpenses();
            PrintExpensesAndTotals();
        }

        private void PrintExpensesAndTotals()
        {
            PrintHeader();
            PrintExpenses();
            PrintTotals();
        }

        private void PrintTotals()
        {
            _printer.Print(string.Format("\nMeal expenses: {0}", _report.MealExpenses));
            _printer.Print(string.Format("\nTotal: {0}", _report.Total));
        }

        private void PrintExpenses()
        {
            foreach (var expense in _report.Expenses)
            {
                PrintExpense(expense);
            }
        }

        private void PrintExpense(Expense expense)
        {
            _printer.Print(string.Format("{0}\t{1}\t{2}\n",
                expense.IsOverage() ? "X" : " ", 
                _expenseNamer.GetName(expense), 
                expense.Amount));
        }

        private void PrintHeader()
        {
            _printer.Print(string.Format("Expenses {0} \n", GetDate()));
        }

        private string GetDate()
        {
            return DateTime.Now.ToShortDateString();
        }
    }
}