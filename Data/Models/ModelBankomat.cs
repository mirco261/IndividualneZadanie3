using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ModelBankomat
    {
        public bool Zablokovana { get; set; }
        public string KlientMeno { get; set; }
        public decimal StavUctu { get; set; }
        public bool UcetAktivny { get; set; }
        public decimal Precerpanie { get; set; }
        public int IDUcet { get; set; }
        public int IDKarta { get; set; }
    }
}
