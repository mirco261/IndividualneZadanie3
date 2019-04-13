using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories;
using Data.Models;
using System.Data;

namespace BankSystem
{
    class FrmTransactionViewModel
    {
        //vytvorím si objekt ktorý budem naplnat informáciami o klientoch
        readonly ModelKlientTransakcia DbKlientov = new ModelKlientTransakcia();

        //vytvorím si objekt repozitára, v ktorom si ťahám klientov banky a záznamy o transakciach
        RepoTransakcia transakcia = new RepoTransakcia();

        /// <summary>
        /// Vytiahnem si všetkých klientov z db
        /// </summary>
        /// <returns></returns>
        public DataTable NacitajzTabulkyKlientov()
        {
            return transakcia.NacitajzTabulkyKlientov();
        }

        public void ZapisTransakciu(ModelTransakcia infoOTransakcii)
        {
            transakcia.ZapisTransakciu(infoOTransakcii);
        }
    }
}
