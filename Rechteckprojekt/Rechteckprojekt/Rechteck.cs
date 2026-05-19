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
        public double Hoehe // public attribute um zu gucken ob der wert über 0 wenn nein kommt fehlermeldung
        {
            set
            {
                if (value > 0) 
                {
                    hoehe = value; 
                }
                else
                {
                    MessageBox.Show("Höhe muss mehr als 0 sein"); 
                }
            }
            get { return hoehe; }
        }
        private double breite; // private attribute mit korrekter eingabe
        public double Breite // public attribute um zu gucken ob der wert über 0 wenn nein kommt fehlermeldung
        {
            set
            {
                if (value > 0)
                {
                    breite = value;
                }
                else
                {
                    MessageBox.Show("Breite muss mehr als 0 sein");
                }
            }
            get { return breite; }
        }
        public double Umfang // berechnet umfang aus höhe und breite und speichert es
        {
            get {
                return 2 * (hoehe + breite);}
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
            hoehe = breite;
            breite = zwischenspeicher;
        }
    }
}
