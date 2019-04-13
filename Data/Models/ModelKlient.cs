using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ModelKlient
    {
        public int ID { get; set; }
        public string Meno { get; set; }
        public string Priezvisko { get; set; }
        public string Ulica { get; set; }
        public string Mesto { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string OP { get; set; }
        public decimal StavNaUcte { get; set; }
        public decimal Precerpanie { get; set; }
        public string IBAN { get; set; }
        public bool Aktivny { get; set; }
    }
}
