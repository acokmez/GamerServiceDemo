using System;
using System.Collections.Generic;
using System.Text;

namespace GamerServiceDemo
{
    class ChristmasSpecialOfferManager : ISpecialOfferService
    {
        public void AddSpecialOffer(SpecialOffer specialOffer)
        {
            specialOffer.SpecialOfferName = "Yılbaşı İndirimi";
            Console.WriteLine("Yılbaşı indirimi sisteme eklendi.");
        }

        public void DeleteSpecialOffer()
        {
            Console.WriteLine("Yılbaşı indirimi sistemden kaldırıldı.");
        }

        public void UpdateSpecialOffer()
        {
            throw new NotImplementedException("Yılbaşı indirimi güncellendi.");
        }
    }
}
