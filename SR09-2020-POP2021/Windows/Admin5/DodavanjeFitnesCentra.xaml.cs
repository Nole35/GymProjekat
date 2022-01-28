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
    /// Interaction logic for DodavanjeFitnesCentra.xaml
    /// </summary>
    public partial class DodavanjeFitnesCentra : Window
    {
        public DodavanjeFitnesCentra()
        {
            InitializeComponent();
            string adrese = "select * from Adrese";
            SqlConnection sqlCon = new SqlConnection(Utill.CONNECTION_STRING);
            sqlCon.Open();
            SqlCommand sqlCommand = new SqlCommand(adrese, sqlCon);
            SqlDataReader sdr = sqlCommand.ExecuteReader();
            while (sdr.Read())
            {
                cbAdresFC.Items.Add(sdr[0]);
            }
        }

        private void dodaj(object sender, RoutedEventArgs e)
        {
            int sifra = int.Parse(txtSif.Text.ToString());
            string naziv = txtNaz.Text;
            int adresaID = int.Parse(cbAdresFC.SelectedItem.ToString());
            Random random = new Random();
            int id = random.Next(200, 500);

            FitnesCentar fitnesCentar = new FitnesCentar(id, naziv, adresaID, true);
            Utill.Instance.FitnesCentri.Add(fitnesCentar);
            Utill.Instance.SacuvajEntitet(fitnesCentar);
            AFitnesCentarWindow afc = new AFitnesCentarWindow();
            afc.Show();
            this.Close();
        }

        private void close(object sender, RoutedEventArgs e)
        {

        }
    }
}
