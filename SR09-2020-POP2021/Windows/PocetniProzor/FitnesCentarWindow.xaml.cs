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
    /// Interaction logic for FitnesCentarWindow.xaml
    /// </summary>
    public partial class FitnesCentarWindow : Window
    {
        public FitnesCentarWindow()
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
            RegsitracijaPolaznikaWindow reg = new RegsitracijaPolaznikaWindow();
            reg.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            InfoFitnesCentraWindow ifc = new InfoFitnesCentraWindow();
            ifc.Show();
            this.Close();
        }

        private void pretraga(object sender, RoutedEventArgs e)
        {
            PretragaInstruktoraxaml pretraga = new PretragaInstruktoraxaml();
            pretraga.Show();
            this.Close();
        }
    }
}
