using System.Collections.Generic;
using CodingChallenge.Data;
using CodingChallenge.Models;
using DevExpress.Mvvm.POCO;

namespace CodingChallenge.ViewModels
{
    public class OffersViewModel
    {
        private readonly IOfferRepository _offerRepository;

        public virtual string FilterText { get; set; }
        public virtual List<Offer> Offers { get; set; }
        
        protected OffersViewModel()
        {
            _offerRepository = BootStrapper.Resolve<IOfferRepository>();

            Offers = _offerRepository.Get();
        }

        public static OffersViewModel Create()
        {
            return ViewModelSource.Create(() => new OffersViewModel());
        }
        
        public void ClearFilter()
        {
            FilterText = null;
        }

        protected void OnFilterTextChanged()
        { 
            Offers = _offerRepository.Get(FilterText);
        }
    }
}
