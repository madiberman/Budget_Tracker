using System;
using System.Collections.Generic;
using System.IO;

namespace _7SENG003W_CW1
{
    class Program
    {
        static void Main(string[] args)
        {
            ExpenseTracker expenses = new ExpenseTracker();
            expenses.createCategory("FOOD");
            expenses.createCategory("ENTERTAINMENT");
            expenses.createCategory("TRANSIT");
            expenses.createCategory("CLOTHES");
            expenses.createCategory("BILLS");

            while (true)
            {
                Console.WriteLine("Welcome! Please select an option from the following list: ");
                Console.WriteLine("");
                Console.WriteLine("Enter 1 to create a new budget");
                Console.WriteLine("Enter 2 to create a new transaction");
                Console.WriteLine("Enter 3 to edit an existing transaction");
                Console.WriteLine("Enter 4 to delete an existing transaction");
                Console.WriteLine("Enter 5 to create a new budget category");
                Console.WriteLine("Enter 6 to list recent transactions");
                Console.WriteLine("Enter 7 to list all transactions");
                Console.WriteLine("Enter 8 to list all budget categories");
                Console.WriteLine("Enter 9 to print budget progress");
                Console.WriteLine("");

                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        expenses.createBudget();
                        break;
                    case "2":
                        expenses.createTransaction();
                        break;
                    case "3":
                        expenses.editTransaction();
                        break;
                    case "4":
                        expenses.deleteTransaction();
                        break;
                    case "5":
                        Console.WriteLine("What would you like the new budget category to be?");
                        Console.WriteLine("");
                        string cat = Console.ReadLine();
                        expenses.createCategory(cat.ToUpper());
                        Console.WriteLine("Category successfully added");
                        break;
                    case "6":
                        expenses.listRecentTransactions();
                        break;
                    case "7":
                        expenses.listAllTransactions();
                        break;
                    case "8":
                        expenses.listCategories();
                        break;
                    case "9":
                        expenses.printProgress();
                        break;
                    default:
                        Console.Write("Invalid input");
                        break;
                }

            }

        }
    }
}
