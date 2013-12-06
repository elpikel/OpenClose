namespace POS.BL.RIGHT.Model.Abstract
{
    public abstract class Expense
    {
        public int Amount { get; private set; }

        protected Expense(int amount)
        {
            Amount = amount;
        }

        public abstract bool IsOverage();

        public abstract bool IsMeal();
    }
}