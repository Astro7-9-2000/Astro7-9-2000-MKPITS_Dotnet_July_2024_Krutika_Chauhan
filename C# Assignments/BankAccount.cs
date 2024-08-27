/* Que 1 – Define a class to represent a bank  account. Include the following members:
 Data Member :- 
Name of the depositor
- Account Number 
- Type of Account 
- Balance amount in the account
Member Functions –
To assign values 
- To deposited an amount 
- To withdraw an amount after checking balance 
- To display name and balance */

using System;
namespace BankAccount
{
    public class BankAccount
    {
        public string depositorName;
        public int accountNumber;
        public string accountType;
        public double balance;
        public BankAccount(string name, int number, string type)
        {
            depositorName = name;
            accountNumber = number;
            accountType = type;
            balance = 0.0;
        }
        public void AssignValues(string name, int number, string type, double initialBalance)
        {
            depositorName = name;
            accountNumber = number;
            accountType = type;
            balance = initialBalance;
       }
        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine("Deposit Successful. New Balance: " + balance);
        }
        public void Withdraw(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine("Withdrawal Successful. New Balance: " + balance);
           }
            else
            {
                Console.WriteLine("Insufficient Balance.");
            }
        }
        public void DisplayAccountInfo()
        {
            Console.WriteLine("Account Holder: " + depositorName);
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Account Type: " + accountType);
            Console.WriteLine("Balance: " + balance);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("John Doe", 123456, "Savings");
            account.AssignValues("John Doe", 123456, "Savings", 1000.0);
            account.DisplayAccountInfo();
            account.Deposit(500.0);
            account.Withdraw(200.0);
            account.DisplayAccountInfo();
            Console.ReadLine();
        }
    }
}
