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
    /// Interaction logic for PregledPodataka.xaml
    /// </summary>
    public partial class PregledPodataka : Window
    {
        public PregledPodataka(string jmbg)
        {
            InitializeComponent();
            Utill.Instance.CitanjeEntiteta();
            Admin admin = Utill.Instance.Admini.ToList().Find(admin1 => admin1.JMBG.Equals(jmbg));
            ObservableCollection<Admin> admini = new ObservableCollection<Admin>();
            admini.Add(admin);


            ICollectionView view = CollectionViewSource.GetDefaultView(admini);

            Informacije.ItemsSource = view;
            Informacije.IsSynchronizedWithCurrentItem = true;

            Informacije.ColumnWidth = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var izabraniAdmin = Informacije.SelectedItem;
            Admin admin = (Admin)izabraniAdmin;
            IzmeniPodatke izmeni = new IzmeniPodatke(admin);
            izmeni.Show();
            this.Close();
        }
    }
}
