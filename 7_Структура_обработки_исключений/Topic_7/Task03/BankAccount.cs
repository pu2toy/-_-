using System;
namespace Task03
{
    public class BankAccount
    {
        decimal balance;

        public BankAccount(decimal balance)
        {
            this.balance = balance;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > balance)
            {
                throw new InsufficientFundsException("Недостаточно средств!");
            }
            else
            {
                balance -= amount;
            }
        }

        public void CheckBalance()
        {
            Console.WriteLine("Баланс: " + balance);
        }
    }
}

