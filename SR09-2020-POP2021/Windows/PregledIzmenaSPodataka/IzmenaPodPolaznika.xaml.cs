using System;
using System.Collections.Generic;
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

namespace SR09_2020_POP2021.Windows.PregledIzmenaSPodataka
{
    /// <summary>
    /// Interaction logic for IzmenaPodPolaznika.xaml
    /// </summary>
    public partial class IzmenaPodPolaznika : Window
    {
        private Polaznik prosledjeniPolaznik;
        public IzmenaPodPolaznika(Polaznik polaznik)
        {
            InitializeComponent();
            this.prosledjeniPolaznik = polaznik;
            txtIme.DataContext = polaznik;
            txtPrezime.DataContext = polaznik;
            txtEmail.DataContext = polaznik;
            cbPol.ItemsSource = Enum.GetValues(typeof(EPol)).Cast<EPol>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string email = txtEmail.Text;
            string polString = cbPol.SelectedItem.ToString();
            EPol pol = (EPol)Enum.Parse(typeof(EPol), polString, true);
            prosledjeniPolaznik.Ime = ime;
            prosledjeniPolaznik.Prezime = prezime;
            prosledjeniPolaznik.Email = email;
            prosledjeniPolaznik.Pol = pol;
            Utill.Instance.updatePolaznik(prosledjeniPolaznik);
            MessageBox.Show("Izmena Uspesna");
            PregledPodPolaznika pregled = new PregledPodPolaznika(prosledjeniPolaznik.JMBG);
            pregled.Show();
            this.Close();
        }
    }
}