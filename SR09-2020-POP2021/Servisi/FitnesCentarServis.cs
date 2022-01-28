using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SR09_2020_POP2021.Model;
using System.Data.SqlClient;

namespace SR09_2020_POP2021.Servisi
{
    class FitnesCentarServis : IFitnesCentarServis
    {
        public void deleteFitnesCentar(int broj)
        {
            FitnesCentar k = Utill.Instance.FitnesCentri.ToList().Find(FitnesCentar => FitnesCentar.Sifra.Equals(broj));
            k.Aktivan = false;
            //  if (k == null)
            // throw new UserNotFoundException($"Ne postoji korisnik sa korisnickim imenom {username}");
            updateFitnesCentar(k);
        }


        public void readFitnesCentar()
        {
            Utill.Instance.FitnesCentri = new ObservableCollection<FitnesCentar>();
            using (SqlConnection conn = new SqlConnection(Utill.CONNECTION_STRING))
            {
                conn.Open();

                SqlCommand command = conn.CreateCommand();

                command.CommandText = @"select * from FitnesCentri";

                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    Utill.Instance.FitnesCentri.Add(new FitnesCentar
                    {
                        Sifra = reader.GetInt32(0),
                        Naziv = reader.GetString(1),
                        AdresaID = reader.GetInt32(2),
                        Aktivan = reader.GetBoolean(3)
                    });


                }



                reader.Close();
            }
        }



        public int saveFitnesCentar(object obj)
        {
            FitnesCentar fitnesCentar = obj as FitnesCentar;
            Random rnd = new Random();

            using (SqlConnection conn = new SqlConnection(Utill.CONNECTION_STRING))
            {
                conn.Open();

                SqlCommand command = conn.CreateCommand();
                command.CommandText = @"insert into dbo.FitnesCentri (id,Naziv,adresa_id,active)
                                        output inserted.id VALUES (@id,@Naziv,@adresa_id,@active)";
                command.Parameters.Add(new SqlParameter("id", fitnesCentar.Sifra = rnd.Next(1, 1000)));
                command.Parameters.Add(new SqlParameter("Naziv", fitnesCentar.Naziv));
                command.Parameters.Add(new SqlParameter("adresa_id", fitnesCentar.AdresaID));
                command.Parameters.Add(new SqlParameter("active", fitnesCentar.Aktivan));

                return (int)command.ExecuteScalar();
            }
            //return -1;
        }

        public void updateFitnesCentar(object obj)
        {
            FitnesCentar fitnesCentar = obj as FitnesCentar;
            using (SqlConnection conn = new SqlConnection(Utill.CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();

                command.CommandText = @"update dbo.FitnesCentri
                                        SET Active = @Active
                                        where id = @id";

                command.Parameters.Add(new SqlParameter("Active", fitnesCentar.Aktivan = false));
                command.Parameters.Add(new SqlParameter("id", fitnesCentar.Sifra));

                command.ExecuteNonQuery();
            }
        }

        public void updateFitnesCentar1(object obj)
        {

            FitnesCentar fitnesCentar = obj as FitnesCentar;
            using (SqlConnection conn = new SqlConnection(Utill.CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = @"update FitnesCentri 
                                        SET naziv = @naziv,
                                            adresa_id = @adresa_id
                                        where id = @id";

                command.Parameters.Add(new SqlParameter("naziv", fitnesCentar.Naziv));
                command.Parameters.Add(new SqlParameter("adresa_id", fitnesCentar.AdresaID));
                command.Parameters.Add(new SqlParameter("id", fitnesCentar.Sifra));


                command.ExecuteScalar();
            }

        }
    }
}
