using System;
using System.Collections.Generic;
using System.IO;
namespace _7SENG003W_CW1
{
    public class ExpenseTracker
    {
        List<Budget> budgets = new List<Budget>();
        List<Transaction> transactions = new List<Transaction>();
        List<Category> categories = new List<Category>();

        public ExpenseTracker()
        {

        }

        public void createBudget()
        {
            Console.WriteLine("Would you like to create a new budget? (y/n)");
            Console.WriteLine("");
            string expression = Console.ReadLine();

            switch (expression)
            {
                case "y":
                    Console.WriteLine("");
                    Console.WriteLine("What is the amount of the budget?");
                    double amount = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("");
                    Console.WriteLine("What is the category of the budget?");
                    string cat = Console.ReadLine();
                    Category category = new Category(cat);

                    bool test1 = false;

                    foreach (Category c in categories)
                    {
                        if (c.getName().ToUpper() == cat.ToUpper())
                        {
                            Budget newBudget = new Budget(amount, c);
                            budgets.Add(newBudget);
                            Console.WriteLine("");
                            Console.WriteLine("New budget created successfully");
                            Console.WriteLine("");
                            test1 = true;
                            break;
                        }
                    }

                    if (test1 == false)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("This category doesn't exist, would you like to add it as a new category? (y/n)");
                        Console.WriteLine("");
                        string answer = Console.ReadLine();
                        switch (answer)
                        {
                            case "y":
                                Budget newBudget = new Budget(amount, category);
                                categories.Add(category);
                                budgets.Add(newBudget);
                                Console.WriteLine("");
                                Console.WriteLine("New budget created successfully");
                                Console.WriteLine("");
                                break;
                            case "n":
                                this.createBudget();
                                break;
                            default:
                                Console.WriteLine("Invalid input");
                                Console.WriteLine("");
                                break;
                        }
                    }
                    break;
        
                case "n":
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    Console.WriteLine("");
                    break;
            }
        }


        public void createTransaction()
        {
            Console.WriteLine("Would you like to create a new transaction? (y/n)");
            Console.WriteLine("");
            string expression = Console.ReadLine();

            switch (expression)
            {
                case "y":
                    Console.WriteLine("What is the amount of the transaction?");

                    double amount = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    Console.WriteLine("Is the transaction income or expense? (i/e)");
                    Console.WriteLine("");
                    string income = Console.ReadLine();

                    bool i = true;
                    switch (income)
                    {
                        case "i":
                            i = true;
                            break;
                        case "e":
                            i = false;
                            break;
                        default:
                            Console.WriteLine("Invalid input");
                            Console.WriteLine("");
                            break;
                    }

                    Console.WriteLine("What is the category of the transaction?");
                    string cat = Console.ReadLine();
                    Category category = new Category(cat);

                    bool true2 = false;
                    foreach (Category c in categories)
                    {
                        if (c.getName().ToUpper() == cat.ToUpper())
                        {
                            Transaction newTransaction = new Transaction(amount, i, c);
                            newTransaction.setID(transactions.Count + 1);
                            transactions.Add(newTransaction);
                            Console.WriteLine("");
                            Console.WriteLine("New transaction created successfully");
                            Console.WriteLine("");
                            true2 = true;
                            break;
                        }
                    }
                    if (true2 == false)
                    {
                        Console.WriteLine("This category doesn't exist, would you like to add it as a new category? (y/n)");
                        Console.WriteLine("");

                        string answer = Console.ReadLine();
                        switch (answer)
                        {
                            case "y":
                                categories.Add(category);
                                Transaction newTransaction = new Transaction(amount, i, category);
                                newTransaction.setID(transactions.Count + 1);
                                transactions.Add(newTransaction);
                                Console.WriteLine("");
                                Console.WriteLine("New transaction created successfully");
                                Console.WriteLine("");
                                break;
                            case "n":
                                this.createTransaction();
                                break;
                            default:
                                Console.WriteLine("Invalid input");
                                Console.WriteLine("");
                                break;
                        }
                    }
                 break;
 
                case "n":
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    Console.WriteLine("");
                    break;
            }
        }

