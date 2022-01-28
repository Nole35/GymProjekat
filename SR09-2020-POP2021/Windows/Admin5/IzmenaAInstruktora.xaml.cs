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
    /// Interaction logic for IzmenaAInstruktora.xaml
    /// </summary>
    public partial class IzmenaAInstruktora : Window

    {
        private Instruktor dodeljeniInstruktor;
        public IzmenaAInstruktora(Instruktor instruktor)
        {
            InitializeComponent();
            this.dodeljeniInstruktor = instruktor;
            txtIme.DataContext = instruktor;
            txtPrez.DataContext = instruktor;
            txtEmail.DataContext = instruktor;
            txtPass.DataContext = instruktor;
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
            dodeljeniInstruktor.Ime = ime;
            dodeljeniInstruktor.Prezime = prezime;
            dodeljeniInstruktor.Email = email;
            dodeljeniInstruktor.Lozinka = lozinka;
            dodeljeniInstruktor.Pol = pol;
            dodeljeniInstruktor.AdresaId = adresaID;
            Utill.Instance.updateInstruktor(dodeljeniInstruktor);
            MessageBox.Show("Izmena Uspesna");
            AInstruktoriWindow iaw = new AInstruktoriWindow();
            iaw.Show();
            this.Close();
        }
    }
}