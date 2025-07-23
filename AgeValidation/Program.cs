using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Step 1: Create a class that inherits from Exception
public class InsufficientBalanceException : Exception
{
    // Step 2: Constructor that takes a message parameter and passes it to the base class constructor
    public InsufficientBalanceException(string message) : base(message)
    {
    }

    // Step 3: Optionally, you can add additional properties or methods if needed
    // For example: public double AttemptedAmount { get; set; }
}

// Step 4: Use the custom exception in your code where you want to validate balance
public class BankAccount
{
    // Balance property with public getter and private setter
    public double Balance { get; private set; }

    // Constructor to initialize account with balance
    public BankAccount(double initialBalance)
    {
        if (initialBalance < 0)
            throw new ArgumentException("Initial balance cannot be negative.");

        Balance = initialBalance;
    }

    // Method to withdraw money from the account
    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be greater than zero.");
        }

        if (amount > Balance)
        {
            // Throw custom exception when balance is insufficient
            throw new InsufficientBalanceException($"Withdrawal failed. Available balance is only {Balance}.");
        }

        Balance -= amount;
        Console.WriteLine($"Withdrawal of {amount} successful. Remaining Balance: {Balance}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Create a bank account with an initial balance
            BankAccount account = new BankAccount(1000);

            // Try withdrawing a valid amount
            account.Withdraw(300);  // Success

            // Try withdrawing more than available balance
            account.Withdraw(800);  // This will throw custom exception
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine($"Insufficient Balance Exception Caught: {ex.Message}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Argument Exception Caught: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected Exception: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Transaction completed. Thank you for banking with us.");
        }
    }
}