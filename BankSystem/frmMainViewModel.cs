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

        public int HladajKlienta(string vyraz)
        {
            return klient.HladajKlienta(vyraz);
        }

        public DataSet Top10klientov()
        {
            return statistiky.Top10klientov();
        }

        public decimal PocetPenaziNaUctoch()
        {
            return statistiky.PocetPenaziNaUctoch();
        }

        public decimal PocetUctov()
        {
            return statistiky.PocetUctov();
        }

        public DataSet TopMestaKlienti()
        {
            return statistiky.TopMestaKlienti();
        }
    }
}
