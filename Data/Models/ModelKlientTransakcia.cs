using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ModelKlientTransakcia
    {
        public int UcetID { get; set; }
        public string Klient { get; set; }
        public string Adresa { get; set; }
        public string IBAN { get; set; }
    }
}
