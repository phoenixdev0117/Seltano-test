using System;

public class BankAccount {
    // Property for account holder's name
    public string AccountHolder { get; set; }
    // Property for account balance, only accessible within this class
    public decimal Balance { get; private set; }

    //account holder
    public BankAccount(string accountHolder) {
        // Initialize account holder's name and balance upon creation of an account object
        AccountHolder = accountHolder;
        Balance = 0;
    }
    //Deposit
    public void Deposit(decimal amount) {
        if (amount > 0) {
            Balance += amount;
        }
    }
    //Withdraw
    public bool Withdraw(decimal amount) {
        if (amount > 0 && amount <= Balance) {
            Balance -= amount;
            return true;
        }
        return false; // Withdrawal failed due to insufficient funds
    }
}

class Program {
    static void Main(string[] args) {
        
        BankAccount account = new BankAccount("John Doe");
        account.Deposit(1000);
        Console.WriteLine($"Account holder: {account.AccountHolder}");
        Console.WriteLine($"Balance: {account.Balance}");
        
        // Test withdrawal
        if (account.Withdraw(500)) {
            Console.WriteLine($"Withdrawal successful! New Balance: {account.Balance}");
        } else {
            Console.WriteLine("Withdrawal failed due to insufficient funds.");
        }
    }
}