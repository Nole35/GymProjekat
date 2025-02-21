﻿using System;
using System.Collections.Generic;
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
    /// Interaction logic for IzmenaAAdrese.xaml
    /// </summary>
    public partial class IzmenaAAdrese : Window
    {
        private Adresa dodeljenaAdresa;
        public IzmenaAAdrese(Adresa adresa)
        {
            InitializeComponent();
            this.dodeljenaAdresa = adresa;
            txtUl.DataContext = adresa;
            txtBr.DataContext = adresa;
            txtGr.DataContext = adresa;
            txtDrz.DataContext = adresa;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string ulica = txtUl.Text;
            string broj = txtBr.Text;
            string grad = txtGr.Text;
            string drzava = txtDrz.Text;

            dodeljenaAdresa.Ulica = ulica;
            dodeljenaAdresa.Broj = broj;
            dodeljenaAdresa.Grad = grad;
            dodeljenaAdresa.Drzava = drzava;

            Utill.Instance.updateAdresa(dodeljenaAdresa);
            MessageBox.Show("Izmena Uspesna");
            AAdresaWindow pregled = new AAdresaWindow();
            pregled.Show();
            this.Close();
        }
    }
}
