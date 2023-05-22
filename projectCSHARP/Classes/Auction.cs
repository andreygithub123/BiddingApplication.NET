using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectCSHARP.Classes
{
    internal class Auction
    {

        //an auction has a list of bidders and a list of offers ( 1 to 1 relationship : bidder - offer )
        //auction a sold for price p to bidder b ,offerNo b

       // public int bidderId { get; set; }
        public int offerId { get; set; }
        public int auctionId { get; set; }
        public string auctionName { get;set; }
        public float auctionPrice { get; set; }
        public int auctionNo { get; set; }
       // List<Bidder> bidderList { get; set; }
       // List<Offer> listOffer { get; set; }

        //default ctor
        public Auction()
        {
            // bidderId = 0;
            //offerId = 0;
            //auctionId = 0;
            //auctionPrice = 0;
            //auctionName = string.Empty;
            //auctionNo++;

            //bidderList = null;
            //listOffer = null;
        }

        //parameters ctor
       /* public Auction(int offerId, string name, float auctionPrice)
        {
           // this.bidderId = bidderId;
            this.offerId = offerId;
            this.auctionPrice = auctionPrice;
            this.auctionName = name;
           
            auctionNo++;
        }*/

        public Auction(int auctionId,int offerId, string name, float auctionPrice)
        {
            this.auctionId = auctionId;
            this.offerId = offerId;
            this.auctionPrice = auctionPrice;
            this.auctionName = name;

            auctionNo++;
        }

        //copy ctor
        public Auction(Auction previousAuction) : this(previousAuction.auctionId,previousAuction.offerId, previousAuction.auctionName,previousAuction.auctionPrice)
        {
            auctionNo++;
        }

        //destructor
        ~Auction()
        {
            auctionNo--;
        }
    }
}
