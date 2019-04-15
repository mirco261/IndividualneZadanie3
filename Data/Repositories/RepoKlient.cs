﻿using System;
using System.Data;
using System.Data.SqlClient;
using Data.Models;

namespace Data.Repositories
{
    public class RepoKlient : RepoBase
    {
        public string ConnString { get; set; }


        /// <summary>
        /// Načíta údaje z tabuľky klient  pre účely filtrovania klientov
        /// </summary>
        /// <returns>vracia dataset v ktorom sú všetky potrebné info pre zobrazenie v gride</returns>
        public DataSet NacitajzTabulkyKlient(string meno, string priezvisko, string IBAN)
        {
            using (Connection)
            {
                Connection.Open();
                using (SqlCommand command = Connection.CreateCommand())
                {
                    command.CommandText = @"SELECT
                       k.ID
                      ,k.Priezvisko
                      ,k.Meno
                      ,k.Ulica
                      ,k.Mesto
                      ,k.Telefon
                      ,k.Mail
                      ,k.OP
                      ,u.IBAN
                      ,u.Aktivny
                      FROM Klient AS k
                      LEFT JOIN Ucet AS u
                      ON k.UcetID = u.ID
                      WHERE k.Meno LIKE @Meno AND 
                            k.Priezvisko LIKE @Priezvisko AND
                            u.IBAN LIKE @IBAN
                      ORDER BY k.Priezvisko asc";

                    command.Parameters.Add("@Meno", SqlDbType.NVarChar).Value = $"%{meno}%";
                    command.Parameters.Add("@Priezvisko", SqlDbType.NVarChar).Value = $"%{priezvisko}%";
                    command.Parameters.Add("@IBAN", SqlDbType.NVarChar).Value = $"%{IBAN}%";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "Klient");
                        DataTable dt = ds.Tables["Klient"];
                        return ds;
                    }
                }
            }
        }

        /// <summary>
        /// Pridanie nového klienta
        /// </summary>
        /// <param name="meno"></param>
        /// <param name="priezvisko"></param>
        /// <param name="adresa"></param>
        /// <param name="mesto"></param>
        /// <param name="cisloOP"></param>
        /// <param name="telefon"></param>
        /// <param name="mail"></param>
        /// <param name="iban"></param>
        /// <returns></returns>
        public int ZapisKlientaDoDb(string meno, string priezvisko, string adresa, string mesto, string cisloOP, string telefon, string mail, string iban, int precerpanie, DateTime datum)
        {
            using (SqlConnection connection = Connection)
            {
                connection.Open();
                int idCudziKluc;

                //vytvorím si bankový účet
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"insert into Ucet (IBAN, Precerpanie, StavUctu, Aktivny, DatumZalozenia) output inserted.ID values(@Iban, @Precerpanie, 0, 1, @Datum)";
                    command.Parameters.AddWithValue("@Iban", iban);
                    command.Parameters.AddWithValue("@Precerpanie", precerpanie);
                    command.Parameters.AddWithValue("@Datum", datum);

                    idCudziKluc = (int)command.ExecuteScalar();
                }

                //Vytvorím si užívateľa
                using (SqlCommand command = new SqlCommand(@"INSERT into Klient (Meno,Priezvisko,Ulica,Mesto,Telefon,Mail,OP,UcetID)
                                          VALUES (@Meno ,@Priezvisko ,@Ulica ,@Mesto ,@Telefon ,@Mail ,@OP, @UcetID)", connection))
                {

                    command.CommandType = CommandType.Text;

                    command.Parameters.AddWithValue("@Meno", meno);
                    command.Parameters.AddWithValue("@Priezvisko", priezvisko);
                    command.Parameters.AddWithValue("@Ulica", adresa);
                    command.Parameters.AddWithValue("@Mesto", mesto);
                    command.Parameters.AddWithValue("@OP", cisloOP);
                    command.Parameters.AddWithValue("@Telefon", telefon);
                    command.Parameters.AddWithValue("@Mail", mail);
                    command.Parameters.AddWithValue("@UcetID", idCudziKluc);

                    int vysledok = command.ExecuteNonQuery();
                    return vysledok;
                }
            }
        }



        /// <summary>
        /// Vyhľadá klienta z dtb. 
        /// </summary>
        /// <param name="vyraz">Priezvisko, Občiansky preukaz alebo IBAN</param>
        /// <returns>Ak vráti <> 0, klient existuje</returns>
        public int HladajKlienta(string vyraz)
        {
            using (SqlConnection connection = base.Connection)
            {
                connection.Open();
                int id;

                //vyhľadám výraz
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT k.ID, k.Priezvisko, k.OP, u.IBAN FROM [Klient] as k left join ucet as u on k.UcetID = u.ID where k.Priezvisko like @Vyraz or k.OP like @Vyraz or k.Priezvisko like @Vyraz";
                    command.Parameters.Add("@Vyraz", SqlDbType.NVarChar).Value = $"%{vyraz}%";
                    if (command.ExecuteScalar() == null)
                    {
                        id = 0;
                    }
                    else
                    {
                        id = (int)command.ExecuteScalar();
                    }
                }
                return id;
            }
        }


        /// <summary>
        /// Načítam údaje o klientovi podľa ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ModelKlient NacitajKlientaPodlaID(int id)
        {
            using (base.Connection)
            {
                base.Connection.Open();
                using (SqlCommand command = base.Connection.CreateCommand())
                {
                    command.CommandText = @"SELECT
                      k.[Meno]
                      ,k.[Priezvisko]
                      ,k.[Ulica]
                      ,k.[Mesto]
                      ,k.[Telefon]
                      ,k.[Mail]
                      ,k.[OP]
                      ,u.[IBAN]
                      ,u.StavUctu
                      ,u.Precerpanie
                      ,u.Aktivny
                      ,u.DatumZalozenia
                      FROM [ATM].[dbo].[Klient] as k
                      left join dbo.Ucet as u
                      on k.UcetID = u.ID
                      where k.ID = @id";

                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "Klient");
                        DataTable dt = ds.Tables["Klient"];

                        ModelKlient klient = new ModelKlient
                        {

                            //naplním si klienta properties
                            Meno = ds.Tables[0].Rows[0][0].ToString(),
                            Priezvisko = ds.Tables[0].Rows[0][1].ToString(),
                            Ulica = ds.Tables[0].Rows[0][2].ToString(),
                            Mesto = ds.Tables[0].Rows[0][3].ToString(),
                            Telefon = ds.Tables[0].Rows[0][4].ToString(),
                            Mail = ds.Tables[0].Rows[0][5].ToString(),
                            OP = ds.Tables[0].Rows[0][6].ToString(),
                            IBAN = ds.Tables[0].Rows[0][7].ToString(),
                            StavNaUcte = (decimal)ds.Tables[0].Rows[0][8],
                            Precerpanie = (decimal)ds.Tables[0].Rows[0][9],
                            Aktivny = (bool)ds.Tables[0].Rows[0][10],
                            DatumZalozenia = (DateTime)ds.Tables[0].Rows[0][11]

                        };
                        return klient;
                    }
                }
            }
        }


        /// <summary>
        /// Úprava existujúceho klienta
        /// </summary>
        /// <param name="meno"></param>
        /// <param name="priezvisko"></param>
        /// <param name="adresa"></param>
        /// <param name="mesto"></param>
        /// <param name="cisloOP"></param>
        /// <param name="telefon"></param>
        /// <param name="mail"></param>
        /// <param name="iban"></param>
        /// <returns></returns>
        public void UpravKlientaDoDb(int ID, string meno, string priezvisko, string adresa, string mesto, string cisloOP, string telefon, string mail, string iban, int precerpanie)
        {
            using (SqlConnection connection = base.Connection)
            {
                connection.Open();

                //vytvorím si bankový účet
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"Update Ucet set Precerpanie = @Precerpanie where IBAN = @Iban";
                    command.Parameters.AddWithValue("@Iban", iban);
                    command.Parameters.AddWithValue("@Precerpanie", precerpanie);
                    command.ExecuteNonQuery();
                }


                //Upravím si užívateľove informácie podľa nových
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.CommandText = @"Update Klient SET Meno = @Meno, Priezvisko = @Priezvisko, Ulica = @Ulica, Mesto = @Mesto, Telefon = @Telefon, Mail = @Mail, OP = @OP where[ID] = @ID";
                    command.Parameters.AddWithValue("@Meno", meno);
                    command.Parameters.AddWithValue("@Priezvisko", priezvisko);
                    command.Parameters.AddWithValue("@Ulica", adresa);
                    command.Parameters.AddWithValue("@Mesto", mesto);
                    command.Parameters.AddWithValue("@OP", cisloOP);
                    command.Parameters.AddWithValue("@Telefon", telefon);
                    command.Parameters.AddWithValue("@Mail", mail);
                    command.Parameters.AddWithValue("@ID", ID);

                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Zatvorí učet klientovi. Pridá príznak Aktivny=0 v tabulke ucet, pomocou ID klienta
        /// </summary>
        /// <param name="IDklienta"></param>
        public void ZatvorUcetKlientovi(int IDklienta)
        {
            using (SqlConnection connection = base.Connection)
            {
                connection.Open();

                //vytvorím si bankový účet
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"update Ucet set Ucet.Aktivny = 0  FROM Ucet left join Klient on Ucet.ID = Klient.UcetID where Klient.id = @ID";
                    command.Parameters.AddWithValue("@ID", IDklienta);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
