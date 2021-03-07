using System.Collections.Generic;
using System.Linq;
using CodingChallenge.Data.Factories;
using CodingChallenge.Models;

namespace CodingChallenge.Data
{
    public class OfferRepository : IOfferRepository
    {
        private readonly List<Offer> _offers;

        public OfferRepository()
        {
            _offers = OfferFactory.CreateOffers();
        }

        public List<Offer> Get()
        {
            return _offers;
        }

        public List<Offer> Get(string filter)
        {
            if (string.IsNullOrWhiteSpace(filter))
            {
                return Get();
            }

            return _offers.Where(o => o.Products.Any(p => p.ContainsIgnoreCase(filter))).ToList();
        }
    }
}
