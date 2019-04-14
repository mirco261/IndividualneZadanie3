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
    public class RepoBankomat : RepoBase
    {
        public string ConnString { get; set; }


        /// <summary>
        /// Načítam údaje o klientovi podľa karty a PIN
        /// </summary>
        public ModelBankomat NacitajKlienta(int karta, int PIN)
        {
            using (base.Connection)
            {
                base.Connection.Open();
                using (SqlCommand command = base.Connection.CreateCommand())
                {
                    command.CommandText = @"SELECT 
                                           p.[UcetID]
	                                      ,u.StavUctu
	                                      ,u.Precerpanie
	                                      ,k.Priezvisko + ', '+k.Meno as KlientMeno
                                          FROM [Karta] as p
                                          inner join Ucet as u
                                          on p.UcetID = u.ID
                                          inner join Klient as k
                                         on u.ID = k.UcetID
                                         where p.PIN = @PIN and p.Cislo = @Karta and p.Platnost >= @Platnost and p.Zablokovana = 0 and u.Aktivny =1";

                    command.Parameters.Add("@PIN", SqlDbType.Int).Value = PIN;
                    command.Parameters.Add("@Karta", SqlDbType.Int).Value = karta;
                    command.Parameters.Add("@Platnost", SqlDbType.DateTime).Value = DateTime.Today;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "Klient");
                        DataTable dt = ds.Tables["Klient"];


                        //ak select nemá žiaden záznam, vrátum null
                        if (ds.Tables[0].Rows.Count != 0)
                        {
                            //ak select vráti záznam, naplním klienta
                            ModelBankomat klientBankomat = new ModelBankomat
                            {
                                //naplním si klienta properties
                                IDUcet = (int)ds.Tables[0].Rows[0][0],
                                StavUctu = (decimal)ds.Tables[0].Rows[0][1],
                                Precerpanie = (decimal)ds.Tables[0].Rows[0][2],
                                KlientMeno = ds.Tables[0].Rows[0][3].ToString()
                            };
                            return klientBankomat;
                        }

                        return null;
                    }
                }
            }


            /// <summary>
            /// Overím prihlásenie
            /// </summary>
            /// <returns></returns>
            //    public bool OvereniePrihlasenia(int karta, int pin)
            //{

            //    using (base.Connection)
            //    {
            //        base.Connection.Open();
            //        using (SqlCommand command = base.Connection.CreateCommand())
            //        {
            //            command.CommandText = @"SELECT
            //                                    k.[Priezvisko] + ' '+ k.[Meno] as Klient
            //                                    ,k.Ulica + ', '+ k.Mesto as Adresa
            //                                    ,u.[IBAN] as UcetIBAN
            //                                    ,u.ID as UcetID
            //                                    FROM [Klient] as k
            //                                    left join dbo.Ucet as u
            //                                    on k.UcetID = u.ID
            //                                    where u.[Aktivny] = 1
            //                                    order by k.Priezvisko asc, k.Mesto asc, u.IBAN asc";

            //            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            //            {
            //                DataSet ds = new DataSet();
            //                adapter.Fill(ds, "Klient");
            //                DataTable dt = ds.Tables["Klient"];

            //                return dt;
            //            }
            //        }
            //    }

        }
    }
}
