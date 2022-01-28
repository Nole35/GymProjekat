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
    /// Interaction logic for DodavanjeInstruktora.xaml
    /// </summary>
    public partial class DodavanjeInstruktora : Window
    {
        public DodavanjeInstruktora()
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

        private void dodaj(object sender, RoutedEventArgs e)
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

            Instruktor instruktor = new Instruktor(id, ime, prezime, lozinka, email, jmbg, adresaID, pol, true);
            Utill.Instance.Instruktori.Add(instruktor);
            Utill.Instance.SacuvajEntitet(instruktor);
            AInstruktoriWindow iw = new AInstruktoriWindow();
            iw.Show();
            this.Close();
        }

        private void close(object sender, RoutedEventArgs e)
        {

        }
    }
}
