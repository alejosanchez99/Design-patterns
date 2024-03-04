
using Observer.Example2;

Bidder john = new Bidder("John");
Bidder jane = new Bidder("Jane");

AuctionItem item1 = new AuctionItem("Item1", 10);

item1.RegisterBidder(john);
item1.RegisterBidder(jane);

item1.NewBid(20, john);
item1.NewBid(30, jane);