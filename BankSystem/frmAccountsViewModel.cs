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

        public DataSet NacitajzTabulkyPerson(string meno, string priezvisko, string IBAN)
        {
            return ZoznamKlientov.NacitajzTabulkyKlient(meno, priezvisko, IBAN);
        }





    }
}
