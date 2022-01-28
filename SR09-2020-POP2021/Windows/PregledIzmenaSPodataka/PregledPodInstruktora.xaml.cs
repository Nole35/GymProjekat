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

namespace SR09_2020_POP2021.Windows.PregledIzmenaSPodataka 
{

    /// <summary>
    /// Interaction logic for PregledPodInstruktora.xaml
    /// </summary>
public partial class PregledPodInstruktora : Window
{
    ICollectionView view;


    public PregledPodInstruktora(string jmbg)
    {
        InitializeComponent();
        Utill.Instance.CitanjeEntiteta();
        UpdateView();
    }

    private void UpdateView()
    {
        DGInstruktori.ItemsSource = null;
        view = CollectionViewSource.GetDefaultView(source: Utill.Instance.Instruktori);
        DGInstruktori.ItemsSource = view;
        DGInstruktori.IsSynchronizedWithCurrentItem = true;

        DGInstruktori.ColumnWidth = new DataGridLength(1, DataGridLengthUnitType.Star);

        DGInstruktori.SelectedItems.Clear();
    }
}
}
