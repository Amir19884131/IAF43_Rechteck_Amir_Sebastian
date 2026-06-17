namespace Rechteckprojekt
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Willkommen bei unserem Rechteckprogramm");
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            Rechteck r = new Rechteck();
            try
            {
                r.Hoehe = Convert.ToDouble(tbxHoehe.Text);
                r.Breite = Convert.ToDouble(tbxBreite.Text);

                r.Zoomen(0.5);

                tbxHoehe.Text = r.Hoehe.ToString();
                tbxBreite.Text = r.Breite.ToString();
            }
            catch
            {
                MessageBox.Show("Bitte geben Sie eine Zahl ein!");
            }
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            Rechteck r = new Rechteck();
            try
            {
                r.Hoehe = Convert.ToDouble(tbxHoehe.Text);
                r.Breite = Convert.ToDouble(tbxBreite.Text);

                r.Zoomen(1.5);

                tbxHoehe.Text = Math.Round(r.Hoehe, 2).ToString();
                tbxBreite.Text = Math.Round(r.Breite, 2).ToString();
            }
            catch
            {
                MessageBox.Show("Bitte geben Sie eine Zahl ein!");
            }
        }

        private void btnDrehen_Click(object sender, EventArgs e)
        {

        }

        private void tbxBreite_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxHoehe_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxFarben_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbxTextinhalt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxRand_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void lbxRechtecke_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {

        }

        private void mnuSave_Click(object sender, EventArgs e)
        {

        }

        private void mnuSaveUnder_Click(object sender, EventArgs e)
        {

        }
    }
}
