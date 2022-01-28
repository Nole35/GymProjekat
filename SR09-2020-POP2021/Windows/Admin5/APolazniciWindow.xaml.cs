using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using SR09_2020_POP2021.Windows.PocetniProzor;

namespace SR09_2020_POP2021.Windows.Admin5
{
    /// <summary>
    /// Interaction logic for APolazniciWindow.xaml
    /// </summary>
    public partial class APolazniciWindow : Window
    {
        public APolazniciWindow()
        {
            InitializeComponent();
            Utill.Instance.CitanjeEntiteta();
            ICollectionView view = CollectionViewSource.GetDefaultView(Utill.Instance.Polaznici);

            Informacije.ItemsSource = view;
            Informacije.IsSynchronizedWithCurrentItem = true;

            Informacije.ColumnWidth = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void dodaj(object sender, RoutedEventArgs e)
        {
            DodavanjePolaznika dp = new DodavanjePolaznika();
            dp.Show();
            this.Close();
        }

        private void obrisi(object sender, RoutedEventArgs e)
        {
            var selektovanPolaznik = Informacije.SelectedItem;
            Polaznik polaznik = (Polaznik)selektovanPolaznik;
            Utill.Instance.DeletePolaznik(polaznik.Id);
            Utill.Instance.Polaznici.Remove(polaznik);
        }

        private void izmeni(object sender, RoutedEventArgs e)
        {
            var selektovaniPolaznik = Informacije.SelectedItem;
            Polaznik polaznik = (Polaznik)selektovaniPolaznik;
            IzmenaAPolaznika izmeni = new IzmenaAPolaznika(polaznik);
            izmeni.Show();
            this.Close();
        }

        private void close(object sender, RoutedEventArgs e)
        {
            FitnesCentarSajt fcs = new FitnesCentarSajt();
            fcs.Show();
            this.Close();
        }
    }
}
