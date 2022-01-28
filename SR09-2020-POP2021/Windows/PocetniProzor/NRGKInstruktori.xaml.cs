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

namespace SR09_2020_POP2021.Windows.PocetniProzor
{
    /// <summary>
    /// Interaction logic for NRGKInstruktori.xaml
    /// </summary>
    public partial class NRGKInstruktori : Window
    {
        public NRGKInstruktori()
        {
            InitializeComponent();
            Utill.Instance.CitanjeEntiteta();
            ICollectionView view = CollectionViewSource.GetDefaultView(Utill.Instance.Instruktori);

            instruktori.ItemsSource = view;
            instruktori.IsSynchronizedWithCurrentItem = true;

            instruktori.ColumnWidth = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NRGKGlavnaStr fcs = new NRGKGlavnaStr();
            fcs.Show();
            this.Close();
        }
    }
}