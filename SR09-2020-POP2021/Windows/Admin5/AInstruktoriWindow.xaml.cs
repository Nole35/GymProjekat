using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace SR09_2020_POP2021.Windows.Admin5
{
    /// <summary>
    /// Interaction logic for AInstruktoriWindow.xaml
    /// </summary>
    public partial class AInstruktoriWindow : Window
    {
        public AInstruktoriWindow()
        {
            InitializeComponent();
            Utill.Instance.CitanjeEntiteta();
            ICollectionView view = CollectionViewSource.GetDefaultView(Utill.Instance.Instruktori);

            Informacije.ItemsSource = view;
            Informacije.IsSynchronizedWithCurrentItem = true;

            Informacije.ColumnWidth = new DataGridLength(1, DataGridLengthUnitType.Star);
        }
        private void dodaj(object sender, RoutedEventArgs e)
        {
            DodavanjeInstruktora di = new DodavanjeInstruktora();
            di.Show();
            this.Close();
        }

        private void obrisi(object sender, RoutedEventArgs e)
        {
            var selektovaniInstruktor = Informacije.SelectedItem;
            Instruktor instruktor = (Instruktor)selektovaniInstruktor;
            Utill.Instance.DeleteInstruktor(instruktor.Id);
            Utill.Instance.Instruktori.Remove(instruktor);
        }

        private void izmeni(object sender, RoutedEventArgs e)
        {
            var selektovaniInstruktor = Informacije.SelectedItem;
            Instruktor instruktor = (Instruktor)selektovaniInstruktor;
            IzmenaAInstruktora izmeni = new IzmenaAInstruktora(instruktor);
            izmeni.Show();
            this.Close();
        }


        private void close(object sender, RoutedEventArgs e)
        {

        }
    }
}