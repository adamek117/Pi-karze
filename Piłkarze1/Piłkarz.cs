using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piłkarze1
{
    class Piłkarz
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public double waga { get; set; }
        public double wzrost { get; set; }
        public Pozycje pozycje { get; set; }

        public Piłkarz(string imie, string nazwisko, double waga, double wzrost, Pozycje pozycja)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.waga = waga;
            this.wzrost = wzrost;
            pozycje = pozycja;
        }
        public Piłkarz (Piłkarz p)
        {
            p.imie = imie;
            p.nazwisko = nazwisko;
            p.waga = waga;
            p.wzrost = wzrost;
            p.pozycje = pozycje;
        }
        public override string ToString()
        {
            return $"{imie} {nazwisko}, p: {pozycje}, waga: {waga}[kg], wzrost: {wzrost}[cm]";
        }

    }
}
