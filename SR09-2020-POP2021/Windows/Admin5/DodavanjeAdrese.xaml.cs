using System;
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
    /// Interaction logic for DodavanjeAdrese.xaml
    /// </summary>
    public partial class DodavanjeAdrese : Window
    {
        public DodavanjeAdrese()
        {
            InitializeComponent();
        }

        private void dodaj(object sender, RoutedEventArgs e)
        {
            int sifra = int.Parse(txtSifra.Text.ToString());
            string ulica = txtUlica.Text;
            string broj = txtBroj.Text;
            string grad = txtGrad.Text;
            string drzava = txtDrzava.Text;


            Adresa adresa = new Adresa(sifra, ulica, broj, grad, drzava, true);
            Utill.Instance.Adrese.Add(adresa);
            Utill.Instance.SacuvajEntitet(adresa);
            AAdresaWindow aw = new AAdresaWindow();
            aw.Show();
            this.Close();
        }

        private void close(object sender, RoutedEventArgs e)
        {

        }
    }
}