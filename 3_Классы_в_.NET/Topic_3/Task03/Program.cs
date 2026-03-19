namespace Task03
{
    class Program
    {
        public static void Main()
        {
            Bank newBank = new Bank();
            Console.WriteLine("Введите число аккаунтов.");
            int count = Convert.ToInt16(Console.ReadLine());
            newBank.GenerateAccounts(count);
            newBank.PrintAccounts();
            newBank.GetRichestClient();
            float bankBalance = newBank.GetTotalBankBalance();
            Console.WriteLine($"Общий баланс банка: {bankBalance:N4}");
        }
    }
}