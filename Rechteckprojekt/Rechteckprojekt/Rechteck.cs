using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechteckprojekt
{
    internal class Rechteck
    {
        private double hoehe; // private attribute mit korrekter eingabe
        public double Hoehe // public attribute um zu gucken ob der wert  >= 1 und <= 23 ist wenn es nicht passt kommt eine fehlermeldung
        {
            set
            {
                if (value >= 1 && value <= 23)
                {
                    hoehe = value;
                }
                else
                {
                    throw new Exception("Die Höhe muss zwischen 1 und 23 liegen!");
                }
            }
            get { return hoehe; }
        }
        private double breite; // private attribute mit korrekter eingabe
        public double Breite // public attribute um zu gucken ob der wert  >= 1 und <= 38 ist wenn es nicht passt kommt eine fehlermeldung
        {
            set
            {
                if (value >= 1 && value <= 38)
                {
                    breite = value;
                }
                else
                {
                    throw new Exception("Die Breite muss zwischen 1 und 38 liegen!");
                }
            }
            get { return breite; }
        }
        public int Farbe { get; set; }
        public string Textinhalt { get; set; }
        private double rand; // private attribute mit korrekter eingabe
        public double Rand // public attribute um zu gucken ob der wert  >= 0 und <= 2 ist wenn es nicht passt kommt eine fehlermeldung
        {
            set
            {
                if (value >= 0 && value <= 2)
                {
                    rand = value;
                }
                else
                {
                    throw new Exception("Die Randdicke muss zwischen 0 und 2 liegen!");
                }
            }
            get { return rand; }
        }
        public double Umfang // berechnet umfang aus höhe und breite und speichert es
        {
            get
            {
                return 2 * (hoehe + breite);
            }
        }
        public double Flaeche // berechnet fläche aus höhe und breite und speichert es
        {
            get
            {
                return hoehe * breite;
            }
        }
        public double Diagonale // berechnet diagonale aus höhe und breite und speichert es
        {
            get
            {
                return Math.Sqrt(hoehe * hoehe + breite * breite);
            }
        }
        public void Zoomen(double faktor) // methode für den zoom mit vorgegebenen faktor nimmt die werte einfach * faktor
        {
            Hoehe *= faktor;
            Breite *= faktor;
        }
        public void Drehen()
        {
            double zwischenspeicher = hoehe; // methode zum drehen des rechteckes ändert einfach höhe mit breite und breite mit höhe
            Hoehe = breite;
            Breite = zwischenspeicher;
        }
        public override string ToString()
        {
            return $"Höhe:{Hoehe}, Breite:{Breite}"; // für lbx anzeige  
        }
    }
}
