using Data.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Data.Repositories
{
    public class RepoBankomat : RepoBase
    {
        public string ConnString { get; set; }
        
        /// <summary>
        /// Načítam údaje o klientovi podľa karty a PIN (musí mať aktívny účet, nezablokovanú kartu a platnosť karty do dnes)
        /// </summary>
        public ModelBankomat NacitajKlienta(int karta, int PIN)
        {
            using (Connection)
            {
                Connection.Open();
                using (SqlCommand command = base.Connection.CreateCommand())
                {
                    command.CommandText = @"SELECT p.UcetID
	                                      ,u.StavUctu
	                                      ,u.Precerpanie
	                                      ,k.Priezvisko + ', '+k.Meno as KlientMeno
                                          FROM Karta AS p
                                          INNER JOIN Ucet AS u
                                          ON p.UcetID = u.ID
                                          INNER JOIN Klient AS k
                                          ON u.ID = k.UcetID
                                          WHERE p.PIN = @PIN AND 
                                          p.Cislo = @Karta AND 
                                          p.Platnost >= @Platnost AND 
                                          p.Zablokovana = 0 AND 
                                          u.Aktivny =1";

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
        }
    }
}
