using System;
using System.Collections.Generic;
using System.Text;

namespace GamerServiceDemo
{
    class VerificationManager
    {
        public void VerifyGamer (Gamer gamer) // bool döndürmesi daha iyi olur ama sadece simüle ediyoruz.
        {
            Console.WriteLine("----- E-Devlet Kimlik Doğrulaması-----\n" + 
               "Sayın, " + gamer.GamerName + "--" + gamer.NationalityId + " Girdiğiniz bilgiler doğrudur.\n" + 
               "Üyeliğinizi tamamlama sayfasına yönlendiriliyorsunuz..."
                ); // Sadece doğru giriş yapıldığını varsayalım.
        }
    }
}
