using System;
using System.Collections.Generic;
using System.Text;

namespace NBAKonferencja
{
    class Gracz:Osoba
    {
        private int numer;
        private int wzrost;
        private int zasieg_rak;
        private int wysokosc_skoku;
        private int obecny_klub;
        private float cena;

        public Gracz(string imie, string nazwisko, string data_urodzeni, string pESEL, int numer, int wzrost, int zasieg_rak, int wysokosc_skoku, int obecny_klub, float cena):base(imie, nazwisko, data_urodzeni,pESEL)
        {
            this.Numer = numer;
            this.Wzrost = wzrost;
            this.Zasieg_rak = zasieg_rak;
            this.Wysokosc_skoku = wysokosc_skoku;
            this.Obecny_klub = obecny_klub;
            this.Cena = cena;
        }

        public int Numer { get => numer; set => numer = value; }
        public int Wzrost { get => wzrost; set => wzrost = value; }
        public int Zasieg_rak { get => zasieg_rak; set => zasieg_rak = value; }
        public int Wysokosc_skoku { get => wysokosc_skoku; set => wysokosc_skoku = value; }
        public int Obecny_klub { get => obecny_klub; set => obecny_klub = value; }
        public float Cena { get => cena; set => cena = value; }
    }
}
