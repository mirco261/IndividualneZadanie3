using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data;
using Data.Repositories;
using Data.Models;

namespace BankSystem
{
    class FrmAccountsViewModel
    {

        RepoKlient ZoznamKlientov = new RepoKlient();

        /// <summary>
        /// Určené pre načítavanie klientov do ponuky pre prevody peňazí
        /// </summary>
        /// <param name="meno">Meno klienta</param>
        /// <param name="priezvisko">Priezvisko klienta</param>
        /// <param name="IBAN">IBAN, proste... IBAN</param>
        /// <returns>Dataset v ktorom je zoznam týchto stĺpcov</returns>
        public DataSet NacitajzTabulkyPerson(string meno, string priezvisko, string IBAN)
        {
            return ZoznamKlientov.NacitajzTabulkyKlient(meno, priezvisko, IBAN);
        }
    }
}
