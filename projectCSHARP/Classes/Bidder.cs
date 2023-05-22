using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectCSHARP.Classes
{
    [Serializable]
    internal class Bidder
    { //a bidder can have only one offer at a time

            public string firstName { get; set; }

            
            public string lastName { get; set; }

            public DateTime dateOfBirth { get; set; }

            
            public int bidderId { get; set; }
           
            public float deposit { get; set; }

            public int noBidders { get; set; }

            public Offer offer { get; set; }

            //default ctor
            public Bidder()
            {
                firstName = string.Empty;
                lastName = string.Empty;
                bidderId = 0;
                deposit = 0;
                offer = null;
                noBidders++;
            }

            //ctor with parameters
            public Bidder(String fname, String lname, DateTime birth, int id,float deposit)
            {
                /* if (birth < DateTime.MinValue)
                     throw new ArgumentOutOfRangeException("You are to young for this shit");*/
                if (deposit < 100)
                    throw new ArgumentOutOfRangeException("You are to poor. Deposit more money");

                firstName = fname;
                lastName = lname;
                this.dateOfBirth = birth;
                this.bidderId = id;

            this.deposit = deposit;
                noBidders++;
            }

            //copy ctor
            public Bidder(Bidder previousBidder) : this(previousBidder.firstName, previousBidder.lastName, previousBidder.dateOfBirth, previousBidder.bidderId, previousBidder.deposit)
            {
                noBidders++;

            }

            //Destructor
            ~Bidder()
            {
                noBidders--;
            }


           
        }
}
