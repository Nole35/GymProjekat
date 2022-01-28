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
using SR09_2020_POP2021.Windows;

namespace SR09_2020_POP2021.Windows.PregledIzmenaSPodataka
{
    /// <summary>
    /// Interaction logic for IzmenaPodInstruktora.xaml
    /// </summary>
    public partial class IzmenaPodInstruktora : Window
    {
        private Instruktor prosledjeniInstruktor;
        public IzmenaPodInstruktora(Instruktor instruktor)
        {
            InitializeComponent();
            this.prosledjeniInstruktor = instruktor;
            txtIme.DataContext = instruktor;
            txtPrezime.DataContext = instruktor;
            txtEmail.DataContext = instruktor;
            cbPol.ItemsSource = Enum.GetValues(typeof(EPol)).Cast<EPol>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string email = txtEmail.Text;
            string polString = cbPol.SelectedItem.ToString();
            EPol pol = (EPol)Enum.Parse(typeof(EPol), polString, true);
            prosledjeniInstruktor.Ime = ime;
            prosledjeniInstruktor.Prezime = prezime;
            prosledjeniInstruktor.Email = email;
            prosledjeniInstruktor.Pol = pol;
            Utill.Instance.updateInstruktor(prosledjeniInstruktor);
            MessageBox.Show("Izmena Uspesna");
            PregledPodInstruktora pregled = new PregledPodInstruktora(prosledjeniInstruktor.JMBG);
            pregled.Show();
            this.Close();
        }
    }
}