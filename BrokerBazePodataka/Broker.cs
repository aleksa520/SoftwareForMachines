using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace BrokerBazePodataka
{
    public class Broker
    {
        SqlConnection connection;
        SqlTransaction transaction;

        public Broker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VezbanjeDoSmrti;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public void OtvoriKonekciju()
        {
            connection.Open();
        }

        public void ZatvoriKonekciju()
        {
            connection.Close();
        }

        public void PokreniTransakciju()
        {
            transaction = connection.BeginTransaction();
        }

        public void Commit()
        {
            transaction.Commit();
        }

        public void Rollback()
        {
            transaction.Rollback();
        }

        public List<Lokacija> VratiSveLokacijeSortirano()
        {
            connection.Open();
            List<Lokacija> lokacije = new List<Lokacija>();
            SqlDataReader reader = null;

            try
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM Lokacija ORDER BY Naziv";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Lokacija l = new Lokacija()
                    {
                        LokacijaId = reader.GetInt32(0),
                        Naziv = reader.GetString(1)
                    };
                    lokacije.Add(l);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Greska u radu s bazom");
            }
            finally
            {
                connection.Close();
                reader.Close();
            }
            return lokacije;
        }

        public bool PostojiLiMasinaNaLokaciji(Lokacija l)
        {
            connection.Open();
            bool ima;
            try
            {        
                SqlCommand command = connection.CreateCommand();
                command.CommandText = $"SELECT COUNT(MasinaId) FROM Masina WHERE LokacijaId = {l.LokacijaId}";
                object rez = command.ExecuteScalar();
                if((int)(rez) == 0)
                {
                    ima = false;
                }
                else
                {
                    ima = true;
                }       
            }
            catch (Exception e)
            {
                throw new Exception("Greska u radu s bazom");
            }
            finally
            {
                connection.Close();
            }
            return ima;
        }

        public void SacuvajMasinuSmanjiAlate(Masina m, List<Alat> alatiNaFormi)
        {
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO Masina OUTPUT INSERTED.MasinaId VALUES(@Naziv,@Proizvodjac, @OcekivaniRadniVek, @GodinaProizvodnje, @Korisnik, @DatumPocetkaEksploatacije, @TipMasine, @LokacijaId)",
                    connection, transaction);
                command.Parameters.AddWithValue("@Naziv", m.Naziv);
                command.Parameters.AddWithValue("@Proizvodjac", m.Proizvodjac);
                command.Parameters.AddWithValue("@OcekivaniRadniVek", m.OcekivaniRadniVek);
                command.Parameters.AddWithValue("@GodinaProizvodnje", m.GodinaProizvodnje);
                command.Parameters.AddWithValue("@Korisnik", m.Korisnik.KorisnickoIme);
                command.Parameters.AddWithValue("@DatumPocetkaEksploatacije", m.DatumPocetkaEksploatacije);
                command.Parameters.AddWithValue("@TipMasine", m.TipMasine.Naziv);
                command.Parameters.AddWithValue("@LokacijaId", m.Lokacija.LokacijaId);

                m.MasinaId = (int)command.ExecuteScalar();

                foreach (Alat alat in alatiNaFormi)
                {
                    SqlCommand commandAlat = new SqlCommand("INSERT INTO MasinaAlat VALUES(@MasinaId, @AlatId)", connection, transaction);
                    commandAlat.Parameters.AddWithValue("@MasinaId", m.MasinaId);
                    commandAlat.Parameters.AddWithValue("AlatId", alat.AlatId);
                    commandAlat.ExecuteNonQuery();
                }

                foreach (Alat alat in alatiNaFormi)
                {
                    SqlCommand commandAlat2 = new SqlCommand($"UPDATE Alat SET StanjeNaZalihama = StanjeNaZalihama - {alat.StanjeNaZalihama} WHERE AlatId = {alat.AlatId}", connection, transaction);
                    commandAlat2.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IList<Alat> VratiSveAlate()
        {
            connection.Open();
            List<Alat> alati = new List<Alat>();
            SqlDataReader reader = null;

            try
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM Alat ORDER BY Naziv";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Alat a = new Alat()
                    {
                        AlatId = reader.GetInt32(0),
                        Naziv = reader.GetString(1),
                        StanjeNaZalihama = reader.GetInt32(2)
                    };
                    alati.Add(a);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Greska u radu s bazom");
            }
            finally
            {
                connection.Close();
                reader.Close();
            }
            return alati;
        }
    }
}
