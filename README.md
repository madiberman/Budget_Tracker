# Budget_Tracker

Allows a number of budgets, transactions and categories to be tracked as the user inputs or deletes these items.

Category class: Given a name attribute to identify and differentiate different category objects from one another. Getters and setters are also added as methods to change and retrieve the name of the categories.

Transaction class: Given an amount attribute to track the amount of the transaction, isExpense to differentiate between income and expense, an ID to track the transaction itself and an instance of a category object to link the transaction to a category. The methods added include printTransaction to be able to print the details of an instance of the transaction object to the console. getAmount to be able to return the amount of the transaction and setAmount to set the amount of the transaction.
 
Budget class: Given an amount attribute to track the amount of the budget that is set and an instance of a category object to link it to that budget object. The methods included are getAmount and setAmount which work as they do for the transaction class, getCategory to return the category object link with this specific instance of a budget object and printBudget which prints all relevant details of a budget object to the console.
ExpenseTracker class: This class is where all the ‘business’ logic occurs and brings together all the objects previously mentioned to fulfil the requirements of this budget application. Contains a list of each object i.e. budget, category and transaction.
The methods included allow for the creation of all objects and then listing all of those objects included in the lists stored in the instance of the ExpenseTracker object. The PrintProgress method allows for the budgets of each category to be totalled and compared against the income and relevant information printed to the console, which includes total budget, total expenses, total income and how much is remaining in the budget.
