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

namespace SR09_2020_POP2021.Windows.Admin5
{
    /// <summary>
    /// Interaction logic for IzmenaATreninga.xaml
    /// </summary>
    public partial class IzmenaATreninga : Window
    {
        private Trening prosledjeniTrening;
        public IzmenaATreninga(Trening trening)
        {
            InitializeComponent();
            this.prosledjeniTrening = trening;
            txtSifra.DataContext = trening;
            txtVreme.DataContext = trening;
            txtTrajanje.DataContext = trening;
            txtInId.DataContext = trening;
            txtPolId.DataContext = trening;
            txtDatum.DataContext = trening;


            cbStatus.ItemsSource = Enum.GetValues(typeof(EStatus)).Cast<EStatus>();
        }

        private void dodaj(object sender, RoutedEventArgs e)
        {
            int sifra = int.Parse(txtSifra.Text.ToString());
            int trajanje = int.Parse(txtTrajanje.Text.ToString());
            int vrijeme = int.Parse(txtVreme.Text.ToString());
            string statusString = cbStatus.Text.ToString();
            EStatus status = (EStatus)Enum.Parse(typeof(EStatus), statusString, true);
            int insId = int.Parse(txtInId.Text.ToString());
            int polId = int.Parse(txtPolId.Text.ToString());
            DateTime datum = DateTime.Parse(txtDatum.Text.ToString());
            Utill.Instance.updateTrening(prosledjeniTrening);
            MessageBox.Show("Izmena Uspesna");
            ATreninziWindow atw = new ATreninziWindow();
            atw.Show();
            this.Close();
        }

        private void close(object sender, RoutedEventArgs e)
        {

        }
    }
}
