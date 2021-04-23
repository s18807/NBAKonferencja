using System;
using System.Collections.Generic;
using System.Text;

namespace NBAKonferencja
{
    class Trener:Osoba
    {
        private readonly string numer_licencji_trenerskiej;

        public Trener(string imie, string nazwisko, string data_urodzeni, string pESEL,string numer_licencji_trenerskiej):base(imie, nazwisko, data_urodzeni, pESEL)
        {
            this.numer_licencji_trenerskiej = numer_licencji_trenerskiej;
        }
    }
}
