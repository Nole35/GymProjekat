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
    /// Interaction logic for DodavanjeTreninga.xaml
    /// </summary>
    public partial class DodavanjeTreninga : Window
    {
        public DodavanjeTreninga()
        {
            InitializeComponent();
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
            Trening trening = new Trening(sifra, datum, vrijeme, trajanje, status, insId, polId, true);
            Utill.Instance.Treninzi.Add(trening);
            Utill.Instance.SacuvajEntitet(trening);
            ATreninziWindow at = new ATreninziWindow();
            at.Show();
            this.Close();

        }

        private void close(object sender, RoutedEventArgs e)
        {

        }
    }
}