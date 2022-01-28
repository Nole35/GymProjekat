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
    /// Interaction logic for PregledPodInstruktora.xaml
    /// </summary>
    public partial class PregledPodInstruktora : Window
    {
        public PregledPodInstruktora(string jmbg)
        {
            InitializeComponent();
            Utill.Instance.CitanjeEntiteta();
            Instruktor instruktor = Utill.Instance.Instruktori.ToList().Find(instruktor1 => instruktor1.JMBG.Equals(jmbg));
            ObservableCollection<Instruktor> instruktori = new ObservableCollection<Instruktor>();
            instruktori.Add(instruktor);


            ICollectionView view = CollectionViewSource.GetDefaultView(instruktori);

            PodaciI.ItemsSource = view;
            PodaciI.IsSynchronizedWithCurrentItem = true;

            PodaciI.ColumnWidth = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selektovaniInstruktor = PodaciI.SelectedItem;
            Instruktor instruktor = (Instruktor)selektovaniInstruktor;
            IzmenaPodInstruktora izpi = new IzmenaPodInstruktora(instruktor);
            izpi.Show();
            this.Close();
        }
    }
}

