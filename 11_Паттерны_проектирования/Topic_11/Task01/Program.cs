namespace Task01
{
    class Program
    {
        public static void Main(string[] args)
        {
            BankCardFactory factory = new CreditCardFactory();
            IBankCard card = factory.CreateCard();
            card.Use();
            factory = new DebitCardFactory();
            card = factory.CreateCard();
            card.Use();
            factory = new VirtualCardFactory();
            card = factory.CreateCard();
            card.Use();
        }
    }
}