using System;
using System.Collections.Generic;
using System.Text;

namespace NBAKonferencja
{
    class Konferencja_Prasowa
    {
        private Klub klub1;
        private Klub klub2;
        private Adres adres1;
        private Adres adres2;
        private Adres adres3;
        private status status1;
        private status status2;
        private status status3;
        void CalculateAdres()
        {
            adres1 = klub1.Adres;
            adres3 = klub2.Adres;

        }
    }
    enum status {
        zaplanowany,
        odbyl,
        nie_odbyl
    }
}
