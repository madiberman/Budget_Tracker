using System;
namespace _7SENG003W_CW1
{
    public class Budget
    {
        private double amount;
        private Category category;

        public Budget(double a, Category c)
        {
            amount = a;
            category = c;
        }

        public void printBudgetInfo()
        {
            Console.WriteLine("Budget Amount: " + amount);
            Console.WriteLine("Category: " + category);
        }

        public double getAmount()
        {
            return amount;
        }

        public Category getCategory()
        {
            return category;
        }

        public void setAmount(double a)
        {
            amount = a;
        }
    }
}
