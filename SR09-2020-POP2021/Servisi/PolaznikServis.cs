using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using SR09_2020_POP2021.Model;

namespace SR09_2020_POP2021.Servisi
{
    class PolaznikServis : IPolaznikServis
    {
       

       

        public int savePolaznik(object obj)
        {
            Polaznik polaznik = obj as Polaznik;
            Random random = new Random();
            using (SqlConnection conn = new SqlConnection(Utill.CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = @"insert into Polaznici (id,ime,prezime,lozinka,email,jmbg,pol,aktivan,adresa_id,instruktor_id)
                                        output inserted.id VALUES (@id,@ime,@prezime,@lozinka,@email,@jmbg,@pol,@aktivan,@adresa_id,@instruktor_id)";
                command.Parameters.Add(new SqlParameter("id", polaznik.Id));
                command.Parameters.Add(new SqlParameter("ime", polaznik.Ime));
                command.Parameters.Add(new SqlParameter("prezime", polaznik.Prezime));
                command.Parameters.Add(new SqlParameter("lozinka", polaznik.Lozinka));
                command.Parameters.Add(new SqlParameter("email", polaznik.Email));
                command.Parameters.Add(new SqlParameter("jmbg", polaznik.JMBG));
                command.Parameters.Add(new SqlParameter("pol", polaznik.Pol));
                command.Parameters.Add(new SqlParameter("aktivan", polaznik.Aktivan));
                command.Parameters.Add(new SqlParameter("adresa_id", polaznik.AdresaId));
                command.Parameters.Add(new SqlParameter("instruktor_id", polaznik.InstruktorId));
                return (int)command.ExecuteScalar();









            }
        }

        public void updatePolaznik(object obj)
        {
            Polaznik polaznik = obj as Polaznik;
            using (SqlConnection conn = new SqlConnection(Utill.CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();

                command.CommandText = @"update dbo.Polaznici
                                        SET Aktivan = @Aktivan
                                        where id = @id";

                command.Parameters.Add(new SqlParameter("Aktivan", polaznik.Aktivan = false));
                command.Parameters.Add(new SqlParameter("id", polaznik.Id));

                command.ExecuteNonQuery();
            }
        }
        public void updatePolaznik1(object obj)
        {
            Polaznik polaznik = obj as Polaznik;
            using (SqlConnection conn = new SqlConnection(Utill.CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = @"update Polaznici
                                        SET ime = @ime,
                                             prezime = @prezime,
                                              lozinka = @lozinka,
                                               email = @email,
                                               pol = @pol,
                                               aktivan = @aktivan,
                                            adresa_id = @adresa_id,
                                            instruktor_id = @instruktor_id
                                        where id = @id";

                command.Parameters.Add(new SqlParameter("id", polaznik.Id));
                command.Parameters.Add(new SqlParameter("ime", polaznik.Ime));
                command.Parameters.Add(new SqlParameter("prezime", polaznik.Prezime));
                command.Parameters.Add(new SqlParameter("lozinka", polaznik.Lozinka));
                command.Parameters.Add(new SqlParameter("email", polaznik.Email));
                command.Parameters.Add(new SqlParameter("pol", polaznik.Pol));
                command.Parameters.Add(new SqlParameter("aktivan", polaznik.Aktivan));
                command.Parameters.Add(new SqlParameter("adresa_id", polaznik.AdresaId));
                command.Parameters.Add(new SqlParameter("instruktor_id", polaznik.InstruktorId));

                command.ExecuteScalar();
            }
        }


        public void readPolaznik()
        {
            Utill.Instance.Polaznici = new ObservableCollection<Polaznik>();
            using (SqlConnection conn = new SqlConnection(Utill.CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();

                command.CommandText = @"select * from Polaznici";

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Utill.Instance.Polaznici.Add(new Polaznik
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
                        InstruktorId = reader.GetInt32(9)



                    });


                }
                reader.Close();



            }
        }

        public void deletePolaznik(int id)
        {
            Polaznik k = Utill.Instance.Polaznici.ToList().Find(Polaznik => Polaznik.Id.Equals(id));
            k.Aktivan = false;
            //   if (k == null)
            // throw new UserNotFoundException($"Ne postoji korisnik sa korisnickim imenom {username}");
            updatePolaznik(k);
        }
    }
}
