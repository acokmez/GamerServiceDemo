using System;
using System.Collections.Generic;
using System.Text;

namespace GamerServiceDemo
{
    class SalesManager
    {
        public void SellGame (Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.GamerName + " Satın aldığınız:\n " + 
                game.GameName + "Başarıyla koleksiyonunuza eklendi.");
        }
        public void SellSpecialOfferGame (Game game, SpecialOffer specialOffer, Gamer gamer)
        {
            Console.WriteLine(gamer.GamerName + " " + specialOffer.SpecialOfferName + " Kampanyasından satın aldığınız:\n " +
                game.GameName + " Başarıyla koleksiyonunuza eklendi.");
        }
    }
}
