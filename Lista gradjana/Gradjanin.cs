using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_gradjana
{
    public class Gradjanin
    {
        private string ime;
        private string prezime;
        private string jmbg;

        public Gradjanin(string ime, string prezime, string jmbg)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Jmbg = jmbg;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Jmbg { get => jmbg; set => jmbg = value; }

        public override string ToString()
        {
            return jmbg + " " + ime + " " + prezime;
        }

        public DateTime DatumRodjenja()
        {
            int dan = int.Parse(jmbg.Substring(0, 2));
            int mesec = int.Parse(jmbg.Substring(2, 2));
            int god = int.Parse(jmbg.Substring(4, 3));
            if (god > 900) god += 1000;
            else god += 2000;

            return new DateTime(god, mesec, dan);
        }
    }
}