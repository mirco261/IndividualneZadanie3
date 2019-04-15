using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data.Repositories
{
    public class RepoStatistiky : RepoBase
    {

        public string ConnString { get; set; }

        /// <summary>
        /// Načíta štatistiky top 10 klientov
        /// </summary>
        /// <returns>vracia dataset v ktorom sú top 10 klientov</returns>
        public DataSet Top10klientov()
        {
            using (base.Connection)
            {
                base.Connection.Open();
                using (SqlCommand command = base.Connection.CreateCommand())
                {
                    command.CommandText = @"SELECT TOP 10 RANK() OVER (ORDER BY Ucet.StavUctu DESC) AS Poradie
                                          ,Meno + ' '+ Priezvisko AS Klient
	                                      ,Ucet.StavUctu AS StavÚčtu
                                          FROM Klient
                                          INNER JOIN Ucet
                                          ON Klient.UcetID = Ucet.ID
                                          WHERE Ucet.[Aktivny] = 1
                                          ORDER by StavÚčtu DESC";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "Top10");
                        DataTable dt = ds.Tables["Top10"];

                        return ds;
                    }
                }
            }
        }

        /// <summary>
        /// Načíta koľko peňazí banka disponuje iba na aktívnych účtoch
        /// </summary>
        /// <returns>Suma peňazí banky</returns>
        public decimal PocetPenaziNaUctoch()
        {
            using (SqlConnection connection = base.Connection)
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.CommandText = @"SELECT SUM(Ucet.StavUctu) as StavÚčtu 
                                            FROM Ucet
                                            WHERE Aktivny = 1";
                    
                        return (decimal)command.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// Načíta počet aktívnych účtov v banke
        /// </summary>
        /// <returns>Počet aktívnych účtov v banke</returns>
        public decimal PocetUctov()
        {
            using (SqlConnection connection = base.Connection)
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.CommandText = @"SELECT COUNT(Ucet.IBAN) AS PocetUctov FROM Ucet WHERE ucet.Aktivny = 1";

                    return (int)command.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// Načíta dataset top 5 miest, z ktorých má banka klientov
        /// </summary>
        /// <returns>top 5 miest, z ktorých má banka klientov</returns>
        public DataSet TopMestaKlienti()
        {
            using (SqlConnection connection = Connection)
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.CommandText = @"SELECT TOP 5 Mesto, Count(ID) AS PočetKlientov
                                          FROM Klient
                                          GROUP BY Mesto
                                          ORDER BY PočetKlientov DESC";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "Mesta");
                        DataTable dt = ds.Tables["Mesta"];

                        return ds;
                    }
                }
            }
        }

        /// <summary>
        /// Načíta dataset počet založených účtov po mesiacoch za posledných 6 mesiacov
        /// </summary>
        /// <returns>počet založených účtov</returns>
        public DataSet PocetZalozenychUctovPoMesiacoch()
        {
            using (Connection)
            {
                Connection.Open();
                using (SqlCommand command = Connection.CreateCommand())
                {
                    command.CommandText = @"SELECT YEAR(DatumZalozenia) AS Rok
                                            ,MONTH(DatumZalozenia)  AS  Mesiac
                                            ,COUNT(ID) AS 'Počet účtov'
                                            FROM Ucet
                                            WHERE DATEDIFF(MONTH, DatumZalozenia, GETDATE()) <= 6
                                            GROUP BY MONTH(DatumZalozenia), YEAR(DatumZalozenia)
											ORDER BY Rok DESC, MONTH(DatumZalozenia) DESC";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "Top6");
                        DataTable dt = ds.Tables["Top6"];

                        return ds;
                    }
                }
            }
        }
    }
}
