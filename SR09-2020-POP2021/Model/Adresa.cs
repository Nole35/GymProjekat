using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR09_2020_POP2021.Model
{
    public class Adresa : ICloneable
    {
        private int sifraAdrese;

        public int SifraAdrese
        {
            get { return sifraAdrese; }
            set { sifraAdrese = value; }
        }
        private string ulica;

        public Adresa()
        {

        }
        public Adresa(int sifraAdrese, string ulica, string broj, string grad, string drzava, bool aktivan)
        {
            this.sifraAdrese = sifraAdrese;
            this.ulica = ulica;
            this.broj = broj;
            this.grad = grad;
            this.drzava = drzava;
            this.aktivan = aktivan;
        }

        public string Ulica
        {
            get { return ulica; }
            set { ulica = value; }
        }

        private string broj;

        public string Broj
        {
            get { return broj; }
            set { broj = value; }
        }

        private string grad;

        public string Grad
        {
            get { return grad; }
            set { grad = value; }
        }


        private string drzava;

        public string Drzava
        {
            get { return drzava; }
            set { drzava = value; }
        }

        public override string ToString()
        {
            return "Ulica " + Ulica + " broj " + Broj + " grad" + Grad + " drzava " + Drzava;
        }

        private Boolean aktivan;

        public Boolean Aktivan
        {
            get { return aktivan; }
            set { aktivan = value; }
        }



        public object Clone()
        {
            Adresa kopija = new Adresa();
            kopija.SifraAdrese = SifraAdrese;
            kopija.Ulica = Ulica;
            kopija.Broj = Broj;
            kopija.Grad = Grad;
            kopija.Drzava = Drzava;
            kopija.Aktivan = Aktivan;

            return kopija;

        }


    }
}