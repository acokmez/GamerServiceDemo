using System;

namespace GamerServiceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game();
            game1.GameId = 12;
            game1.GameName = "Grand Theft Auto V";
            game1.GamePrice = 129.99;

            Game game2 = new Game();
            game2.GameId = 15;
            game2.GameName = "The Witcher 3: Wild Hunt";
            game2.GamePrice = 79.99;

            Gamer gamer1 = new Gamer();
            gamer1.GamerId = 1234;
            gamer1.GamerName = "Melek";
            gamer1.GamerLastName = "Ünsal";
            gamer1.NationalityId = "123456789";
            gamer1.BirthYear = "2000";

            SpecialOffer specialOffer = new SpecialOffer();
            specialOffer.SpecialOfferName = null;

            GamerManager gamerManager = new GamerManager();
            gamerManager.RegisterGamer(gamer1);
            Console.WriteLine();

            ChristmasSpecialOfferManager christmasSpecialOfferManager = new ChristmasSpecialOfferManager();
            JuneSpecialOfferManager juneSpecialOfferManager = new JuneSpecialOfferManager();
            WeekendSpecialOfferManager weekendSpecialOfferManager = new WeekendSpecialOfferManager();

            christmasSpecialOfferManager.AddSpecialOffer(specialOffer);

            SalesManager salesManager = new SalesManager();
            salesManager.SellSpecialOfferGame(game1, specialOffer, gamer1);
            Console.WriteLine();

            christmasSpecialOfferManager.DeleteSpecialOffer();
            Console.WriteLine();
            salesManager.SellGame(game1, gamer1);
            Console.WriteLine();

            juneSpecialOfferManager.AddSpecialOffer(specialOffer);
            Console.WriteLine();
            salesManager.SellSpecialOfferGame(game2, specialOffer, gamer1);
            Console.WriteLine();
            weekendSpecialOfferManager.UpdateSpecialOffer();
        }
    }
}
