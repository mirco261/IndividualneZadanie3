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
            
            using (base.Connection)
            {
                base.Connection.Open();
                using (SqlCommand command = base.Connection.CreateCommand())
                {
                    command.CommandText = @"SELECT
                                            k.[Priezvisko] + ' '+ k.[Meno] as Klient
                                            ,k.Ulica + ', '+ k.Mesto as Adresa
                                            ,u.[IBAN] as UcetIBAN
                                            ,u.ID as UcetID
                                            FROM [Klient] as k
                                            left join dbo.Ucet as u
                                            on k.UcetID = u.ID
                                            where u.[Aktivny] = 1
                                            order by k.Priezvisko asc, k.Mesto asc, u.IBAN asc";

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
        /// Načítam všetkých klientov z db
        /// </summary>
        /// <returns></returns>
        public DataTable NacitajzTabulkyKlientov(int clientID)
        {

            using (base.Connection)
            {
                base.Connection.Open();
                using (SqlCommand command = base.Connection.CreateCommand())
                {
                    command.CommandText = @"SELECT
                                            k.[Priezvisko] + ' '+ k.[Meno] as Klient
                                            ,k.Ulica + ', '+ k.Mesto as Adresa
                                            ,u.[IBAN] as UcetIBAN
                                            ,u.ID as UcetID
                                            FROM [Klient] as k
                                            left join dbo.Ucet as u
                                            on k.UcetID = u.ID
                                            where u.[Aktivny] = 1 and k.ID = @ID";
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


        public void ZapisTransakciu(ModelTransakcia transakcia)
        {
            using (SqlConnection connection = base.Connection)
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    //zadeklarujem si datum transakcie
                    DateTime datum = DateTime.Now;
                    command.Connection = connection;

                    command.CommandText = @"INSERT INTO [Transakcia]
                                           ([Suma]
                                           ,[VS]
                                           ,[SS]
                                           ,[KS]
                                           ,[Sprava]
                                           ,[PrijemcaUcetID]
                                           ,[OdosielatelUcetID]
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
            using(SqlConnection connection = base.Connection)
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"UPDATE [Ucet] SET [StavUctu] = [StavUctu]+@Suma WHERE Id = @Id";
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
                    command.CommandText = @"UPDATE [Ucet] SET [StavUctu] = [StavUctu]-@Suma WHERE Id = @Id";
                    command.Parameters.Add("@Suma", SqlDbType.Decimal).Value = Ciastka;
                    command.Parameters.AddWithValue("@Id", OdosielatelUcetId);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Načíta všetky transakcie všetkých klientov
        /// </summary>
        /// <returns></returns>
        public DataSet NacitajTransakcie()
        {
            using (base.Connection)
            {
                base.Connection.Open();
                using (SqlCommand command = base.Connection.CreateCommand())
                {
                    command.CommandText = @"SELECT t.[ID] as ID_transakcie
	                                      ,ko.Priezvisko +', '+ ko.Meno as Odosielateľ
	                                      ,kp.Priezvisko +', '+ kp.Meno as Príjemca
	                                      ,ko.ID as ID_odosielateľa
	                                      ,kp.ID as ID_prijímateľa
	                                      ,t.[Suma] as Čiastka
                                          ,t.[VS]
                                          ,t.[SS]
                                          ,t.[KS]
                                          ,t.[Sprava] as Správa
                                          ,t.[OdosielatelUcetID]
                                          ,t.[PrijemcaUcetID]   
                                          ,t.Datum           
                                          FROM [Transakcia] as t
                                          left join Ucet as up
                                          on t.PrijemcaUcetID = up.ID
                                          left join Klient as kp
                                          on up.ID = kp.ID
                                          left join Ucet as uo
                                          on t.OdosielatelUcetID = uo.ID
                                         left join Klient as ko
                                          on uo.ID = ko.ID";

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
        /// Načíta všetky transakcie iba vybraného klienta
        /// </summary>
        /// <returns></returns>
        public DataSet NacitajTransakcie(int clientID)
        {
            using (base.Connection)
            {
                base.Connection.Open();
                using (SqlCommand command = base.Connection.CreateCommand())
                {
                    command.CommandText = @"SELECT t.[ID] as ID_transakcie
	                                      ,ko.Priezvisko +', '+ ko.Meno as Odosielateľ
	                                      ,kp.Priezvisko +', '+ kp.Meno as Príjemca
	                                      ,ko.ID as ID_odosielateľa
	                                      ,kp.ID as ID_prijímateľa
	                                      ,t.[Suma] as Čiastka
                                          ,t.[VS]
                                          ,t.[SS]
                                          ,t.[KS]
                                          ,t.[Sprava] as Správa
                                          ,t.[OdosielatelUcetID]
                                          ,t.[PrijemcaUcetID]
                                          ,t.Datum           
                                          FROM [Transakcia] as t
                                          left join Ucet as up
                                          on t.PrijemcaUcetID = up.ID
                                          left join Klient as kp
                                          on up.ID = kp.ID
                                          left join Ucet as uo
                                          on t.OdosielatelUcetID = uo.ID
                                         left join Klient as ko
                                          on uo.ID = ko.ID
                                          where ko.ID = @clientID or kp.ID = @ClientID ";

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
