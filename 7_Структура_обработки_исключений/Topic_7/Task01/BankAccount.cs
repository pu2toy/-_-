using System;
namespace Task01
{
    public class BankAccount
    {
        string accountNumber;

        public BankAccount(string numb)
        {
            ValidateAccount(numb);
            accountNumber = numb;
        }

        private void ValidateAccount(string num)
        {
            if (num.Length != 10 || !num.All(char.IsDigit))
            {
                throw new InvalidAccountNumberException("Неверно введен номер счета");
            }
        }
    }
}

