using System;
using System.Collections.Generic;
using System.Text;

namespace NBAKonferencja
{
    class Wlasciciel:Osoba
    {
        private string nazwa_firmy;

        public Wlasciciel(string imie, string nazwisko, string data_urodzeni, string pESEL,string nazwa_firmy):base(imie, nazwisko, data_urodzeni, pESEL)
        {
            this.Nazwa_firmy = nazwa_firmy;
        }

        public string Nazwa_firmy { get => nazwa_firmy; set => nazwa_firmy = value; }
    }
}
