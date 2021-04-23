using System;
using System.Collections.Generic;
using System.Text;

namespace NBAKonferencja
{
    class Klub
    {
        private string nazwa;
        private Wlasciciel wlasciciel;
        private Trener trener;
        private Adres adres;

        public Klub(string nazwa, Wlasciciel wlasciciel, Trener trener, Adres adres)
        {
            this.Nazwa = nazwa;
            this.Wlasciciel = wlasciciel;
            this.Trener = trener;
            this.Adres = adres;
        }

        public string Nazwa { get => nazwa; set => nazwa = value; }
        internal Wlasciciel Wlasciciel { get => wlasciciel; set => wlasciciel = value; }
        internal Trener Trener { get => trener; set => trener = value; }
        internal Adres Adres { get => adres; set => adres = value; }
    }
}
