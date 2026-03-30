namespace Task03
{
    class Program
    {
        public static void Main()
        {
            StockMarket market = new StockMarket();

            var investor = new Investor("Ваня");

            market.Subscribe(investor);
            market.Subscribe(new Investor("Галя"));

            market.Notify();
            market.Detach(investor);
            market.Notify();
        }
    }
}