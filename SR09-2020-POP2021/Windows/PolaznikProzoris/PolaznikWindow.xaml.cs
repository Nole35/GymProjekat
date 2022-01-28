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
    }
}
