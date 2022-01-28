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
        IInstruktoriServis _instruktoriServis;
        IPolaznikServis _polaznikServis;
        IAdminService _adminServis;
        IAdresaServis _adresaServis;
        IFitnesCentarServis _fitnesCentarServis;
        ITreningServis _treningServis;
       
        Random _random;

        private Utill()
        {
            _adresaServis = new AdresaServis();
            _treningServis = new TreningServis();
            _fitnesCentarServis = new FitnesCentarServis();
            _adminServis = new AdminService();
            _polaznikServis = new PolaznikServis();
            _instruktoriServis = new InstruktoriServis();
   
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

        public ObservableCollection<Admin> Admini { get; set; }
        public ObservableCollection<Instruktor> Instruktori { get; set; }

        public ObservableCollection<Polaznik> Polaznici { get; set; }


        public ObservableCollection<Adresa> Adrese { get; set; }
        public ObservableCollection<FitnesCentar> FitnesCentri { get; set; }

        public ObservableCollection<Trening> Treninzi { get; set; }

       
        public Random Random { get; set; }

        public void Initialize()
        {
            Adrese = new ObservableCollection<Adresa>();
            FitnesCentri = new ObservableCollection<FitnesCentar>();
            Treninzi = new ObservableCollection<Trening>();
            Polaznici = new ObservableCollection<Polaznik>();
            Instruktori = new ObservableCollection<Instruktor>();
            Admini = new ObservableCollection<Admin>();
            Random = new Random();

        }



        public int SacuvajEntitet(Object obj)
        {
           
            if (obj is Adresa)
            {
                return _adresaServis.saveAdresa(obj);
            }
            else if (obj is FitnesCentar)
            {
                return _fitnesCentarServis.saveFitnesCentar(obj);
            }
            else if (obj is Trening)
            {
                return _treningServis.saveTrening(obj);
            }

            else if (obj is Admin)
            {
                return _adminServis.saveAdmin(obj);
            }

            else if (obj is Instruktor)
            {
                return _instruktoriServis.saveInstruktor(obj);
            }

            else if (obj is Polaznik)
            {
                return _polaznikServis.savePolaznik(obj);
            }
      
           
           

            return -1;
        }

        public void CitanjeEntiteta()
        {


          
            _adresaServis.readAdrese();
            _fitnesCentarServis.readFitnesCentar();
            _treningServis.readTrening();
            _polaznikServis.readPolaznik();
            _instruktoriServis.readInstruktor();
            _adminServis.readAdmin();
        }



        public void DeleteAdresa(int id)
        {
            _adresaServis.deleteAdresa(id);
        }
        public void DeleteFitnesCentar(int id)
        {
            _fitnesCentarServis.deleteFitnesCentar(id);
        }

        public void DeleteTrening(int id)
        {
            _treningServis.deleteTrening(id);
        }

        public void DeleteAdmin(int id)
        {
            _adminServis.deleteAdmin(id);
        }
       
        public void DeletePolaznik(int id)
        {
            _polaznikServis.deletePolaznik(id);
        }
        public void DeleteInstruktor(int id)
        {
            _instruktoriServis.deleteInstruktor(id);
        }

      

   

        public void updateAdresa(Adresa adresa)
        {
            _adresaServis.updateAdresa1(adresa);
        }

     
        public void updateFitnesCentar(FitnesCentar fitnesCentar)
        {
            _fitnesCentarServis.updateFitnesCentar1(fitnesCentar);
        }

        public void updateTrening(Trening trening)
        {
            _treningServis.updateTrening1(trening);
        }

        public void updateAdmin(Admin admin)
        {
            _adminServis.updateAdmin(admin);
        }

        public void updatePolaznik(Polaznik polaznik)
        {
            _polaznikServis.updatePolaznik1(polaznik);
        }

        public void updateInstruktor(Instruktor instruktor)
        {
            _instruktoriServis.updateInstruktor1(instruktor);
        }

     
    }
}