        public void editTransaction()
        {
            Category c = new Category("NULL");
            Transaction tra = new Transaction(0.0, false, c);

            Console.WriteLine("");
            Console.WriteLine("Would you like to edit a transaction? (y/n)");
            Console.WriteLine("");
            int j = 0;
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "y":
                    Console.WriteLine("Please enter the ID of the transaction you would like to edit: ");
                    Console.WriteLine("");
                    this.listAllTransactions();
                    Console.WriteLine("");
                    int IDRead = Convert.ToInt32(Console.ReadLine());
                    foreach (Transaction t in transactions)
                    {
                        if (t.getID() == IDRead)
                        {
                            tra = t;
                            break;
                        }
                        else
                        {
                            j++;
                        }
                    }

                    if (j > 0)
                    {
                        Console.WriteLine("This transaction doesn't exist");
                        Console.WriteLine("");
                        break;
                    }

                    foreach (Transaction t in transactions)
                    {
                        if (t == tra)
                        {
                            Console.WriteLine("Enter '1' if you would like to edit the amount");
                            Console.WriteLine("Enter '2' if you would like to edit the income/expense status");
                            Console.WriteLine("Enter '3' if you would like to edit the category");

                            Console.WriteLine("");
                            string expression = Console.ReadLine();
                            Console.WriteLine("");

                            switch (expression)
                            {
                                case "1":
                                    Console.WriteLine("What is the new amount of this transaction?");
                                    double a = Convert.ToDouble(Console.ReadLine());
                                    t.setAmount(a);
                                    Console.WriteLine("");
                                    Console.WriteLine("Transaction updated successfully");
                                    Console.WriteLine("");
                                    break;
                                case "2":
                                    Console.WriteLine("Is this transaction income or expense? (i/e)");
                                    string income = Console.ReadLine();
                                    switch (income)
                                    {
                                        case "i":
                                            tra.setIncome(true);
                                            break;
                                        case "e":
                                            tra.setIncome(false);
                                            break;
                                        default:
                                            Console.WriteLine("Invalid input");
                                            this.editTransaction();
                                            break;
                                    }
                                    Console.WriteLine("");
                                    Console.WriteLine("Transaction updated successfully");
                                    Console.WriteLine("");
                                    break;
                                case "3":
                                    Console.WriteLine("What is the new category of the transaction?");
                                    string cat = Console.ReadLine();
                                    Category category = new Category(cat);
                                    Console.WriteLine("");

                                    bool true3 = false;
                                    foreach (Category cc in categories)
                                    {
                                        if (cc == category)
                                        {
                                            tra.setCategory(cc);
                                            Console.WriteLine("Transaction updated successfully");
                                            true3 = true;
                                            Console.WriteLine("");
                                        }
                                    }
                                        if (true3 == false)
                                        {
                                            Console.WriteLine("This category doesn't exist, would you like to add it as a new category? (y/n)");
                                            Console.WriteLine("");

                                            string newCat = Console.ReadLine();
                                            switch (newCat)
                                            {
                                                case "y":
                                                    categories.Add(category);
                                                    tra.setCategory(category);
                                                    Console.WriteLine("Transaction updated successfully");
                                                    Console.WriteLine("");
                                                    break;
                                                case "n":
                                                    this.editTransaction();
                                                    break;
                                                default:
                                                    Console.WriteLine("Invalid input");
                                                    Console.WriteLine("");
                                                    break;
                                            }
                                        }
                                    
                                    break;

                                default:
                                    Console.WriteLine("Invalid input");
                                    Console.WriteLine("");
                                    this.editTransaction();
                                    break;
                            }
                        }
                    }
                    break;
                case "n":
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    Console.WriteLine("");
                    this.editTransaction();
                    break;
            }
        }


        public void deleteTransaction()
        {
            int j = 0;
            Console.WriteLine("Please enter the ID of the transaction would you like to edit: ");
            Console.WriteLine("");
            this.listAllTransactions();
            Console.WriteLine("");
            string IDRead = Console.ReadLine();
            foreach (Transaction t in transactions)
            {
                if (Convert.ToString(t.getID()) == IDRead)
                {
                    transactions.Remove(t);
                    Console.WriteLine("Transaction successfully removed");
                    Console.WriteLine("");
                    j++;
                    break;
                }
            }
            if (j == 0)
            {
                Console.WriteLine("This transaction doesn't exist");
                Console.WriteLine("");
            }
        }

        public void createCategory(string cat)
        {
            Category category = new Category(cat.ToUpper());
            categories.Add(category);
        }

        public void listAllTransactions()
        {
            Console.WriteLine("All transactions:");
            for (int i = 0; i < transactions.Count; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Transaction ID: " + transactions[i].getID());
                Console.WriteLine("Amount: " + transactions[i].getAmount());
                Console.WriteLine("Is it income?: " + transactions[i].getIncome());
                Console.WriteLine("Category: " + transactions[i].getCategory().getName());
                Console.WriteLine("");
            }
        }

        public void listRecentTransactions()
        {
            Console.WriteLine("Recent transactions:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Transaction ID: " + transactions[i].getID());
                Console.WriteLine("Amount: " + transactions[i].getAmount());
                Console.WriteLine("Is it income?: " + transactions[i].getIncome());
                Console.WriteLine("Category: " + transactions[i].getCategory().getName());
                Console.WriteLine("");
            }
        }

        public void listCategories()
        {
            for (int i = 0; i < categories.Count; i++)
            {
                Console.WriteLine(categories[i].getName());
                Console.WriteLine("");
            }
        }

        public void printProgress()
        {

            double overallBudget = 0;
            double overallIncome = 0;
            double overallExpenses = 0;

            foreach (Budget b in budgets)
            {
                double a = b.getAmount();
                overallBudget += a;
            }

            foreach (Transaction t in transactions)
            {
                bool incomeStatus = t.getIncome();
                if (incomeStatus == true)
                {
                    double a = t.getAmount();
                    overallIncome += a;
                }
                else
                {
                    double a = t.getAmount();
                    overallExpenses += a;
                }
            }

            double remainingBudget = overallBudget + overallIncome - overallExpenses;

            Console.WriteLine("Overall budget progress:");
            Console.WriteLine("");
            Console.WriteLine("Total budget: " + overallBudget);
            Console.WriteLine("Total expenses: " + overallExpenses);
            Console.WriteLine("Total income: " + overallIncome);
            Console.WriteLine("");
            Console.WriteLine("Remaining budget: " + remainingBudget);


            foreach (Category c in categories)
            {
                double catBudget = 0;
                double catExpenses = 0;
                string cat = c.getName();
                foreach (Transaction t in transactions)
                {
                    if (t.getCategory() == c)
                    {
                        if (t.getIncome() == true)
                        {
                            catExpenses -= t.getAmount();
                        }
                        else
                        {
                            catExpenses += t.getAmount();
                        }
                    }
                }

                foreach (Budget b in budgets)
                {
                    if (b.getCategory() == c)
                    {
                        catBudget += b.getAmount();
                    }
                }
                    Console.WriteLine("Original budget for " + cat);
                    Console.WriteLine(catBudget);
                    Console.WriteLine("Total expenses: ");
                    Console.WriteLine(catExpenses);
                    Console.WriteLine("Remaining budget: ");
                    Console.WriteLine(catBudget - catExpenses);
                    Console.WriteLine("");
                
            }
        }
    }
}
