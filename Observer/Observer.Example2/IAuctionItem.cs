namespace Observer.Example2
{
    public interface IAuctionItem
    {
        void RegisterBidder(IBidder bidder);
        void RemoveBidder(IBidder bidder);
        void NotifyBidders();

        void NewBid(float price, IBidder bidder);
    }
}
