﻿using System;
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

        readonly RepoKlient klient = new RepoKlient();


        /// <summary>
        /// Vytiahnem si všetkých klientov z db
        /// </summary>
        /// <returns></returns>
        public DataTable NacitajzTabulkyKlientov()
        {
            return transakcia.NacitajzTabulkyKlientov();
        }

        /// <summary>
        /// Vytiahnem si konkrétneho klienta z db
        /// </summary>
        /// <returns></returns>
        public DataTable NacitajzTabulkyKlientov(int idKlienta)
        {
            return transakcia.NacitajzTabulkyKlientov(idKlienta);
        }

        /// <summary>
        /// Zapíše transakciu do databázy. Stačí podhodiť transakciu z model transakcia
        /// </summary>
        /// <param name="transakcia"></param>
        public void ZapisTransakciu(ModelTransakcia infoOTransakcii)
        {
            transakcia.ZapisTransakciu(infoOTransakcii);
        }

        /// <summary>
        /// Načítam údaje o klientovi podľa ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ModelKlient NacitajKlientaPodlaID(int id)
        {
            return klient.NacitajKlientaPodlaID(id);
        }
    }
}
