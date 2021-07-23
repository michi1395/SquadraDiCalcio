using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquadraDiCalcio
{
    class Attaccante : Calciatore
    {
        public int NumeroGolRealizzati { get; set; }
        public override string ToStringForTable()
        {
            return base.ToStringForTable() + String.Format("{0,-30}", NumeroGolRealizzati);
        }
    }
}
