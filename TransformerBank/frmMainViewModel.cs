using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data.Repositories;

namespace TransformerBank
{
    class FrmMainViewModel
    {
        readonly RepoBankomat viewModel = new RepoBankomat();

        public ModelBankomat NacitajKlienta(int karta, int PIN)
        {
            return viewModel.NacitajKlienta(karta, PIN);
        }
    }
}
