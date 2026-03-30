using System;
namespace Task03
{
    abstract public class BankAccount
    {
        public int accountNumber { get; set; }
        public float balance { get; set;}
        public string? ownerName { get; set; }

        public abstract void Deposit(float amount);
        public abstract bool Withdraw(float amount);
    }

    sealed class SavingsAccount : BankAccount
    {
        public float interestRate { get; set; }

        public override void Deposit(float amount)
        {
            balance += amount;
        }

        public override bool Withdraw(float amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return true;
            }
            return false;
        }

        public void AddInterest()
        {
            balance += balance * interestRate;
        }
    }

    sealed class CheckingAccount : BankAccount
    {
        public float overdraftLimit { get; set; }

        public override void Deposit(float amount)
        {
            balance += amount;
        }

        public override bool Withdraw(float amount)
        {
            if (balance + overdraftLimit >= amount)
            {
                balance -= amount;
                return true;
            }
            return false;
        }
    }
}

