using System;
using System.Collections.Generic;
using System.Text;

namespace NBAKonferencja
{
    class Mecz
    {
        private DateTime data;
        private int wynik1;
        private int wynik2;
        private Klub klub1;

        public Mecz(DateTime data, int wynik1, int wynik2, Klub klub1)
        {
            this.Data = data;
            this.Wynik1 = wynik1;
            this.Wynik2 = wynik2;
            this.Klub1 = klub1;
        }

        public DateTime Data { get => data; set => data = value; }
        public int Wynik1 { get => wynik1; set => wynik1 = value; }
        public int Wynik2 { get => wynik2; set => wynik2 = value; }
        internal Klub Klub1 { get => klub1; set => klub1 = value; }
    }
}
