using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories;
using System.Data;

namespace BankSystem
{
    class FrmTransactionsViewModel
    {
        
        RepoTransakcia ViewModel = new RepoTransakcia();

        /// <summary>
        /// Načíta všetky transakcie všetkých klientov
        /// </summary>
        /// <returns>dataset ktorý použijem pre datagridview</returns>
        public DataSet NacitajTransakcie()
        {
            return ViewModel.NacitajTransakcie();
        }

        /// <summary>
        /// Načíta všetky transakcie všetkých klientov
        /// </summary>
        /// <param name="clientID">ID klienta, ktorého mam načítať</param>
        /// <returns>dataset ktorý použijem pre datagridview</returns>
        public DataSet NacitajTransakcie(int clientID)
        {
            return ViewModel.NacitajTransakcie(clientID);
        }

    }
}
