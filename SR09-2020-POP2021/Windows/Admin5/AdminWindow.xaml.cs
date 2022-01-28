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
    }
}
