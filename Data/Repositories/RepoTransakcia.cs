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
    public class RepoTransakcia : RepoBase
    {
        public string ConnString { get; set; }


        /// <summary>
        /// Načítam všetkých klientov z db
        /// </summary>
        /// <returns></returns>
        public DataTable NacitajzTabulkyKlientov()
        {
            using (Connection)
            {
                Connection.Open();
                using (SqlCommand command = Connection.CreateCommand())
                {
                    command.CommandText = @"SELECT k.Priezvisko + ' '+ k.Meno AS Klient
                                            ,k.Ulica + ', '+ k.Mesto AS Adresa
                                            ,u.IBAN AS UcetIBAN
                                            ,u.ID AS UcetID
                                            FROM Klient AS k
                                            LEFT JOIN Ucet AS u
                                            ON k.UcetID = u.ID
                                            WHERE u.Aktivny = 1
                                            ORDER BY k.Priezvisko ASC";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "Klient");
                        DataTable dt = ds.Tables["Klient"];

                        return dt;
                    }
                }
            }
        }

        /// <summary>
        /// Načítam konkrétneho klienta z db
        /// </summary>
        /// <returns></returns>
        public DataTable NacitajzTabulkyKlientov(int clientID)
        {
            using (Connection)
            {
                Connection.Open();
                using (SqlCommand command = Connection.CreateCommand())
                {
                    command.CommandText = @"SELECT k.Priezvisko + ' '+ k.Meno AS Klient
                                            ,k.Ulica + ', '+ k.Mesto as Adresa
                                            ,u.IBAN AS UcetIBAN
                                            ,u.ID AS UcetID
                                            FROM Klient AS k
                                            LEFT JOIN Ucet AS u
                                            ON k.UcetID = u.ID
                                            WHERE u.Aktivny = 1 and k.ID = @ID";
                    command.Parameters.AddWithValue("@ID", clientID);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "Klient");
                        DataTable dt = ds.Tables["Klient"];

                        return dt;
                    }
                }
            }
        }

        /// <summary>
        /// Zapíše transakciu do databázy. Stačí podhodiť transakciu z model transakcia
        /// </summary>
        /// <param name="transakcia"></param>
        public void ZapisTransakciu(ModelTransakcia transakcia)
        {
            using (SqlConnection connection = Connection)
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    //zadeklarujem si datum transakcie
                    DateTime datum = DateTime.Now;
                    command.Connection = connection;

                    command.CommandText = @"INSERT INTO Transakcia
                                           (Suma
                                           ,VS
                                           ,SS
                                           ,KS
                                           ,Sprava
                                           ,PrijemcaUcetID
                                           ,OdosielatelUcetID
                                           ,t.Datum)
                                            VALUES
                                           (@Suma
                                           ,@VS
                                           ,@SS
                                           ,@KS
                                           ,@Sprava
                                           ,@PrijemcaUcetID
                                           ,@OdosielatelUcetID
                                           ,@Datum)";

                    command.Parameters.Add("@Suma", SqlDbType.Decimal).Value = transakcia.Suma;

                    command.Parameters.AddWithValue("@VS", transakcia.VariabilnySymbol);
                    command.Parameters.AddWithValue("@SS", transakcia.SpecifickySymbol);
                    command.Parameters.AddWithValue("@KS", transakcia.KonstatnySymbol);
                    command.Parameters.AddWithValue("@Sprava", transakcia.Sprava);
                    command.Parameters.AddWithValue("@PrijemcaUcetID", transakcia.PrijimatelUcetID);
                    command.Parameters.AddWithValue("@OdosielatelUcetID", transakcia.OdosielatelUcetID);
                    command.Parameters.AddWithValue("@Datum", datum);

                    command.ExecuteNonQuery();

                    //Prirátam peniaze príjemcovi
                    PriratajPrijemcovi(transakcia.PrijimatelUcetID,transakcia.Suma);

                    //Odrátam peniaze odosielateľovi
                    OdratajOdosielatelovi(transakcia.OdosielatelUcetID, transakcia.Suma);
                }
            }
        }

        /// <summary>
        /// Prirátam príjemcovi čiastku na účet
        /// </summary>
        /// <param name="PrijemcaUcetID"></param>
        /// <param name="Ciastka"></param>
        public void PriratajPrijemcovi(int PrijemcaUcetID, decimal Ciastka)
        {
            using(SqlConnection connection = Connection)
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"UPDATE Ucet SET StavUctu = StavUctu+@Suma WHERE Id = @Id";
                    command.Parameters.Add("@Suma", SqlDbType.Decimal).Value = Ciastka;
                    command.Parameters.AddWithValue("@Id", PrijemcaUcetID);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Odrátam odosielatelovi platby peniaze z účtu
        /// </summary>
        /// <param name="OdosielatelUcetId"></param>
        /// <param name="Ciastka"></param>
        public void OdratajOdosielatelovi(int OdosielatelUcetId, decimal Ciastka)
        {
            using (SqlConnection connection = base.Connection)
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"UPDATE Ucet SET StavUctu = StavUctu-@Suma WHERE Id = @Id";
                    command.Parameters.Add("@Suma", SqlDbType.Decimal).Value = Ciastka;
                    command.Parameters.AddWithValue("@Id", OdosielatelUcetId);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Načíta všetky transakcie všetkých klientov
        /// </summary>
        /// <returns>dataset ktorý použijem pre datagridview</returns>
        public DataSet NacitajTransakcie()
        {
            using (Connection)
            {
                Connection.Open();
                using (SqlCommand command = Connection.CreateCommand())
                {
                    command.CommandText = @"SELECT t.ID AS ID_transakcie
	                                      ,ko.Priezvisko +', '+ ko.Meno AS Odosielateľ
	                                      ,kp.Priezvisko +', '+ kp.Meno AS Príjemca
	                                      ,ko.ID AS ID_odosielateľa
	                                      ,kp.ID AS ID_prijímateľa
										  ,CASE
                                            WHEN ko.Priezvisko IS NOT NULL AND kp.Priezvisko IS NOT NULL THEN 'Prevod'
                                            WHEN ko.Priezvisko IS NOT NULL AND kp.Priezvisko IS     NULL THEN 'Výber'
                                            WHEN ko.Priezvisko IS     NULL AND kp.Priezvisko IS NOT NULL THEN 'Vklad'
                                            END AS 'Typ operácie'
	                                      ,t.Suma AS Čiastka
                                          ,t.VS
                                          ,t.SS
                                          ,t.KS
                                          ,t.Sprava AS Správa
                                          ,t.OdosielatelUcetID
                                          ,t.PrijemcaUcetID  
                                          ,t.Datum AS Dátum
                                          FROM Transakcia AS t
                                          LEFT JOIN Ucet AS up
                                          ON t.PrijemcaUcetID = up.ID
                                          LEFT JOIN Klient AS kp
                                          ON up.ID = kp.ID
                                          LEFT JOIN Ucet AS uo
                                          ON t.OdosielatelUcetID = uo.ID
                                          LEFT JOIN Klient AS ko
                                          ON uo.ID = ko.ID";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "Transakcie");
                        DataTable dt = ds.Tables["Transakcie"];

                        return ds;
                    }
                }
            }
        }


        /// <summary>
        /// Načíta všetky transakcie všetkých klientov
        /// </summary>
        /// <param name="clientID">ID klienta, ktorého mam načítať</param>
        /// <returns>dataset ktorý použijem pre datagridview</returns>
        public DataSet NacitajTransakcie(int clientID)
        {
            using (base.Connection)
            {
                base.Connection.Open();
                using (SqlCommand command = Connection.CreateCommand())
                {
                    command.CommandText = @"SELECT t.ID AS ID_transakcie
	                                      ,ko.Priezvisko +', '+ ko.Meno AS Odosielateľ
	                                      ,kp.Priezvisko +', '+ kp.Meno AS Príjemca
	                                      ,ko.ID AS ID_odosielateľa
	                                      ,kp.ID AS ID_prijímateľa
										  ,CASE
                                            WHEN ko.Priezvisko IS NOT NULL AND kp.Priezvisko IS NOT NULL THEN 'Prevod'
                                            WHEN ko.Priezvisko IS NOT NULL AND kp.Priezvisko IS     NULL THEN 'Výber'
                                            WHEN ko.Priezvisko IS     NULL AND kp.Priezvisko IS NOT NULL THEN 'Vklad'
                                            END AS 'Typ operácie'
	                                      ,t.Suma AS Čiastka
                                          ,t.VS
                                          ,t.SS
                                          ,t.KS
                                          ,t.Sprava AS Správa
                                          ,t.OdosielatelUcetID
                                          ,t.PrijemcaUcetID  
                                          ,t.Datum AS Dátum
                                          FROM Transakcia AS t
                                          LEFT JOIN Ucet AS up
                                          ON t.PrijemcaUcetID = up.ID
                                          LEFT JOIN Klient AS kp
                                          ON up.ID = kp.ID
                                          LEFT JOIN Ucet AS uo
                                          ON t.OdosielatelUcetID = uo.ID
                                          LEFT JOIN Klient AS ko
                                          ON uo.ID = ko.ID
                                          WHERE ko.ID = @clientID OR kp.ID = @ClientID ";

                    command.Parameters.Add("@ClientID", SqlDbType.Int).Value = clientID;


                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "Transakcie");
                        DataTable dt = ds.Tables["Transakcie"];

                        return ds;
                    }
                }
            }
        }
    }
}
