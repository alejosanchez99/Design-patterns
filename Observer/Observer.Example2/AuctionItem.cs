namespace Observer.Example2
{
    using System.Collections.Generic;

    public class AuctionItem : IAuctionItem
    {
        private List<IBidder> bidders = new List<IBidder>();
        private IBidder highestBidder;

        public string Name { get; set; }
        public float Price { get; set; }

        public AuctionItem(string name, float startingPrice)
        {
            this.Name = name;
            this.Price = startingPrice;
        }

        public void NewBid(float price, IBidder bidder)
        {
            if (price > this.Price)
            {
                this.Price = price;
                this.highestBidder = bidder;

                this.NotifyBidders();
            }
        }

        public void NotifyBidders()
        {
            foreach (IBidder bidder in this.bidders)
            {
                bidder.Update(this);
            }
        }

        public void RegisterBidder(IBidder bidder)
        {
            this.bidders.Add(bidder);
        }

        public void RemoveBidder(IBidder bidder)
        {
            this.bidders.Remove(bidder);
        }
    }
}
