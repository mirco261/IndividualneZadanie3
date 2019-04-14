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
        readonly RepoBankomat viewModelRepoBankomat = new RepoBankomat();

        RepoPlatobnaKarta viewModelPlatobnaKarta = new RepoPlatobnaKarta();

        public ModelBankomat NacitajKlienta(int karta, int PIN)
        {
            return viewModelRepoBankomat.NacitajKlienta(karta, PIN);
        }

        public void ZablokujKartu(int KartaCislo)
        {
            viewModelPlatobnaKarta.ZablokujKartu(KartaCislo);
        }
    }
}
