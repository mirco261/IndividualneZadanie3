using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ModelTransakcia
    {
        public int PrijimatelUcetID { get; set; }
        public int OdosielatelUcetID { get; set; }
        public decimal Suma { get; set; }
        public string VariabilnySymbol { get; set; }
        public string SpecifickySymbol { get; set; }
        public string KonstatnySymbol { get; set; }
        public string Sprava { get; set; }
    }
}
