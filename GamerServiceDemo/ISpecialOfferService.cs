using System;
using System.Collections.Generic;
using System.Text;

namespace GamerServiceDemo
{
    interface ISpecialOfferService 
    {
        void AddSpecialOffer(SpecialOffer specialOffer);
        void UpdateSpecialOffer();
        void DeleteSpecialOffer();
    }
}
