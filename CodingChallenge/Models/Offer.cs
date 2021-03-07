using System.Collections.Generic;

namespace CodingChallenge.Models
{
    public class Offer
    {

        public string OfferName { get; set; }
        public List<string> Products { get; set; } = new();

    }
}
