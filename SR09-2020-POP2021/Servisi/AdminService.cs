using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SR09_2020_POP2021.Model;


namespace SR09_2020_POP2021.Servisi
{
    public class AdminService : IAdminService
    {
       

       

        public int saveAdmin(object obj)
        {
            throw new NotImplementedException();
        }


        public void updateAdmin(object obj)
        {
            Admin admin = obj as Admin;
            using (SqlConnection conn = new SqlConnection(Utill.CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = @"update Administrator
                                        SET ime = @ime,
                                             prezime = @prezime,
                                              lozinka = @lozinka,
                                               email = @email,
                                               pol = @pol,
                                               aktivan = @aktivan,
                                            adresa_id = @adresa_id
                                        where id = @id";

                command.Parameters.Add(new SqlParameter("id", admin.Id));
                command.Parameters.Add(new SqlParameter("ime", admin.Ime));
                command.Parameters.Add(new SqlParameter("prezime", admin.Prezime));
                command.Parameters.Add(new SqlParameter("lozinka", admin.Lozinka));
                command.Parameters.Add(new SqlParameter("email", admin.Email));
                command.Parameters.Add(new SqlParameter("pol", admin.Pol));
                command.Parameters.Add(new SqlParameter("aktivan", admin.Aktivan));
                command.Parameters.Add(new SqlParameter("adresa_id", admin.AdresaId));

                command.ExecuteScalar();
            }
        }

        public void readAdmin()
        {
            Utill.Instance.Admini = new ObservableCollection<Admin>();
            using (SqlConnection conn = new SqlConnection(Utill.CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();

                command.CommandText = @"select * from Administrator";

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Utill.Instance.Admini.Add(new Admin
                    {
                        Id = reader.GetInt32(0),
                        Ime = reader.GetString(1),
                        Prezime = reader.GetString(2),
                        Lozinka = reader.GetString(3),
                        Email = reader.GetString(4),
                        JMBG = reader.GetString(5),
                        Pol = (EPol)Enum.Parse(typeof(EPol), reader.GetString(6)),
                        Aktivan = reader.GetBoolean(7),
                        AdresaId = reader.GetInt32(8),
                    });
                }
                reader.Close();
            }
        }

        public void deleteAdmin(int broj)
        {
            Admin k = Utill.Instance.Admini.ToList().Find(Admin => Admin.Id.Equals(broj));
            k.Aktivan = false;
            updateAdmin(k);
        }
    }
}
