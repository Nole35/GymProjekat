using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SR09_2020_POP2021.Model;
using SR09_2020_POP2021.Windows.PocetniProzor;

namespace SR09_2020_POP2021.Windows.PregledIzmenaSPodataka
{
    /// <summary>
    /// Interaction logic for IzmenaPodPolaznika.xaml
    /// </summary>
    public partial class IzmenaPodPolaznika : Window
    {
        private Polaznik dodeljeniPolaznik;
        public IzmenaPodPolaznika(Polaznik polaznik)
        {
            InitializeComponent();
            this.dodeljeniPolaznik = polaznik;
            txtIme.DataContext = polaznik;
            txtPrez.DataContext = polaznik;
            txtEmail.DataContext = polaznik;
            txtPass.DataContext = polaznik;
            cbPol.ItemsSource = Enum.GetValues(typeof(EPol)).Cast<EPol>();
            cbPol.ItemsSource = Enum.GetValues(typeof(EPol)).Cast<EPol>();
            string adrese = "select * from Adrese";
            SqlConnection sqlCon = new SqlConnection(Utill.CONNECTION_STRING);
            sqlCon.Open();
            SqlCommand sqlCommand = new SqlCommand(adrese, sqlCon);
            SqlDataReader sdr = sqlCommand.ExecuteReader();
            while (sdr.Read())
            {
                cbAdrese.Items.Add(sdr[0]);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrez.Text;
            string email = txtEmail.Text;
            string lozinka = txtPass.Text;
            string polString = cbPol.SelectedItem.ToString();
            EPol pol = (EPol)Enum.Parse(typeof(EPol), polString, true);
            string adresaString = cbAdrese.SelectedItem.ToString();
            int adresaID = int.Parse(adresaString);
            dodeljeniPolaznik.Ime = ime;
            dodeljeniPolaznik.Prezime = prezime;
            dodeljeniPolaznik.Email = email;
            dodeljeniPolaznik.Pol = pol;
            dodeljeniPolaznik.AdresaId = adresaID;
            Utill.Instance.updatePolaznik(dodeljeniPolaznik);
            MessageBox.Show("Izmena Uspesna");
            PregledPodPolaznika pregled = new PregledPodPolaznika(dodeljeniPolaznik.JMBG);
            pregled.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            FitnesCentarSajt fcs = new FitnesCentarSajt();
            fcs.Show();
            this.Close();
        }
    }
}