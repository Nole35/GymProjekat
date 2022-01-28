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
    /// Interaction logic for ATreninziWindow.xaml
    /// </summary>
    public partial class ATreninziWindow : Window
    {
        public ATreninziWindow()
        {
            InitializeComponent();
            Utill.Instance.CitanjeEntiteta();
            ICollectionView view = CollectionViewSource.GetDefaultView(Utill.Instance.Treninzi);

            Informacije.ItemsSource = view;
            Informacije.IsSynchronizedWithCurrentItem = true;

            Informacije.ColumnWidth = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void obrisi(object sender, RoutedEventArgs e)
        {

        }

        private void close(object sender, RoutedEventArgs e)
        {
            FitnesCentarSajt fcs = new FitnesCentarSajt();
            fcs.Show();
            this.Close();
        }

        private void izmeni(object sender, RoutedEventArgs e)
        {
            var izabraniTrening = Informacije.SelectedItem;
            Trening trening = (Trening)izabraniTrening;
            IzmenaATreninga iat = new IzmenaATreninga(trening);
            iat.Show();
            this.Close();
        }

        private void dodaj(object sender, RoutedEventArgs e)
        {
            DodavanjeTreninga dt = new DodavanjeTreninga();
            dt.Show();
            this.Close();
        }
    }
}
