using System;
using System.Collections.Generic;
using System.Text;

namespace GamerServiceDemo
{
    class GamerManager
    {
        public void RegisterGamer (Gamer gamer)
        {
            Console.WriteLine("Hoşgeldin, " + gamer.GamerName + " Oyuncu ID: " + gamer.GamerId);
        }
        public void UpdateGamer (Gamer gamer)
        {
            Console.WriteLine(gamer.GamerName + " Hesabınız başarıyla güncellendi!");
        }
        public void DeleteGamer (Gamer gamer)
        {
            Console.WriteLine(gamer.GamerName + " Hesabınız silindi.");
        }
    }
}
