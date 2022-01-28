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
    class TreningServis : ITreningServis
    {
    

        public void readTrening()
        {
            Utill.Instance.Treninzi = new ObservableCollection<Trening>();
            using (SqlConnection conn = new SqlConnection(Utill.CONNECTION_STRING))
            {
                conn.Open();

                SqlCommand command = conn.CreateCommand();

                command.CommandText = @"select * from Treninzi where datum_treninga >= CAST(CURRENT_TIMESTAMP AS DATE);";

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Utill.Instance.Treninzi.Add(new Trening
                    {
                        Sifra = reader.GetInt32(0),
                        InstruktorId = reader.GetInt32(1),
                        DatumTreninga = reader.GetDateTime(2),
                        VremeTreninga = reader.GetInt32(3),
                        TrajanjeTreninga = reader.GetInt32(4),
                        Status = (EStatus)Enum.Parse(typeof(EStatus), reader.GetString(5)),
                        PolaznikId = reader.GetInt32(6),
                        Aktivan = reader.GetBoolean(7)



                    });


                }
                reader.Close();
            }
        }
        public int saveTrening(object obj)
        {
            Trening trening = obj as Trening;
            Random random = new Random();

            using (SqlConnection conn = new SqlConnection(Utill.CONNECTION_STRING))
            {
                conn.Open();

                SqlCommand command = conn.CreateCommand();
                command.CommandText = @"insert into dbo.Treninzi (id,instruktor_id,datum_treninga,vreme_treninga,trajanje_treninga,status,polaznik_id,aktivan)
                                        output inserted.id VALUES (@id,@instruktor_id,@datum_treninga,@vreme_treninga,@trajanje_treninga,@status,@polaznik_id,@aktivan)";
                command.Parameters.Add(new SqlParameter("id", trening.Sifra = random.Next(1, 1000)));
                command.Parameters.Add(new SqlParameter("instruktor_id", trening.InstruktorId));
                command.Parameters.Add(new SqlParameter("datum_treninga", trening.DatumTreninga));
                command.Parameters.Add(new SqlParameter("vreme_treninga", trening.VremeTreninga));
                command.Parameters.Add(new SqlParameter("trajanje_treninga", trening.TrajanjeTreninga));
                command.Parameters.Add(new SqlParameter("status", trening.Status));
                command.Parameters.Add(new SqlParameter("polaznik_id", trening.PolaznikId));
                command.Parameters.Add(new SqlParameter("aktivan", trening.Aktivan));

                return (int)command.ExecuteScalar();
            }
            //return -1;
        }

        public void updateTrening(object obj)
        {
            Trening t = obj as Trening;
            using (SqlConnection conn = new SqlConnection(Utill.CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();

                command.CommandText = @"update dbo.Treninzi
                                        SET aktivan = @aktivan
                                        where id = @id";

                command.Parameters.Add(new SqlParameter("aktivan", t.Aktivan = false));
                command.Parameters.Add(new SqlParameter("id", t.Sifra));

                command.ExecuteNonQuery();
            }
        }
        public void updateTrening1(object obj)
        {
            Trening trening = obj as Trening;
            using (SqlConnection conn = new SqlConnection(Utill.CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = @"update Treninzi
                                        SET instruktor_id = @instruktor_id,
                                            datum_treninga = @datum_treninga,
                                            vreme_treninga = @vreme_treninga
                                            trajanje_treninga = @trajanje_treninga
                                            status = @status,
                                            polaznik_id = @polaznik_id
                                        where id = @id";

                command.Parameters.Add(new SqlParameter("instruktor_id", trening.InstruktorId));
                command.Parameters.Add(new SqlParameter("datum_treninga", trening.DatumTreninga));
                command.Parameters.Add(new SqlParameter("vreme_treninga", trening.VremeTreninga));
                command.Parameters.Add(new SqlParameter("trajanje_treninga", trening.TrajanjeTreninga));
                command.Parameters.Add(new SqlParameter("status", trening.Status));
                command.Parameters.Add(new SqlParameter("polaznik_id", trening.PolaznikId));
                command.Parameters.Add(new SqlParameter("sifra", trening.Sifra));

                command.ExecuteScalar();
            }
        }

        public void deleteTrening(int broj)
        {
            Trening k = Utill.Instance.Treninzi.ToList().Find(Trening => Trening.Sifra.Equals(broj));
            k.Aktivan = false;
            //   if (k == null)
            // throw new UserNotFoundException($"Ne postoji korisnik sa korisnickim imenom {username}");
            updateTrening(k);
        }
    }
}
