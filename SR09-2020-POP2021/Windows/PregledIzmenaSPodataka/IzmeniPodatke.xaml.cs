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
    /// Interaction logic for IzmeniPodatke.xaml
    /// </summary>
    public partial class IzmeniPodatke : Window
    {
        private Admin prosledjeniAdmin;
        public IzmeniPodatke(Admin admin)
        {
            InitializeComponent();
            this.prosledjeniAdmin = admin;
            txtIme.DataContext = admin;
            txtPrezime.DataContext = admin;
            txtEmail.DataContext = admin;
            cbPol.ItemsSource = Enum.GetValues(typeof(EPol)).Cast<EPol>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string email = txtEmail.Text;
            string polString = cbPol.SelectedItem.ToString();
            EPol pol = (EPol)Enum.Parse(typeof(EPol), polString, true);
            prosledjeniAdmin.Ime = ime;
            prosledjeniAdmin.Prezime = prezime;
            prosledjeniAdmin.Email = email;
            prosledjeniAdmin.Pol = pol;
            Utill.Instance.updateAdmin(prosledjeniAdmin);
            MessageBox.Show("Izmena Uspesna");
            PregledPodataka pregled = new PregledPodataka(prosledjeniAdmin.JMBG);
            pregled.Show();
            this.Close();
        }
    }
}