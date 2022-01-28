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
    class InstruktoriServis : IInstruktoriServis
    {
        public void deleteInstruktor(int id)
        {
            Instruktor k = Utill.Instance.Instruktori.ToList().Find(Instruktor => Instruktor.Id.Equals(id));
            k.Aktivan = false;
            //   if (k == null)
            // throw new UserNotFoundException($"Ne postoji korisnik sa korisnickim imenom {username}");
            updateInstruktor(k);
        }

        public void readInstruktor()
        {
            Utill.Instance.Instruktori = new ObservableCollection<Instruktor>();
            using (SqlConnection conn = new SqlConnection(Utill.CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();

                command.CommandText = @"select * from Instruktori";

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Utill.Instance.Instruktori.Add(new Instruktor
                    {
                        Id = reader.GetInt32(0),
                        Ime = reader.GetString(1),
                        Prezime = reader.GetString(2),
                        Lozinka = reader.GetString(3),
                        Email = reader.GetString(4),
                        JMBG = reader.GetString(5),
                        Pol = (EPol)Enum.Parse(typeof(EPol), reader.GetString(6)),
                        Aktivan = reader.GetBoolean(7),
                        AdresaId = reader.GetInt32(8)




                    });


                }
                reader.Close();



            }
        }

        public int saveInstruktor(object obj)
        {
            Instruktor instruktor = obj as Instruktor;
            Random random = new Random();
            using (SqlConnection conn = new SqlConnection(Utill.CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = @"insert into Instruktori (id,ime,prezime,lozinka,email,jmbg,pol,aktivan,adresa_id)
                                        output inserted.id VALUES (@id,@ime,@prezime,@lozinka,@email,@jmbg,@pol,@aktivan,@adresa_id)";
                command.Parameters.Add(new SqlParameter("id", instruktor.Id));
                command.Parameters.Add(new SqlParameter("ime", instruktor.Ime));
                command.Parameters.Add(new SqlParameter("prezime", instruktor.Prezime));
                command.Parameters.Add(new SqlParameter("lozinka", instruktor.Lozinka));
                command.Parameters.Add(new SqlParameter("email", instruktor.Email));
                command.Parameters.Add(new SqlParameter("jmbg", instruktor.JMBG));
                command.Parameters.Add(new SqlParameter("pol", instruktor.Pol));
                command.Parameters.Add(new SqlParameter("aktivan", instruktor.Aktivan));
                command.Parameters.Add(new SqlParameter("adresa_id", instruktor.AdresaId));
                return (int)command.ExecuteScalar();









            }
        }

        public void updateInstruktor(object obj)
        {
            Instruktor instruktor = obj as Instruktor;
            using (SqlConnection conn = new SqlConnection(Utill.CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();

                command.CommandText = @"update dbo.Instruktori
                                        SET Aktivan = @Aktivan
                                        where id = @id";

                command.Parameters.Add(new SqlParameter("Aktivan", instruktor.Aktivan = false));
                command.Parameters.Add(new SqlParameter("id", instruktor.Id));

                command.ExecuteNonQuery();
            }
        }
        public void updateInstruktor1(object obj)
        {
            Instruktor instruktor = obj as Instruktor;
            using (SqlConnection conn = new SqlConnection(Utill.CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = @"update Instruktori
                                        SET ime = @ime,
                                             prezime = @prezime,
                                              lozinka = @lozinka,
                                               email = @email,
                                               pol = @pol,
                                               aktivan = @aktivan,
                                            adresa_id = @adresa_id
                                        where id = @id";

                command.Parameters.Add(new SqlParameter("id", instruktor.Id));
                command.Parameters.Add(new SqlParameter("ime", instruktor.Ime));
                command.Parameters.Add(new SqlParameter("prezime", instruktor.Prezime));
                command.Parameters.Add(new SqlParameter("lozinka", instruktor.Lozinka));
                command.Parameters.Add(new SqlParameter("email", instruktor.Email));
                command.Parameters.Add(new SqlParameter("pol", instruktor.Pol));
                command.Parameters.Add(new SqlParameter("aktivan", instruktor.Aktivan));
                command.Parameters.Add(new SqlParameter("adresa_id", instruktor.AdresaId));

                command.ExecuteScalar();
            }
        }
    }
}
