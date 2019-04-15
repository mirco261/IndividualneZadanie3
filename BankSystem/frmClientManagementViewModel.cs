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

        /// <summary>
        /// Načítam zoznam platobných kariet vybraného klienta
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataSet NacitajPlatobneKarty(int id)
        {
            return Karta.NacitajPlatobneKarty(id);
        }

        /// <summary>
        /// Pozrem sa, či má klient platobné karty založené
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns>vrátim nulu, ak nemá</returns>
        public int ZistiCiMaKlientPlatobneKarty(int clientId)
        {
            return Karta.ZistiCiMaKlientPlatobneKarty(clientId);
        }

        /// <summary>
        /// Vykoná zablokovanie/odblokovanie karty
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="zablokovanie"></param>
        public void ZmenZablokovanieKarty(int clientId, bool zablokovanie)
        {
            Karta.ZmenZablokovanieKarty(clientId, zablokovanie);
        }


        /// <summary>
        /// Zistí, či existuje už dané číslo karty, vráti počet zázanmov s číslom karty (Malo by 0 žiadna, alebo 1 existuje)
        /// </summary>
        /// <param name="kartaCislo"></param>
        /// <returns></returns>
        public int ZistiCiExistujeCisloKarty(int kartaCislo)
        {
            return Karta.ZistiCiExistujeCisloKarty(kartaCislo);

        }

        /// <summary>
        /// Pridá kartu užívateľovi
        /// </summary>
        /// <param name="cisloKarty"></param>
        /// <param name="IdKlienta"></param>
        public void PridajKartu(int cisloKarty, int IdKlienta)
        {
            Karta.PridajKartu(cisloKarty, IdKlienta);

        }

        /// <summary>
        /// Zatvorí učet klientovi. Pridá príznak Aktivny=0 v tabulke ucet, pomocou ID klienta
        /// </summary>
        /// <param name="IDklienta"></param>
        public void ZatvorUcetKlientovi(int IdKlienta)
        {
            Klient.ZatvorUcetKlientovi(IdKlienta);

        }
    }
}
