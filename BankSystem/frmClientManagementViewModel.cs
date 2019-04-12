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
    class frmClientManagementViewModel
    {
        RepoKlient Klient = new RepoKlient();

        public ModelKlient NacitajKlientaPodlaID(int id)
        {
            return Klient.NacitajKlientaPodlaID(id);
        }




    }
}
