using System;
using System.Collections.Generic;
using System.Text;

namespace NBAKonferencja
{
    class Reporter:Redaktor
    {
        private Redaktor dane_przelozonego;

        public Reporter(string imie, string nazwisko, string data_urodzeni, string pESEL,string numer_licencji, Redaktor dane_przelozonego):base(imie, nazwisko, data_urodzeni, pESEL, numer_licencji)
        {
            this.Dane_przelozonego = dane_przelozonego;
        }
        internal Redaktor Dane_przelozonego { get => dane_przelozonego; set => dane_przelozonego = value; }
    }
}
