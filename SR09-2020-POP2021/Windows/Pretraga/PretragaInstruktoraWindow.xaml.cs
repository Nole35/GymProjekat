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

namespace SR09_2020_POP2021.Windows.Pretraga
{
    public partial class PretragaInstruktoraWindow : Window
    {
        public PretragaInstruktoraWindow()
        {
            InitializeComponent();
            Utill.Instance.CitanjeEntiteta();
            string adrese = "select * from Adrese";
            SqlConnection sqlCon = new SqlConnection(Utill.CONNECTION_STRING);
            sqlCon.Open();
            SqlCommand sqlCommand = new SqlCommand(adrese, sqlCon);
            SqlDataReader sdr = sqlCommand.ExecuteReader();
            while (sdr.Read())
            {
                cbAdresa.Items.Add(sdr[0]);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Utill.Instance.CitanjeEntiteta();
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string adresaString = cbAdresa.SelectedItem.ToString();
            string email = txtEmail.Text;
            Adresa adresa = Utill.Instance.Adrese.ToList().Find(trazenjeAdrese => trazenjeAdrese.SifraAdrese.ToString().Equals(adresaString));
            ObservableCollection<Instruktor> instruktoriLista = new ObservableCollection<Instruktor>();

            foreach (Instruktor instruktor in Utill.Instance.Instruktori)
            {
                if (instruktor.Ime.Equals(ime, StringComparison.OrdinalIgnoreCase) || instruktor.Prezime.Equals(prezime, StringComparison.OrdinalIgnoreCase) || instruktor.AdresaId == adresa.SifraAdrese || instruktor.Email.Equals(email, StringComparison.OrdinalIgnoreCase))
                {
                    instruktoriLista.Add(instruktor);
                }
            }


            PrikazRezultataPretrage rezultat = new PrikazRezultataPretrage(instruktoriLista);
            rezultat.Show();
            this.Close();

        }
    }
}
