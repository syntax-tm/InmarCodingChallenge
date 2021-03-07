using System.Collections.Generic;
using CodingChallenge.Models;

namespace CodingChallenge.Data
{
    public interface IOfferRepository
    {

        List<Offer> Get();
        List<Offer> Get(string filter);

    }
}
