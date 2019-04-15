using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data.Repositories;

namespace BankSystem
{
    class FrmMainViewModel
    {
        RepoKlient klient = new RepoKlient();

        RepoStatistiky statistiky = new RepoStatistiky();

        /// <summary>
        /// Vyhľadá klienta z dtb. 
        /// </summary>
        /// <param name="vyraz">Priezvisko, Občiansky preukaz alebo IBAN</param>
        /// <returns>Ak vráti <> 0, klient existuje</returns>
        public int HladajKlienta(string vyraz)
        {
            return klient.HladajKlienta(vyraz);
        }

        /// <summary>
        /// Načíta štatistiky top 10 klientov
        /// </summary>
        /// <returns>vracia dataset v ktorom sú top 10 klientov</returns>
        public DataSet Top10klientov()
        {
            return statistiky.Top10klientov();
        }

        /// <summary>
        /// Načíta koľko peňazí banka disponuje iba na aktívnych účtoch
        /// </summary>
        /// <returns>Suma peňazí banky</returns>
        public decimal PocetPenaziNaUctoch()
        {
            return statistiky.PocetPenaziNaUctoch();
        }

        /// <summary>
        /// Načíta počet aktívnych účtov v banke
        /// </summary>
        /// <returns>Počet aktívnych účtov v banke</returns>
        public decimal PocetUctov()
        {
            return statistiky.PocetUctov();
        }

        /// <summary>
        /// Načíta dataset top 5 miest, z ktorých má banka klientov
        /// </summary>
        /// <returns>top 5 miest, z ktorých má banka klientov</returns>
        public DataSet TopMestaKlienti()
        {
            return statistiky.TopMestaKlienti();
        }

        /// <summary>
        /// Načíta dataset počet založených účtov po mesiacoch za posledných 6 mesiacov
        /// </summary>
        /// <returns>počet založených účtov</returns>
        public DataSet PocetZalozenychUctovPoMesiacoch()
        {
            return statistiky.PocetZalozenychUctovPoMesiacoch();
        }
    }
}
