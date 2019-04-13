using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Data.Models;

namespace Data.Repositories
{
    public class RepoPlatobnaKarta : RepoBase
    {
        public string ConnString { get; set; }


        /// <summary>
        /// Načítam zoznam platobných kariet užívateľa
        /// </summary>
        /// <param name="ID">ID klienta</param>
        /// <returns></returns>
        public DataSet NacitajPlatobneKarty(int ID)
        {
            using (Connection)
            {
                base.Connection.Open();
                using (SqlCommand command = Connection.CreateCommand())
                {
                    command.CommandText = @"SELECT klient.ID
                                        ,Karta.ID
                                        ,Karta.Cislo
                                        ,Karta.Meno
                                        ,karta.Platnost
                                        ,Karta.Zablokovana
                                        ,karta.PIN
                                        FROM [Klient]
                                        inner join Ucet
                                        on Klient.UcetID = Ucet.ID
                                        left join Karta
                                        on Ucet.ID = Karta.UcetID
                                        where Klient.Id = @Id";

                    command.Parameters.Add("@Id", SqlDbType.Int).Value = ID;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "Karty");
                        DataTable dt = ds.Tables["Karty"];


                        PlatobnaKarta karta = new PlatobnaKarta
                        {
                            IDklienta = (int)ds.Tables[0].Rows[0][0],
                            IDkarty = (int)ds.Tables[0].Rows[0][1],
                            Cislo = (int)ds.Tables[0].Rows[0][2],
                            Platnost = ds.Tables[0].Rows[0][4].ToString(),
                            PIN = (int)ds.Tables[0].Rows[0][6],
                            Zablokovana = (bool)ds.Tables[0].Rows[0][5],
                        };
                        return ds;
                    }
                }
            }
        }

        /// <summary>
        /// zistí mi, či má klient založené platobné karty k účtu
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public int ZistiCiMaKlientPlatobneKarty(int clientId)
        {
            int pocetKariet;
            using (SqlConnection connection = base.Connection)
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT COUNT(*)
                                            from Karta
                                            left join Ucet
                                            on Karta.UcetID = Ucet.ID
                                            left join Klient
                                            on ucet.ID = Klient.UcetID
                                            where klient.ID = @Id";
                    command.Parameters.AddWithValue("@Id", clientId);
                    pocetKariet = (int)command.ExecuteScalar();
                }
            }
            return pocetKariet;
        }

        /// <summary>
        /// Zmení status karty, či je zablokovaná alebo odblokovaná
        /// </summary>
        /// <param name="kartaID"></param>
        /// <param name="zablokovanie"></param>
        public void ZmenZablokovanieKarty(int kartaID, bool zablokovanie)
        {
            zablokovanie = zablokovanie == true ? false : true;

            using (SqlConnection connection = base.Connection)
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"UPDATE [Karta] SET [Zablokovana] = @Status WHERE karta.ID = @KartaId";
                    command.Parameters.AddWithValue("@KartaId", kartaID);
                    command.Parameters.AddWithValue("@Status", zablokovanie);
                    command.ExecuteNonQuery();
                }
            }
        }


        /// <summary>
        /// Zistí, či existuje už dané číslo karty, vráti počet zázanmov s číslom karty (Malo by 0 žiadna, alebo 1 existuje)
        /// </summary>
        /// <param name="kartaCislo"></param>
        /// <returns></returns>
        public int ZistiCiExistujeCisloKarty(int kartaCislo)
        {
            using (SqlConnection connection = base.Connection)
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT count(*) from Karta where Cislo = @kartaCislo";
                    command.Parameters.AddWithValue("@KartaCislo", kartaCislo);
                    return (int)command.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// Pridá kartu užívateľovi
        /// </summary>
        /// <param name="cisloKarty"></param>
        /// <param name="IdKlienta"></param>
        public void PridajKartu(int cisloKarty, int IdKlienta)
        {
            Random rndPIN = new Random();
            int IdUctuKlienta;

            using (SqlConnection connection = base.Connection)
            {
                connection.Open();

                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"select ucet.ID from ucet inner join klient on ucet.ID = @IdKlienta";
                    command.Parameters.AddWithValue("@IdKlienta", IdKlienta);
                    IdUctuKlienta = (int)command.ExecuteScalar();
                }

                    using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"insert into [Karta] ([Cislo],[Platnost], [PIN],[Zablokovana], UcetID )  values(@KartaCislo, @Platnost, @PIN, @Zablokovana, @UcetID)";
                    command.Parameters.AddWithValue("@KartaCislo", cisloKarty);
                    command.Parameters.AddWithValue("@PIN", rndPIN.Next(1000,9999));
                    command.Parameters.AddWithValue("@Platnost", DateTime.Today.AddYears(2));
                    command.Parameters.AddWithValue("@Zablokovana", false);
                    command.Parameters.AddWithValue("@UcetID", IdUctuKlienta);
                    command.ExecuteNonQuery();



                }
            }
        }

    }
}
