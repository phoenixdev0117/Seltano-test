using System;

public class BankAccount {
    public string AccountHolder { get; set; }
    public decimal Balance { get; private set; }

    public BankAccount(string accountHolder) {
        AccountHolder = accountHolder;
        Balance = 0;
    }

    public void Deposit(decimal amount) {
        if (amount > 0) {
            Balance += amount;
        }
    }

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