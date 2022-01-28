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

namespace SR09_2020_POP2021.Windows.Instructors
{
    /// <summary>
    /// Interaction logic for InstruktorWindow.xaml
    /// </summary>
    public partial class InstruktorWindow : Window
    {
        string prosledjeniJmbg;
        public InstruktorWindow(string jmbg)
        {
            InitializeComponent();
            this.prosledjeniJmbg = jmbg;
        }

        private void pregledPolaznika(object sender, RoutedEventArgs e)
        {

        }

        private void pregledPodataka(object sender, RoutedEventArgs e)
        {
            PregledPodInstruktora ppi = new PregledPodInstruktora(prosledjeniJmbg);
            ppi.Show();
            this.Close();
        }

        private void pregledTreninga(object sender, RoutedEventArgs e)
        {

        }
    }
}
