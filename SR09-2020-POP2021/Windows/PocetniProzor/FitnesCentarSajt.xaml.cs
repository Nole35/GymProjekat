using SR09_2020_POP2021.Windows.LoginReg;
using SR09_2020_POP2021.Windows.Pretraga;
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

namespace SR09_2020_POP2021.Windows.PocetniProzor
{
    /// <summary>
    /// Interaction logic for FitnesCentarSajt.xaml
    /// </summary>
    public partial class FitnesCentarSajt : Window
    {
        public FitnesCentarSajt()
        {
            InitializeComponent();
        }
        private void btnPrijava_Click(object sender, RoutedEventArgs e)
        {
            PrijavaWindow pw = new PrijavaWindow();
            pw.Show();
            this.Close();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void registracija(object sender, RoutedEventArgs e)
        {
            RegistracijaPolaznikaWindow reg = new RegistracijaPolaznikaWindow();
            reg.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NRGKGlavnaStr nrgkgl = new NRGKGlavnaStr();
            nrgkgl.Show();
            this.Close();
        }

        private void pretraga(object sender, RoutedEventArgs e)
        {
            PretragaInstruktoraWindow pretraga = new PretragaInstruktoraWindow();
            pretraga.Show();
            this.Close();
        }
    }
}
