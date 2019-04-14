using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories;
using Data.Models;

namespace TransformerBank
{
    class FrmVyberZUctuViewModel
    {
        RepoTransakcia transakcia = new RepoTransakcia();
        readonly ModelTransakcia informacie = new ModelTransakcia();


        public void ZapisTransakciu(ModelTransakcia informacie)
        {
            transakcia.ZapisTransakciu(informacie);

        }
    }
}
