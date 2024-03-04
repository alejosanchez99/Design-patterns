namespace Observer.Example2
{
    using System;

    public class Bidder : IBidder
    {
        private readonly string name;

        public Bidder(string name)
        {
            this.name = name;
        }
        public void Update(AuctionItem auctionItem)
        {
            Console.WriteLine($"{this.name} notified. New highest bid on {auctionItem.Name} is {auctionItem.Price}");
        }
    }
}
