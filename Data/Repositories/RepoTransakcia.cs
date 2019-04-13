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
        /// Načítam si všetkých klientov z db
        /// </summary>
        /// <returns></returns>
        public DataTable NacitajzTabulkyKlientov()
        {
            //List<ModelKlientTransakcia> katalog = new List<ModelKlientTransakcia>();
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
                                            FROM [ATM].[dbo].[Klient] as k
                                            left join dbo.Ucet as u
                                            on k.UcetID = u.ID
                                            order by k.Priezvisko asc, k.Mesto asc, u.IBAN asc";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "Klient");
                        DataTable dt = ds.Tables["Klient"];

                        return dt;

                        //foreach (var item in collection)
                        //{

                        //}
                        //ModelKlientTransakcia klient = new ModelKlientTransakcia()
                        //{
                        //    Klient = ds.Tables[0].Rows[0][0].ToString(),
                        //    Adresa = ds.Tables[0].Rows[0][1].ToString(),
                        //    IBAN = ds.Tables[0].Rows[0][2].ToString(),
                        //    UcetID = (int)ds.Tables[0].Rows[0][3]
                        //};
                        //return klient;
                    }
                }
            }
        }
    }
}
