using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquadraDiCalcio
{
    class Difensore : Calciatore
    {
        public int NumeroTackle { get; set; }

        public override string ToStringForTable()
        {
            return base.ToStringForTable() + String.Format("{0,-30}",NumeroTackle);
        }
    }
}
