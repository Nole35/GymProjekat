﻿using System;
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

namespace SR09_2020_POP2021.Windows.Admin5
{
    /// <summary>
    /// Interaction logic for AFitnesCentarWindow.xaml
    /// </summary>
    public partial class AFitnesCentarWindow : Window
    {
        public AFitnesCentarWindow()
        {
            InitializeComponent();
            Utill.Instance.CitanjeEntiteta();
            ICollectionView view = CollectionViewSource.GetDefaultView(Utill.Instance.FitnesCentri);

            Podaci.ItemsSource = view;
            Podaci.IsSynchronizedWithCurrentItem = true;

            Podaci.ColumnWidth = new DataGridLength(1, DataGridLengthUnitType.Star);

        }

        private void dodaj(object sender, RoutedEventArgs e)
        {

        }

        private void obrisi(object sender, RoutedEventArgs e)
        {
            var selektovaniFitnes = Podaci.SelectedItem;
            FitnesCentar fitnes = (FitnesCentar)selektovaniFitnes;
            Utill.Instance.DeleteFitnesCentar(fitnes.Sifra);
            Utill.Instance.FitnesCentri.Remove(fitnes);
        }

        private void izmeni(object sender, RoutedEventArgs e)
        {
            var selektovanFitnes = Podaci.SelectedItem;
            FitnesCentar fitnes = (FitnesCentar)selektovanFitnes;
            IzmenaAFC ipfc = new IzmenaAFC(fitnes);
            ipfc.Show();
            this.Close();
        }

        private void close(object sender, RoutedEventArgs e)
        {

        }
    }
}