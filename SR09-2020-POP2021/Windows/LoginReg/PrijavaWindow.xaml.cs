using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace SR09_2020_POP2021.Windows.LoginReg
{
    /// <summary>
    /// Interaction logic for PrijavaWindow.xaml
    /// </summary>
    public partial class PrijavaWindow : Window
    {
        public PrijavaWindow()
        {
            Utill.Instance.CitanjeEntiteta();
            InitializeComponent();
        }

        private void prijava(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(Utill.CONNECTION_STRING);
            try
            {
                sqlCon.Open();
                string admin = "SELECT COUNT(1) FROM Administrator WHERE jmbg=@jmbg AND lozinka=@lozinka and aktivan=1";
                SqlCommand sqlcommandAdmin = new SqlCommand(admin, sqlCon);
                sqlcommandAdmin.CommandType = System.Data.CommandType.Text;
                sqlcommandAdmin.Parameters.AddWithValue("@jmbg", txtUsername.Text);
                sqlcommandAdmin.Parameters.AddWithValue("@lozinka", txtPassword.Password);
                int countAdmin = (int)sqlcommandAdmin.ExecuteScalar();

                string instruktor = "SELECT COUNT(1) FROM Instruktori WHERE jmbg=@jmbg AND lozinka=@lozinka and aktivan=1";
                SqlCommand sqlcommandInstrukotr = new SqlCommand(instruktor, sqlCon);
                sqlcommandInstrukotr.CommandType = System.Data.CommandType.Text;
                sqlcommandInstrukotr.Parameters.AddWithValue("@jmbg", txtUsername.Text);
                sqlcommandInstrukotr.Parameters.AddWithValue("@lozinka", txtPassword.Password);
                int countInstruktor = (int)sqlcommandInstrukotr.ExecuteScalar();

                string polaznik = "SELECT COUNT(1) FROM Polaznici WHERE jmbg=@jmbg AND lozinka=@lozinka and aktivan=1";
                SqlCommand sqlcommandPolaznik = new SqlCommand(polaznik, sqlCon);
                sqlcommandPolaznik.CommandType = System.Data.CommandType.Text;
                sqlcommandPolaznik.Parameters.AddWithValue("@jmbg", txtUsername.Text);
                sqlcommandPolaznik.Parameters.AddWithValue("@lozinka", txtPassword.Password);

                int countPolaznik = (int)sqlcommandPolaznik.ExecuteScalar();


                if (countAdmin > 0)
                {
                    AdminWindow adminProzor = new AdminWindow(txtUsername.Text);
                    adminProzor.Show();
                    this.Close();
                }
                else if (countInstruktor > 0)
                {
                    InstruktorWindow instProzor = new InstruktorWindow(txtUsername.Text);
                    instProzor.Show();
                    this.Close();
                }
                else if (countPolaznik > 0)
                {
                    PolaznikWindow polaznikProzor = new PolaznikWindow(txtUsername.Text);
                    polaznikProzor.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Greska pri unosu");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
