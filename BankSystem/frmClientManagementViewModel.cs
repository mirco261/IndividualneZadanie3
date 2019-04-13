using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories;
using System.Data;
using Data.Models;


namespace BankSystem
{
    class FrmClientManagementViewModel
    {
        RepoKlient Klient = new RepoKlient();

        RepoPlatobnaKarta Karta = new RepoPlatobnaKarta();

        /// <summary>
        /// Načítam si údaje o klientovi podľa jeho ID, ktoré mi prišlo z frmMain
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ModelKlient NacitajKlientaPodlaID(int id)
        {
            return Klient.NacitajKlientaPodlaID(id);
        }


        public DataSet NacitajPlatobneKarty(int id)
        {
            return Karta.NacitajPlatobneKarty(id);
        }

        public int ZistiCiMaKlientPlatobneKarty(int clientId)
        {
            return Karta.ZistiCiMaKlientPlatobneKarty(clientId);
        }

        public void ZmenZablokovanieKarty(int clientId, bool zablokovanie)
        {
            Karta.ZmenZablokovanieKarty(clientId, zablokovanie);
        }

        public int ZistiCiExistujeCisloKarty(int kartaCislo)
        {
            return Karta.ZistiCiExistujeCisloKarty(kartaCislo);

        }

        public void PridajKartu(int cisloKarty, int IdKlienta)
        {
            Karta.PridajKartu(cisloKarty, IdKlienta);

        }


        public void ZatvorUcetKlientovi(int IdKlienta)
        {
            Klient.ZatvorUcetKlientovi(IdKlienta);

        }
    }
}
