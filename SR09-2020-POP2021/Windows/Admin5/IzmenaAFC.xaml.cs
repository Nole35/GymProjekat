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
    /// Interaction logic for IzmenaAFC.xaml
    /// </summary>
    public partial class IzmenaAFC : Window
    {
        private FitnesCentar prosledjenFitnesCentar;
        public IzmenaAFC(FitnesCentar fitnes)
        {
            InitializeComponent();
            this.prosledjenFitnesCentar = fitnes;
            txtNaz.DataContext = fitnes;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string naziv = txtNaz.Text;


            prosledjenFitnesCentar.Naziv = naziv;
            Utill.Instance.updateFitnesCentar(prosledjenFitnesCentar);
            MessageBox.Show("Izmena Uspesna");
            AFitnesCentarWindow pregled = new AFitnesCentarWindow();
            pregled.Show();
            this.Close();

        }
    }
}
