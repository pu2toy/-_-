namespace Task03
{
    class Program
    {
        public static void Main()
        {
            BankAccount account = new BankAccount(145.43m);

            try
            {
                account.Withdraw(10m);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
            }

            account.CheckBalance();
        }
    }
}