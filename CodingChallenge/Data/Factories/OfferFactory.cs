using System.Collections.Generic;
using CodingChallenge.Models;

namespace CodingChallenge.Data.Factories
{
    public static class OfferFactory
    {
        public static List<Offer> CreateOffers()
        {
            return new()
            {
                new()
                {
                    OfferName = "Offer1",
                    Products = new List<string>
                    {
                        "ProductA1",
                        "ProductAB2",
                        "ProductAC3"
                    }
                },
                new()
                {
                    OfferName = "Offer2",
                    Products = new List<string>
                    {
                        "ProductA4",
                        "ProductAB5",
                        "ProductABC6"
                    }
                }
            };
        }
    }
}
