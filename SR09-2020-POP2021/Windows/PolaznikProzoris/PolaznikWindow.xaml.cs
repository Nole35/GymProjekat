using SR09_2020_POP2021.Windows.PocetniProzor;
using SR09_2020_POP2021.Windows.PregledIzmenaSPodataka;
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

namespace SR09_2020_POP2021.Windows.PolaznikProzoris
{
    /// <summary>
    /// Interaction logic for PolaznikWindow.xaml
    /// </summary>
    public partial class PolaznikWindow : Window
    {
        string prosledjeniJmbg;
        public PolaznikWindow(string jmbg)
        {
            InitializeComponent();
            this.prosledjeniJmbg = jmbg;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FitnesCentarSajt fcs = new FitnesCentarSajt();
            fcs.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PregledPodPolaznika ppp = new PregledPodPolaznika(prosledjeniJmbg);
            ppp.Show();
            this.Close();
        }
    }
}
