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

namespace SR09_2020_POP2021.Windows.Admin5
{
    /// <summary>
    /// Interaction logic for IzmenaAPolaznika.xaml
    /// </summary>
    public partial class IzmenaAPolaznika : Window
    {
        private Polaznik prosledjeniPolaznik;
        public IzmenaAPolaznika(Polaznik polaznik)
        {
            InitializeComponent();
            this.prosledjeniPolaznik = polaznik;
            txtIme.DataContext = polaznik;
            txtPrez.DataContext = polaznik;
            txtEmail.DataContext = polaznik;
            txtPass.DataContext = polaznik;
            txtIme.DataContext = polaznik;
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
            prosledjeniPolaznik.Ime = ime;
            prosledjeniPolaznik.Prezime = prezime;
            prosledjeniPolaznik.Email = email;
            prosledjeniPolaznik.Lozinka = lozinka;
            prosledjeniPolaznik.Pol = pol;
            prosledjeniPolaznik.AdresaId = adresaID;
            Utill.Instance.updatePolaznik(prosledjeniPolaznik);
            MessageBox.Show("Izmena Uspesna");
            APolazniciWindow paw = new APolazniciWindow();
            paw.Show();
            this.Close();
        }
    }
}
