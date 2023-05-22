using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectCSHARP.Classes
{
    [Serializable]
      public class Offer
    {
        public String offerName { get; set; }
        public int offerId { get; set; }
       
        public float biddingPrice { get; set; }

        int noOffers { get; set; }

        //default ctor
        public Offer()
        {
        }

        //parameters ctor
        public Offer(String name, int id,  float price2)
        {
            offerName = name;
            offerId = id;
            biddingPrice = price2;
            noOffers++;
        }

        //copy ctor
        public Offer(Offer previousOffer) : this(previousOffer.offerName, previousOffer.offerId, previousOffer.biddingPrice)
        {
            noOffers++;
        }

        //destructor
        ~Offer()
        {
            noOffers--;
        }

    }
}
