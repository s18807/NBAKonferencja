using System;
using System.Collections.Generic;
using System.Text;

namespace NBAKonferencja
{
    class Adres
    {
        private string ulica;
        private int numer_domu;
        private int numer_mieszkania;
        private string miasto;
        private string kod_pocztowy;
        private float gpsN;
        private float gpsW;

        public Adres(string ulica, int numer_domu, int numer_mieszkania, string miasto, string kod_pocztowy, float gpsN, float gpsW)
        {
            this.ulica = ulica;
            this.numer_domu = numer_domu;
            this.numer_mieszkania = numer_mieszkania;
            this.miasto = miasto;
            this.kod_pocztowy = kod_pocztowy;
            this.gpsN = gpsN;
            this.gpsW = gpsW;
        }

        public string Ulica { get => ulica; set => ulica = value; }
        public int Numer_domu { get => numer_domu; set => numer_domu = value; }
        public int Numer_mieszkania { get => numer_mieszkania; set => numer_mieszkania = value; }
        public string Miasto { get => miasto; set => miasto = value; }
        public string Kod_pocztowy { get => kod_pocztowy; set => kod_pocztowy = value; }
        public float GpsN { get => gpsN; set => gpsN = value; }
        public float GpsW { get => gpsW; set => gpsW = value; }
    }
}
