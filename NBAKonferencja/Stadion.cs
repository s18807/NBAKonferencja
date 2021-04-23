using System;
using System.Collections.Generic;
using System.Text;

namespace NBAKonferencja
{
    class Stadion
    {
        private string nazwa;
        private int ilosc_miejsc;
        private Adres adres;

        public string Nazwa { get => nazwa; set => nazwa = value; }
        public int Ilosc_miejsc { get => ilosc_miejsc; set => ilosc_miejsc = value; }
        internal Adres Adres { get => adres; set => adres = value; }
    }
}
