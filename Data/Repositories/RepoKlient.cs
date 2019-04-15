using System;
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
        /// <returns>vráti 1 ak zapísal</returns>
        public int ZapisKlientaDoDb(ModelKlient klient)
        {
            using (SqlConnection connection = Connection)
            {
                connection.Open();
                int idCudziKluc;

                //vytvorím si bankový účet
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"INSERT INTO Ucet (IBAN, Precerpanie, StavUctu, Aktivny, DatumZalozenia) output inserted.ID values(@Iban, @Precerpanie, 0, 1, @Datum)";
                    command.Parameters.AddWithValue("@Iban", klient.IBAN);
                    command.Parameters.AddWithValue("@Precerpanie", klient.Precerpanie);
                    command.Parameters.AddWithValue("@Datum", klient.DatumZalozenia);

                    idCudziKluc = (int)command.ExecuteScalar();
                }

                //Vytvorím si užívateľa
                using (SqlCommand command = new SqlCommand(@"INSERT INTO Klient (Meno,Priezvisko,Ulica,Mesto,Telefon,Mail,OP,UcetID)
                                          VALUES (@Meno ,@Priezvisko ,@Ulica ,@Mesto ,@Telefon ,@Mail ,@OP, @UcetID)", connection))
                {
                    command.CommandType = CommandType.Text;

                    command.Parameters.AddWithValue("@Meno", klient.Meno);
                    command.Parameters.AddWithValue("@Priezvisko", klient.Priezvisko);
                    command.Parameters.AddWithValue("@Ulica", klient.Ulica);
                    command.Parameters.AddWithValue("@Mesto", klient.Mesto);
                    command.Parameters.AddWithValue("@OP", klient.OP);
                    command.Parameters.AddWithValue("@Telefon", klient.Telefon);
                    command.Parameters.AddWithValue("@Mail", klient.Mail);
                    command.Parameters.AddWithValue("@UcetID", idCudziKluc);

                    int vysledok = command.ExecuteNonQuery();
                    return vysledok;
                }
            }
        }


        /// <summary>
        /// Vyhľadá klienta z db podla zadaného výrazu
        /// </summary>
        /// <param name="vyraz">Priezvisko, Občiansky preukaz alebo IBAN</param>
        /// <returns>Ak vráti <> 0, klient existuje, 0 ak neexistuje</returns>
        public int HladajKlienta(string vyraz)
        {
            using (SqlConnection connection = Connection)
            {
                connection.Open();
                int id;

                //vyhľadám výraz
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT k.ID, 
                                        k.Priezvisko, 
                                        k.OP, 
                                        u.IBAN 
                                        FROM Klient AS k 
                                        LEFT JOIN ucet AS u 
                                        ON k.UcetID = u.ID 
                                        WHERE k.Priezvisko LIKE @Vyraz OR 
                                        k.OP LIKE @Vyraz OR 
                                        k.Priezvisko LIKE @Vyraz";
                    command.Parameters.Add("@Vyraz", SqlDbType.NVarChar).Value = $"%{vyraz}%";

                    //Ak scalar vráti null, znamená to, že nenašlo žiaden záznam
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
        /// Načítam údaje o klientovi podľa ID a vráť ModelKlient - klienta v objekte
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ModelKlient NacitajKlientaPodlaID(int id)
        {
            using (Connection)
            {
                Connection.Open();
                using (SqlCommand command = Connection.CreateCommand())
                {
                    command.CommandText = @"SELECT
                       k.Meno
                      ,k.Priezvisko
                      ,k.Ulica
                      ,k.Mesto
                      ,k.Telefon
                      ,k.Mail
                      ,k.OP
                      ,u.IBAN
                      ,u.StavUctu
                      ,u.Precerpanie
                      ,u.Aktivny
                      ,u.DatumZalozenia
                      FROM Klient AS k
                      LEFT JOIN Ucet AS u
                      ON k.UcetID = u.ID
                      WHERE k.ID = @id";

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
        public void UpravKlientaDoDb(ModelKlient klient)
        {
            using (SqlConnection connection = base.Connection)
            {
                connection.Open();

                //vytvorím si bankový účet
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"UPDATE Ucet SET Precerpanie = @Precerpanie WHERE IBAN = @Iban";
                    command.Parameters.AddWithValue("@Iban", klient.IBAN);
                    command.Parameters.AddWithValue("@Precerpanie", klient.Precerpanie);
                    command.ExecuteNonQuery();
                }

                //Upravím si užívateľove informácie podľa nových
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.CommandText = @"UPDATE Klient 
                                            SET Meno = @Meno
                                            ,Priezvisko = @Priezvisko
                                            ,Ulica = @Ulica
                                            ,Mesto = @Mesto
                                            ,Telefon = @Telefon
                                            ,Mail = @Mail
                                            ,OP = @OP
                                            WHERE ID = @ID";
                    command.Parameters.AddWithValue("@Meno", klient.Meno);
                    command.Parameters.AddWithValue("@Priezvisko", klient.Priezvisko);
                    command.Parameters.AddWithValue("@Ulica", klient.Ulica);
                    command.Parameters.AddWithValue("@Mesto", klient.Mesto);
                    command.Parameters.AddWithValue("@OP", klient.OP);
                    command.Parameters.AddWithValue("@Telefon", klient.Telefon);
                    command.Parameters.AddWithValue("@Mail", klient.Mail);
                    command.Parameters.AddWithValue("@ID", klient.ID);

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

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"UPDATE Ucet 
                                            SET Ucet.Aktivny = 0  
                                            FROM Ucet 
                                            LEFT JOIN Klient 
                                            ON Ucet.ID = Klient.UcetID 
                                            WHERE Klient.id = @ID";
                    command.Parameters.AddWithValue("@ID", IDklienta);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
