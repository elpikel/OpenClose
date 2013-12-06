using System;
using System.Collections.Generic;
using POS.BL.Models;
using POS.BL.Printers;
using POS.BL.Types;

namespace POS.BL.Reports
{
    public class ExpenseReport
    {
        private readonly List<Expense> _expenses = new List<Expense>();

        public void PrintReport()
        {
            var printer = new ReportPrinter();
            int total = 0;
            int mealExpenses = 0;

            printer.Print("Expenses " + GetDate() + "\n");

            foreach (var expense in _expenses)
            {
                if (expense.Type == ExpenseType.Breakfast || expense.Type == ExpenseType.Dinner)
                    mealExpenses += expense.Amount;

                String name = "TILT";
                switch (expense.Type)
                {
                    case ExpenseType.Dinner: name = "Dinner"; break;
                    case ExpenseType.Breakfast: name = "Breakfast"; break;
                    case ExpenseType.CarRental: name = "Car Rental"; break;
                }
                printer.Print(string.Format("{0}\t{1}\t{2}\n",
                  ((expense.Type == ExpenseType.Dinner && expense.Amount > 5000)
                  || (expense.Type == ExpenseType.Breakfast && expense.Amount > 1000)) ? "X" : " ",
                  name, expense.Amount / 100.0));

                total += expense.Amount;
            }

            printer.Print(string.Format("\nMeal expenses {0}", mealExpenses / 100.0));
            printer.Print(string.Format("\nTotal {0}", total / 100.0));
        }

        public void AddExpense(Expense expense)
        {
            _expenses.Add(expense);
        }

        private String GetDate()
        {
            return "9/12/2002";
        }
    }
}