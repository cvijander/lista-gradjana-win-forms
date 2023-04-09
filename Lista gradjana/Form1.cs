using System.Threading.Tasks.Dataflow;

namespace Lista_gradjana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.MaskCompleted == true)
            {
                string ime = txtIme.Text;
                string prezime = txtPrezime.Text;
                string jmbg = maskedTextBox1.Text;
                Gradjanin osoba = new Gradjanin(ime, prezime, jmbg);
                listBox1.Items.Add(osoba);

                txtIme.Clear();
                txtPrezime.Clear();
                maskedTextBox1.Clear();
            }
            else
            {
                MessageBox.Show("Unesite maticni broj u formatu 13 cifara");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string text = listBox1.Items[index].ToString();
            string[] niz = text.Split(' ');
            string ime = niz[1];
            string prezime = niz[2];
            string jmbg = niz[0];
            Gradjanin aktuelni = new Gradjanin(ime, prezime, jmbg);
            monthCalendar1.SelectionStart = aktuelni.DatumRodjenja();
            monthCalendar1.SelectionEnd = aktuelni.DatumRodjenja();
            txtIme.Text = aktuelni.Ime;
            txtPrezime.Text = aktuelni.Prezime;
        }
    }
}