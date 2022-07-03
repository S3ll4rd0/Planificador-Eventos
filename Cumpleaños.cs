using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciayPolimofísmoWF
{
    internal class Cumpleaños : Fiesta
    {
        private int tamañoTarta = 40;
        private string textoTarta = "";

        public int TamañoTarta
        {
            get { return tamañoTarta; }
            set { tamañoTarta = value; }
        }

        public string TextoTarta
        {
            get { return textoTarta; }
            set { textoTarta = value; }
        }

        public Cumpleaños() { }

        public override double CalcularCoste()
        {
            double coste = ((NumPersonas * CosteFijoPersona) + CosteDecoracion
                + TamañoTarta + (TextoTarta.Length * 0.25));
            return coste;
        }
    }
}
