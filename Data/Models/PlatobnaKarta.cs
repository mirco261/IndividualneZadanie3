using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class PlatobnaKarta
    {
        public int IDkarty { get; set; }
        public int IDklienta { get; set; }
        public int Cislo { get; set; }
        public string Platnost { get; set; }
        public int PIN { get; set; }
        public bool Zablokovana { get; set; }
    }
}
