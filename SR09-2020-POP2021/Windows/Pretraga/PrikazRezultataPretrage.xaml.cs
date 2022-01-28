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

namespace SR09_2020_POP2021.Windows.Pretraga
{
    /// <summary>
    /// Interaction logic for PrikazRezultataPretrage.xaml
    /// </summary>
    public partial class PrikazRezultataPretrage : Window
    {
        public PrikazRezultataPretrage(ObservableCollection<Instruktor> instruktoriLista)
        {
            InitializeComponent();

            ICollectionView view = CollectionViewSource.GetDefaultView(instruktoriLista);

            prikazRezultataPretrage.ItemsSource = view;
            prikazRezultataPretrage.IsSynchronizedWithCurrentItem = true;

            prikazRezultataPretrage.ColumnWidth = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void prikazRezultataPretrage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
