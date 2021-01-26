using System;
using System.Collections.Generic;
using System.Text;

namespace GamerServiceDemo
{
    class WeekendSpecialOfferManager : ISpecialOfferService
    {
        public void AddSpecialOffer(SpecialOffer specialOffer)
        {
            specialOffer.SpecialOfferName = "Haftasonu İndirimi";
            Console.WriteLine("Haftasonu indirimi sisteme eklendi.");
        }

        public void DeleteSpecialOffer()
        {
            Console.WriteLine("Haftasonu indirimi sistemden kaldırıldı.");
        }

        public void UpdateSpecialOffer()
        {
            Console.WriteLine("Haftasonu indirimi güncellendi.");
        }
    }
}
