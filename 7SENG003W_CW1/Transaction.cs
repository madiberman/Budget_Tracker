using System;
namespace _7SENG003W_CW1
{
    public class Transaction
    {
        double amount;
        bool isIncome;
        Category category;
        int ID;

        public Transaction(double a, bool i, Category c)
        {
            amount = a;
            isIncome = i;
            category = c;
        }

        public void printTransactionInfo()
        {
            Console.WriteLine("Amount: " + amount);
            Console.WriteLine("Income: " + isIncome);
            Console.WriteLine("Expense: " + !isIncome);
            Console.WriteLine("Category: " + category.getName());
        }

        public double getAmount()
        {
            return amount;
        }

        public void setAmount(double a)
        {
            amount = a;
        }

        public bool getIncome()
        {
            return isIncome;
        }

        public void setIncome(bool i)
        {
            isIncome = i;
        }

        public Category getCategory()
        {
            return category;
        }

        public void setCategory(Category c)
        {
            category = c;
        }
        public void setID(int id)
        {
            ID = id;
        }

        public int getID()
        {
            return ID;
        }
    }
}
