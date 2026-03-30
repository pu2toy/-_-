namespace Task01
{
    class Program
    {
        public static void Main()
        {
            try
            {
                BankAccount account = new BankAccount("152114788a");
            }
            catch (InvalidAccountNumberException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}