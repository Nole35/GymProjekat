using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Policy;
using SR09_2020_POP2021.Servisi;
using SR09_2020_POP2021.Model;

namespace SR09_2020_POP2021.Model
{
    public class Utill
    {
        public const string CONNECTION_STRING = @"Integrated Security=true; Initial Catalog=Gym; Data Source=DESKTOP-P0HATT2\SQLEXPRESS";
        private static Utill instance = new Utill();
        //IUserServis _userServis;
        IInstruktoriServis _instruktoriServis;
        IPolaznikServis _polaznikServis;
        IAdresaServis _adresaServis;
        IFitnesCentarServis _fitnesCentarServis;
        ITreningServis _treningServis;
        IAdminService _adminServis;
        Random _random;

        private Utill()
        {
            _adresaServis = new AdresaServis();
            _fitnesCentarServis = new FitnesCentarServis();
            _polaznikServis = new PolaznikServis();
            _instruktoriServis = new InstruktoriServis();
            _treningServis = new TreningServis();
            _adminServis = new AdminService();
            // _userServis = new UserServis();
            _random = new Random();
            Initialize();

        }


        public static Utill Instance
        {
            get
            {
                return instance;
            }
        }

       // public ObservableCollection<Korisnik> Korisnici { get; set; }
        public ObservableCollection<Instruktor> Instruktori { get; set; }

        public ObservableCollection<Polaznik> Polaznici { get; set; }


        public ObservableCollection<Adresa> Adrese { get; set; }
        public ObservableCollection<FitnesCentar> FitnesCentri { get; set; }

        public ObservableCollection<Trening> Treninzi { get; set; }

        public ObservableCollection<Admin> Admini { get; set; }
        public Random Random { get; set; }

        public void Initialize()
        {
          //  Korisnici = new ObservableCollection<Korisnik>();
            Adrese = new ObservableCollection<Adresa>();
            Instruktori = new ObservableCollection<Instruktor>();
            FitnesCentri = new ObservableCollection<FitnesCentar>();
            Polaznici = new ObservableCollection<Polaznik>();
            Treninzi = new ObservableCollection<Trening>();
            Admini = new ObservableCollection<Admin>();
            Random = new Random();

        }



        public int SacuvajEntitet(Object obj)
        {
            /*if (obj is Korisnik)
            {
                return _userServis.saveUser(obj);
            }*/
            if (obj is Adresa)
            {
                return _adresaServis.saveAdresa(obj);
            }
            else if (obj is FitnesCentar)
            {
                return _fitnesCentarServis.saveFitnesCentar(obj);
            }
            else if (obj is Polaznik)
            {
                return _polaznikServis.savePolaznik(obj);
            }
            else if (obj is Instruktor)
            {
                return _instruktoriServis.saveInstruktor(obj);
            }
            else if (obj is Trening)
            {
                return _treningServis.saveTrening(obj);
            }
            else if (obj is Admin)
            {
                return _adminServis.saveAdmin(obj);
            }

            return -1;
        }

        public void CitanjeEntiteta()
        {


            // _userServis.readUsers();
            _adresaServis.readAdrese();
            _fitnesCentarServis.readFitnesCentar();
            _polaznikServis.readPolaznik();
            _instruktoriServis.readInstruktor();
            _treningServis.readTrening();
            _adminServis.readAdmin();
        }

        /* public void DeleteUser(int id)
         {
             _userServis.deleteUser(id);
         }*/

        public void DeleteFitnesCentar(int id)
        {
            _fitnesCentarServis.deleteFitnesCentar(id);
        }

        public void DeleteAdmin(int id)
        {
            _adminServis.deleteAdmin(id);
        }
        public void DeleteAdresa(int id)
        {
            _adresaServis.deleteAdresa(id);
        }
        public void DeletePolaznik(int id)
        {
            _polaznikServis.deletePolaznik(id);
        }
        public void DeleteInstruktor(int id)
        {
            _instruktoriServis.deleteInstruktor(id);
        }

        public void DeleteTrening(int id)
        {
            _treningServis.deleteTrening(id);
        }

        /*public void UpdateUser(Korisnik korisnik)
        {
            //_userServis.updateUser1(korisnik);
        }*/

        public void updateAdresa(Adresa adresa)
        {
            _adresaServis.updateAdresa1(adresa);
        }

        public void updateAdmin(Admin admin)
        {
            _adminServis.updateAdmin(admin);
        }
        public void updateFitnesCentar(FitnesCentar fitnesCentar)
        {
            _fitnesCentarServis.updateFitnesCentar1(fitnesCentar);
        }

        public void updatePolaznik(Polaznik polaznik)
        {
            _polaznikServis.updatePolaznik1(polaznik);
        }

        public void updateInstruktor(Instruktor instruktor)
        {
            _instruktoriServis.updateInstruktor1(instruktor);
        }

        public void updateTrening(Trening trening)
        {
            _treningServis.updateTrening1(trening);
        }
    }
}