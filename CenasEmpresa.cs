using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciayPolimofísmoWF
{
    internal class CenasEmpresa : Fiesta
    {
        private int costeBebidaPorPersona = 20;
        private bool opcionSaludable = false;

        public int CosteBebidaPorPersona
        {
            get { return costeBebidaPorPersona; }
            set { costeBebidaPorPersona = value; }
        }

        public bool OpcionSaludable
        {
            get { return opcionSaludable; }
            set { opcionSaludable = value; }
        }

        public CenasEmpresa() { }

        public override double CalcularCoste()
        {
            double coste = ((NumPersonas * CosteFijoPersona) + CosteDecoracion
                + (CosteBebidaPorPersona * NumPersonas));
            if (OpcionSaludable) { coste -= ((coste * 5) / 100); }
            return coste;
        }

        public void EstableceOpcionSaludable()
        {
            if (OpcionSaludable) { CosteBebidaPorPersona = 5; }
            else { CosteBebidaPorPersona = 20; }
        }
    }

}
