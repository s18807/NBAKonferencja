using System;
using System.Collections.Generic;
using System.Text;

namespace NBAKonferencja
{
    class Statystyki_Gracza
    {
        private float czas_na_boisku;
        private int zdobyte_pkt;
        private int ilosc_zbiorek;
        private float asysty;

        public Statystyki_Gracza(float czas_na_boisku, int zdobyte_pkt, int ilosc_zbiorek, float asysty)
        {
            this.czas_na_boisku = czas_na_boisku;
            this.zdobyte_pkt = zdobyte_pkt;
            this.ilosc_zbiorek = ilosc_zbiorek;
            this.asysty = asysty;
        }

        public float Czas_na_boisku { get => czas_na_boisku; set => czas_na_boisku = value; }
        public int Zdobyte_pkt { get => zdobyte_pkt; set => zdobyte_pkt = value; }
        public int Ilosc_zbiorek { get => ilosc_zbiorek; set => ilosc_zbiorek = value; }
        public float Asysty { get => asysty; set => asysty = value; }
    }
}
