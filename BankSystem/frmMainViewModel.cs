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

        public int HladajKlienta(string vyraz)
        {
            return klient.HladajKlienta(vyraz);
        }
    }
}
