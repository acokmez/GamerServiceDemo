using System;
using System.Collections.Generic;
using System.Text;

namespace GamerServiceDemo
{
    class JuneSpecialOfferManager : ISpecialOfferService
    {

        public void AddSpecialOffer(SpecialOffer specialOffer)
        {
            specialOffer.SpecialOfferName = "Haziran İndirimi";
            Console.WriteLine("Haziran indirimi sisteme eklendi.");
        }

        public void DeleteSpecialOffer()
        {
            Console.WriteLine("Haziran indirimi sistemden kaldırıldı.");
        }

        public void UpdateSpecialOffer()
        {
            Console.WriteLine("Haziran indirimi güncellendi.");
        }
    }
}
