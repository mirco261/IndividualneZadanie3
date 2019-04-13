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

        public DataSet NacitajTransakcie()
        {
            return ViewModel.NacitajTransakcie();
        }


        public DataSet NacitajTransakcie(int clientID)
        {
            return ViewModel.NacitajTransakcie(clientID);
        }

    }
}
