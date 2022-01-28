using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR09_2020_POP2021.Model
{
    public class Polaznik : ICloneable
    {

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }



        private string _ime;

        public string Ime
        {
            get { return _ime; }
            set { _ime = value; }
        }

        private string _prezime;

        public string Prezime
        {
            get { return _prezime; }
            set { _prezime = value; }
        }

        private string _lozinka;

        public string Lozinka
        {
            get { return _lozinka; }
            set { _lozinka = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _JMBG;

        public string JMBG
        {
            get { return _JMBG; }
            set { _JMBG = value; }
        }

        private int adresaId;

        public int AdresaId
        {
            get { return adresaId; }
            set { adresaId = value; }
        }

        private EPol _pol;

        public EPol Pol
        {
            get { return _pol; }
            set { _pol = value; }
        }

        private Boolean aktivan;

        public Boolean Aktivan
        {
            get { return aktivan; }
            set { aktivan = value; }
        }

        private int instruktorId;

        public int InstruktorId
        {
            get { return instruktorId; }
            set { instruktorId = value; }
        }



        public object Clone()
        {
            Polaznik kopija = new Polaznik();

            kopija.Id = Id;
            kopija.AdresaId = adresaId;
            kopija.Aktivan = Aktivan;
            kopija.Email = Email;
            kopija.Ime = Ime;
            kopija.Prezime = Prezime;
            kopija.Pol = Pol;
            kopija.Lozinka = Lozinka;
            kopija.JMBG = JMBG;
            kopija.InstruktorId = instruktorId;


            return kopija;
        }

        public Polaznik() { }

        public Polaznik(int id, string ime, string prezime, string lozinka, string email, string jMBG, int adresaId, EPol pol, bool aktivan, int instruktorId)
        {
            _id = id;
            _ime = ime;
            _prezime = prezime;
            _lozinka = lozinka;
            _email = email;
            _JMBG = jMBG;
            this.adresaId = adresaId;
            _pol = pol;
            this.aktivan = aktivan;
            this.instruktorId = instruktorId;
        }
    }
}
