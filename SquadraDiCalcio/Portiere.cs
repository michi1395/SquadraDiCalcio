using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquadraDiCalcio
{
    class Portiere: Calciatore
    {
        public int NumeroGolSubiti { get; set; }
        public int NumeroRigoriParati { get; set; }

        public override string ToStringForTable()
        {
            return base.ToStringForTable() + String.Format("{0,-30}{0 -30}", NumeroGolSubiti, NumeroRigoriParati);
        }
    }
}
