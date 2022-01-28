using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR09_2020_POP2021.Model
{
    public class FitnesCentar : ICloneable
    {
        private int sifra;

        public int Sifra
        {
            get { return sifra; }
            set { sifra = value; }
        }

        private string naziv;

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }

        }

        private int adresaID;

        public int AdresaID
        {
            get
            {
                return adresaID;
            }
            set
            {
                adresaID = value;

            }
        }

        private Boolean aktivan;

        public Boolean Aktivan
        {
            get
            {
                return aktivan;
            }
            set
            {
                aktivan = value;

            }
        }

        public object Clone()
        {
            FitnesCentar kopija = new FitnesCentar();
            kopija.Sifra = Sifra;
            kopija.Naziv = Naziv;
            kopija.adresaID = adresaID;
            kopija.Aktivan = Aktivan;
            return kopija;

        }
        public FitnesCentar() { }
        public FitnesCentar(int sifra, string naziv, int adresaID, bool aktivan)
        {
            this.sifra = sifra;
            this.naziv = naziv;
            this.adresaID = adresaID;
            this.aktivan = aktivan;
        }
    }
}
