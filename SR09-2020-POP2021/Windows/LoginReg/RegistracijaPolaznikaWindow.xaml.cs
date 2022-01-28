using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using SR09_2020_POP2021.Windows.Admin5;

namespace SR09_2020_POP2021.Windows.LoginReg
{
    /// <summary>
    /// Interaction logic for RegsitracijaPolaznikaWindow.xaml
    /// </summary>
    public partial class RegistracijaPolaznikaWindow : Window
    {
        public RegistracijaPolaznikaWindow()
        {
            InitializeComponent();
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

        private void registracijaDugme(object sender, RoutedEventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string jmbg = txtJMBG.Text;
            string polString = cbPol.Text.ToString();
            EPol pol = (EPol)Enum.Parse(typeof(EPol), polString, true);
            int adresaID = int.Parse(cbAdrese.SelectedItem.ToString());
            string email = txtEmail.Text;
            string lozinka = txtLozinka.Text;
            Random random = new Random();
            int id = random.Next(200, 500);

            Polaznik polaznik = new Polaznik(id, ime, prezime, lozinka, email, jmbg, adresaID, pol, true, 200);
            Utill.Instance.Polaznici.Add(polaznik);
            Utill.Instance.SacuvajEntitet(polaznik);
            MessageBox.Show("Uspesna registracija");
            PrijavaWindow prijava = new PrijavaWindow();
            prijava.Show();
            this.Close();
        }

        private void close(object sender, RoutedEventArgs e)
        {
            this.Close();
            FitnesCentarAWindow f = new FitnesCentarAWindow();
            f.Show();
        }
    }
}
