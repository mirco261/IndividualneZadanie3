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
                    command.CommandText = @"SELECT top 10 rank() over ( order by Ucet.StavUctu desc) as Poradie
                                          , [Meno] + ' '+[Priezvisko] as Klient
	                                      ,Ucet.StavUctu as StavÚčtu
                                          FROM [ATM].[dbo].[Klient]
                                          inner join Ucet
                                          on Klient.UcetID = Ucet.ID
                                          where Ucet.[Aktivny] = 1
                                          order by stavÚčtu desc";

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

                    command.CommandText = @"SELECT SUM(Ucet.StavUctu) as StavÚčtu FROM Ucet";



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

                    command.CommandText = @"SELECT Count(Ucet.IBAN) as PocetUctov FROM Ucet where ucet.Aktivny = 1";

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
            using (SqlConnection connection = base.Connection)
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.CommandText = @"SELECT top 5 Mesto, Count([ID]) as PočetKlientov
                                          FROM [ATM].[dbo].[Klient]
                                          group by Mesto
                                          order by PočetKlientov desc";

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
            using (base.Connection)
            {
                base.Connection.Open();
                using (SqlCommand command = base.Connection.CreateCommand())
                {
                    command.CommandText = @"SELECT  YEAR(DatumZalozenia) as Rok
                                            ,Month(DatumZalozenia)  as  Mesiac
                                            ,Count([ID]) as 'Počet účtov'
                                            FROM [ATM].[dbo].[Ucet]
                                            where datediff(month, DatumZalozenia, getdate()) <= 6
                                            group by Month(DatumZalozenia), YEAR(DatumZalozenia)";

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
