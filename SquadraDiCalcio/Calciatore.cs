using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquadraDiCalcio
{
    public class Calciatore
    {
        public int NumeroMaglia { get; set; }
        public string Nome { get; set; }
        public DateTime DataDiNascita { get; set; }
        public Categoria Ruolo { get; set; }

        public enum Categoria
        {
            Portiere,
            Difensore,
            Centrocampista,
            Attaccante
        }
        public override string ToString()
        {
            return String.Format("{0,-30}{1,-30}{1,-30} ", Nome, NumeroMaglia,Ruolo);
        }

        public virtual string ToStringForTable()
        {
            return String.Format("{0,-30}{1,-30}{1,-30} ", Nome, NumeroMaglia, DataDiNascita, Ruolo);
        }
    }
}
