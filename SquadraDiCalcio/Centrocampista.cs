using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquadraDiCalcio
{
    class Centrocampista : Calciatore
    {
        public int NumeroPassaggiTentati { get; set; }
        public int NumeroPassaggiRiusciti { get; set; }

        public override string ToStringForTable()
        {
            return base.ToStringForTable() + String.Format("{0,-30}{0 -30}",NumeroPassaggiTentati, NumeroPassaggiRiusciti);
        }
    }
}
