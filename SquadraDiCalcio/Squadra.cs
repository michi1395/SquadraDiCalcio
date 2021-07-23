using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquadraDiCalcio
{
    public class Squadra
    {
        public string Nome { get; set; }
        public DateTime DataDiFondazione { get; set; }
        public string CampionatoDisputato { get; set; }
        public string NomePresidente { get; set; }
        public string NomeAllenatore { get; set; }
        public List<Calciatore> Rosa { get; set; }

        

    }
}
