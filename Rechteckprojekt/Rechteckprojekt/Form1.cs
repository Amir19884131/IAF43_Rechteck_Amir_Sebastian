namespace Rechteckprojekt
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            btnRechteck.FlatStyle = FlatStyle.Flat; // rechteck eigentlich button auf flat setzen damit man nachher den rand ändern kann
        }
        Rechteck r = new Rechteck(); // erstellt objekt

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Willkommen bei unserem Rechteckprogramm");
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            try
            {
                r.Hoehe = Convert.ToDouble(tbxHoehe.Text); // speichert werte aus den textboxen in den jeweiligen attributen wo sie auch überprüft werden
                r.Breite = Convert.ToDouble(tbxBreite.Text);

                r.Zoomen(1.0 / 1.1); // ruft die methode für den zoom auf und gibt den faktor 1.0 / 1.1 damit wenn man 1 mal zoom in und dann zoom out macht immer die selben werte hat mit 0.9 wären immer andere zahlen da

                tbxHoehe.Text = Math.Round(r.Hoehe, 2).ToString(); // zeigt die werte wieder in der textbox an und zeigt nur 2 nachkommastellen an
                tbxBreite.Text = Math.Round(r.Breite, 2).ToString();
            }
            catch (FormatException) // fehler der getriggert wird wenn ein compiler fehler kommt wenn die textbox leer ist oder buchstaben eingegeben werden
            {
                MessageBox.Show("Bitte geben Sie eine gültige Zahl ein!");
            }
            catch (Exception ex) // fehler der die direkte fehlermeldung aus der exception beim public attribut hier ausgibt 
            {
                MessageBox.Show("ACHTUNG! " + ex.Message);
            }
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            try
            {
                r.Hoehe = Convert.ToDouble(tbxHoehe.Text); // speichert werte aus den textboxen in den jeweiligen attributen wo sie auch überprüft werden
                r.Breite = Convert.ToDouble(tbxBreite.Text);

                r.Zoomen(1.1); // ruft die methode für den zoom auf und gibt den faktor 1.1 mit damit reingezoomt wird 


                tbxHoehe.Text = Math.Round(r.Hoehe, 2).ToString(); // zeigt die werte wieder in der textbox an und zeigt nur 2 nachkommastellen an
                tbxBreite.Text = Math.Round(r.Breite, 2).ToString();
            }
            catch (FormatException) // fehler der getriggert wird wenn ein compiler fehler kommt wenn die textbox leer ist oder buchstaben eingegeben werden
            {
                MessageBox.Show("Bitte geben Sie eine gültige Zahl ein!");
            }
            catch (Exception ex) // fehler der die direkte fehlermeldung aus der exception beim public attribut hier ausgibt 
            {
                MessageBox.Show("ACHTUNG! " + ex.Message);
            }
        }
        private void AktualisiereGrafik()
        {
            btnRechteck.Width = Convert.ToInt32(r.Breite * 37.8); // für die größe der rechtecks zuständig länge und höhe damit es auch 1 cm ist auf dem bildschirm
            btnRechteck.Height = Convert.ToInt32(r.Hoehe * 37.8);
            btnRechteck.Left = 1050 - (btnRechteck.Width / 2); // für die zentrierung zuständig damit es schön dort rechts in der mitte ist 
            btnRechteck.Top = 445 - (btnRechteck.Height / 2);
        }
        private void tbxBreite_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxBreite.Text)) // macht nicht weiter wenn das feld leer ist ist praktisch wenn der user eine ganze zahl neu schreiben will anstatt 200 eine 100 
                return;

            try
            {
                r.Breite = Convert.ToDouble(tbxBreite.Text); // speichert wert aus den textbox in dem attribut wo es auch überprüft werden
                tbxUmfang.Text = Math.Round(r.Umfang, 2).ToString(); // triggert die schreibgeschützen eigenschaften die die textboxen mit den inhalten füllen
                tbxFlaeche.Text = Math.Round(r.Flaeche, 2).ToString();
                tbxDiagonaleCM.Text = Math.Round(r.Diagonale, 2).ToString();
                tbxDiagonaleZOLL.Text = Math.Round(r.Diagonale / 2.54, 2).ToString();
                AktualisiereGrafik();
            }
            catch (FormatException) // fehler der getriggert wird wenn ein compiler fehler kommt wenn die textbox leer ist oder buchstaben eingegeben werden
            {
                MessageBox.Show("Bitte geben Sie eine gültige Zahl ein!");
            }
            catch (Exception ex) // fehler der die direkte fehlermeldung aus der exception beim public attribut hier ausgibt 
            {
                MessageBox.Show("ACHTUNG! " + ex.Message);
            }
        }

        private void tbxHoehe_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxHoehe.Text)) // macht nicht weiter wenn das feld leer ist ist praktisch wenn der user eine ganze zahl neu schreiben will anstatt 200 eine 100 
                return;

            try
            {
                r.Hoehe = Convert.ToDouble(tbxHoehe.Text); // speichert wert aus den textbox in dem attribut wo es auch überprüft werden
                tbxUmfang.Text = Math.Round(r.Umfang, 2).ToString(); // triggert die schreibgeschützen eigenschaften die die textboxen mit den inhalten füllen
                tbxFlaeche.Text = Math.Round(r.Flaeche, 2).ToString();
                tbxDiagonaleCM.Text = Math.Round(r.Diagonale, 2).ToString();
                tbxDiagonaleZOLL.Text = Math.Round(r.Diagonale / 2.54, 2).ToString();
                AktualisiereGrafik();
            }
            catch (FormatException) // fehler der getriggert wird wenn ein compiler fehler kommt wenn die textbox leer ist oder buchstaben eingegeben werden
            {
                MessageBox.Show("Bitte geben Sie eine gültige Zahl ein!");
            }
            catch (Exception ex) // fehler der die direkte fehlermeldung aus der exception beim public attribut hier ausgibt 
            {
                MessageBox.Show("ACHTUNG! " + ex.Message);
            }
        }

        private void btnDrehen_Click(object sender, EventArgs e)
        {
            try
            {
                r.Hoehe = Convert.ToDouble(tbxHoehe.Text); // speichert werte aus den textboxen in den jeweiligen attributen wo sie auch überprüft werden
                r.Breite = Convert.ToDouble(tbxBreite.Text);
                r.Drehen(); // ruft die methode zum drehen auf und die dreht das rechteck einfach
                tbxHoehe.Text = Math.Round(r.Hoehe, 2).ToString(); // zeigt die werte wieder in der textbox an und zeigt nur 2 nachkommastellen an
                tbxBreite.Text = Math.Round(r.Breite, 2).ToString();
            }
            catch (FormatException) // fehler der getriggert wird wenn ein compiler fehler kommt wenn die textbox leer ist oder buchstaben eingegeben werden
            {
                MessageBox.Show("Bitte geben Sie eine gültige Zahl ein!");
            }
            catch (Exception ex) // fehler der die direkte fehlermeldung aus der exception beim public attribut hier ausgibt 
            {
                MessageBox.Show("ACHTUNG! " + ex.Message);
            }
        }

        private void cbxFarben_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                r.Farbe = cbxFarben.SelectedIndex; // speichert indexwert im objekt
                int Index = r.Farbe; // und gibt dem int hier den indexwert wieder zurück damit es die richtige farbe auswählen kann und das rechteck was eigentlich ein button ist umfärben kann
                switch (Index)
                {
                    case 0:
                        btnRechteck.BackColor = Color.White;
                        break;
                    case 1:
                        btnRechteck.BackColor = Color.Yellow;
                        break;
                    case 2:
                        btnRechteck.BackColor = Color.Red;
                        break;
                    case 3:
                        btnRechteck.BackColor = Color.Blue;
                        break;
                    case 4:
                        btnRechteck.BackColor = Color.Orange;
                        break;
                    case 5:
                        btnRechteck.BackColor = Color.Purple;
                        break;
                    case 6:
                        btnRechteck.BackColor = Color.Black;
                        break;
                    case 7:
                        btnRechteck.BackColor = Color.Gray;
                        break;
                    case 8:
                        btnRechteck.BackColor = Color.Green;
                        break;
                }
            }
            catch (Exception) // nur zur absicherung
            {
            }
        }

        private void tbxRand_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxRand.Text)) // macht nicht mehr weiter mti dem code damit keine fehlermeldung kommt wenn man seine eingabe komplett löscht
            {
                return;
            }
            try
            {
                r.Rand = Convert.ToDouble(tbxRand.Text.Replace('.', ',')); // falls der user einen . anstatt einen , setzt ist das dank replace kein problem es wird perfekt umgewandelt 
                btnRechteck.FlatAppearance.BorderSize = Convert.ToInt32(r.Rand * 37.8); // gibt dem rechteck eigentlich button den rand in cm 
            }
            catch (FormatException) // fehler der getriggert wird wenn ein compiler fehler kommt wenn die textbox leer ist oder buchstaben eingegeben werden
            {
                MessageBox.Show("Bitte geben Sie eine gültige Zahl ein!");
            }
            catch (Exception ex) // fehler der die direkte fehlermeldung aus der exception beim public attribut hier ausgibt 
            {
                MessageBox.Show("ACHTUNG! " + ex.Message);
            }
        }

        private void tbxTextinhalt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                r.Textinhalt = tbxTextinhalt.Text; // speichert eingegebenen text im objekt
                btnRechteck.Text = r.Textinhalt; // und gibt den text hier wieder zurück damit es im rechteck angezeigt wird
            }
            catch (Exception) // nur zur absicherung
            {
            }
        }
    }
}
