using System;
using System.Collections.Generic;
using System.Text;

namespace NBAKonferencja
{
    class Redaktor:Osoba
    {
        private string numer_licencji;

        public Redaktor(string imie, string nazwisko, string data_urodzeni, string pESEL,string numer_licencji):base(imie, nazwisko, data_urodzeni, pESEL) { 
            this.numer_licencji = numer_licencji;
        }

        public string Numer_licencji { get => numer_licencji; set => numer_licencji = value; }
    }
}
