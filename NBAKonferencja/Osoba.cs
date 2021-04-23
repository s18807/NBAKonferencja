using System;
using System.Collections.Generic;
using System.Text;

namespace NBAKonferencja
{
    abstract class Osoba
    {
        private string imie;
        private string nazwisko;
        private string data_urodzeni;
        private string PESEL;

        protected Osoba(string imie, string nazwisko, string data_urodzeni, string pESEL)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.data_urodzeni = data_urodzeni;
            PESEL = pESEL;
        }

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public string Data_urodzeni { get => data_urodzeni; set => data_urodzeni = value; }
        public string PESEL1 { get => PESEL; set => PESEL = value; }
    }
}
