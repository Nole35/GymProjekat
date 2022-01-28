using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR09_2020_POP2021.Model
{
    public class Trening
    {
        private int sifra;

        public int Sifra
        {
            get { return sifra; }
            set { sifra = value; }
        }

        private DateTime datumTreninga;

        public DateTime DatumTreninga
        {
            get { return datumTreninga; }
            set { datumTreninga = value; }
        }

        private int vremeTreninga;

        public int VremeTreninga
        {
            get { return vremeTreninga; }
            set { vremeTreninga = value; }
        }

        private int trajanjeTreninga;

        public int TrajanjeTreninga
        {
            get { return trajanjeTreninga; }
            set { trajanjeTreninga = value; }
        }



        private EStatus status;

        public EStatus Status
        {
            get { return status; }
            set { status = value; }
        }

        private int instruktorId;

        public int InstruktorId
        {
            get { return instruktorId; }
            set { instruktorId = value; }
        }

        private int polaznikId;

        public int PolaznikId
        {
            get { return polaznikId; }
            set { polaznikId = value; }
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
            Trening kopija = new Trening();
            kopija.sifra = Sifra;
            kopija.instruktorId = instruktorId;
            kopija.datumTreninga = DatumTreninga;
            kopija.vremeTreninga = VremeTreninga;
            kopija.trajanjeTreninga = TrajanjeTreninga;
            kopija.status = Status;
            kopija.polaznikId = polaznikId;
            kopija.aktivan = Aktivan;
            return kopija;

        }

        public Trening() { }
        public Trening(int sifra, DateTime datumTreninga, int vremeTreninga, int trajanjeTreninga, EStatus status, int instruktorId, int polaznikId, bool aktivan)
        {
            this.sifra = sifra;
            this.datumTreninga = datumTreninga;
            this.vremeTreninga = vremeTreninga;
            this.trajanjeTreninga = trajanjeTreninga;
            this.status = status;
            this.instruktorId = instruktorId;
            this.polaznikId = polaznikId;
            this.aktivan = aktivan;
        }
    }
}
