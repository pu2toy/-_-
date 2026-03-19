using System;
namespace Task03
{
    public class Bank
    {
        BankAccount[] accounts = new BankAccount[1];

        public void GenerateAccounts(int count)
        {
            accounts = new BankAccount[count];
            Random rnd = new Random();

            for (int i = 0; i < count; i++)
            {
                if (rnd.Next(2) == 0)
                {
                    accounts[i] = new SavingsAccount
                    {
                        accountNumber = 1000 + i,
                        balance = rnd.Next(0, 10000),
                        ownerName = "Client " + i,
                        interestRate = 0.05f
                    };
                }
                else
                {
                    accounts[i] = new CheckingAccount
                    {
                        accountNumber = 2000 + i,
                        balance = rnd.Next(0, 10000),
                        ownerName = "Client " + i,
                        overdraftLimit = 5000f
                    };
                }
            }
        }

        public void PrintAccounts()
        {
            foreach(BankAccount account in accounts)
            {
                if (account is SavingsAccount s)
                {
                    Console.WriteLine($"Savings: {s.ownerName}, Balance: {s.balance}, " +
                        $"Interest: {s.interestRate}, AccountNumber:{s.accountNumber}");
                }
                else if (account is CheckingAccount c)
                {
                    Console.WriteLine($"Checking: {c.ownerName}, Balance: {c.balance}, " +
                        $"Overdraft: {c.overdraftLimit}, AccountNumber:{c.accountNumber}");
                }
            }
        }

        public void GetRichestClient()
        {
            float max = 0f;
            BankAccount? richest = null;

            foreach(BankAccount account in accounts)
            {
                if (account.balance > max)
                {
                    max = account.balance;
                    richest = account;
                }
            }

            if (richest != null)
            {
                Console.WriteLine("Самый богатый клиент: " + richest.ownerName);
            }
            else
            {
                Console.WriteLine("Нет аккаунтов");
            }
        }

        public float GetTotalBankBalance()
        {
            float bankBalance = 0f;
            foreach (BankAccount account in accounts)
            {
                bankBalance += account.balance;
            }
            return bankBalance;
        }
    }
}

