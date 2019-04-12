using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Data.Models;
using System.Diagnostics;

namespace Data.Repositories
{
    public class RepoKlient : RepoBase
    {
        public string ConnString { get; set; }


        /// <summary>
        /// Načíta údaje z tabuľky klient
        /// </summary>
        /// <returns></returns>
        public DataSet NacitajzTabulkyKlient(string meno, string priezvisko, string IBAN)
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
                      FROM [ATM].[dbo].[Klient] as k
                      left join dbo.Ucet as u
                      on k.UcetID = u.ID
                      where k.Meno like @Meno and k.Priezvisko like @Priezvisko and u.IBAN like @IBAN";

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
        public int ZapisKlientaDoDb(string meno, string priezvisko, string adresa, string mesto, string cisloOP, string telefon, string mail, string iban, int precerpanie)
        {
            using (SqlConnection connection = base.Connection)
            {
                connection.Open();
                int idCudziKluc;

                //vytvorím si bankový účet
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"insert into Ucet (IBAN, Precerpanie) output inserted.ID values(@Iban, @Precerpanie)";
                    command.Parameters.AddWithValue("@Iban", iban);
                    command.Parameters.AddWithValue("@Precerpanie", precerpanie);

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
        /// Vyhľadám ID klienta
        /// </summary>
        /// <param name="vyraz"></param>
        /// <returns></returns>
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


        
        public ModelKlient NacitajKlientaPodlaID(int id)
        {
            ModelKlient klient = new ModelKlient();
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
                      FROM [ATM].[dbo].[Klient] as k
                      left join dbo.Ucet as u
                      on k.UcetID = u.ID
                      where k.Meno like @Meno and k.Priezvisko like @Priezvisko and u.IBAN like @IBAN";

                    command.Parameters.Add("@id", SqlDbType.NVarChar).Value = $"%{id}%";

                    
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Debug.WriteLine(String.Format("{0}", reader[0]));
                    }

                    //klient.Meno = 
                }
            }
            return klient;
            
        }
    }
}
