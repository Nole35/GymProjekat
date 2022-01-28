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
    /// Interaction logic for IzmenaAAdrese.xaml
    /// </summary>
    public partial class IzmenaAAdrese : Window
    {
        private Adresa prosledjenaAdresa;
        public IzmenaAAdrese(Adresa adresa)
        {
            InitializeComponent();
            this.prosledjenaAdresa = adresa;
            txtUlica.DataContext = adresa;
            txtBroj.DataContext = adresa;
            txtGrad.DataContext = adresa;
            txtDrzava.DataContext = adresa;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string ulica = txtUlica.Text;
            string broj = txtBroj.Text;
            string grad = txtGrad.Text;
            string drzava = txtDrzava.Text;

            prosledjenaAdresa.Ulica = ulica;
            prosledjenaAdresa.Broj = broj;
            prosledjenaAdresa.Grad = grad;
            prosledjenaAdresa.Drzava = drzava;

            Utill.Instance.updateAdresa(prosledjenaAdresa);
            MessageBox.Show("Izmena Uspesna");
            AAdresaWindow pregled = new AAdresaWindow();
            pregled.Show();
            this.Close();
        }
    }
}
