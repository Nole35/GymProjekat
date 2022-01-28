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

namespace SR09_2020_POP2021.Windows.PregledIzmenaSPodataka
{
    /// <summary>
    /// Interaction logic for PregledPodPolaznika.xaml
    /// </summary>
    public partial class PregledPodPolaznika : Window
    {
        public PregledPodPolaznika(string jmbg)
        {
            InitializeComponent();
            Utill.Instance.CitanjeEntiteta();
            Polaznik polaznik = Utill.Instance.Polaznici.ToList().Find(polaznik1 => polaznik1.JMBG.Equals(jmbg));
            ObservableCollection<Polaznik> polaznici = new ObservableCollection<Polaznik>();
            polaznici.Add(polaznik);


            ICollectionView view = CollectionViewSource.GetDefaultView(polaznici);

            Informacije.ItemsSource = view;
            Informacije.IsSynchronizedWithCurrentItem = true;

            Informacije.ColumnWidth = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var izabraniPolaznik = Informacije.SelectedItem;
            Polaznik polaznik = (Polaznik)izabraniPolaznik;
            IzmenaPodPolaznika izmeni = new IzmenaPodPolaznika(polaznik);
            izmeni.Show();
            this.Close();
        }
    }
}
