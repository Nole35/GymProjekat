﻿using System;
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
    /// Interaction logic for AAdresaWindow.xaml
    /// </summary>
    public partial class AAdresaWindow : Window
    {
        public AAdresaWindow()
        {
            InitializeComponent();
            Utill.Instance.CitanjeEntiteta();
            ICollectionView view = CollectionViewSource.GetDefaultView(Utill.Instance.Adrese);

            Podaci.ItemsSource = view;
            Podaci.IsSynchronizedWithCurrentItem = true;

            Podaci.ColumnWidth = new DataGridLength(1, DataGridLengthUnitType.Star);
        }


        private void dodaj(object sender, RoutedEventArgs e)
        {

        }

        private void obrisi(object sender, RoutedEventArgs e)
        {
            var selektovanaAdresa = Podaci.SelectedItem;
            Adresa adresa = (Adresa)selektovanaAdresa;
            Utill.Instance.DeleteAdresa(adresa.SifraAdrese);
            Utill.Instance.Adrese.Remove(adresa);
        }

        private void izmeni(object sender, RoutedEventArgs e)
        {
            var selektovanaAdresa = Podaci.SelectedItem;
            Adresa adresa = (Adresa)selektovanaAdresa;
            IzmenaAAdrese izmeni = new IzmenaAAdrese(adresa);
            izmeni.Show();
            this.Close();
        }

        private void close(object sender, RoutedEventArgs e)
        {

        }
    }
}