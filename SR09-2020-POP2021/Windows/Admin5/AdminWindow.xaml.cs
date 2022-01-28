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
using SR09_2020_POP2021.Windows.PregledIzmenaSPodataka;
using SR09_2020_POP2021.Windows.Pretraga;

namespace SR09_2020_POP2021.Windows.Admin5
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        private string prosledjeniJmbg;
        public AdminWindow(string jmbg)
        {
            InitializeComponent();
            this.prosledjeniJmbg = jmbg;
        }

       /* private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            PregledInstruktoraWindow piw = new PregledInstruktoraWindow();
            piw.Show();
            this.Close();
        }*/

        private void pregledPodataka(object sender, RoutedEventArgs e)
        {
            PregledPodataka podataka = new PregledPodataka(prosledjeniJmbg);
            podataka.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PretragaPolaznikaWindow ppw = new PretragaPolaznikaWindow();
            ppw.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ATreninziWindow at = new ATreninziWindow();
            at.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AInstruktoriWindow iw = new AInstruktoriWindow();
            iw.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            APolazniciWindow pw = new APolazniciWindow();
            pw.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            AAdresaWindow aaw = new AAdresaWindow();
            aaw.Show();
            this.Close();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            AFitnesCentarWindow aaafc = new AFitnesCentarWindow();
            aaafc.Show();
            this.Close();
        }
    }
}
