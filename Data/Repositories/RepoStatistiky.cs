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

        public decimal PocetPenaziNaUctoch()
        {
            using (SqlConnection connection = base.Connection)
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.CommandText = @"SELECT SUM(Ucet.StavUctu) as StavÚčtu FROM Ucet";

                    decimal peniaze = (decimal)command.ExecuteScalar();
                    return peniaze;
                }
            }
        }

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
                        adapter.Fill(ds, "Top10");
                        DataTable dt = ds.Tables["Top10"];

                        return ds;
                    }
                }
            }
        }
    }
}
